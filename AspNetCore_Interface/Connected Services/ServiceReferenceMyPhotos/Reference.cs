﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ServiceReferenceMyPhotos
{
    using System.Runtime.Serialization;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.Runtime.Serialization.DataContractAttribute(Name="FileDto", Namespace="http://schemas.datacontract.org/2004/07/MyPhotosApi.Api.DTOs", IsReference=true)]
    public partial class FileDto : object
    {
        
        private System.DateTime DateField;
        
        private int IdField;
        
        private string NameField;
        
        private string PathField;
        
        private System.Collections.Generic.List<ServiceReferenceMyPhotos.PropertyDto> PropertiesField;
        
        private bool TypeField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime Date
        {
            get
            {
                return this.DateField;
            }
            set
            {
                this.DateField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id
        {
            get
            {
                return this.IdField;
            }
            set
            {
                this.IdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name
        {
            get
            {
                return this.NameField;
            }
            set
            {
                this.NameField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Path
        {
            get
            {
                return this.PathField;
            }
            set
            {
                this.PathField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Collections.Generic.List<ServiceReferenceMyPhotos.PropertyDto> Properties
        {
            get
            {
                return this.PropertiesField;
            }
            set
            {
                this.PropertiesField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool Type
        {
            get
            {
                return this.TypeField;
            }
            set
            {
                this.TypeField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.Runtime.Serialization.DataContractAttribute(Name="PropertyDto", Namespace="http://schemas.datacontract.org/2004/07/MyPhotosApi.Api.DTOs.ResponseDtos", IsReference=true)]
    public partial class PropertyDto : object
    {
        
        private int IdField;
        
        private string TypeField;
        
        private string ValueField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id
        {
            get
            {
                return this.IdField;
            }
            set
            {
                this.IdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Type
        {
            get
            {
                return this.TypeField;
            }
            set
            {
                this.TypeField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Value
        {
            get
            {
                return this.ValueField;
            }
            set
            {
                this.ValueField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CreateFileDto", Namespace="http://schemas.datacontract.org/2004/07/MyPhotosApi.Api", IsReference=true)]
    public partial class CreateFileDto : object
    {
        
        private string PathField;
        
        private System.Collections.Generic.Dictionary<int, System.Collections.Generic.List<string>> PropertiesField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Path
        {
            get
            {
                return this.PathField;
            }
            set
            {
                this.PathField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Collections.Generic.Dictionary<int, System.Collections.Generic.List<string>> Properties
        {
            get
            {
                return this.PropertiesField;
            }
            set
            {
                this.PropertiesField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Response", Namespace="http://schemas.datacontract.org/2004/07/MyPhotosApi.Api.Constants", IsReference=true)]
    public partial class Response : object
    {
        
        private string MessageField;
        
        private bool SucceededField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Message
        {
            get
            {
                return this.MessageField;
            }
            set
            {
                this.MessageField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool Succeeded
        {
            get
            {
                return this.SucceededField;
            }
            set
            {
                this.SucceededField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ModifyFileDto", Namespace="http://schemas.datacontract.org/2004/07/MyPhotosApi.Api.DTOs.RequestDtos", IsReference=true)]
    public partial class ModifyFileDto : object
    {
        
        private System.Collections.Generic.Dictionary<int, string> AddedPropertiesInfoField;
        
        private System.Collections.Generic.Dictionary<int, string> DeletedPropertiesInfoField;
        
        private int FileIdField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Collections.Generic.Dictionary<int, string> AddedPropertiesInfo
        {
            get
            {
                return this.AddedPropertiesInfoField;
            }
            set
            {
                this.AddedPropertiesInfoField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Collections.Generic.Dictionary<int, string> DeletedPropertiesInfo
        {
            get
            {
                return this.DeletedPropertiesInfoField;
            }
            set
            {
                this.DeletedPropertiesInfoField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int FileId
        {
            get
            {
                return this.FileIdField;
            }
            set
            {
                this.FileIdField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.Runtime.Serialization.DataContractAttribute(Name="FilterFilesDto", Namespace="http://schemas.datacontract.org/2004/07/MyPhotosApi.Api.DTOs", IsReference=true)]
    public partial class FilterFilesDto : object
    {
        
        private int PropertyTypeIdField;
        
        private string PropertyValueField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int PropertyTypeId
        {
            get
            {
                return this.PropertyTypeIdField;
            }
            set
            {
                this.PropertyTypeIdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string PropertyValue
        {
            get
            {
                return this.PropertyValueField;
            }
            set
            {
                this.PropertyValueField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.Runtime.Serialization.DataContractAttribute(Name="PropertyTypeDto", Namespace="http://schemas.datacontract.org/2004/07/MyPhotosApi.Api.DTOs", IsReference=true)]
    public partial class PropertyTypeDto : object
    {
        
        private int IdField;
        
        private string NameField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id
        {
            get
            {
                return this.IdField;
            }
            set
            {
                this.IdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name
        {
            get
            {
                return this.NameField;
            }
            set
            {
                this.NameField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.Runtime.Serialization.DataContractAttribute(Name="PropertyTypeValuesDto", Namespace="http://schemas.datacontract.org/2004/07/MyPhotosApi.Api.DTOs", IsReference=true)]
    public partial class PropertyTypeValuesDto : object
    {
        
        private int IdField;
        
        private string NameField;
        
        private System.Collections.Generic.List<string> ValuesField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id
        {
            get
            {
                return this.IdField;
            }
            set
            {
                this.IdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name
        {
            get
            {
                return this.NameField;
            }
            set
            {
                this.NameField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Collections.Generic.List<string> Values
        {
            get
            {
                return this.ValuesField;
            }
            set
            {
                this.ValuesField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReferenceMyPhotos.IMyPhotosService")]
    public interface IMyPhotosService
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMediaFileService/GetAll", ReplyAction="http://tempuri.org/IMediaFileService/GetAllResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<ServiceReferenceMyPhotos.FileDto>> GetAllAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMediaFileService/LoadFile", ReplyAction="http://tempuri.org/IMediaFileService/LoadFileResponse")]
        System.Threading.Tasks.Task<ServiceReferenceMyPhotos.Response> LoadFileAsync(ServiceReferenceMyPhotos.CreateFileDto createFileDto);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMediaFileService/ModifyMediaFile", ReplyAction="http://tempuri.org/IMediaFileService/ModifyMediaFileResponse")]
        System.Threading.Tasks.Task<ServiceReferenceMyPhotos.Response> ModifyMediaFileAsync(ServiceReferenceMyPhotos.ModifyFileDto dto);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMediaFileService/GetDirectoryPhotosVideos", ReplyAction="http://tempuri.org/IMediaFileService/GetDirectoryPhotosVideosResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<string>> GetDirectoryPhotosVideosAsync(string directoryPath);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMediaFileService/GetFilteredMediaFiles", ReplyAction="http://tempuri.org/IMediaFileService/GetFilteredMediaFilesResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<ServiceReferenceMyPhotos.FileDto>> GetFilteredMediaFilesAsync(ServiceReferenceMyPhotos.FilterFilesDto dto);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMediaFileService/Delete", ReplyAction="http://tempuri.org/IMediaFileService/DeleteResponse")]
        System.Threading.Tasks.Task DeleteAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPropertyTypeService/GetAllPropertiesTypes", ReplyAction="http://tempuri.org/IPropertyTypeService/GetAllPropertiesTypesResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<ServiceReferenceMyPhotos.PropertyTypeDto>> GetAllPropertiesTypesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPropertyTypeService/GetAllPropertyTypesWithValues", ReplyAction="http://tempuri.org/IPropertyTypeService/GetAllPropertyTypesWithValuesResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<ServiceReferenceMyPhotos.PropertyTypeValuesDto>> GetAllPropertyTypesWithValuesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPropertyTypeService/AddPropertyType", ReplyAction="http://tempuri.org/IPropertyTypeService/AddPropertyTypeResponse")]
        System.Threading.Tasks.Task<ServiceReferenceMyPhotos.Response> AddPropertyTypeAsync(string name);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    public interface IMyPhotosServiceChannel : ServiceReferenceMyPhotos.IMyPhotosService, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    public partial class MyPhotosServiceClient : System.ServiceModel.ClientBase<ServiceReferenceMyPhotos.IMyPhotosService>, ServiceReferenceMyPhotos.IMyPhotosService
    {
        
        /// <summary>
        /// Implement this partial method to configure the service endpoint.
        /// </summary>
        /// <param name="serviceEndpoint">The endpoint to configure</param>
        /// <param name="clientCredentials">The client credentials</param>
        static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public MyPhotosServiceClient() : 
                base(MyPhotosServiceClient.GetDefaultBinding(), MyPhotosServiceClient.GetDefaultEndpointAddress())
        {
            this.Endpoint.Name = EndpointConfiguration.BasicHttpBinding_IMediaFileService.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public MyPhotosServiceClient(EndpointConfiguration endpointConfiguration) : 
                base(MyPhotosServiceClient.GetBindingForEndpoint(endpointConfiguration), MyPhotosServiceClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public MyPhotosServiceClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(MyPhotosServiceClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public MyPhotosServiceClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(MyPhotosServiceClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public MyPhotosServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<ServiceReferenceMyPhotos.FileDto>> GetAllAsync()
        {
            return base.Channel.GetAllAsync();
        }
        
        public System.Threading.Tasks.Task<ServiceReferenceMyPhotos.Response> LoadFileAsync(ServiceReferenceMyPhotos.CreateFileDto createFileDto)
        {
            return base.Channel.LoadFileAsync(createFileDto);
        }
        
        public System.Threading.Tasks.Task<ServiceReferenceMyPhotos.Response> ModifyMediaFileAsync(ServiceReferenceMyPhotos.ModifyFileDto dto)
        {
            return base.Channel.ModifyMediaFileAsync(dto);
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<string>> GetDirectoryPhotosVideosAsync(string directoryPath)
        {
            return base.Channel.GetDirectoryPhotosVideosAsync(directoryPath);
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<ServiceReferenceMyPhotos.FileDto>> GetFilteredMediaFilesAsync(ServiceReferenceMyPhotos.FilterFilesDto dto)
        {
            return base.Channel.GetFilteredMediaFilesAsync(dto);
        }
        
        public System.Threading.Tasks.Task DeleteAsync(int id)
        {
            return base.Channel.DeleteAsync(id);
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<ServiceReferenceMyPhotos.PropertyTypeDto>> GetAllPropertiesTypesAsync()
        {
            return base.Channel.GetAllPropertiesTypesAsync();
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<ServiceReferenceMyPhotos.PropertyTypeValuesDto>> GetAllPropertyTypesWithValuesAsync()
        {
            return base.Channel.GetAllPropertyTypesWithValuesAsync();
        }
        
        public System.Threading.Tasks.Task<ServiceReferenceMyPhotos.Response> AddPropertyTypeAsync(string name)
        {
            return base.Channel.AddPropertyTypeAsync(name);
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
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_IMediaFileService))
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
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_IMediaFileService))
            {
                return new System.ServiceModel.EndpointAddress("http://localhost:8000/PC");
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.Channels.Binding GetDefaultBinding()
        {
            return MyPhotosServiceClient.GetBindingForEndpoint(EndpointConfiguration.BasicHttpBinding_IMediaFileService);
        }
        
        private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress()
        {
            return MyPhotosServiceClient.GetEndpointAddress(EndpointConfiguration.BasicHttpBinding_IMediaFileService);
        }
        
        public enum EndpointConfiguration
        {
            
            BasicHttpBinding_IMediaFileService,
        }
    }
}
