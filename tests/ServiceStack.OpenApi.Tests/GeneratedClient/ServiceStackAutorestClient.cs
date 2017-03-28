// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace AutorestClient
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Models;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Net;
    using System.Net.Http;

    public partial class ServiceStackAutorestClient : ServiceClient<ServiceStackAutorestClient>, IServiceStackAutorestClient
    {
        /// <summary>
        /// The base URI of the service.
        /// </summary>
        public System.Uri BaseUri { get; set; }

        /// <summary>
        /// Gets or sets json serialization settings.
        /// </summary>
        public JsonSerializerSettings SerializationSettings { get; private set; }

        /// <summary>
        /// Gets or sets json deserialization settings.
        /// </summary>
        public JsonSerializerSettings DeserializationSettings { get; private set; }

        /// <summary>
        /// Accept Header
        /// </summary>
        public string Accept { get; private set; }

        /// <summary>
        /// Gets the IReturnListRequest.
        /// </summary>
        public virtual IReturnListRequest ReturnListRequest { get; private set; }

        /// <summary>
        /// Gets the IReturnArrayRequest.
        /// </summary>
        public virtual IReturnArrayRequest ReturnArrayRequest { get; private set; }

        /// <summary>
        /// Gets the IReturnKeyValuePairRequest.
        /// </summary>
        public virtual IReturnKeyValuePairRequest ReturnKeyValuePairRequest { get; private set; }

        /// <summary>
        /// Gets the IReturnDictionaryStringRequest.
        /// </summary>
        public virtual IReturnDictionaryStringRequest ReturnDictionaryStringRequest { get; private set; }

        /// <summary>
        /// Gets the IReturnDictionaryDtoRequest.
        /// </summary>
        public virtual IReturnDictionaryDtoRequest ReturnDictionaryDtoRequest { get; private set; }

        /// <summary>
        /// Gets the IGetSession.
        /// </summary>
        public virtual IGetSession GetSession { get; private set; }

        /// <summary>
        /// Gets the IUpdateSessioneditCustomName.
        /// </summary>
        public virtual IUpdateSessioneditCustomName UpdateSessioneditCustomName { get; private set; }

        /// <summary>
        /// Gets the IHelloOperations.
        /// </summary>
        public virtual IHelloOperations Hello { get; private set; }

        /// <summary>
        /// Gets the IHelloName.
        /// </summary>
        public virtual IHelloName HelloName { get; private set; }

        /// <summary>
        /// Gets the IHelloListOperations.
        /// </summary>
        public virtual IHelloListOperations HelloList { get; private set; }

        /// <summary>
        /// Gets the IHelloArrayOperations.
        /// </summary>
        public virtual IHelloArrayOperations HelloArray { get; private set; }

        /// <summary>
        /// Gets the IAllowedAttributesOperations.
        /// </summary>
        public virtual IAllowedAttributesOperations AllowedAttributes { get; private set; }

        /// <summary>
        /// Gets the IHelloAllTypesOperations.
        /// </summary>
        public virtual IHelloAllTypesOperations HelloAllTypes { get; private set; }

        /// <summary>
        /// Gets the IHelloAllTypesWithResultOperations.
        /// </summary>
        public virtual IHelloAllTypesWithResultOperations HelloAllTypesWithResult { get; private set; }

        /// <summary>
        /// Gets the IHelloStringOperations.
        /// </summary>
        public virtual IHelloStringOperations HelloString { get; private set; }

        /// <summary>
        /// Gets the IHelloDateTimeOperations.
        /// </summary>
        public virtual IHelloDateTimeOperations HelloDateTime { get; private set; }

        /// <summary>
        /// Gets the IHelloVoidOperations.
        /// </summary>
        public virtual IHelloVoidOperations HelloVoid { get; private set; }

        /// <summary>
        /// Gets the IHelloWithRouteOperations.
        /// </summary>
        public virtual IHelloWithRouteOperations HelloWithRoute { get; private set; }

        /// <summary>
        /// Gets the IHelloTypesOperations.
        /// </summary>
        public virtual IHelloTypesOperations HelloTypes { get; private set; }

        /// <summary>
        /// Gets the IHelloZipOperations.
        /// </summary>
        public virtual IHelloZipOperations HelloZip { get; private set; }

        /// <summary>
        /// Gets the ISecuredRequest.
        /// </summary>
        public virtual ISecuredRequest SecuredRequest { get; private set; }

        /// <summary>
        /// Gets the ISecuredDtoRequest.
        /// </summary>
        public virtual ISecuredDtoRequest SecuredDtoRequest { get; private set; }

        /// <summary>
        /// Gets the ISecuredOpsRequest.
        /// </summary>
        public virtual ISecuredOpsRequest SecuredOpsRequest { get; private set; }

        /// <summary>
        /// Gets the IAuthenticateOperations.
        /// </summary>
        public virtual IAuthenticateOperations Authenticate { get; private set; }

        /// <summary>
        /// Gets the IAuthenticateprovider.
        /// </summary>
        public virtual IAuthenticateprovider Authenticateprovider { get; private set; }

        /// <summary>
        /// Gets the IAuthenticate2.
        /// </summary>
        public virtual IAuthenticate2 Authenticate2 { get; private set; }

        /// <summary>
        /// Gets the IAuthenticateprovider2.
        /// </summary>
        public virtual IAuthenticateprovider2 Authenticateprovider2 { get; private set; }

        /// <summary>
        /// Gets the IAssignRolesOperations.
        /// </summary>
        public virtual IAssignRolesOperations AssignRoles { get; private set; }

        /// <summary>
        /// Gets the IUnAssignRolesOperations.
        /// </summary>
        public virtual IUnAssignRolesOperations UnAssignRoles { get; private set; }

        /// <summary>
        /// Initializes a new instance of the ServiceStackAutorestClient class.
        /// </summary>
        /// <param name='handlers'>
        /// Optional. The delegating handlers to add to the http client pipeline.
        /// </param>
        public ServiceStackAutorestClient(params DelegatingHandler[] handlers) : base(handlers)
        {
            Initialize();
        }

        /// <summary>
        /// Initializes a new instance of the ServiceStackAutorestClient class.
        /// </summary>
        /// <param name='rootHandler'>
        /// Optional. The http client handler used to handle http transport.
        /// </param>
        /// <param name='handlers'>
        /// Optional. The delegating handlers to add to the http client pipeline.
        /// </param>
        public ServiceStackAutorestClient(HttpClientHandler rootHandler, params DelegatingHandler[] handlers) : base(rootHandler, handlers)
        {
            Initialize();
        }

        /// <summary>
        /// Initializes a new instance of the ServiceStackAutorestClient class.
        /// </summary>
        /// <param name='baseUri'>
        /// Optional. The base URI of the service.
        /// </param>
        /// <param name='handlers'>
        /// Optional. The delegating handlers to add to the http client pipeline.
        /// </param>
        /// <exception cref="System.ArgumentNullException">
        /// Thrown when a required parameter is null
        /// </exception>
        public ServiceStackAutorestClient(System.Uri baseUri, params DelegatingHandler[] handlers) : this(handlers)
        {
            if (baseUri == null)
            {
                throw new System.ArgumentNullException("baseUri");
            }
            BaseUri = baseUri;
        }

        /// <summary>
        /// Initializes a new instance of the ServiceStackAutorestClient class.
        /// </summary>
        /// <param name='baseUri'>
        /// Optional. The base URI of the service.
        /// </param>
        /// <param name='rootHandler'>
        /// Optional. The http client handler used to handle http transport.
        /// </param>
        /// <param name='handlers'>
        /// Optional. The delegating handlers to add to the http client pipeline.
        /// </param>
        /// <exception cref="System.ArgumentNullException">
        /// Thrown when a required parameter is null
        /// </exception>
        public ServiceStackAutorestClient(System.Uri baseUri, HttpClientHandler rootHandler, params DelegatingHandler[] handlers) : this(rootHandler, handlers)
        {
            if (baseUri == null)
            {
                throw new System.ArgumentNullException("baseUri");
            }
            BaseUri = baseUri;
        }

        /// <summary>
        /// An optional partial-method to perform custom initialization.
        ///</summary>
        partial void CustomInitialize();
        /// <summary>
        /// Initializes client properties.
        /// </summary>
        private void Initialize()
        {
            ReturnListRequest = new ReturnListRequest(this);
            ReturnArrayRequest = new ReturnArrayRequest(this);
            ReturnKeyValuePairRequest = new ReturnKeyValuePairRequest(this);
            ReturnDictionaryStringRequest = new ReturnDictionaryStringRequest(this);
            ReturnDictionaryDtoRequest = new ReturnDictionaryDtoRequest(this);
            GetSession = new GetSession(this);
            UpdateSessioneditCustomName = new UpdateSessioneditCustomName(this);
            Hello = new HelloOperations(this);
            HelloName = new HelloName(this);
            HelloList = new HelloListOperations(this);
            HelloArray = new HelloArrayOperations(this);
            AllowedAttributes = new AllowedAttributesOperations(this);
            HelloAllTypes = new HelloAllTypesOperations(this);
            HelloAllTypesWithResult = new HelloAllTypesWithResultOperations(this);
            HelloString = new HelloStringOperations(this);
            HelloDateTime = new HelloDateTimeOperations(this);
            HelloVoid = new HelloVoidOperations(this);
            HelloWithRoute = new HelloWithRouteOperations(this);
            HelloTypes = new HelloTypesOperations(this);
            HelloZip = new HelloZipOperations(this);
            SecuredRequest = new SecuredRequest(this);
            SecuredDtoRequest = new SecuredDtoRequest(this);
            SecuredOpsRequest = new SecuredOpsRequest(this);
            Authenticate = new AuthenticateOperations(this);
            Authenticateprovider = new Authenticateprovider(this);
            Authenticate2 = new Authenticate2(this);
            Authenticateprovider2 = new Authenticateprovider2(this);
            AssignRoles = new AssignRolesOperations(this);
            UnAssignRoles = new UnAssignRolesOperations(this);
            BaseUri = new System.Uri("http://localhost:20000/");
            Accept = "application/json";
            SerializationSettings = new JsonSerializerSettings
            {
                Formatting = Newtonsoft.Json.Formatting.Indented,
                DateFormatHandling = Newtonsoft.Json.DateFormatHandling.IsoDateFormat,
                DateTimeZoneHandling = Newtonsoft.Json.DateTimeZoneHandling.Utc,
                NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore,
                ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Serialize,
                ContractResolver = new ReadOnlyJsonContractResolver(),
                Converters = new  List<JsonConverter>
                    {
                        new Iso8601TimeSpanConverter()
                    }
            };
            DeserializationSettings = new JsonSerializerSettings
            {
                DateFormatHandling = Newtonsoft.Json.DateFormatHandling.IsoDateFormat,
                DateTimeZoneHandling = Newtonsoft.Json.DateTimeZoneHandling.Utc,
                NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore,
                ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Serialize,
                ContractResolver = new ReadOnlyJsonContractResolver(),
                Converters = new List<JsonConverter>
                    {
                        new Iso8601TimeSpanConverter()
                    }
            };
            CustomInitialize();
        }
    }
}
