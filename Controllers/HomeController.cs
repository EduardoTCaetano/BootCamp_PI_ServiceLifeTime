using BootCamp_PI_ServiceLifeTime.Models;
using BootCamp_PI_ServiceLifeTime.Services;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace BootCamp_PI_ServiceLifeTime.Controllers
{
    public class HomeController : Controller
    {

        private readonly IOperationTransient _operationTransient;
        private readonly IOperationTransient _operationTransient2;

        private readonly IOperationScoped _operationScoped;
        private readonly IOperationScoped _operationScoped2;

        private readonly IOperationSingleton _operationSingleton;
        private readonly IOperationSingleton _operationSingleton2;


        public HomeController(
            IOperationTransient operationTransient,
            IOperationTransient operationTransient2,

            IOperationScoped operationScoped,
            IOperationScoped operationScoped2,

            IOperationSingleton operationSingleton,
            IOperationSingleton operationSingleton2
            )
        {
            _operationTransient = operationTransient;
            _operationTransient2 = operationTransient2;

            _operationScoped = operationScoped;
            _operationScoped2 = operationScoped2;

            _operationSingleton = operationSingleton;
            _operationSingleton2 = operationSingleton2;
        }

        public string Index()
        {
            return
                $"Transient : {_operationTransient.OperationId} \n" +
                $"Transient2 : {_operationTransient2.OperationId} \n" +

                $"Scoped : {_operationScoped.OperationId} \n" +
                $"Scoped2 : {_operationScoped2.OperationId} \n" +

                $"Singleton : {_operationSingleton.OperationId} \n" +
                $"Singleton2 : {_operationSingleton2.OperationId} \n";
        }
    }
}
