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

namespace SincronizacaoMusical.Domain.ServiceEmail {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.Xml.Serialization;
    using System.ComponentModel;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1590.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="BasicHttpBinding_ISincronizacaoMusicalService", Namespace="http://tempuri.org/")]
    public partial class SincronizacaoMusicalService : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback SendEmailWithTemplateOperationCompleted;
        
        private System.Threading.SendOrPostCallback SendEmailWithContentOperationCompleted;
        
        private System.Threading.SendOrPostCallback GetActiveUserDetailsOperationCompleted;
        
        private System.Threading.SendOrPostCallback GetInactiveUserDetailsOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public SincronizacaoMusicalService() {
            this.Url = "http://paladio03:99/SincronizacaoMusicalService.svc/SincronizacaoMusical";
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
        public event SendEmailWithTemplateCompletedEventHandler SendEmailWithTemplateCompleted;
        
        /// <remarks/>
        public event SendEmailWithContentCompletedEventHandler SendEmailWithContentCompleted;
        
        /// <remarks/>
        public event GetActiveUserDetailsCompletedEventHandler GetActiveUserDetailsCompleted;
        
        /// <remarks/>
        public event GetInactiveUserDetailsCompletedEventHandler GetInactiveUserDetailsCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/IEmailService/SendEmailWithTemplate", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void SendEmailWithTemplate([System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] Email email, [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] Template template) {
            this.Invoke("SendEmailWithTemplate", new object[] {
                        email,
                        template});
        }
        
        /// <remarks/>
        public void SendEmailWithTemplateAsync(Email email, Template template) {
            this.SendEmailWithTemplateAsync(email, template, null);
        }
        
        /// <remarks/>
        public void SendEmailWithTemplateAsync(Email email, Template template, object userState) {
            if ((this.SendEmailWithTemplateOperationCompleted == null)) {
                this.SendEmailWithTemplateOperationCompleted = new System.Threading.SendOrPostCallback(this.OnSendEmailWithTemplateOperationCompleted);
            }
            this.InvokeAsync("SendEmailWithTemplate", new object[] {
                        email,
                        template}, this.SendEmailWithTemplateOperationCompleted, userState);
        }
        
        private void OnSendEmailWithTemplateOperationCompleted(object arg) {
            if ((this.SendEmailWithTemplateCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.SendEmailWithTemplateCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/IEmailService/SendEmailWithContent", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void SendEmailWithContent([System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] Email email, [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] Conteudo conteudo) {
            this.Invoke("SendEmailWithContent", new object[] {
                        email,
                        conteudo});
        }
        
        /// <remarks/>
        public void SendEmailWithContentAsync(Email email, Conteudo conteudo) {
            this.SendEmailWithContentAsync(email, conteudo, null);
        }
        
        /// <remarks/>
        public void SendEmailWithContentAsync(Email email, Conteudo conteudo, object userState) {
            if ((this.SendEmailWithContentOperationCompleted == null)) {
                this.SendEmailWithContentOperationCompleted = new System.Threading.SendOrPostCallback(this.OnSendEmailWithContentOperationCompleted);
            }
            this.InvokeAsync("SendEmailWithContent", new object[] {
                        email,
                        conteudo}, this.SendEmailWithContentOperationCompleted, userState);
        }
        
        private void OnSendEmailWithContentOperationCompleted(object arg) {
            if ((this.SendEmailWithContentCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.SendEmailWithContentCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/IActiveDirectoryService/GetActiveUserDetails", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public Usuario GetActiveUserDetails([System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string nomeUsuario) {
            object[] results = this.Invoke("GetActiveUserDetails", new object[] {
                        nomeUsuario});
            return ((Usuario)(results[0]));
        }
        
        /// <remarks/>
        public void GetActiveUserDetailsAsync(string nomeUsuario) {
            this.GetActiveUserDetailsAsync(nomeUsuario, null);
        }
        
        /// <remarks/>
        public void GetActiveUserDetailsAsync(string nomeUsuario, object userState) {
            if ((this.GetActiveUserDetailsOperationCompleted == null)) {
                this.GetActiveUserDetailsOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetActiveUserDetailsOperationCompleted);
            }
            this.InvokeAsync("GetActiveUserDetails", new object[] {
                        nomeUsuario}, this.GetActiveUserDetailsOperationCompleted, userState);
        }
        
        private void OnGetActiveUserDetailsOperationCompleted(object arg) {
            if ((this.GetActiveUserDetailsCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetActiveUserDetailsCompleted(this, new GetActiveUserDetailsCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/IActiveDirectoryService/GetInactiveUserDetails", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public Usuario GetInactiveUserDetails([System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string nomeUsuario) {
            object[] results = this.Invoke("GetInactiveUserDetails", new object[] {
                        nomeUsuario});
            return ((Usuario)(results[0]));
        }
        
        /// <remarks/>
        public void GetInactiveUserDetailsAsync(string nomeUsuario) {
            this.GetInactiveUserDetailsAsync(nomeUsuario, null);
        }
        
        /// <remarks/>
        public void GetInactiveUserDetailsAsync(string nomeUsuario, object userState) {
            if ((this.GetInactiveUserDetailsOperationCompleted == null)) {
                this.GetInactiveUserDetailsOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetInactiveUserDetailsOperationCompleted);
            }
            this.InvokeAsync("GetInactiveUserDetails", new object[] {
                        nomeUsuario}, this.GetInactiveUserDetailsOperationCompleted, userState);
        }
        
        private void OnGetInactiveUserDetailsOperationCompleted(object arg) {
            if ((this.GetInactiveUserDetailsCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetInactiveUserDetailsCompleted(this, new GetInactiveUserDetailsCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1590.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.datacontract.org/2004/07/Record.RAP.Domain.Entities")]
    public partial class Email {
        
        private AttachmentBase[] anexosField;
        
        private string assuntoField;
        
        private string[] bccField;
        
        private string[] ccField;
        
        private string deField;
        
        private string[] paraField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(IsNullable=true)]
        [System.Xml.Serialization.XmlArrayItemAttribute(Namespace="http://schemas.datacontract.org/2004/07/System.Net.Mail")]
        public AttachmentBase[] Anexos {
            get {
                return this.anexosField;
            }
            set {
                this.anexosField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string Assunto {
            get {
                return this.assuntoField;
            }
            set {
                this.assuntoField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(IsNullable=true)]
        [System.Xml.Serialization.XmlArrayItemAttribute(Namespace="http://schemas.microsoft.com/2003/10/Serialization/Arrays")]
        public string[] Bcc {
            get {
                return this.bccField;
            }
            set {
                this.bccField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(IsNullable=true)]
        [System.Xml.Serialization.XmlArrayItemAttribute(Namespace="http://schemas.microsoft.com/2003/10/Serialization/Arrays")]
        public string[] Cc {
            get {
                return this.ccField;
            }
            set {
                this.ccField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string De {
            get {
                return this.deField;
            }
            set {
                this.deField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(IsNullable=true)]
        [System.Xml.Serialization.XmlArrayItemAttribute(Namespace="http://schemas.microsoft.com/2003/10/Serialization/Arrays")]
        public string[] Para {
            get {
                return this.paraField;
            }
            set {
                this.paraField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1590.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.datacontract.org/2004/07/System.Net.Mail")]
    public partial class AttachmentBase {
        
        private string contentIdField;
        
        private ContentType contentTypeField;
        
        private TransferEncoding transferEncodingField;
        
        private bool transferEncodingFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string ContentId {
            get {
                return this.contentIdField;
            }
            set {
                this.contentIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public ContentType ContentType {
            get {
                return this.contentTypeField;
            }
            set {
                this.contentTypeField = value;
            }
        }
        
        /// <remarks/>
        public TransferEncoding TransferEncoding {
            get {
                return this.transferEncodingField;
            }
            set {
                this.transferEncodingField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TransferEncodingSpecified {
            get {
                return this.transferEncodingFieldSpecified;
            }
            set {
                this.transferEncodingFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1590.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.datacontract.org/2004/07/System.Net.Mime")]
    public partial class ContentType {
        
        private string boundaryField;
        
        private string charSetField;
        
        private string mediaTypeField;
        
        private string nameField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string Boundary {
            get {
                return this.boundaryField;
            }
            set {
                this.boundaryField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string CharSet {
            get {
                return this.charSetField;
            }
            set {
                this.charSetField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string MediaType {
            get {
                return this.mediaTypeField;
            }
            set {
                this.mediaTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string Name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1590.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.datacontract.org/2004/07/Record.RAP.Domain.Entities")]
    public partial class Usuario {
        
        private string departamentoField;
        
        private string enderecoEmailField;
        
        private string funcaoField;
        
        private string[] gruposField;
        
        private string nomeField;
        
        private string nomeUsuarioField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string Departamento {
            get {
                return this.departamentoField;
            }
            set {
                this.departamentoField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string EnderecoEmail {
            get {
                return this.enderecoEmailField;
            }
            set {
                this.enderecoEmailField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string Funcao {
            get {
                return this.funcaoField;
            }
            set {
                this.funcaoField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(IsNullable=true)]
        [System.Xml.Serialization.XmlArrayItemAttribute(Namespace="http://schemas.microsoft.com/2003/10/Serialization/Arrays")]
        public string[] Grupos {
            get {
                return this.gruposField;
            }
            set {
                this.gruposField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string Nome {
            get {
                return this.nomeField;
            }
            set {
                this.nomeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string NomeUsuario {
            get {
                return this.nomeUsuarioField;
            }
            set {
                this.nomeUsuarioField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1590.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.datacontract.org/2004/07/Record.RAP.Domain.Entities")]
    public partial class Conteudo {
        
        private string textoField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string Texto {
            get {
                return this.textoField;
            }
            set {
                this.textoField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1590.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.datacontract.org/2004/07/Record.RAP.Domain.Entities")]
    public partial class Template {
        
        private string nomeField;
        
        private string[] parametrosField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string Nome {
            get {
                return this.nomeField;
            }
            set {
                this.nomeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(IsNullable=true)]
        [System.Xml.Serialization.XmlArrayItemAttribute(Namespace="http://schemas.microsoft.com/2003/10/Serialization/Arrays")]
        public string[] Parametros {
            get {
                return this.parametrosField;
            }
            set {
                this.parametrosField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1590.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.datacontract.org/2004/07/System.Net.Mime")]
    public enum TransferEncoding {
        
        /// <remarks/>
        QuotedPrintable,
        
        /// <remarks/>
        Base64,
        
        /// <remarks/>
        SevenBit,
        
        /// <remarks/>
        Unknown,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1590.0")]
    public delegate void SendEmailWithTemplateCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1590.0")]
    public delegate void SendEmailWithContentCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1590.0")]
    public delegate void GetActiveUserDetailsCompletedEventHandler(object sender, GetActiveUserDetailsCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1590.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetActiveUserDetailsCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetActiveUserDetailsCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public Usuario Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((Usuario)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1590.0")]
    public delegate void GetInactiveUserDetailsCompletedEventHandler(object sender, GetInactiveUserDetailsCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1590.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetInactiveUserDetailsCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetInactiveUserDetailsCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public Usuario Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((Usuario)(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591