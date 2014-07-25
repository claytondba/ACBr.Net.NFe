﻿//------------------------------------------------------------------------------
// <auto-generated>
//     O código foi gerado por uma ferramenta.
//     Versão de Tempo de Execução:2.0.50727.5466
//
//     As alterações ao arquivo poderão causar comportamento incorreto e serão perdidas se
//     o código for gerado novamente.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.Xml.Serialization;

// 
// This source code was auto-generated by wsdl, Version=2.0.50727.3038.
// 

namespace NFe.NET.Webservice.Recepcao2
{

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name = "NfeRecepcao2Soap12", Namespace = "http://www.portalfiscal.inf.br/nfe/wsdl/NfeRecepcao2")]
    public partial class NfeRecepcao2 : System.Web.Services.Protocols.SoapHttpClientProtocol
    {

        private nfeCabecMsg nfeCabecMsgValueField;

        private System.Threading.SendOrPostCallback nfeRecepcaoLote2OperationCompleted;

        /// <remarks/>
        public NfeRecepcao2(string pUrl)
        {
            this.SoapVersion = System.Web.Services.Protocols.SoapProtocolVersion.Soap12;
            this.Url = pUrl;
        }

        public nfeCabecMsg nfeCabecMsgValue
        {
            get
            {
                return this.nfeCabecMsgValueField;
            }
            set
            {
                this.nfeCabecMsgValueField = value;
            }
        }

        /// <remarks/>
        public event nfeRecepcaoLote2CompletedEventHandler nfeRecepcaoLote2Completed;

        /// <remarks/>
        [System.Web.Services.Protocols.SoapHeaderAttribute("nfeCabecMsgValue", Direction = System.Web.Services.Protocols.SoapHeaderDirection.InOut)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.portalfiscal.inf.br/nfe/wsdl/NfeRecepcao2/nfeRecepcaoLote2", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Bare)]
        [return: System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.portalfiscal.inf.br/nfe/wsdl/NfeRecepcao2")]
        public System.Xml.XmlNode nfeRecepcaoLote2([System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.portalfiscal.inf.br/nfe/wsdl/NfeRecepcao2")] System.Xml.XmlNode nfeDadosMsg)
        {
            object[] results = this.Invoke("nfeRecepcaoLote2", new object[] {
                    nfeDadosMsg});
            return ((System.Xml.XmlNode)(results[0]));
        }

        /// <remarks/>
        public System.IAsyncResult BeginnfeRecepcaoLote2(System.Xml.XmlNode nfeDadosMsg, System.AsyncCallback callback, object asyncState)
        {
            return this.BeginInvoke("nfeRecepcaoLote2", new object[] {
                    nfeDadosMsg}, callback, asyncState);
        }

        /// <remarks/>
        public System.Xml.XmlNode EndnfeRecepcaoLote2(System.IAsyncResult asyncResult)
        {
            object[] results = this.EndInvoke(asyncResult);
            return ((System.Xml.XmlNode)(results[0]));
        }

        /// <remarks/>
        public void nfeRecepcaoLote2Async(System.Xml.XmlNode nfeDadosMsg)
        {
            this.nfeRecepcaoLote2Async(nfeDadosMsg, null);
        }

        /// <remarks/>
        public void nfeRecepcaoLote2Async(System.Xml.XmlNode nfeDadosMsg, object userState)
        {
            if ((this.nfeRecepcaoLote2OperationCompleted == null))
            {
                this.nfeRecepcaoLote2OperationCompleted = new System.Threading.SendOrPostCallback(this.OnnfeRecepcaoLote2OperationCompleted);
            }
            this.InvokeAsync("nfeRecepcaoLote2", new object[] {
                    nfeDadosMsg}, this.nfeRecepcaoLote2OperationCompleted, userState);
        }

        private void OnnfeRecepcaoLote2OperationCompleted(object arg)
        {
            if ((this.nfeRecepcaoLote2Completed != null))
            {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.nfeRecepcaoLote2Completed(this, new nfeRecepcaoLote2CompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <remarks/>
        public new void CancelAsync(object userState)
        {
            base.CancelAsync(userState);
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/nfe/wsdl/NfeRecepcao2")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.portalfiscal.inf.br/nfe/wsdl/NfeRecepcao2", IsNullable = false)]
    public partial class nfeCabecMsg : System.Web.Services.Protocols.SoapHeader
    {

        private string cUFField;

        private string versaoDadosField;

        private System.Xml.XmlAttribute[] anyAttrField;

        /// <remarks/>
        public string cUF
        {
            get
            {
                return this.cUFField;
            }
            set
            {
                this.cUFField = value;
            }
        }

        /// <remarks/>
        public string versaoDados
        {
            get
            {
                return this.versaoDadosField;
            }
            set
            {
                this.versaoDadosField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAnyAttributeAttribute()]
        public System.Xml.XmlAttribute[] AnyAttr
        {
            get
            {
                return this.anyAttrField;
            }
            set
            {
                this.anyAttrField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
    public delegate void nfeRecepcaoLote2CompletedEventHandler(object sender, nfeRecepcaoLote2CompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class nfeRecepcaoLote2CompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {

        private object[] results;

        internal nfeRecepcaoLote2CompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
            base(exception, cancelled, userState)
        {
            this.results = results;
        }

        /// <remarks/>
        public System.Xml.XmlNode Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return ((System.Xml.XmlNode)(this.results[0]));
            }
        }
    }
}