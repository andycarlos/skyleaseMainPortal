﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ServiceReference1
{
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.WsUtilSoap")]
    public interface WsUtilSoap
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/sendMail", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<bool> sendMailAsync(string user, string password, string to, string subject, string body, string[] bcc, string[] cc);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/forgotMyPassword", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task forgotMyPasswordAsync(string email);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/forgotExtPassword", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task forgotExtPasswordAsync(string email);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/getShippers", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<ServiceReference1.ArrayOfXElement> getShippersAsync(string filter, string baseO);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/getCommodity", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<ServiceReference1.ArrayOfXElement> getCommodityAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/getCancelReason", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<ServiceReference1.ArrayOfXElement> getCancelReasonAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/getAllAgents", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<ServiceReference1.ArrayOfXElement> getAllAgentsAsync(string filter, string baseO);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/getAllBases4Agent", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<ServiceReference1.ArrayOfXElement> getAllBases4AgentAsync(string agentId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/getEquivalents", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<ServiceReference1.ArrayOfXElement> getEquivalentsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/getDestination", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<ServiceReference1.ArrayOfXElement> getDestinationAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/getConsignee", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<ServiceReference1.ArrayOfXElement> getConsigneeAsync(string filter, string baseO);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/isUsed", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<bool> isUsedAsync(string airwaybill);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/isUsedExt", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<bool> isUsedExtAsync(string airwaybill);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/getAgent", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<ServiceReference1.ArrayOfXElement> getAgentAsync(string prefix, string awbNo, string dig, string user, string passwordMD5, char typeUser);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/getIAgent", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<ServiceReference1.ArrayOfXElement> getIAgentAsync(string prefix, string awbNo, string dig, string user, string passwordMD5, char typeUser);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/getAgentSimple", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<ServiceReference1.ArrayOfXElement> getAgentSimpleAsync(string awbNo, string clave);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/getAgentBase", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<ServiceReference1.ArrayOfXElement> getAgentBaseAsync(string prefix, string awbNo, string dig, string baseA, string user, string passwordMD5, char typeUser);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/getIAgentBase", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<ServiceReference1.ArrayOfXElement> getIAgentBaseAsync(string prefix, string awbNo, string dig, string baseA, string user, string passwordMD5, char typeUser);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/getExpEmail", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<string> getExpEmailAsync(string destination);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/getImpEmail", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<string> getImpEmailAsync(string destination);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/LocalToZulu", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<string[]> LocalToZuluAsync(string loctime, string locbase);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ZuluToLocal", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<string[]> ZuluToLocalAsync(string loctime, string locbase);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/getBookCodesFromAwb", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<string> getBookCodesFromAwbAsync(string awb);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/getTracking", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<ServiceReference1.ArrayOfXElement> getTrackingAsync(string pAwbno);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/getTrackWHR", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<ServiceReference1.ArrayOfXElement> getTrackWHRAsync(string pAwbno);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/getTrackBook", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<ServiceReference1.ArrayOfXElement> getTrackBookAsync(string pAwbno);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/getTrackAwb", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<ServiceReference1.ArrayOfXElement> getTrackAwbAsync(string pAwbno);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    public interface WsUtilSoapChannel : ServiceReference1.WsUtilSoap, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    public partial class WsUtilSoapClient : System.ServiceModel.ClientBase<ServiceReference1.WsUtilSoap>, ServiceReference1.WsUtilSoap
    {
        
        /// <summary>
        /// Implement this partial method to configure the service endpoint.
        /// </summary>
        /// <param name="serviceEndpoint">The endpoint to configure</param>
        /// <param name="clientCredentials">The client credentials</param>
        static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public WsUtilSoapClient(EndpointConfiguration endpointConfiguration) : 
                base(WsUtilSoapClient.GetBindingForEndpoint(endpointConfiguration), WsUtilSoapClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public WsUtilSoapClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(WsUtilSoapClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public WsUtilSoapClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(WsUtilSoapClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public WsUtilSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        public System.Threading.Tasks.Task<bool> sendMailAsync(string user, string password, string to, string subject, string body, string[] bcc, string[] cc)
        {
            return base.Channel.sendMailAsync(user, password, to, subject, body, bcc, cc);
        }
        
        public System.Threading.Tasks.Task forgotMyPasswordAsync(string email)
        {
            return base.Channel.forgotMyPasswordAsync(email);
        }
        
        public System.Threading.Tasks.Task forgotExtPasswordAsync(string email)
        {
            return base.Channel.forgotExtPasswordAsync(email);
        }
        
        public System.Threading.Tasks.Task<ServiceReference1.ArrayOfXElement> getShippersAsync(string filter, string baseO)
        {
            return base.Channel.getShippersAsync(filter, baseO);
        }
        
        public System.Threading.Tasks.Task<ServiceReference1.ArrayOfXElement> getCommodityAsync()
        {
            return base.Channel.getCommodityAsync();
        }
        
        public System.Threading.Tasks.Task<ServiceReference1.ArrayOfXElement> getCancelReasonAsync()
        {
            return base.Channel.getCancelReasonAsync();
        }
        
        public System.Threading.Tasks.Task<ServiceReference1.ArrayOfXElement> getAllAgentsAsync(string filter, string baseO)
        {
            return base.Channel.getAllAgentsAsync(filter, baseO);
        }
        
        public System.Threading.Tasks.Task<ServiceReference1.ArrayOfXElement> getAllBases4AgentAsync(string agentId)
        {
            return base.Channel.getAllBases4AgentAsync(agentId);
        }
        
        public System.Threading.Tasks.Task<ServiceReference1.ArrayOfXElement> getEquivalentsAsync()
        {
            return base.Channel.getEquivalentsAsync();
        }
        
        public System.Threading.Tasks.Task<ServiceReference1.ArrayOfXElement> getDestinationAsync()
        {
            return base.Channel.getDestinationAsync();
        }
        
        public System.Threading.Tasks.Task<ServiceReference1.ArrayOfXElement> getConsigneeAsync(string filter, string baseO)
        {
            return base.Channel.getConsigneeAsync(filter, baseO);
        }
        
        public System.Threading.Tasks.Task<bool> isUsedAsync(string airwaybill)
        {
            return base.Channel.isUsedAsync(airwaybill);
        }
        
        public System.Threading.Tasks.Task<bool> isUsedExtAsync(string airwaybill)
        {
            return base.Channel.isUsedExtAsync(airwaybill);
        }
        
        public System.Threading.Tasks.Task<ServiceReference1.ArrayOfXElement> getAgentAsync(string prefix, string awbNo, string dig, string user, string passwordMD5, char typeUser)
        {
            return base.Channel.getAgentAsync(prefix, awbNo, dig, user, passwordMD5, typeUser);
        }
        
        public System.Threading.Tasks.Task<ServiceReference1.ArrayOfXElement> getIAgentAsync(string prefix, string awbNo, string dig, string user, string passwordMD5, char typeUser)
        {
            return base.Channel.getIAgentAsync(prefix, awbNo, dig, user, passwordMD5, typeUser);
        }
        
        public System.Threading.Tasks.Task<ServiceReference1.ArrayOfXElement> getAgentSimpleAsync(string awbNo, string clave)
        {
            return base.Channel.getAgentSimpleAsync(awbNo, clave);
        }
        
        public System.Threading.Tasks.Task<ServiceReference1.ArrayOfXElement> getAgentBaseAsync(string prefix, string awbNo, string dig, string baseA, string user, string passwordMD5, char typeUser)
        {
            return base.Channel.getAgentBaseAsync(prefix, awbNo, dig, baseA, user, passwordMD5, typeUser);
        }
        
        public System.Threading.Tasks.Task<ServiceReference1.ArrayOfXElement> getIAgentBaseAsync(string prefix, string awbNo, string dig, string baseA, string user, string passwordMD5, char typeUser)
        {
            return base.Channel.getIAgentBaseAsync(prefix, awbNo, dig, baseA, user, passwordMD5, typeUser);
        }
        
        public System.Threading.Tasks.Task<string> getExpEmailAsync(string destination)
        {
            return base.Channel.getExpEmailAsync(destination);
        }
        
        public System.Threading.Tasks.Task<string> getImpEmailAsync(string destination)
        {
            return base.Channel.getImpEmailAsync(destination);
        }
        
        public System.Threading.Tasks.Task<string[]> LocalToZuluAsync(string loctime, string locbase)
        {
            return base.Channel.LocalToZuluAsync(loctime, locbase);
        }
        
        public System.Threading.Tasks.Task<string[]> ZuluToLocalAsync(string loctime, string locbase)
        {
            return base.Channel.ZuluToLocalAsync(loctime, locbase);
        }
        
        public System.Threading.Tasks.Task<string> getBookCodesFromAwbAsync(string awb)
        {
            return base.Channel.getBookCodesFromAwbAsync(awb);
        }
        
        public System.Threading.Tasks.Task<ServiceReference1.ArrayOfXElement> getTrackingAsync(string pAwbno)
        {
            return base.Channel.getTrackingAsync(pAwbno);
        }
        
        public System.Threading.Tasks.Task<ServiceReference1.ArrayOfXElement> getTrackWHRAsync(string pAwbno)
        {
            return base.Channel.getTrackWHRAsync(pAwbno);
        }
        
        public System.Threading.Tasks.Task<ServiceReference1.ArrayOfXElement> getTrackBookAsync(string pAwbno)
        {
            return base.Channel.getTrackBookAsync(pAwbno);
        }
        
        public System.Threading.Tasks.Task<ServiceReference1.ArrayOfXElement> getTrackAwbAsync(string pAwbno)
        {
            return base.Channel.getTrackAwbAsync(pAwbno);
        }
        
        public virtual System.Threading.Tasks.Task OpenAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
        }
        
        public virtual System.Threading.Tasks.Task CloseAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginClose(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndClose));
        }
        
        private static System.ServiceModel.Channels.Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.WsUtilSoap))
            {
                System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.AllowCookies = true;
                return result;
            }
            if ((endpointConfiguration == EndpointConfiguration.WsUtilSoap12))
            {
                System.ServiceModel.Channels.CustomBinding result = new System.ServiceModel.Channels.CustomBinding();
                System.ServiceModel.Channels.TextMessageEncodingBindingElement textBindingElement = new System.ServiceModel.Channels.TextMessageEncodingBindingElement();
                textBindingElement.MessageVersion = System.ServiceModel.Channels.MessageVersion.CreateVersion(System.ServiceModel.EnvelopeVersion.Soap12, System.ServiceModel.Channels.AddressingVersion.None);
                result.Elements.Add(textBindingElement);
                System.ServiceModel.Channels.HttpTransportBindingElement httpBindingElement = new System.ServiceModel.Channels.HttpTransportBindingElement();
                httpBindingElement.AllowCookies = true;
                httpBindingElement.MaxBufferSize = int.MaxValue;
                httpBindingElement.MaxReceivedMessageSize = int.MaxValue;
                result.Elements.Add(httpBindingElement);
                return result;
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.WsUtilSoap))
            {
                return new System.ServiceModel.EndpointAddress("http://skylease.cargolink.aero/xmltracking/wsutil.asmx");
            }
            if ((endpointConfiguration == EndpointConfiguration.WsUtilSoap12))
            {
                return new System.ServiceModel.EndpointAddress("http://skylease.cargolink.aero/xmltracking/wsutil.asmx");
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        public enum EndpointConfiguration
        {
            
            WsUtilSoap,
            
            WsUtilSoap12,
        }
    }
    
    [System.Xml.Serialization.XmlSchemaProviderAttribute(null, IsAny=true)]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil-lib", "2.0.0.1")]
    public partial class ArrayOfXElement : object, System.Xml.Serialization.IXmlSerializable
    {
        
        private System.Collections.Generic.List<System.Xml.Linq.XElement> nodesList = new System.Collections.Generic.List<System.Xml.Linq.XElement>();
        
        public ArrayOfXElement()
        {
        }
        
        public virtual System.Collections.Generic.List<System.Xml.Linq.XElement> Nodes
        {
            get
            {
                return this.nodesList;
            }
        }
        
        public virtual System.Xml.Schema.XmlSchema GetSchema()
        {
            throw new System.NotImplementedException();
        }
        
        public virtual void WriteXml(System.Xml.XmlWriter writer)
        {
            System.Collections.Generic.IEnumerator<System.Xml.Linq.XElement> e = nodesList.GetEnumerator();
            for (
            ; e.MoveNext(); 
            )
            {
                ((System.Xml.Serialization.IXmlSerializable)(e.Current)).WriteXml(writer);
            }
        }
        
        public virtual void ReadXml(System.Xml.XmlReader reader)
        {
            for (
            ; (reader.NodeType != System.Xml.XmlNodeType.EndElement); 
            )
            {
                if ((reader.NodeType == System.Xml.XmlNodeType.Element))
                {
                    System.Xml.Linq.XElement elem = new System.Xml.Linq.XElement("default");
                    ((System.Xml.Serialization.IXmlSerializable)(elem)).ReadXml(reader);
                    Nodes.Add(elem);
                }
                else
                {
                    reader.Skip();
                }
            }
        }
    }
}
