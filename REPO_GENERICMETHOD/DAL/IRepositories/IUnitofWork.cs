namespace REPO_GENERICMETHOD.DAL.Iinterfaces
{
    public interface IUnitofWork :IDisposable
    {
        IPlayerRepository _playerRepository { get; }
        IBignnersRepository _bignnersRepository { get; }
        IOrderRepository _orderRepository { get; }

        int Save();

    }

    
}
