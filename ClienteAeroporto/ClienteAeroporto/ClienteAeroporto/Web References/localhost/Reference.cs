﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by Microsoft.VSDesigner, Version 4.0.30319.42000.
// 
#pragma warning disable 1591

namespace ClienteAeroporto.localhost {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.Xml.Serialization;
    using System.ComponentModel;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2053.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="WebService1Soap", Namespace="http://gerenciavoos.org/")]
    public partial class WebService1 : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback ConsultarVoosOperationCompleted;
        
        private System.Threading.SendOrPostCallback CadastroVooOperationCompleted;
        
        private System.Threading.SendOrPostCallback AtualizarVooOperationCompleted;
        
        private System.Threading.SendOrPostCallback ComprarBilheteOperationCompleted;
        
        private System.Threading.SendOrPostCallback ConsultarBilhetesOperationCompleted;
        
        private System.Threading.SendOrPostCallback DevolverBilheteOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public WebService1() {
            this.Url = global::ClienteAeroporto.Properties.Settings.Default.ClienteAeroporto_localhost_WebService1;
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
        public event ConsultarVoosCompletedEventHandler ConsultarVoosCompleted;
        
        /// <remarks/>
        public event CadastroVooCompletedEventHandler CadastroVooCompleted;
        
        /// <remarks/>
        public event AtualizarVooCompletedEventHandler AtualizarVooCompleted;
        
        /// <remarks/>
        public event ComprarBilheteCompletedEventHandler ComprarBilheteCompleted;
        
        /// <remarks/>
        public event ConsultarBilhetesCompletedEventHandler ConsultarBilhetesCompleted;
        
        /// <remarks/>
        public event DevolverBilheteCompletedEventHandler DevolverBilheteCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://gerenciavoos.org/ConsultarVoos", RequestNamespace="http://gerenciavoos.org/", ResponseNamespace="http://gerenciavoos.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public Voo[] ConsultarVoos() {
            object[] results = this.Invoke("ConsultarVoos", new object[0]);
            return ((Voo[])(results[0]));
        }
        
        /// <remarks/>
        public void ConsultarVoosAsync() {
            this.ConsultarVoosAsync(null);
        }
        
        /// <remarks/>
        public void ConsultarVoosAsync(object userState) {
            if ((this.ConsultarVoosOperationCompleted == null)) {
                this.ConsultarVoosOperationCompleted = new System.Threading.SendOrPostCallback(this.OnConsultarVoosOperationCompleted);
            }
            this.InvokeAsync("ConsultarVoos", new object[0], this.ConsultarVoosOperationCompleted, userState);
        }
        
        private void OnConsultarVoosOperationCompleted(object arg) {
            if ((this.ConsultarVoosCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.ConsultarVoosCompleted(this, new ConsultarVoosCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://gerenciavoos.org/CadastroVoo", RequestNamespace="http://gerenciavoos.org/", ResponseNamespace="http://gerenciavoos.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public Voo CadastroVoo(Voo voo) {
            object[] results = this.Invoke("CadastroVoo", new object[] {
                        voo});
            return ((Voo)(results[0]));
        }
        
        /// <remarks/>
        public void CadastroVooAsync(Voo voo) {
            this.CadastroVooAsync(voo, null);
        }
        
        /// <remarks/>
        public void CadastroVooAsync(Voo voo, object userState) {
            if ((this.CadastroVooOperationCompleted == null)) {
                this.CadastroVooOperationCompleted = new System.Threading.SendOrPostCallback(this.OnCadastroVooOperationCompleted);
            }
            this.InvokeAsync("CadastroVoo", new object[] {
                        voo}, this.CadastroVooOperationCompleted, userState);
        }
        
        private void OnCadastroVooOperationCompleted(object arg) {
            if ((this.CadastroVooCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.CadastroVooCompleted(this, new CadastroVooCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://gerenciavoos.org/AtualizarVoo", RequestNamespace="http://gerenciavoos.org/", ResponseNamespace="http://gerenciavoos.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public Voo AtualizarVoo(Voo voo) {
            object[] results = this.Invoke("AtualizarVoo", new object[] {
                        voo});
            return ((Voo)(results[0]));
        }
        
        /// <remarks/>
        public void AtualizarVooAsync(Voo voo) {
            this.AtualizarVooAsync(voo, null);
        }
        
        /// <remarks/>
        public void AtualizarVooAsync(Voo voo, object userState) {
            if ((this.AtualizarVooOperationCompleted == null)) {
                this.AtualizarVooOperationCompleted = new System.Threading.SendOrPostCallback(this.OnAtualizarVooOperationCompleted);
            }
            this.InvokeAsync("AtualizarVoo", new object[] {
                        voo}, this.AtualizarVooOperationCompleted, userState);
        }
        
        private void OnAtualizarVooOperationCompleted(object arg) {
            if ((this.AtualizarVooCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.AtualizarVooCompleted(this, new AtualizarVooCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://gerenciavoos.org/ComprarBilhete", RequestNamespace="http://gerenciavoos.org/", ResponseNamespace="http://gerenciavoos.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public bool ComprarBilhete(System.Guid id, int QtdPassagens) {
            object[] results = this.Invoke("ComprarBilhete", new object[] {
                        id,
                        QtdPassagens});
            return ((bool)(results[0]));
        }
        
        /// <remarks/>
        public void ComprarBilheteAsync(System.Guid id, int QtdPassagens) {
            this.ComprarBilheteAsync(id, QtdPassagens, null);
        }
        
        /// <remarks/>
        public void ComprarBilheteAsync(System.Guid id, int QtdPassagens, object userState) {
            if ((this.ComprarBilheteOperationCompleted == null)) {
                this.ComprarBilheteOperationCompleted = new System.Threading.SendOrPostCallback(this.OnComprarBilheteOperationCompleted);
            }
            this.InvokeAsync("ComprarBilhete", new object[] {
                        id,
                        QtdPassagens}, this.ComprarBilheteOperationCompleted, userState);
        }
        
        private void OnComprarBilheteOperationCompleted(object arg) {
            if ((this.ComprarBilheteCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.ComprarBilheteCompleted(this, new ComprarBilheteCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://gerenciavoos.org/ConsultarBilhetes", RequestNamespace="http://gerenciavoos.org/", ResponseNamespace="http://gerenciavoos.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public Passagem[] ConsultarBilhetes() {
            object[] results = this.Invoke("ConsultarBilhetes", new object[0]);
            return ((Passagem[])(results[0]));
        }
        
        /// <remarks/>
        public void ConsultarBilhetesAsync() {
            this.ConsultarBilhetesAsync(null);
        }
        
        /// <remarks/>
        public void ConsultarBilhetesAsync(object userState) {
            if ((this.ConsultarBilhetesOperationCompleted == null)) {
                this.ConsultarBilhetesOperationCompleted = new System.Threading.SendOrPostCallback(this.OnConsultarBilhetesOperationCompleted);
            }
            this.InvokeAsync("ConsultarBilhetes", new object[0], this.ConsultarBilhetesOperationCompleted, userState);
        }
        
        private void OnConsultarBilhetesOperationCompleted(object arg) {
            if ((this.ConsultarBilhetesCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.ConsultarBilhetesCompleted(this, new ConsultarBilhetesCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://gerenciavoos.org/DevolverBilhete", RequestNamespace="http://gerenciavoos.org/", ResponseNamespace="http://gerenciavoos.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public bool DevolverBilhete(System.Guid id) {
            object[] results = this.Invoke("DevolverBilhete", new object[] {
                        id});
            return ((bool)(results[0]));
        }
        
        /// <remarks/>
        public void DevolverBilheteAsync(System.Guid id) {
            this.DevolverBilheteAsync(id, null);
        }
        
        /// <remarks/>
        public void DevolverBilheteAsync(System.Guid id, object userState) {
            if ((this.DevolverBilheteOperationCompleted == null)) {
                this.DevolverBilheteOperationCompleted = new System.Threading.SendOrPostCallback(this.OnDevolverBilheteOperationCompleted);
            }
            this.InvokeAsync("DevolverBilhete", new object[] {
                        id}, this.DevolverBilheteOperationCompleted, userState);
        }
        
        private void OnDevolverBilheteOperationCompleted(object arg) {
            if ((this.DevolverBilheteCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.DevolverBilheteCompleted(this, new DevolverBilheteCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2102.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://gerenciavoos.org/")]
    public partial class Voo {
        
        private System.Guid idField;
        
        private string aeronaveField;
        
        private int numeroField;
        
        private System.DateTime dataField;
        
        private System.DateTime horaField;
        
        private string destinoField;
        
        private int qtdAssentosField;
        
        private double precoField;
        
        /// <remarks/>
        public System.Guid Id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
            }
        }
        
        /// <remarks/>
        public string Aeronave {
            get {
                return this.aeronaveField;
            }
            set {
                this.aeronaveField = value;
            }
        }
        
        /// <remarks/>
        public int Numero {
            get {
                return this.numeroField;
            }
            set {
                this.numeroField = value;
            }
        }
        
        /// <remarks/>
        public System.DateTime Data {
            get {
                return this.dataField;
            }
            set {
                this.dataField = value;
            }
        }
        
        /// <remarks/>
        public System.DateTime Hora {
            get {
                return this.horaField;
            }
            set {
                this.horaField = value;
            }
        }
        
        /// <remarks/>
        public string Destino {
            get {
                return this.destinoField;
            }
            set {
                this.destinoField = value;
            }
        }
        
        /// <remarks/>
        public int QtdAssentos {
            get {
                return this.qtdAssentosField;
            }
            set {
                this.qtdAssentosField = value;
            }
        }
        
        /// <remarks/>
        public double Preco {
            get {
                return this.precoField;
            }
            set {
                this.precoField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2102.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://gerenciavoos.org/")]
    public partial class Passagem {
        
        private System.Guid idField;
        
        private Voo vooField;
        
        /// <remarks/>
        public System.Guid Id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
            }
        }
        
        /// <remarks/>
        public Voo Voo {
            get {
                return this.vooField;
            }
            set {
                this.vooField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2053.0")]
    public delegate void ConsultarVoosCompletedEventHandler(object sender, ConsultarVoosCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2053.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class ConsultarVoosCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal ConsultarVoosCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public Voo[] Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((Voo[])(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2053.0")]
    public delegate void CadastroVooCompletedEventHandler(object sender, CadastroVooCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2053.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class CadastroVooCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal CadastroVooCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public Voo Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((Voo)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2053.0")]
    public delegate void AtualizarVooCompletedEventHandler(object sender, AtualizarVooCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2053.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class AtualizarVooCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal AtualizarVooCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public Voo Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((Voo)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2053.0")]
    public delegate void ComprarBilheteCompletedEventHandler(object sender, ComprarBilheteCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2053.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class ComprarBilheteCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal ComprarBilheteCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public bool Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((bool)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2053.0")]
    public delegate void ConsultarBilhetesCompletedEventHandler(object sender, ConsultarBilhetesCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2053.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class ConsultarBilhetesCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal ConsultarBilhetesCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public Passagem[] Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((Passagem[])(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2053.0")]
    public delegate void DevolverBilheteCompletedEventHandler(object sender, DevolverBilheteCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2053.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class DevolverBilheteCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal DevolverBilheteCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public bool Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((bool)(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591