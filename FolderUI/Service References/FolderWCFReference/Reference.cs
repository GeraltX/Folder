﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.34014
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This code was auto-generated by Microsoft.Silverlight.ServiceReference, version 5.0.61118.0
// 
namespace HuaweiSoftware.Folder.FolderWCFReference {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="FolderWCFReference.IFolderWCF")]
    public interface IFolderWCF {
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://tempuri.org/IFolderWCF/SaveData", ReplyAction="http://tempuri.org/IFolderWCF/SaveDataResponse")]
        System.IAsyncResult BeginSaveData(System.Collections.Generic.List<System.Collections.Generic.List<string>> folders, System.AsyncCallback callback, object asyncState);
        
        int EndSaveData(System.IAsyncResult result);
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://tempuri.org/IFolderWCF/GetAllFolders", ReplyAction="http://tempuri.org/IFolderWCF/GetAllFoldersResponse")]
        System.IAsyncResult BeginGetAllFolders(System.AsyncCallback callback, object asyncState);
        
        System.Collections.Generic.List<System.Collections.Generic.List<string>> EndGetAllFolders(System.IAsyncResult result);
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://tempuri.org/IFolderWCF/GetFiles", ReplyAction="http://tempuri.org/IFolderWCF/GetFilesResponse")]
        System.IAsyncResult BeginGetFiles(System.Nullable<int> PID, System.AsyncCallback callback, object asyncState);
        
        System.Collections.Generic.List<System.Collections.Generic.List<string>> EndGetFiles(System.IAsyncResult result);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IFolderWCFChannel : HuaweiSoftware.Folder.FolderWCFReference.IFolderWCF, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class SaveDataCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        public SaveDataCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        public int Result {
            get {
                base.RaiseExceptionIfNecessary();
                return ((int)(this.results[0]));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class GetAllFoldersCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        public GetAllFoldersCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        public System.Collections.Generic.List<System.Collections.Generic.List<string>> Result {
            get {
                base.RaiseExceptionIfNecessary();
                return ((System.Collections.Generic.List<System.Collections.Generic.List<string>>)(this.results[0]));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class GetFilesCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        public GetFilesCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        public System.Collections.Generic.List<System.Collections.Generic.List<string>> Result {
            get {
                base.RaiseExceptionIfNecessary();
                return ((System.Collections.Generic.List<System.Collections.Generic.List<string>>)(this.results[0]));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class FolderWCFClient : System.ServiceModel.ClientBase<HuaweiSoftware.Folder.FolderWCFReference.IFolderWCF>, HuaweiSoftware.Folder.FolderWCFReference.IFolderWCF {
        
        private BeginOperationDelegate onBeginSaveDataDelegate;
        
        private EndOperationDelegate onEndSaveDataDelegate;
        
        private System.Threading.SendOrPostCallback onSaveDataCompletedDelegate;
        
        private BeginOperationDelegate onBeginGetAllFoldersDelegate;
        
        private EndOperationDelegate onEndGetAllFoldersDelegate;
        
        private System.Threading.SendOrPostCallback onGetAllFoldersCompletedDelegate;
        
        private BeginOperationDelegate onBeginGetFilesDelegate;
        
        private EndOperationDelegate onEndGetFilesDelegate;
        
        private System.Threading.SendOrPostCallback onGetFilesCompletedDelegate;
        
        private BeginOperationDelegate onBeginOpenDelegate;
        
        private EndOperationDelegate onEndOpenDelegate;
        
        private System.Threading.SendOrPostCallback onOpenCompletedDelegate;
        
        private BeginOperationDelegate onBeginCloseDelegate;
        
        private EndOperationDelegate onEndCloseDelegate;
        
        private System.Threading.SendOrPostCallback onCloseCompletedDelegate;
        
        public FolderWCFClient() {
        }
        
        public FolderWCFClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public FolderWCFClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public FolderWCFClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public FolderWCFClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Net.CookieContainer CookieContainer {
            get {
                System.ServiceModel.Channels.IHttpCookieContainerManager httpCookieContainerManager = this.InnerChannel.GetProperty<System.ServiceModel.Channels.IHttpCookieContainerManager>();
                if ((httpCookieContainerManager != null)) {
                    return httpCookieContainerManager.CookieContainer;
                }
                else {
                    return null;
                }
            }
            set {
                System.ServiceModel.Channels.IHttpCookieContainerManager httpCookieContainerManager = this.InnerChannel.GetProperty<System.ServiceModel.Channels.IHttpCookieContainerManager>();
                if ((httpCookieContainerManager != null)) {
                    httpCookieContainerManager.CookieContainer = value;
                }
                else {
                    throw new System.InvalidOperationException("无法设置 CookieContainer。请确保绑定包含 HttpCookieContainerBindingElement。");
                }
            }
        }
        
        public event System.EventHandler<SaveDataCompletedEventArgs> SaveDataCompleted;
        
        public event System.EventHandler<GetAllFoldersCompletedEventArgs> GetAllFoldersCompleted;
        
        public event System.EventHandler<GetFilesCompletedEventArgs> GetFilesCompleted;
        
        public event System.EventHandler<System.ComponentModel.AsyncCompletedEventArgs> OpenCompleted;
        
        public event System.EventHandler<System.ComponentModel.AsyncCompletedEventArgs> CloseCompleted;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.IAsyncResult HuaweiSoftware.Folder.FolderWCFReference.IFolderWCF.BeginSaveData(System.Collections.Generic.List<System.Collections.Generic.List<string>> folders, System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginSaveData(folders, callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        int HuaweiSoftware.Folder.FolderWCFReference.IFolderWCF.EndSaveData(System.IAsyncResult result) {
            return base.Channel.EndSaveData(result);
        }
        
        private System.IAsyncResult OnBeginSaveData(object[] inValues, System.AsyncCallback callback, object asyncState) {
            System.Collections.Generic.List<System.Collections.Generic.List<string>> folders = ((System.Collections.Generic.List<System.Collections.Generic.List<string>>)(inValues[0]));
            return ((HuaweiSoftware.Folder.FolderWCFReference.IFolderWCF)(this)).BeginSaveData(folders, callback, asyncState);
        }
        
        private object[] OnEndSaveData(System.IAsyncResult result) {
            int retVal = ((HuaweiSoftware.Folder.FolderWCFReference.IFolderWCF)(this)).EndSaveData(result);
            return new object[] {
                    retVal};
        }
        
        private void OnSaveDataCompleted(object state) {
            if ((this.SaveDataCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.SaveDataCompleted(this, new SaveDataCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void SaveDataAsync(System.Collections.Generic.List<System.Collections.Generic.List<string>> folders) {
            this.SaveDataAsync(folders, null);
        }
        
        public void SaveDataAsync(System.Collections.Generic.List<System.Collections.Generic.List<string>> folders, object userState) {
            if ((this.onBeginSaveDataDelegate == null)) {
                this.onBeginSaveDataDelegate = new BeginOperationDelegate(this.OnBeginSaveData);
            }
            if ((this.onEndSaveDataDelegate == null)) {
                this.onEndSaveDataDelegate = new EndOperationDelegate(this.OnEndSaveData);
            }
            if ((this.onSaveDataCompletedDelegate == null)) {
                this.onSaveDataCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnSaveDataCompleted);
            }
            base.InvokeAsync(this.onBeginSaveDataDelegate, new object[] {
                        folders}, this.onEndSaveDataDelegate, this.onSaveDataCompletedDelegate, userState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.IAsyncResult HuaweiSoftware.Folder.FolderWCFReference.IFolderWCF.BeginGetAllFolders(System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginGetAllFolders(callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Collections.Generic.List<System.Collections.Generic.List<string>> HuaweiSoftware.Folder.FolderWCFReference.IFolderWCF.EndGetAllFolders(System.IAsyncResult result) {
            return base.Channel.EndGetAllFolders(result);
        }
        
        private System.IAsyncResult OnBeginGetAllFolders(object[] inValues, System.AsyncCallback callback, object asyncState) {
            return ((HuaweiSoftware.Folder.FolderWCFReference.IFolderWCF)(this)).BeginGetAllFolders(callback, asyncState);
        }
        
        private object[] OnEndGetAllFolders(System.IAsyncResult result) {
            System.Collections.Generic.List<System.Collections.Generic.List<string>> retVal = ((HuaweiSoftware.Folder.FolderWCFReference.IFolderWCF)(this)).EndGetAllFolders(result);
            return new object[] {
                    retVal};
        }
        
        private void OnGetAllFoldersCompleted(object state) {
            if ((this.GetAllFoldersCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.GetAllFoldersCompleted(this, new GetAllFoldersCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void GetAllFoldersAsync() {
            this.GetAllFoldersAsync(null);
        }
        
        public void GetAllFoldersAsync(object userState) {
            if ((this.onBeginGetAllFoldersDelegate == null)) {
                this.onBeginGetAllFoldersDelegate = new BeginOperationDelegate(this.OnBeginGetAllFolders);
            }
            if ((this.onEndGetAllFoldersDelegate == null)) {
                this.onEndGetAllFoldersDelegate = new EndOperationDelegate(this.OnEndGetAllFolders);
            }
            if ((this.onGetAllFoldersCompletedDelegate == null)) {
                this.onGetAllFoldersCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnGetAllFoldersCompleted);
            }
            base.InvokeAsync(this.onBeginGetAllFoldersDelegate, null, this.onEndGetAllFoldersDelegate, this.onGetAllFoldersCompletedDelegate, userState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.IAsyncResult HuaweiSoftware.Folder.FolderWCFReference.IFolderWCF.BeginGetFiles(System.Nullable<int> PID, System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginGetFiles(PID, callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Collections.Generic.List<System.Collections.Generic.List<string>> HuaweiSoftware.Folder.FolderWCFReference.IFolderWCF.EndGetFiles(System.IAsyncResult result) {
            return base.Channel.EndGetFiles(result);
        }
        
        private System.IAsyncResult OnBeginGetFiles(object[] inValues, System.AsyncCallback callback, object asyncState) {
            System.Nullable<int> PID = ((System.Nullable<int>)(inValues[0]));
            return ((HuaweiSoftware.Folder.FolderWCFReference.IFolderWCF)(this)).BeginGetFiles(PID, callback, asyncState);
        }
        
        private object[] OnEndGetFiles(System.IAsyncResult result) {
            System.Collections.Generic.List<System.Collections.Generic.List<string>> retVal = ((HuaweiSoftware.Folder.FolderWCFReference.IFolderWCF)(this)).EndGetFiles(result);
            return new object[] {
                    retVal};
        }
        
        private void OnGetFilesCompleted(object state) {
            if ((this.GetFilesCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.GetFilesCompleted(this, new GetFilesCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void GetFilesAsync(System.Nullable<int> PID) {
            this.GetFilesAsync(PID, null);
        }
        
        public void GetFilesAsync(System.Nullable<int> PID, object userState) {
            if ((this.onBeginGetFilesDelegate == null)) {
                this.onBeginGetFilesDelegate = new BeginOperationDelegate(this.OnBeginGetFiles);
            }
            if ((this.onEndGetFilesDelegate == null)) {
                this.onEndGetFilesDelegate = new EndOperationDelegate(this.OnEndGetFiles);
            }
            if ((this.onGetFilesCompletedDelegate == null)) {
                this.onGetFilesCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnGetFilesCompleted);
            }
            base.InvokeAsync(this.onBeginGetFilesDelegate, new object[] {
                        PID}, this.onEndGetFilesDelegate, this.onGetFilesCompletedDelegate, userState);
        }
        
        private System.IAsyncResult OnBeginOpen(object[] inValues, System.AsyncCallback callback, object asyncState) {
            return ((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(callback, asyncState);
        }
        
        private object[] OnEndOpen(System.IAsyncResult result) {
            ((System.ServiceModel.ICommunicationObject)(this)).EndOpen(result);
            return null;
        }
        
        private void OnOpenCompleted(object state) {
            if ((this.OpenCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.OpenCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void OpenAsync() {
            this.OpenAsync(null);
        }
        
        public void OpenAsync(object userState) {
            if ((this.onBeginOpenDelegate == null)) {
                this.onBeginOpenDelegate = new BeginOperationDelegate(this.OnBeginOpen);
            }
            if ((this.onEndOpenDelegate == null)) {
                this.onEndOpenDelegate = new EndOperationDelegate(this.OnEndOpen);
            }
            if ((this.onOpenCompletedDelegate == null)) {
                this.onOpenCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnOpenCompleted);
            }
            base.InvokeAsync(this.onBeginOpenDelegate, null, this.onEndOpenDelegate, this.onOpenCompletedDelegate, userState);
        }
        
        private System.IAsyncResult OnBeginClose(object[] inValues, System.AsyncCallback callback, object asyncState) {
            return ((System.ServiceModel.ICommunicationObject)(this)).BeginClose(callback, asyncState);
        }
        
        private object[] OnEndClose(System.IAsyncResult result) {
            ((System.ServiceModel.ICommunicationObject)(this)).EndClose(result);
            return null;
        }
        
        private void OnCloseCompleted(object state) {
            if ((this.CloseCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.CloseCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void CloseAsync() {
            this.CloseAsync(null);
        }
        
        public void CloseAsync(object userState) {
            if ((this.onBeginCloseDelegate == null)) {
                this.onBeginCloseDelegate = new BeginOperationDelegate(this.OnBeginClose);
            }
            if ((this.onEndCloseDelegate == null)) {
                this.onEndCloseDelegate = new EndOperationDelegate(this.OnEndClose);
            }
            if ((this.onCloseCompletedDelegate == null)) {
                this.onCloseCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnCloseCompleted);
            }
            base.InvokeAsync(this.onBeginCloseDelegate, null, this.onEndCloseDelegate, this.onCloseCompletedDelegate, userState);
        }
        
        protected override HuaweiSoftware.Folder.FolderWCFReference.IFolderWCF CreateChannel() {
            return new FolderWCFClientChannel(this);
        }
        
        private class FolderWCFClientChannel : ChannelBase<HuaweiSoftware.Folder.FolderWCFReference.IFolderWCF>, HuaweiSoftware.Folder.FolderWCFReference.IFolderWCF {
            
            public FolderWCFClientChannel(System.ServiceModel.ClientBase<HuaweiSoftware.Folder.FolderWCFReference.IFolderWCF> client) : 
                    base(client) {
            }
            
            public System.IAsyncResult BeginSaveData(System.Collections.Generic.List<System.Collections.Generic.List<string>> folders, System.AsyncCallback callback, object asyncState) {
                object[] _args = new object[1];
                _args[0] = folders;
                System.IAsyncResult _result = base.BeginInvoke("SaveData", _args, callback, asyncState);
                return _result;
            }
            
            public int EndSaveData(System.IAsyncResult result) {
                object[] _args = new object[0];
                int _result = ((int)(base.EndInvoke("SaveData", _args, result)));
                return _result;
            }
            
            public System.IAsyncResult BeginGetAllFolders(System.AsyncCallback callback, object asyncState) {
                object[] _args = new object[0];
                System.IAsyncResult _result = base.BeginInvoke("GetAllFolders", _args, callback, asyncState);
                return _result;
            }
            
            public System.Collections.Generic.List<System.Collections.Generic.List<string>> EndGetAllFolders(System.IAsyncResult result) {
                object[] _args = new object[0];
                System.Collections.Generic.List<System.Collections.Generic.List<string>> _result = ((System.Collections.Generic.List<System.Collections.Generic.List<string>>)(base.EndInvoke("GetAllFolders", _args, result)));
                return _result;
            }
            
            public System.IAsyncResult BeginGetFiles(System.Nullable<int> PID, System.AsyncCallback callback, object asyncState) {
                object[] _args = new object[1];
                _args[0] = PID;
                System.IAsyncResult _result = base.BeginInvoke("GetFiles", _args, callback, asyncState);
                return _result;
            }
            
            public System.Collections.Generic.List<System.Collections.Generic.List<string>> EndGetFiles(System.IAsyncResult result) {
                object[] _args = new object[0];
                System.Collections.Generic.List<System.Collections.Generic.List<string>> _result = ((System.Collections.Generic.List<System.Collections.Generic.List<string>>)(base.EndInvoke("GetFiles", _args, result)));
                return _result;
            }
        }
    }
}