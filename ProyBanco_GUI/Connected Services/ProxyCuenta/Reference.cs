﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProxyCuenta
{
    using System.Runtime.Serialization;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CuentaDC", Namespace="http://schemas.datacontract.org/2004/07/WCF_Banco")]
    public partial class CuentaDC : object
    {
        
        private string Ape_Mat_CliField;
        
        private string Ape_Pat_CliField;
        
        private string Cod_AgeField;
        
        private string Cod_CliField;
        
        private short Est_CuenField;
        
        private string Estado_CuentaField;
        
        private System.DateTime Fec_AperField;
        
        private System.DateTime Fec_RegistroField;
        
        private System.DateTime Fec_Ult_ModField;
        
        private string Nom_CliField;
        
        private string Num_CuenField;
        
        private float Sal_CuenField;
        
        private short Tip_MonField;
        
        private short TipoField;
        
        private string Tipo_CuentaField;
        
        private string Tipo_MonedaField;
        
        private string Usu_RegistroField;
        
        private string Usu_Ult_ModField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Ape_Mat_Cli
        {
            get
            {
                return this.Ape_Mat_CliField;
            }
            set
            {
                this.Ape_Mat_CliField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Ape_Pat_Cli
        {
            get
            {
                return this.Ape_Pat_CliField;
            }
            set
            {
                this.Ape_Pat_CliField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Cod_Age
        {
            get
            {
                return this.Cod_AgeField;
            }
            set
            {
                this.Cod_AgeField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Cod_Cli
        {
            get
            {
                return this.Cod_CliField;
            }
            set
            {
                this.Cod_CliField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public short Est_Cuen
        {
            get
            {
                return this.Est_CuenField;
            }
            set
            {
                this.Est_CuenField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Estado_Cuenta
        {
            get
            {
                return this.Estado_CuentaField;
            }
            set
            {
                this.Estado_CuentaField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime Fec_Aper
        {
            get
            {
                return this.Fec_AperField;
            }
            set
            {
                this.Fec_AperField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime Fec_Registro
        {
            get
            {
                return this.Fec_RegistroField;
            }
            set
            {
                this.Fec_RegistroField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime Fec_Ult_Mod
        {
            get
            {
                return this.Fec_Ult_ModField;
            }
            set
            {
                this.Fec_Ult_ModField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Nom_Cli
        {
            get
            {
                return this.Nom_CliField;
            }
            set
            {
                this.Nom_CliField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Num_Cuen
        {
            get
            {
                return this.Num_CuenField;
            }
            set
            {
                this.Num_CuenField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public float Sal_Cuen
        {
            get
            {
                return this.Sal_CuenField;
            }
            set
            {
                this.Sal_CuenField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public short Tip_Mon
        {
            get
            {
                return this.Tip_MonField;
            }
            set
            {
                this.Tip_MonField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public short Tipo
        {
            get
            {
                return this.TipoField;
            }
            set
            {
                this.TipoField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Tipo_Cuenta
        {
            get
            {
                return this.Tipo_CuentaField;
            }
            set
            {
                this.Tipo_CuentaField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Tipo_Moneda
        {
            get
            {
                return this.Tipo_MonedaField;
            }
            set
            {
                this.Tipo_MonedaField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Usu_Registro
        {
            get
            {
                return this.Usu_RegistroField;
            }
            set
            {
                this.Usu_RegistroField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Usu_Ult_Mod
        {
            get
            {
                return this.Usu_Ult_ModField;
            }
            set
            {
                this.Usu_Ult_ModField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ProxyCuenta.IServicioCuenta")]
    public interface IServicioCuenta
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioCuenta/ListarCuenta", ReplyAction="http://tempuri.org/IServicioCuenta/ListarCuentaResponse")]
        System.Collections.Generic.List<ProxyCuenta.CuentaDC> ListarCuenta();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioCuenta/ListarCuenta", ReplyAction="http://tempuri.org/IServicioCuenta/ListarCuentaResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<ProxyCuenta.CuentaDC>> ListarCuentaAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioCuenta/ConsultarCuenta", ReplyAction="http://tempuri.org/IServicioCuenta/ConsultarCuentaResponse")]
        ProxyCuenta.CuentaDC ConsultarCuenta(string strCodigo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioCuenta/ConsultarCuenta", ReplyAction="http://tempuri.org/IServicioCuenta/ConsultarCuentaResponse")]
        System.Threading.Tasks.Task<ProxyCuenta.CuentaDC> ConsultarCuentaAsync(string strCodigo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioCuenta/InsertarCuenta", ReplyAction="http://tempuri.org/IServicioCuenta/InsertarCuentaResponse")]
        bool InsertarCuenta(ProxyCuenta.CuentaDC objCuenta);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioCuenta/InsertarCuenta", ReplyAction="http://tempuri.org/IServicioCuenta/InsertarCuentaResponse")]
        System.Threading.Tasks.Task<bool> InsertarCuentaAsync(ProxyCuenta.CuentaDC objCuenta);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioCuenta/ActualizarCuenta", ReplyAction="http://tempuri.org/IServicioCuenta/ActualizarCuentaResponse")]
        bool ActualizarCuenta(ProxyCuenta.CuentaDC objCuentaDC);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioCuenta/ActualizarCuenta", ReplyAction="http://tempuri.org/IServicioCuenta/ActualizarCuentaResponse")]
        System.Threading.Tasks.Task<bool> ActualizarCuentaAsync(ProxyCuenta.CuentaDC objCuentaDC);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioCuenta/EliminarCuenta", ReplyAction="http://tempuri.org/IServicioCuenta/EliminarCuentaResponse")]
        bool EliminarCuenta(string strCodigo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioCuenta/EliminarCuenta", ReplyAction="http://tempuri.org/IServicioCuenta/EliminarCuentaResponse")]
        System.Threading.Tasks.Task<bool> EliminarCuentaAsync(string strCodigo);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    public interface IServicioCuentaChannel : ProxyCuenta.IServicioCuenta, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    public partial class ServicioCuentaClient : System.ServiceModel.ClientBase<ProxyCuenta.IServicioCuenta>, ProxyCuenta.IServicioCuenta
    {
        
        /// <summary>
        /// Implement this partial method to configure the service endpoint.
        /// </summary>
        /// <param name="serviceEndpoint">The endpoint to configure</param>
        /// <param name="clientCredentials">The client credentials</param>
        static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public ServicioCuentaClient() : 
                base(ServicioCuentaClient.GetDefaultBinding(), ServicioCuentaClient.GetDefaultEndpointAddress())
        {
            this.Endpoint.Name = EndpointConfiguration.BasicHttpBinding_IServicioCuenta.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public ServicioCuentaClient(EndpointConfiguration endpointConfiguration) : 
                base(ServicioCuentaClient.GetBindingForEndpoint(endpointConfiguration), ServicioCuentaClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public ServicioCuentaClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(ServicioCuentaClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public ServicioCuentaClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(ServicioCuentaClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public ServicioCuentaClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        public System.Collections.Generic.List<ProxyCuenta.CuentaDC> ListarCuenta()
        {
            return base.Channel.ListarCuenta();
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<ProxyCuenta.CuentaDC>> ListarCuentaAsync()
        {
            return base.Channel.ListarCuentaAsync();
        }
        
        public ProxyCuenta.CuentaDC ConsultarCuenta(string strCodigo)
        {
            return base.Channel.ConsultarCuenta(strCodigo);
        }
        
        public System.Threading.Tasks.Task<ProxyCuenta.CuentaDC> ConsultarCuentaAsync(string strCodigo)
        {
            return base.Channel.ConsultarCuentaAsync(strCodigo);
        }
        
        public bool InsertarCuenta(ProxyCuenta.CuentaDC objCuenta)
        {
            return base.Channel.InsertarCuenta(objCuenta);
        }
        
        public System.Threading.Tasks.Task<bool> InsertarCuentaAsync(ProxyCuenta.CuentaDC objCuenta)
        {
            return base.Channel.InsertarCuentaAsync(objCuenta);
        }
        
        public bool ActualizarCuenta(ProxyCuenta.CuentaDC objCuentaDC)
        {
            return base.Channel.ActualizarCuenta(objCuentaDC);
        }
        
        public System.Threading.Tasks.Task<bool> ActualizarCuentaAsync(ProxyCuenta.CuentaDC objCuentaDC)
        {
            return base.Channel.ActualizarCuentaAsync(objCuentaDC);
        }
        
        public bool EliminarCuenta(string strCodigo)
        {
            return base.Channel.EliminarCuenta(strCodigo);
        }
        
        public System.Threading.Tasks.Task<bool> EliminarCuentaAsync(string strCodigo)
        {
            return base.Channel.EliminarCuentaAsync(strCodigo);
        }
        
        public virtual System.Threading.Tasks.Task OpenAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
        }
        
        private static System.ServiceModel.Channels.Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_IServicioCuenta))
            {
                System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.AllowCookies = true;
                return result;
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_IServicioCuenta))
            {
                return new System.ServiceModel.EndpointAddress("http://localhost:8733/Design_Time_Addresses/WCF_Banco/ServicioCuenta/");
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.Channels.Binding GetDefaultBinding()
        {
            return ServicioCuentaClient.GetBindingForEndpoint(EndpointConfiguration.BasicHttpBinding_IServicioCuenta);
        }
        
        private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress()
        {
            return ServicioCuentaClient.GetEndpointAddress(EndpointConfiguration.BasicHttpBinding_IServicioCuenta);
        }
        
        public enum EndpointConfiguration
        {
            
            BasicHttpBinding_IServicioCuenta,
        }
    }
}
