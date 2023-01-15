﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ServiceReference
{
    using System.Runtime.Serialization;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="TrackRslt", Namespace="")]
    public partial class TrackRslt : object
    {
        
        private string CountryCodeField;
        
        private string DestinationField;
        
        private string EventDateField;
        
        private string EventDescField;
        
        private System.DateTime EventTimeField;
        
        private string OfficeField;
        
        private string PODField;
        
        private string PiecesField;
        
        private string StatusCodeField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string CountryCode
        {
            get
            {
                return this.CountryCodeField;
            }
            set
            {
                this.CountryCodeField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Destination
        {
            get
            {
                return this.DestinationField;
            }
            set
            {
                this.DestinationField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string EventDate
        {
            get
            {
                return this.EventDateField;
            }
            set
            {
                this.EventDateField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string EventDesc
        {
            get
            {
                return this.EventDescField;
            }
            set
            {
                this.EventDescField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime EventTime
        {
            get
            {
                return this.EventTimeField;
            }
            set
            {
                this.EventTimeField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Office
        {
            get
            {
                return this.OfficeField;
            }
            set
            {
                this.OfficeField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string POD
        {
            get
            {
                return this.PODField;
            }
            set
            {
                this.PODField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Pieces
        {
            get
            {
                return this.PiecesField;
            }
            set
            {
                this.PiecesField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string StatusCode
        {
            get
            {
                return this.StatusCodeField;
            }
            set
            {
                this.StatusCodeField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="BulkResult", Namespace="")]
    public partial class BulkResult : object
    {
        
        private string AWBField;
        
        private string PODField;
        
        private string PiecesField;
        
        private ServiceReference.TrackRslt[] ResultsField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string AWB
        {
            get
            {
                return this.AWBField;
            }
            set
            {
                this.AWBField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string POD
        {
            get
            {
                return this.PODField;
            }
            set
            {
                this.PODField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Pieces
        {
            get
            {
                return this.PiecesField;
            }
            set
            {
                this.PiecesField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public ServiceReference.TrackRslt[] Results
        {
            get
            {
                return this.ResultsField;
            }
            set
            {
                this.ResultsField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference.iTrack")]
    public interface iTrack
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/iTrack/getSMSATrackingDetails", ReplyAction="http://tempuri.org/iTrack/getSMSATrackingDetailsResponse")]
        System.Threading.Tasks.Task<ServiceReference.TrackRslt[]> getSMSATrackingDetailsAsync(string lang, string awb, string username, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/iTrack/getSMSATracking", ReplyAction="http://tempuri.org/iTrack/getSMSATrackingResponse")]
        System.Threading.Tasks.Task<ServiceReference.TrackRslt[]> getSMSATrackingAsync(string lang, string awb, string username, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/iTrack/getBulkTracking", ReplyAction="http://tempuri.org/iTrack/getBulkTrackingResponse")]
        System.Threading.Tasks.Task<ServiceReference.BulkResult[]> getBulkTrackingAsync(string lang, string[] awbs, string username, string password);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    public interface iTrackChannel : ServiceReference.iTrack, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    public partial class iTrackClient : System.ServiceModel.ClientBase<ServiceReference.iTrack>, ServiceReference.iTrack
    {
        
        /// <summary>
        /// Implement this partial method to configure the service endpoint.
        /// </summary>
        /// <param name="serviceEndpoint">The endpoint to configure</param>
        /// <param name="clientCredentials">The client credentials</param>
        static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public iTrackClient() : 
                base(iTrackClient.GetDefaultBinding(), iTrackClient.GetDefaultEndpointAddress())
        {
            this.Endpoint.Name = EndpointConfiguration.BasicHttpBinding_iTrack.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public iTrackClient(EndpointConfiguration endpointConfiguration) : 
                base(iTrackClient.GetBindingForEndpoint(endpointConfiguration), iTrackClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public iTrackClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(iTrackClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public iTrackClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(iTrackClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public iTrackClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        public System.Threading.Tasks.Task<ServiceReference.TrackRslt[]> getSMSATrackingDetailsAsync(string lang, string awb, string username, string password)
        {
            return base.Channel.getSMSATrackingDetailsAsync(lang, awb, username, password);
        }
        
        public System.Threading.Tasks.Task<ServiceReference.TrackRslt[]> getSMSATrackingAsync(string lang, string awb, string username, string password)
        {
            return base.Channel.getSMSATrackingAsync(lang, awb, username, password);
        }
        
        public System.Threading.Tasks.Task<ServiceReference.BulkResult[]> getBulkTrackingAsync(string lang, string[] awbs, string username, string password)
        {
            return base.Channel.getBulkTrackingAsync(lang, awbs, username, password);
        }
        
        public virtual System.Threading.Tasks.Task OpenAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
        }
        
        private static System.ServiceModel.Channels.Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_iTrack))
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
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_iTrack))
            {
                return new System.ServiceModel.EndpointAddress("http://smsaweb.cloudapp.net:8080/track.svc");
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.Channels.Binding GetDefaultBinding()
        {
            return iTrackClient.GetBindingForEndpoint(EndpointConfiguration.BasicHttpBinding_iTrack);
        }
        
        private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress()
        {
            return iTrackClient.GetEndpointAddress(EndpointConfiguration.BasicHttpBinding_iTrack);
        }
        
        public enum EndpointConfiguration
        {
            
            BasicHttpBinding_iTrack,
        }
    }
}
