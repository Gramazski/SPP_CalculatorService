using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace CalculatorService
{
    // ПРИМЕЧАНИЕ. Команду "Переименовать" в меню "Рефакторинг" можно использовать для одновременного изменения имени класса "Service1" в коде, SVC-файле и файле конфигурации.
    // ПРИМЕЧАНИЕ. Чтобы запустить клиент проверки WCF для тестирования службы, выберите элементы Service1.svc или Service1.svc.cs в обозревателе решений и начните отладку.
    public class Calculator : ICalculator
    {
        public double Add(double a, double b)
        {
            double result = a + b;
            CheckResult(nameof(Add), result);

            return result;
        }

        public double Substract(double a, double b)
        {
            double result = a - b;
            CheckResult(nameof(Substract), result);

            return result;
        }

        public double Multiply(double a, double b)
        {
            double result = a * b;
            CheckResult(nameof(Multiply), result);

            return result;
        }

        public double Divide(double a, double b)
        {
            double result = a / b;
            CheckResult(nameof(Divide), result);

            return result;
        }

        public double Sqrt(double a)
        {
            double result = Math.Sqrt(a);
            CheckResult(nameof(Sqrt), result);

            return result;
        }

        private void CheckResult(string operationName, double result)
        {
            if (double.IsNaN(result))
            {
                OperationFault faut = new OperationFault("Fault in  " + operationName + ". Course: result is NaN.");
                throw new FaultException<OperationFault>(faut, "Fault in  " + operationName + ". Course: result is Infinite.");
            }

            if (double.IsInfinity(result))
            {
                OperationFault faut = new OperationFault("Fault in  " + operationName + ". Course: result is Infinite.");
                throw new FaultException<OperationFault>(faut, "Fault in  " + operationName + ". Course: result is Infinite.");
            }
        }
    }
}
