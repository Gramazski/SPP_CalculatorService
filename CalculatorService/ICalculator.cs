using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace CalculatorService
{
    // ПРИМЕЧАНИЕ. Команду "Переименовать" в меню "Рефакторинг" можно использовать для одновременного изменения имени интерфейса "IService1" в коде и файле конфигурации.
    [ServiceContract]
    public interface ICalculator
    {

        [OperationContract]
        [FaultContract(typeof(OperationFault))]
        double Add(double a, double b);

        [OperationContract]
        [FaultContract(typeof(OperationFault))]
        double Substract(double a, double b);

        [OperationContract]
        [FaultContract(typeof(OperationFault))]
        double Multiply(double a, double b);

        [OperationContract]
        [FaultContract(typeof(OperationFault))]
        double Divide(double a, double b);

        [OperationContract]
        [FaultContract(typeof(OperationFault))]
        double Sqrt(double a);

        // TODO: Добавьте здесь операции служб
    }
}
