using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using REPO_GENERICMETHOD.Controllers.IService;
using REPO_GENERICMETHOD.Controllers.Services;
using REPO_GENERICMETHOD.DAL.Iinterfaces;
using REPO_GENERICMETHOD.DAL.IRepositories;
using REPO_GENERICMETHOD.DAL.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<ApplicationDbcontext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("default")));

builder.Services.AddScoped<IPlayerRepository, PlayerRepository>();
builder.Services.AddScoped<IUnitofWork,  UnitofWork>();
builder.Services.AddScoped<IPlayerServices, PlayerServices>();
builder.Services.AddScoped<IBignnersRepository, BignnersRepository>();
builder.Services.AddScoped<IBignnersServices, BignnersServices>();
builder.Services.AddScoped<IOrderRepository, OrderRepository>();
builder.Services.AddScoped<IOrderServices, OrderServices>();
builder.Services.AddScoped<ICategoryRepository, CategoryRepository>();
builder.Services.AddScoped<ICategoryServices, CategoryServices>();




var app = builder.Build();



// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Player}/{action=GetallPlayers}/{id?}");

app.Run();
