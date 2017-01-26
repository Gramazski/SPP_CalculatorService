﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WcfCalculatorClient.ServiceReference1 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CalculationFault", Namespace="http://schemas.datacontract.org/2004/07/WcfCalculatorService")]
    [System.SerializableAttribute()]
    public partial class CalculationFault : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MessageField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Message {
            get {
                return this.MessageField;
            }
            set {
                if ((object.ReferenceEquals(this.MessageField, value) != true)) {
                    this.MessageField = value;
                    this.RaisePropertyChanged("Message");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.ICalculator")]
    public interface ICalculator {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalculator/Add", ReplyAction="http://tempuri.org/ICalculator/AddResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(WcfCalculatorClient.ServiceReference1.CalculationFault), Action="http://tempuri.org/ICalculator/AddCalculationFaultFault", Name="CalculationFault", Namespace="http://schemas.datacontract.org/2004/07/WcfCalculatorService")]
        double Add(double a, double b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalculator/Add", ReplyAction="http://tempuri.org/ICalculator/AddResponse")]
        System.Threading.Tasks.Task<double> AddAsync(double a, double b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalculator/Substract", ReplyAction="http://tempuri.org/ICalculator/SubstractResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(WcfCalculatorClient.ServiceReference1.CalculationFault), Action="http://tempuri.org/ICalculator/SubstractCalculationFaultFault", Name="CalculationFault", Namespace="http://schemas.datacontract.org/2004/07/WcfCalculatorService")]
        double Substract(double a, double b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalculator/Substract", ReplyAction="http://tempuri.org/ICalculator/SubstractResponse")]
        System.Threading.Tasks.Task<double> SubstractAsync(double a, double b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalculator/Multiply", ReplyAction="http://tempuri.org/ICalculator/MultiplyResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(WcfCalculatorClient.ServiceReference1.CalculationFault), Action="http://tempuri.org/ICalculator/MultiplyCalculationFaultFault", Name="CalculationFault", Namespace="http://schemas.datacontract.org/2004/07/WcfCalculatorService")]
        double Multiply(double a, double b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalculator/Multiply", ReplyAction="http://tempuri.org/ICalculator/MultiplyResponse")]
        System.Threading.Tasks.Task<double> MultiplyAsync(double a, double b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalculator/Divide", ReplyAction="http://tempuri.org/ICalculator/DivideResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(WcfCalculatorClient.ServiceReference1.CalculationFault), Action="http://tempuri.org/ICalculator/DivideCalculationFaultFault", Name="CalculationFault", Namespace="http://schemas.datacontract.org/2004/07/WcfCalculatorService")]
        double Divide(double a, double b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalculator/Divide", ReplyAction="http://tempuri.org/ICalculator/DivideResponse")]
        System.Threading.Tasks.Task<double> DivideAsync(double a, double b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalculator/Sqrt", ReplyAction="http://tempuri.org/ICalculator/SqrtResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(WcfCalculatorClient.ServiceReference1.CalculationFault), Action="http://tempuri.org/ICalculator/SqrtCalculationFaultFault", Name="CalculationFault", Namespace="http://schemas.datacontract.org/2004/07/WcfCalculatorService")]
        double Sqrt(double a);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalculator/Sqrt", ReplyAction="http://tempuri.org/ICalculator/SqrtResponse")]
        System.Threading.Tasks.Task<double> SqrtAsync(double a);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICalculatorChannel : WcfCalculatorClient.ServiceReference1.ICalculator, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class CalculatorClient : System.ServiceModel.ClientBase<WcfCalculatorClient.ServiceReference1.ICalculator>, WcfCalculatorClient.ServiceReference1.ICalculator {
        
        public CalculatorClient() {
        }
        
        public CalculatorClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CalculatorClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CalculatorClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CalculatorClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public double Add(double a, double b) {
            return base.Channel.Add(a, b);
        }
        
        public System.Threading.Tasks.Task<double> AddAsync(double a, double b) {
            return base.Channel.AddAsync(a, b);
        }
        
        public double Substract(double a, double b) {
            return base.Channel.Substract(a, b);
        }
        
        public System.Threading.Tasks.Task<double> SubstractAsync(double a, double b) {
            return base.Channel.SubstractAsync(a, b);
        }
        
        public double Multiply(double a, double b) {
            return base.Channel.Multiply(a, b);
        }
        
        public System.Threading.Tasks.Task<double> MultiplyAsync(double a, double b) {
            return base.Channel.MultiplyAsync(a, b);
        }
        
        public double Divide(double a, double b) {
            return base.Channel.Divide(a, b);
        }
        
        public System.Threading.Tasks.Task<double> DivideAsync(double a, double b) {
            return base.Channel.DivideAsync(a, b);
        }
        
        public double Sqrt(double a) {
            return base.Channel.Sqrt(a);
        }
        
        public System.Threading.Tasks.Task<double> SqrtAsync(double a) {
            return base.Channel.SqrtAsync(a);
        }
    }
}