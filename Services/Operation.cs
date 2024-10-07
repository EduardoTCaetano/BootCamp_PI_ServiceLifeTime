namespace BootCamp_PI_ServiceLifeTime.Services
{
    public class Operation : IOperationTransient, IOperationScoped, IOperationSingleton
    {
        public Operation()
        {
            OperationId = Guid.NewGuid().ToString();
        }
        public string OperationId { get; }
    }
}
