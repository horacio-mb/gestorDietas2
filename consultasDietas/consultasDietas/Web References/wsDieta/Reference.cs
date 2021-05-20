﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// Microsoft.VSDesigner generó automáticamente este código fuente, versión=4.0.30319.42000.
// 
#pragma warning disable 1591

namespace consultasDietas.wsDieta {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.Xml.Serialization;
    using System.ComponentModel;
    using System.Data;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3752.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="wsDietaSoap", Namespace="http://tempuri.org/")]
    public partial class wsDieta : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback buscarDietaPorUsuarioOperationCompleted;
        
        private System.Threading.SendOrPostCallback buscarDietaPorClienteOperationCompleted;
        
        private System.Threading.SendOrPostCallback buscarDietaPorRangoFechaOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public wsDieta() {
            this.Url = global::consultasDietas.Properties.Settings.Default.consultasDietas_wsDieta_wsDieta;
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
        public event buscarDietaPorUsuarioCompletedEventHandler buscarDietaPorUsuarioCompleted;
        
        /// <remarks/>
        public event buscarDietaPorClienteCompletedEventHandler buscarDietaPorClienteCompleted;
        
        /// <remarks/>
        public event buscarDietaPorRangoFechaCompletedEventHandler buscarDietaPorRangoFechaCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/buscarDietaPorUsuario", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public System.Data.DataSet buscarDietaPorUsuario(string usuario) {
            object[] results = this.Invoke("buscarDietaPorUsuario", new object[] {
                        usuario});
            return ((System.Data.DataSet)(results[0]));
        }
        
        /// <remarks/>
        public void buscarDietaPorUsuarioAsync(string usuario) {
            this.buscarDietaPorUsuarioAsync(usuario, null);
        }
        
        /// <remarks/>
        public void buscarDietaPorUsuarioAsync(string usuario, object userState) {
            if ((this.buscarDietaPorUsuarioOperationCompleted == null)) {
                this.buscarDietaPorUsuarioOperationCompleted = new System.Threading.SendOrPostCallback(this.OnbuscarDietaPorUsuarioOperationCompleted);
            }
            this.InvokeAsync("buscarDietaPorUsuario", new object[] {
                        usuario}, this.buscarDietaPorUsuarioOperationCompleted, userState);
        }
        
        private void OnbuscarDietaPorUsuarioOperationCompleted(object arg) {
            if ((this.buscarDietaPorUsuarioCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.buscarDietaPorUsuarioCompleted(this, new buscarDietaPorUsuarioCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/buscarDietaPorCliente", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public System.Data.DataSet buscarDietaPorCliente(string nom) {
            object[] results = this.Invoke("buscarDietaPorCliente", new object[] {
                        nom});
            return ((System.Data.DataSet)(results[0]));
        }
        
        /// <remarks/>
        public void buscarDietaPorClienteAsync(string nom) {
            this.buscarDietaPorClienteAsync(nom, null);
        }
        
        /// <remarks/>
        public void buscarDietaPorClienteAsync(string nom, object userState) {
            if ((this.buscarDietaPorClienteOperationCompleted == null)) {
                this.buscarDietaPorClienteOperationCompleted = new System.Threading.SendOrPostCallback(this.OnbuscarDietaPorClienteOperationCompleted);
            }
            this.InvokeAsync("buscarDietaPorCliente", new object[] {
                        nom}, this.buscarDietaPorClienteOperationCompleted, userState);
        }
        
        private void OnbuscarDietaPorClienteOperationCompleted(object arg) {
            if ((this.buscarDietaPorClienteCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.buscarDietaPorClienteCompleted(this, new buscarDietaPorClienteCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/buscarDietaPorRangoFecha", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public System.Data.DataSet buscarDietaPorRangoFecha(string fecha1, string fecha2) {
            object[] results = this.Invoke("buscarDietaPorRangoFecha", new object[] {
                        fecha1,
                        fecha2});
            return ((System.Data.DataSet)(results[0]));
        }
        
        /// <remarks/>
        public void buscarDietaPorRangoFechaAsync(string fecha1, string fecha2) {
            this.buscarDietaPorRangoFechaAsync(fecha1, fecha2, null);
        }
        
        /// <remarks/>
        public void buscarDietaPorRangoFechaAsync(string fecha1, string fecha2, object userState) {
            if ((this.buscarDietaPorRangoFechaOperationCompleted == null)) {
                this.buscarDietaPorRangoFechaOperationCompleted = new System.Threading.SendOrPostCallback(this.OnbuscarDietaPorRangoFechaOperationCompleted);
            }
            this.InvokeAsync("buscarDietaPorRangoFecha", new object[] {
                        fecha1,
                        fecha2}, this.buscarDietaPorRangoFechaOperationCompleted, userState);
        }
        
        private void OnbuscarDietaPorRangoFechaOperationCompleted(object arg) {
            if ((this.buscarDietaPorRangoFechaCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.buscarDietaPorRangoFechaCompleted(this, new buscarDietaPorRangoFechaCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3752.0")]
    public delegate void buscarDietaPorUsuarioCompletedEventHandler(object sender, buscarDietaPorUsuarioCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3752.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class buscarDietaPorUsuarioCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal buscarDietaPorUsuarioCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3752.0")]
    public delegate void buscarDietaPorClienteCompletedEventHandler(object sender, buscarDietaPorClienteCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3752.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class buscarDietaPorClienteCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal buscarDietaPorClienteCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3752.0")]
    public delegate void buscarDietaPorRangoFechaCompletedEventHandler(object sender, buscarDietaPorRangoFechaCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3752.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class buscarDietaPorRangoFechaCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal buscarDietaPorRangoFechaCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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