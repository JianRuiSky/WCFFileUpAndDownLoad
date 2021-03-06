﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.18444
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataRcvClient.ServiceReference {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference.IDataRcvService")]
    public interface IDataRcvService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDataRcvService/DoWork", ReplyAction="http://tempuri.org/IDataRcvService/DoWorkResponse")]
        bool DoWork(System.DateTime dt);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDataRcvService/DoWork", ReplyAction="http://tempuri.org/IDataRcvService/DoWorkResponse")]
        System.Threading.Tasks.Task<bool> DoWorkAsync(System.DateTime dt);
        
        // CODEGEN: 消息 UpFile 的包装名称(UpFile)以后生成的消息协定与默认值(UpLoadFile)不匹配
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDataRcvService/UpLoadFile", ReplyAction="http://tempuri.org/IDataRcvService/UpLoadFileResponse")]
        DataRcvClient.ServiceReference.UpFileResult UpLoadFile(DataRcvClient.ServiceReference.UpFile request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDataRcvService/UpLoadFile", ReplyAction="http://tempuri.org/IDataRcvService/UpLoadFileResponse")]
        System.Threading.Tasks.Task<DataRcvClient.ServiceReference.UpFileResult> UpLoadFileAsync(DataRcvClient.ServiceReference.UpFile request);
        
        // CODEGEN: 消息 DownFile 的包装名称(DownFile)以后生成的消息协定与默认值(DownLoadFile)不匹配
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDataRcvService/DownLoadFile", ReplyAction="http://tempuri.org/IDataRcvService/DownLoadFileResponse")]
        DataRcvClient.ServiceReference.DownFileResult DownLoadFile(DataRcvClient.ServiceReference.DownFile request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDataRcvService/DownLoadFile", ReplyAction="http://tempuri.org/IDataRcvService/DownLoadFileResponse")]
        System.Threading.Tasks.Task<DataRcvClient.ServiceReference.DownFileResult> DownLoadFileAsync(DataRcvClient.ServiceReference.DownFile request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="UpFile", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class UpFile {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://tempuri.org/")]
        public string FileName;
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://tempuri.org/")]
        public long FileSize;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public System.IO.Stream FileStream;
        
        public UpFile() {
        }
        
        public UpFile(string FileName, long FileSize, System.IO.Stream FileStream) {
            this.FileName = FileName;
            this.FileSize = FileSize;
            this.FileStream = FileStream;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="UpFileResult", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class UpFileResult {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://tempuri.org/")]
        public bool IsSuccess;
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://tempuri.org/")]
        public string Message;
        
        public UpFileResult() {
        }
        
        public UpFileResult(bool IsSuccess, string Message) {
            this.IsSuccess = IsSuccess;
            this.Message = Message;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="DownFile", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class DownFile {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://tempuri.org/")]
        public string FileName;
        
        public DownFile() {
        }
        
        public DownFile(string FileName) {
            this.FileName = FileName;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="DownFileResult", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class DownFileResult {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://tempuri.org/")]
        public long FileSize;
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://tempuri.org/")]
        public bool IsSuccess;
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://tempuri.org/")]
        public string Message;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public System.IO.Stream FileStream;
        
        public DownFileResult() {
        }
        
        public DownFileResult(long FileSize, bool IsSuccess, string Message, System.IO.Stream FileStream) {
            this.FileSize = FileSize;
            this.IsSuccess = IsSuccess;
            this.Message = Message;
            this.FileStream = FileStream;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IDataRcvServiceChannel : DataRcvClient.ServiceReference.IDataRcvService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class DataRcvServiceClient : System.ServiceModel.ClientBase<DataRcvClient.ServiceReference.IDataRcvService>, DataRcvClient.ServiceReference.IDataRcvService {
        
        public DataRcvServiceClient() {
        }
        
        public DataRcvServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public DataRcvServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public DataRcvServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public DataRcvServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public bool DoWork(System.DateTime dt) {
            return base.Channel.DoWork(dt);
        }
        
        public System.Threading.Tasks.Task<bool> DoWorkAsync(System.DateTime dt) {
            return base.Channel.DoWorkAsync(dt);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        DataRcvClient.ServiceReference.UpFileResult DataRcvClient.ServiceReference.IDataRcvService.UpLoadFile(DataRcvClient.ServiceReference.UpFile request) {
            return base.Channel.UpLoadFile(request);
        }
        
        public bool UpLoadFile(string FileName, long FileSize, System.IO.Stream FileStream, out string Message) {
            DataRcvClient.ServiceReference.UpFile inValue = new DataRcvClient.ServiceReference.UpFile();
            inValue.FileName = FileName;
            inValue.FileSize = FileSize;
            inValue.FileStream = FileStream;
            DataRcvClient.ServiceReference.UpFileResult retVal = ((DataRcvClient.ServiceReference.IDataRcvService)(this)).UpLoadFile(inValue);
            Message = retVal.Message;
            return retVal.IsSuccess;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<DataRcvClient.ServiceReference.UpFileResult> DataRcvClient.ServiceReference.IDataRcvService.UpLoadFileAsync(DataRcvClient.ServiceReference.UpFile request) {
            return base.Channel.UpLoadFileAsync(request);
        }
        
        public System.Threading.Tasks.Task<DataRcvClient.ServiceReference.UpFileResult> UpLoadFileAsync(string FileName, long FileSize, System.IO.Stream FileStream) {
            DataRcvClient.ServiceReference.UpFile inValue = new DataRcvClient.ServiceReference.UpFile();
            inValue.FileName = FileName;
            inValue.FileSize = FileSize;
            inValue.FileStream = FileStream;
            return ((DataRcvClient.ServiceReference.IDataRcvService)(this)).UpLoadFileAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        DataRcvClient.ServiceReference.DownFileResult DataRcvClient.ServiceReference.IDataRcvService.DownLoadFile(DataRcvClient.ServiceReference.DownFile request) {
            return base.Channel.DownLoadFile(request);
        }
        
        public long DownLoadFile(string FileName, out bool IsSuccess, out string Message, out System.IO.Stream FileStream) {
            DataRcvClient.ServiceReference.DownFile inValue = new DataRcvClient.ServiceReference.DownFile();
            inValue.FileName = FileName;
            DataRcvClient.ServiceReference.DownFileResult retVal = ((DataRcvClient.ServiceReference.IDataRcvService)(this)).DownLoadFile(inValue);
            IsSuccess = retVal.IsSuccess;
            Message = retVal.Message;
            FileStream = retVal.FileStream;
            return retVal.FileSize;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<DataRcvClient.ServiceReference.DownFileResult> DataRcvClient.ServiceReference.IDataRcvService.DownLoadFileAsync(DataRcvClient.ServiceReference.DownFile request) {
            return base.Channel.DownLoadFileAsync(request);
        }
        
        public System.Threading.Tasks.Task<DataRcvClient.ServiceReference.DownFileResult> DownLoadFileAsync(string FileName) {
            DataRcvClient.ServiceReference.DownFile inValue = new DataRcvClient.ServiceReference.DownFile();
            inValue.FileName = FileName;
            return ((DataRcvClient.ServiceReference.IDataRcvService)(this)).DownLoadFileAsync(inValue);
        }
    }
}
