﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProxyAgencia
{
    using System.Runtime.Serialization;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="AgenciaDC", Namespace="http://schemas.datacontract.org/2004/07/WCF_Banco")]
    public partial class AgenciaDC : object
    {
        
        private string Cod_AgeField;
        
        private string Dir_AgeField;
        
        private string Id_UbigeoField;
        
        private string Nom_AgeField;
        
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
        public string Dir_Age
        {
            get
            {
                return this.Dir_AgeField;
            }
            set
            {
                this.Dir_AgeField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Id_Ubigeo
        {
            get
            {
                return this.Id_UbigeoField;
            }
            set
            {
                this.Id_UbigeoField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Nom_Age
        {
            get
            {
                return this.Nom_AgeField;
            }
            set
            {
                this.Nom_AgeField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ProxyAgencia.IServicioAgencia")]
    public interface IServicioAgencia
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioAgencia/ListarAgencia", ReplyAction="http://tempuri.org/IServicioAgencia/ListarAgenciaResponse")]
        System.Collections.Generic.List<ProxyAgencia.AgenciaDC> ListarAgencia();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioAgencia/ListarAgencia", ReplyAction="http://tempuri.org/IServicioAgencia/ListarAgenciaResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<ProxyAgencia.AgenciaDC>> ListarAgenciaAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    public interface IServicioAgenciaChannel : ProxyAgencia.IServicioAgencia, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    public partial class ServicioAgenciaClient : System.ServiceModel.ClientBase<ProxyAgencia.IServicioAgencia>, ProxyAgencia.IServicioAgencia
    {
        
        /// <summary>
        /// Implement this partial method to configure the service endpoint.
        /// </summary>
        /// <param name="serviceEndpoint">The endpoint to configure</param>
        /// <param name="clientCredentials">The client credentials</param>
        static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public ServicioAgenciaClient() : 
                base(ServicioAgenciaClient.GetDefaultBinding(), ServicioAgenciaClient.GetDefaultEndpointAddress())
        {
            this.Endpoint.Name = EndpointConfiguration.BasicHttpBinding_IServicioAgencia.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public ServicioAgenciaClient(EndpointConfiguration endpointConfiguration) : 
                base(ServicioAgenciaClient.GetBindingForEndpoint(endpointConfiguration), ServicioAgenciaClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public ServicioAgenciaClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(ServicioAgenciaClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public ServicioAgenciaClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(ServicioAgenciaClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public ServicioAgenciaClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        public System.Collections.Generic.List<ProxyAgencia.AgenciaDC> ListarAgencia()
        {
            return base.Channel.ListarAgencia();
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<ProxyAgencia.AgenciaDC>> ListarAgenciaAsync()
        {
            return base.Channel.ListarAgenciaAsync();
        }
        
        public virtual System.Threading.Tasks.Task OpenAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
        }
        
        private static System.ServiceModel.Channels.Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_IServicioAgencia))
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
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_IServicioAgencia))
            {
                return new System.ServiceModel.EndpointAddress("http://localhost:8733/Design_Time_Addresses/WCF_Banco/ServicioAgencia/");
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.Channels.Binding GetDefaultBinding()
        {
            return ServicioAgenciaClient.GetBindingForEndpoint(EndpointConfiguration.BasicHttpBinding_IServicioAgencia);
        }
        
        private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress()
        {
            return ServicioAgenciaClient.GetEndpointAddress(EndpointConfiguration.BasicHttpBinding_IServicioAgencia);
        }
        
        public enum EndpointConfiguration
        {
            
            BasicHttpBinding_IServicioAgencia,
        }
    }
}
