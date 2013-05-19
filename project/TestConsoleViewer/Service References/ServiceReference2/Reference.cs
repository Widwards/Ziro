﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.18034
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TestConsoleViewer.ServiceReference2 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://widwards.cloudapp.net", ConfigurationName="ServiceReference2.IZiroService")]
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
        ZiroServerWcfServiceLibrary.ZiroAgentRecord[] GetLastRecords(int numbersOfRecord);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://widwards.cloudapp.net/IZiroService/GetLastRecords", ReplyAction="http://widwards.cloudapp.net/IZiroService/GetLastRecordsResponse")]
        System.Threading.Tasks.Task<ZiroServerWcfServiceLibrary.ZiroAgentRecord[]> GetLastRecordsAsync(int numbersOfRecord);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IZiroServiceChannel : TestConsoleViewer.ServiceReference2.IZiroService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ZiroServiceClient : System.ServiceModel.ClientBase<TestConsoleViewer.ServiceReference2.IZiroService>, TestConsoleViewer.ServiceReference2.IZiroService {
        
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
        
        public ZiroServerWcfServiceLibrary.ZiroAgentRecord[] GetLastRecords(int numbersOfRecord) {
            return base.Channel.GetLastRecords(numbersOfRecord);
        }
        
        public System.Threading.Tasks.Task<ZiroServerWcfServiceLibrary.ZiroAgentRecord[]> GetLastRecordsAsync(int numbersOfRecord) {
            return base.Channel.GetLastRecordsAsync(numbersOfRecord);
        }
    }
}