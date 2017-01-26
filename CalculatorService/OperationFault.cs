using System.Runtime.Serialization;

namespace CalculatorService
{
    [DataContract]
    public class OperationFault
    {
        [DataMember]
        public string Message { get; set; }

        public OperationFault(string message)
        {
            Message = message;
        }
    }
}