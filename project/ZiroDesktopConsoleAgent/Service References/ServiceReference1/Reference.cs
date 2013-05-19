﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.18034
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ZiroDesktopConsoleAgent.ServiceReference1 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ZiroAgentRecord", Namespace="http://schemas.datacontract.org/2004/07/ZiroServerWcfServiceLibrary")]
    [System.SerializableAttribute()]
    public partial class ZiroAgentRecord : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int CpuUsageField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int FreeMemoryField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdAgentField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int idRecordsField;
        
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
        public int CpuUsage {
            get {
                return this.CpuUsageField;
            }
            set {
                if ((this.CpuUsageField.Equals(value) != true)) {
                    this.CpuUsageField = value;
                    this.RaisePropertyChanged("CpuUsage");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int FreeMemory {
            get {
                return this.FreeMemoryField;
            }
            set {
                if ((this.FreeMemoryField.Equals(value) != true)) {
                    this.FreeMemoryField = value;
                    this.RaisePropertyChanged("FreeMemory");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int IdAgent {
            get {
                return this.IdAgentField;
            }
            set {
                if ((this.IdAgentField.Equals(value) != true)) {
                    this.IdAgentField = value;
                    this.RaisePropertyChanged("IdAgent");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int idRecords {
            get {
                return this.idRecordsField;
            }
            set {
                if ((this.idRecordsField.Equals(value) != true)) {
                    this.idRecordsField = value;
                    this.RaisePropertyChanged("idRecords");
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
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://widwards.cloudapp.net", ConfigurationName="ServiceReference1.IZiroService")]
    public interface IZiroService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://widwards.cloudapp.net/IZiroService/GetDefaultOptions", ReplyAction="http://widwards.cloudapp.net/IZiroService/GetDefaultOptionsResponse")]
        int GetDefaultOptions();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://widwards.cloudapp.net/IZiroService/GetDefaultOptions", ReplyAction="http://widwards.cloudapp.net/IZiroService/GetDefaultOptionsResponse")]
        System.Threading.Tasks.Task<int> GetDefaultOptionsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://widwards.cloudapp.net/IZiroService/Update", ReplyAction="http://widwards.cloudapp.net/IZiroService/UpdateResponse")]
        void Update(int idAgent, int cpuUsage, int freeMemory);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://widwards.cloudapp.net/IZiroService/Update", ReplyAction="http://widwards.cloudapp.net/IZiroService/UpdateResponse")]
        System.Threading.Tasks.Task UpdateAsync(int idAgent, int cpuUsage, int freeMemory);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://widwards.cloudapp.net/IZiroService/PushCurrentCpuUsage", ReplyAction="http://widwards.cloudapp.net/IZiroService/PushCurrentCpuUsageResponse")]
        void PushCurrentCpuUsage(int idAgent, int cpuUsage);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://widwards.cloudapp.net/IZiroService/PushCurrentCpuUsage", ReplyAction="http://widwards.cloudapp.net/IZiroService/PushCurrentCpuUsageResponse")]
        System.Threading.Tasks.Task PushCurrentCpuUsageAsync(int idAgent, int cpuUsage);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://widwards.cloudapp.net/IZiroService/PushCurrentFreeMemory", ReplyAction="http://widwards.cloudapp.net/IZiroService/PushCurrentFreeMemoryResponse")]
        void PushCurrentFreeMemory(int idAgent, int freeMemory);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://widwards.cloudapp.net/IZiroService/PushCurrentFreeMemory", ReplyAction="http://widwards.cloudapp.net/IZiroService/PushCurrentFreeMemoryResponse")]
        System.Threading.Tasks.Task PushCurrentFreeMemoryAsync(int idAgent, int freeMemory);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://widwards.cloudapp.net/IZiroService/UpdateConsole", ReplyAction="http://widwards.cloudapp.net/IZiroService/UpdateConsoleResponse")]
        void UpdateConsole(int idAgent, int cpuUsage, int freeMemory);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://widwards.cloudapp.net/IZiroService/UpdateConsole", ReplyAction="http://widwards.cloudapp.net/IZiroService/UpdateConsoleResponse")]
        System.Threading.Tasks.Task UpdateConsoleAsync(int idAgent, int cpuUsage, int freeMemory);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://widwards.cloudapp.net/IZiroService/GetLastRecords", ReplyAction="http://widwards.cloudapp.net/IZiroService/GetLastRecordsResponse")]
        ZiroDesktopConsoleAgent.ServiceReference1.ZiroAgentRecord[] GetLastRecords(int numbersOfRecord);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://widwards.cloudapp.net/IZiroService/GetLastRecords", ReplyAction="http://widwards.cloudapp.net/IZiroService/GetLastRecordsResponse")]
        System.Threading.Tasks.Task<ZiroDesktopConsoleAgent.ServiceReference1.ZiroAgentRecord[]> GetLastRecordsAsync(int numbersOfRecord);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IZiroServiceChannel : ZiroDesktopConsoleAgent.ServiceReference1.IZiroService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ZiroServiceClient : System.ServiceModel.ClientBase<ZiroDesktopConsoleAgent.ServiceReference1.IZiroService>, ZiroDesktopConsoleAgent.ServiceReference1.IZiroService {
        
        public ZiroServiceClient() {
        }
        
        public ZiroServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ZiroServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ZiroServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ZiroServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public int GetDefaultOptions() {
            return base.Channel.GetDefaultOptions();
        }
        
        public System.Threading.Tasks.Task<int> GetDefaultOptionsAsync() {
            return base.Channel.GetDefaultOptionsAsync();
        }
        
        public void Update(int idAgent, int cpuUsage, int freeMemory) {
            base.Channel.Update(idAgent, cpuUsage, freeMemory);
        }
        
        public System.Threading.Tasks.Task UpdateAsync(int idAgent, int cpuUsage, int freeMemory) {
            return base.Channel.UpdateAsync(idAgent, cpuUsage, freeMemory);
        }
        
        public void PushCurrentCpuUsage(int idAgent, int cpuUsage) {
            base.Channel.PushCurrentCpuUsage(idAgent, cpuUsage);
        }
        
        public System.Threading.Tasks.Task PushCurrentCpuUsageAsync(int idAgent, int cpuUsage) {
            return base.Channel.PushCurrentCpuUsageAsync(idAgent, cpuUsage);
        }
        
        public void PushCurrentFreeMemory(int idAgent, int freeMemory) {
            base.Channel.PushCurrentFreeMemory(idAgent, freeMemory);
        }
        
        public System.Threading.Tasks.Task PushCurrentFreeMemoryAsync(int idAgent, int freeMemory) {
            return base.Channel.PushCurrentFreeMemoryAsync(idAgent, freeMemory);
        }
        
        public void UpdateConsole(int idAgent, int cpuUsage, int freeMemory) {
            base.Channel.UpdateConsole(idAgent, cpuUsage, freeMemory);
        }
        
        public System.Threading.Tasks.Task UpdateConsoleAsync(int idAgent, int cpuUsage, int freeMemory) {
            return base.Channel.UpdateConsoleAsync(idAgent, cpuUsage, freeMemory);
        }
        
        public ZiroDesktopConsoleAgent.ServiceReference1.ZiroAgentRecord[] GetLastRecords(int numbersOfRecord) {
            return base.Channel.GetLastRecords(numbersOfRecord);
        }
        
        public System.Threading.Tasks.Task<ZiroDesktopConsoleAgent.ServiceReference1.ZiroAgentRecord[]> GetLastRecordsAsync(int numbersOfRecord) {
            return base.Channel.GetLastRecordsAsync(numbersOfRecord);
        }
    }
}
