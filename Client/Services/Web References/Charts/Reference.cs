﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18033
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by Microsoft.VSDesigner, Version 4.0.30319.18033.
// 
#pragma warning disable 1591

namespace Terrarium.Services.Charts {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.Xml.Serialization;
    using System.ComponentModel;
    using System.Data;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="ChartServiceSoap", Namespace="http://tempuri.org/")]
    public partial class ChartService : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback GetSpeciesListOperationCompleted;
        
        private System.Threading.SendOrPostCallback GrabLatestSpeciesDataOperationCompleted;
        
        private System.Threading.SendOrPostCallback GetTopAnimalsOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public ChartService() {
            this.Url = "http://localhost:56385/Website/charts/chartservice.asmx";
            if ((this.IsLocalFileSystemWebService(this.Url) == true)) {
                this.UseDefaultCredentials = true;
                this.useDefaultCredentialsSetExplicitly = false;
            }
            else {
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        public new string Url {
            get {
                return base.Url;
            }
            set {
                if ((((this.IsLocalFileSystemWebService(base.Url) == true) 
                            && (this.useDefaultCredentialsSetExplicitly == false)) 
                            && (this.IsLocalFileSystemWebService(value) == false))) {
                    base.UseDefaultCredentials = false;
                }
                base.Url = value;
            }
        }
        
        public new bool UseDefaultCredentials {
            get {
                return base.UseDefaultCredentials;
            }
            set {
                base.UseDefaultCredentials = value;
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        /// <remarks/>
        public event GetSpeciesListCompletedEventHandler GetSpeciesListCompleted;
        
        /// <remarks/>
        public event GrabLatestSpeciesDataCompletedEventHandler GrabLatestSpeciesDataCompleted;
        
        /// <remarks/>
        public event GetTopAnimalsCompletedEventHandler GetTopAnimalsCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/GetSpeciesList", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public System.Data.DataSet GetSpeciesList() {
            object[] results = this.Invoke("GetSpeciesList", new object[0]);
            return ((System.Data.DataSet)(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BeginGetSpeciesList(System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("GetSpeciesList", new object[0], callback, asyncState);
        }
        
        /// <remarks/>
        public System.Data.DataSet EndGetSpeciesList(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((System.Data.DataSet)(results[0]));
        }
        
        /// <remarks/>
        public void GetSpeciesListAsync() {
            this.GetSpeciesListAsync(null);
        }
        
        /// <remarks/>
        public void GetSpeciesListAsync(object userState) {
            if ((this.GetSpeciesListOperationCompleted == null)) {
                this.GetSpeciesListOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetSpeciesListOperationCompleted);
            }
            this.InvokeAsync("GetSpeciesList", new object[0], this.GetSpeciesListOperationCompleted, userState);
        }
        
        private void OnGetSpeciesListOperationCompleted(object arg) {
            if ((this.GetSpeciesListCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetSpeciesListCompleted(this, new GetSpeciesListCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/GrabLatestSpeciesData", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public System.Data.DataSet GrabLatestSpeciesData(string species) {
            object[] results = this.Invoke("GrabLatestSpeciesData", new object[] {
                        species});
            return ((System.Data.DataSet)(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BeginGrabLatestSpeciesData(string species, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("GrabLatestSpeciesData", new object[] {
                        species}, callback, asyncState);
        }
        
        /// <remarks/>
        public System.Data.DataSet EndGrabLatestSpeciesData(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((System.Data.DataSet)(results[0]));
        }
        
        /// <remarks/>
        public void GrabLatestSpeciesDataAsync(string species) {
            this.GrabLatestSpeciesDataAsync(species, null);
        }
        
        /// <remarks/>
        public void GrabLatestSpeciesDataAsync(string species, object userState) {
            if ((this.GrabLatestSpeciesDataOperationCompleted == null)) {
                this.GrabLatestSpeciesDataOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGrabLatestSpeciesDataOperationCompleted);
            }
            this.InvokeAsync("GrabLatestSpeciesData", new object[] {
                        species}, this.GrabLatestSpeciesDataOperationCompleted, userState);
        }
        
        private void OnGrabLatestSpeciesDataOperationCompleted(object arg) {
            if ((this.GrabLatestSpeciesDataCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GrabLatestSpeciesDataCompleted(this, new GrabLatestSpeciesDataCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/GetTopAnimals", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public System.Data.DataSet GetTopAnimals(string version, OrganismType tat, int num) {
            object[] results = this.Invoke("GetTopAnimals", new object[] {
                        version,
                        tat,
                        num});
            return ((System.Data.DataSet)(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BeginGetTopAnimals(string version, OrganismType tat, int num, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("GetTopAnimals", new object[] {
                        version,
                        tat,
                        num}, callback, asyncState);
        }
        
        /// <remarks/>
        public System.Data.DataSet EndGetTopAnimals(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((System.Data.DataSet)(results[0]));
        }
        
        /// <remarks/>
        public void GetTopAnimalsAsync(string version, OrganismType tat, int num) {
            this.GetTopAnimalsAsync(version, tat, num, null);
        }
        
        /// <remarks/>
        public void GetTopAnimalsAsync(string version, OrganismType tat, int num, object userState) {
            if ((this.GetTopAnimalsOperationCompleted == null)) {
                this.GetTopAnimalsOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetTopAnimalsOperationCompleted);
            }
            this.InvokeAsync("GetTopAnimals", new object[] {
                        version,
                        tat,
                        num}, this.GetTopAnimalsOperationCompleted, userState);
        }
        
        private void OnGetTopAnimalsOperationCompleted(object arg) {
            if ((this.GetTopAnimalsCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetTopAnimalsCompleted(this, new GetTopAnimalsCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        public new void CancelAsync(object userState) {
            base.CancelAsync(userState);
        }
        
        private bool IsLocalFileSystemWebService(string url) {
            if (((url == null) 
                        || (url == string.Empty))) {
                return false;
            }
            System.Uri wsUri = new System.Uri(url);
            if (((wsUri.Port >= 1024) 
                        && (string.Compare(wsUri.Host, "localHost", System.StringComparison.OrdinalIgnoreCase) == 0))) {
                return true;
            }
            return false;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18033")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public enum OrganismType {
        
        /// <remarks/>
        Carnivore,
        
        /// <remarks/>
        Herbivore,
        
        /// <remarks/>
        Plant,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    public delegate void GetSpeciesListCompletedEventHandler(object sender, GetSpeciesListCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetSpeciesListCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetSpeciesListCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public System.Data.DataSet Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((System.Data.DataSet)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    public delegate void GrabLatestSpeciesDataCompletedEventHandler(object sender, GrabLatestSpeciesDataCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GrabLatestSpeciesDataCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GrabLatestSpeciesDataCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public System.Data.DataSet Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((System.Data.DataSet)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    public delegate void GetTopAnimalsCompletedEventHandler(object sender, GetTopAnimalsCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetTopAnimalsCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetTopAnimalsCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public System.Data.DataSet Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((System.Data.DataSet)(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591