﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ConsumirWebService.svSAP {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://www.celeritech.biz/", ConfigurationName="svSAP.WS_SB1Soap")]
    public interface WS_SB1Soap {
        
        // CODEGEN: Se está generando un contrato de mensaje, ya que el nombre de elemento xmlDoc del espacio de nombres http://www.celeritech.biz/ no está marcado para aceptar valores nil.
        [System.ServiceModel.OperationContractAttribute(Action="http://www.celeritech.biz/CrearDocumentoEntrega", ReplyAction="*")]
        ConsumirWebService.svSAP.CrearDocumentoEntregaResponse CrearDocumentoEntrega(ConsumirWebService.svSAP.CrearDocumentoEntregaRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.celeritech.biz/CrearDocumentoEntrega", ReplyAction="*")]
        System.Threading.Tasks.Task<ConsumirWebService.svSAP.CrearDocumentoEntregaResponse> CrearDocumentoEntregaAsync(ConsumirWebService.svSAP.CrearDocumentoEntregaRequest request);
        
        // CODEGEN: Se está generando un contrato de mensaje, ya que el nombre de elemento xmlDoc del espacio de nombres http://www.celeritech.biz/ no está marcado para aceptar valores nil.
        [System.ServiceModel.OperationContractAttribute(Action="http://www.celeritech.biz/CrearDocumentoVentasArticulo", ReplyAction="*")]
        ConsumirWebService.svSAP.CrearDocumentoVentasArticuloResponse CrearDocumentoVentasArticulo(ConsumirWebService.svSAP.CrearDocumentoVentasArticuloRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.celeritech.biz/CrearDocumentoVentasArticulo", ReplyAction="*")]
        System.Threading.Tasks.Task<ConsumirWebService.svSAP.CrearDocumentoVentasArticuloResponse> CrearDocumentoVentasArticuloAsync(ConsumirWebService.svSAP.CrearDocumentoVentasArticuloRequest request);
        
        // CODEGEN: Se está generando un contrato de mensaje, ya que el nombre de elemento xmlDoc del espacio de nombres http://www.celeritech.biz/ no está marcado para aceptar valores nil.
        [System.ServiceModel.OperationContractAttribute(Action="http://www.celeritech.biz/CrearDocumentoPagoVentas", ReplyAction="*")]
        ConsumirWebService.svSAP.CrearDocumentoPagoVentasResponse CrearDocumentoPagoVentas(ConsumirWebService.svSAP.CrearDocumentoPagoVentasRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.celeritech.biz/CrearDocumentoPagoVentas", ReplyAction="*")]
        System.Threading.Tasks.Task<ConsumirWebService.svSAP.CrearDocumentoPagoVentasResponse> CrearDocumentoPagoVentasAsync(ConsumirWebService.svSAP.CrearDocumentoPagoVentasRequest request);
        
        // CODEGEN: Se está generando un contrato de mensaje, ya que el nombre de elemento xmlDoc del espacio de nombres http://www.celeritech.biz/ no está marcado para aceptar valores nil.
        [System.ServiceModel.OperationContractAttribute(Action="http://www.celeritech.biz/RegistrarSocioDeNegocios", ReplyAction="*")]
        ConsumirWebService.svSAP.RegistrarSocioDeNegociosResponse RegistrarSocioDeNegocios(ConsumirWebService.svSAP.RegistrarSocioDeNegociosRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.celeritech.biz/RegistrarSocioDeNegocios", ReplyAction="*")]
        System.Threading.Tasks.Task<ConsumirWebService.svSAP.RegistrarSocioDeNegociosResponse> RegistrarSocioDeNegociosAsync(ConsumirWebService.svSAP.RegistrarSocioDeNegociosRequest request);
        
        // CODEGEN: Se está generando un contrato de mensaje, ya que el nombre de elemento xmlDoc del espacio de nombres http://www.celeritech.biz/ no está marcado para aceptar valores nil.
        [System.ServiceModel.OperationContractAttribute(Action="http://www.celeritech.biz/CrearAsientoContable", ReplyAction="*")]
        ConsumirWebService.svSAP.CrearAsientoContableResponse CrearAsientoContable(ConsumirWebService.svSAP.CrearAsientoContableRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.celeritech.biz/CrearAsientoContable", ReplyAction="*")]
        System.Threading.Tasks.Task<ConsumirWebService.svSAP.CrearAsientoContableResponse> CrearAsientoContableAsync(ConsumirWebService.svSAP.CrearAsientoContableRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class CrearDocumentoEntregaRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="CrearDocumentoEntrega", Namespace="http://www.celeritech.biz/", Order=0)]
        public ConsumirWebService.svSAP.CrearDocumentoEntregaRequestBody Body;
        
        public CrearDocumentoEntregaRequest() {
        }
        
        public CrearDocumentoEntregaRequest(ConsumirWebService.svSAP.CrearDocumentoEntregaRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://www.celeritech.biz/")]
    public partial class CrearDocumentoEntregaRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string xmlDoc;
        
        public CrearDocumentoEntregaRequestBody() {
        }
        
        public CrearDocumentoEntregaRequestBody(string xmlDoc) {
            this.xmlDoc = xmlDoc;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class CrearDocumentoEntregaResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="CrearDocumentoEntregaResponse", Namespace="http://www.celeritech.biz/", Order=0)]
        public ConsumirWebService.svSAP.CrearDocumentoEntregaResponseBody Body;
        
        public CrearDocumentoEntregaResponse() {
        }
        
        public CrearDocumentoEntregaResponse(ConsumirWebService.svSAP.CrearDocumentoEntregaResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://www.celeritech.biz/")]
    public partial class CrearDocumentoEntregaResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string CrearDocumentoEntregaResult;
        
        public CrearDocumentoEntregaResponseBody() {
        }
        
        public CrearDocumentoEntregaResponseBody(string CrearDocumentoEntregaResult) {
            this.CrearDocumentoEntregaResult = CrearDocumentoEntregaResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class CrearDocumentoVentasArticuloRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="CrearDocumentoVentasArticulo", Namespace="http://www.celeritech.biz/", Order=0)]
        public ConsumirWebService.svSAP.CrearDocumentoVentasArticuloRequestBody Body;
        
        public CrearDocumentoVentasArticuloRequest() {
        }
        
        public CrearDocumentoVentasArticuloRequest(ConsumirWebService.svSAP.CrearDocumentoVentasArticuloRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://www.celeritech.biz/")]
    public partial class CrearDocumentoVentasArticuloRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string xmlDoc;
        
        public CrearDocumentoVentasArticuloRequestBody() {
        }
        
        public CrearDocumentoVentasArticuloRequestBody(string xmlDoc) {
            this.xmlDoc = xmlDoc;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class CrearDocumentoVentasArticuloResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="CrearDocumentoVentasArticuloResponse", Namespace="http://www.celeritech.biz/", Order=0)]
        public ConsumirWebService.svSAP.CrearDocumentoVentasArticuloResponseBody Body;
        
        public CrearDocumentoVentasArticuloResponse() {
        }
        
        public CrearDocumentoVentasArticuloResponse(ConsumirWebService.svSAP.CrearDocumentoVentasArticuloResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://www.celeritech.biz/")]
    public partial class CrearDocumentoVentasArticuloResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string CrearDocumentoVentasArticuloResult;
        
        public CrearDocumentoVentasArticuloResponseBody() {
        }
        
        public CrearDocumentoVentasArticuloResponseBody(string CrearDocumentoVentasArticuloResult) {
            this.CrearDocumentoVentasArticuloResult = CrearDocumentoVentasArticuloResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class CrearDocumentoPagoVentasRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="CrearDocumentoPagoVentas", Namespace="http://www.celeritech.biz/", Order=0)]
        public ConsumirWebService.svSAP.CrearDocumentoPagoVentasRequestBody Body;
        
        public CrearDocumentoPagoVentasRequest() {
        }
        
        public CrearDocumentoPagoVentasRequest(ConsumirWebService.svSAP.CrearDocumentoPagoVentasRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://www.celeritech.biz/")]
    public partial class CrearDocumentoPagoVentasRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string xmlDoc;
        
        public CrearDocumentoPagoVentasRequestBody() {
        }
        
        public CrearDocumentoPagoVentasRequestBody(string xmlDoc) {
            this.xmlDoc = xmlDoc;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class CrearDocumentoPagoVentasResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="CrearDocumentoPagoVentasResponse", Namespace="http://www.celeritech.biz/", Order=0)]
        public ConsumirWebService.svSAP.CrearDocumentoPagoVentasResponseBody Body;
        
        public CrearDocumentoPagoVentasResponse() {
        }
        
        public CrearDocumentoPagoVentasResponse(ConsumirWebService.svSAP.CrearDocumentoPagoVentasResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://www.celeritech.biz/")]
    public partial class CrearDocumentoPagoVentasResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string CrearDocumentoPagoVentasResult;
        
        public CrearDocumentoPagoVentasResponseBody() {
        }
        
        public CrearDocumentoPagoVentasResponseBody(string CrearDocumentoPagoVentasResult) {
            this.CrearDocumentoPagoVentasResult = CrearDocumentoPagoVentasResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class RegistrarSocioDeNegociosRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="RegistrarSocioDeNegocios", Namespace="http://www.celeritech.biz/", Order=0)]
        public ConsumirWebService.svSAP.RegistrarSocioDeNegociosRequestBody Body;
        
        public RegistrarSocioDeNegociosRequest() {
        }
        
        public RegistrarSocioDeNegociosRequest(ConsumirWebService.svSAP.RegistrarSocioDeNegociosRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://www.celeritech.biz/")]
    public partial class RegistrarSocioDeNegociosRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string xmlDoc;
        
        public RegistrarSocioDeNegociosRequestBody() {
        }
        
        public RegistrarSocioDeNegociosRequestBody(string xmlDoc) {
            this.xmlDoc = xmlDoc;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class RegistrarSocioDeNegociosResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="RegistrarSocioDeNegociosResponse", Namespace="http://www.celeritech.biz/", Order=0)]
        public ConsumirWebService.svSAP.RegistrarSocioDeNegociosResponseBody Body;
        
        public RegistrarSocioDeNegociosResponse() {
        }
        
        public RegistrarSocioDeNegociosResponse(ConsumirWebService.svSAP.RegistrarSocioDeNegociosResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://www.celeritech.biz/")]
    public partial class RegistrarSocioDeNegociosResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string RegistrarSocioDeNegociosResult;
        
        public RegistrarSocioDeNegociosResponseBody() {
        }
        
        public RegistrarSocioDeNegociosResponseBody(string RegistrarSocioDeNegociosResult) {
            this.RegistrarSocioDeNegociosResult = RegistrarSocioDeNegociosResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class CrearAsientoContableRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="CrearAsientoContable", Namespace="http://www.celeritech.biz/", Order=0)]
        public ConsumirWebService.svSAP.CrearAsientoContableRequestBody Body;
        
        public CrearAsientoContableRequest() {
        }
        
        public CrearAsientoContableRequest(ConsumirWebService.svSAP.CrearAsientoContableRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://www.celeritech.biz/")]
    public partial class CrearAsientoContableRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string xmlDoc;
        
        public CrearAsientoContableRequestBody() {
        }
        
        public CrearAsientoContableRequestBody(string xmlDoc) {
            this.xmlDoc = xmlDoc;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class CrearAsientoContableResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="CrearAsientoContableResponse", Namespace="http://www.celeritech.biz/", Order=0)]
        public ConsumirWebService.svSAP.CrearAsientoContableResponseBody Body;
        
        public CrearAsientoContableResponse() {
        }
        
        public CrearAsientoContableResponse(ConsumirWebService.svSAP.CrearAsientoContableResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://www.celeritech.biz/")]
    public partial class CrearAsientoContableResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string CrearAsientoContableResult;
        
        public CrearAsientoContableResponseBody() {
        }
        
        public CrearAsientoContableResponseBody(string CrearAsientoContableResult) {
            this.CrearAsientoContableResult = CrearAsientoContableResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface WS_SB1SoapChannel : ConsumirWebService.svSAP.WS_SB1Soap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WS_SB1SoapClient : System.ServiceModel.ClientBase<ConsumirWebService.svSAP.WS_SB1Soap>, ConsumirWebService.svSAP.WS_SB1Soap {
        
        public WS_SB1SoapClient() {
        }
        
        public WS_SB1SoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WS_SB1SoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WS_SB1SoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WS_SB1SoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ConsumirWebService.svSAP.CrearDocumentoEntregaResponse ConsumirWebService.svSAP.WS_SB1Soap.CrearDocumentoEntrega(ConsumirWebService.svSAP.CrearDocumentoEntregaRequest request) {
            return base.Channel.CrearDocumentoEntrega(request);
        }
        
        public string CrearDocumentoEntrega(string xmlDoc) {
            ConsumirWebService.svSAP.CrearDocumentoEntregaRequest inValue = new ConsumirWebService.svSAP.CrearDocumentoEntregaRequest();
            inValue.Body = new ConsumirWebService.svSAP.CrearDocumentoEntregaRequestBody();
            inValue.Body.xmlDoc = xmlDoc;
            ConsumirWebService.svSAP.CrearDocumentoEntregaResponse retVal = ((ConsumirWebService.svSAP.WS_SB1Soap)(this)).CrearDocumentoEntrega(inValue);
            return retVal.Body.CrearDocumentoEntregaResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ConsumirWebService.svSAP.CrearDocumentoEntregaResponse> ConsumirWebService.svSAP.WS_SB1Soap.CrearDocumentoEntregaAsync(ConsumirWebService.svSAP.CrearDocumentoEntregaRequest request) {
            return base.Channel.CrearDocumentoEntregaAsync(request);
        }
        
        public System.Threading.Tasks.Task<ConsumirWebService.svSAP.CrearDocumentoEntregaResponse> CrearDocumentoEntregaAsync(string xmlDoc) {
            ConsumirWebService.svSAP.CrearDocumentoEntregaRequest inValue = new ConsumirWebService.svSAP.CrearDocumentoEntregaRequest();
            inValue.Body = new ConsumirWebService.svSAP.CrearDocumentoEntregaRequestBody();
            inValue.Body.xmlDoc = xmlDoc;
            return ((ConsumirWebService.svSAP.WS_SB1Soap)(this)).CrearDocumentoEntregaAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ConsumirWebService.svSAP.CrearDocumentoVentasArticuloResponse ConsumirWebService.svSAP.WS_SB1Soap.CrearDocumentoVentasArticulo(ConsumirWebService.svSAP.CrearDocumentoVentasArticuloRequest request) {
            return base.Channel.CrearDocumentoVentasArticulo(request);
        }
        
        public string CrearDocumentoVentasArticulo(string xmlDoc) {
            ConsumirWebService.svSAP.CrearDocumentoVentasArticuloRequest inValue = new ConsumirWebService.svSAP.CrearDocumentoVentasArticuloRequest();
            inValue.Body = new ConsumirWebService.svSAP.CrearDocumentoVentasArticuloRequestBody();
            inValue.Body.xmlDoc = xmlDoc;
            ConsumirWebService.svSAP.CrearDocumentoVentasArticuloResponse retVal = ((ConsumirWebService.svSAP.WS_SB1Soap)(this)).CrearDocumentoVentasArticulo(inValue);
            return retVal.Body.CrearDocumentoVentasArticuloResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ConsumirWebService.svSAP.CrearDocumentoVentasArticuloResponse> ConsumirWebService.svSAP.WS_SB1Soap.CrearDocumentoVentasArticuloAsync(ConsumirWebService.svSAP.CrearDocumentoVentasArticuloRequest request) {
            return base.Channel.CrearDocumentoVentasArticuloAsync(request);
        }
        
        public System.Threading.Tasks.Task<ConsumirWebService.svSAP.CrearDocumentoVentasArticuloResponse> CrearDocumentoVentasArticuloAsync(string xmlDoc) {
            ConsumirWebService.svSAP.CrearDocumentoVentasArticuloRequest inValue = new ConsumirWebService.svSAP.CrearDocumentoVentasArticuloRequest();
            inValue.Body = new ConsumirWebService.svSAP.CrearDocumentoVentasArticuloRequestBody();
            inValue.Body.xmlDoc = xmlDoc;
            return ((ConsumirWebService.svSAP.WS_SB1Soap)(this)).CrearDocumentoVentasArticuloAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ConsumirWebService.svSAP.CrearDocumentoPagoVentasResponse ConsumirWebService.svSAP.WS_SB1Soap.CrearDocumentoPagoVentas(ConsumirWebService.svSAP.CrearDocumentoPagoVentasRequest request) {
            return base.Channel.CrearDocumentoPagoVentas(request);
        }
        
        public string CrearDocumentoPagoVentas(string xmlDoc) {
            ConsumirWebService.svSAP.CrearDocumentoPagoVentasRequest inValue = new ConsumirWebService.svSAP.CrearDocumentoPagoVentasRequest();
            inValue.Body = new ConsumirWebService.svSAP.CrearDocumentoPagoVentasRequestBody();
            inValue.Body.xmlDoc = xmlDoc;
            ConsumirWebService.svSAP.CrearDocumentoPagoVentasResponse retVal = ((ConsumirWebService.svSAP.WS_SB1Soap)(this)).CrearDocumentoPagoVentas(inValue);
            return retVal.Body.CrearDocumentoPagoVentasResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ConsumirWebService.svSAP.CrearDocumentoPagoVentasResponse> ConsumirWebService.svSAP.WS_SB1Soap.CrearDocumentoPagoVentasAsync(ConsumirWebService.svSAP.CrearDocumentoPagoVentasRequest request) {
            return base.Channel.CrearDocumentoPagoVentasAsync(request);
        }
        
        public System.Threading.Tasks.Task<ConsumirWebService.svSAP.CrearDocumentoPagoVentasResponse> CrearDocumentoPagoVentasAsync(string xmlDoc) {
            ConsumirWebService.svSAP.CrearDocumentoPagoVentasRequest inValue = new ConsumirWebService.svSAP.CrearDocumentoPagoVentasRequest();
            inValue.Body = new ConsumirWebService.svSAP.CrearDocumentoPagoVentasRequestBody();
            inValue.Body.xmlDoc = xmlDoc;
            return ((ConsumirWebService.svSAP.WS_SB1Soap)(this)).CrearDocumentoPagoVentasAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ConsumirWebService.svSAP.RegistrarSocioDeNegociosResponse ConsumirWebService.svSAP.WS_SB1Soap.RegistrarSocioDeNegocios(ConsumirWebService.svSAP.RegistrarSocioDeNegociosRequest request) {
            return base.Channel.RegistrarSocioDeNegocios(request);
        }
        
        public string RegistrarSocioDeNegocios(string xmlDoc) {
            ConsumirWebService.svSAP.RegistrarSocioDeNegociosRequest inValue = new ConsumirWebService.svSAP.RegistrarSocioDeNegociosRequest();
            inValue.Body = new ConsumirWebService.svSAP.RegistrarSocioDeNegociosRequestBody();
            inValue.Body.xmlDoc = xmlDoc;
            ConsumirWebService.svSAP.RegistrarSocioDeNegociosResponse retVal = ((ConsumirWebService.svSAP.WS_SB1Soap)(this)).RegistrarSocioDeNegocios(inValue);
            return retVal.Body.RegistrarSocioDeNegociosResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ConsumirWebService.svSAP.RegistrarSocioDeNegociosResponse> ConsumirWebService.svSAP.WS_SB1Soap.RegistrarSocioDeNegociosAsync(ConsumirWebService.svSAP.RegistrarSocioDeNegociosRequest request) {
            return base.Channel.RegistrarSocioDeNegociosAsync(request);
        }
        
        public System.Threading.Tasks.Task<ConsumirWebService.svSAP.RegistrarSocioDeNegociosResponse> RegistrarSocioDeNegociosAsync(string xmlDoc) {
            ConsumirWebService.svSAP.RegistrarSocioDeNegociosRequest inValue = new ConsumirWebService.svSAP.RegistrarSocioDeNegociosRequest();
            inValue.Body = new ConsumirWebService.svSAP.RegistrarSocioDeNegociosRequestBody();
            inValue.Body.xmlDoc = xmlDoc;
            return ((ConsumirWebService.svSAP.WS_SB1Soap)(this)).RegistrarSocioDeNegociosAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ConsumirWebService.svSAP.CrearAsientoContableResponse ConsumirWebService.svSAP.WS_SB1Soap.CrearAsientoContable(ConsumirWebService.svSAP.CrearAsientoContableRequest request) {
            return base.Channel.CrearAsientoContable(request);
        }
        
        public string CrearAsientoContable(string xmlDoc) {
            ConsumirWebService.svSAP.CrearAsientoContableRequest inValue = new ConsumirWebService.svSAP.CrearAsientoContableRequest();
            inValue.Body = new ConsumirWebService.svSAP.CrearAsientoContableRequestBody();
            inValue.Body.xmlDoc = xmlDoc;
            ConsumirWebService.svSAP.CrearAsientoContableResponse retVal = ((ConsumirWebService.svSAP.WS_SB1Soap)(this)).CrearAsientoContable(inValue);
            return retVal.Body.CrearAsientoContableResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ConsumirWebService.svSAP.CrearAsientoContableResponse> ConsumirWebService.svSAP.WS_SB1Soap.CrearAsientoContableAsync(ConsumirWebService.svSAP.CrearAsientoContableRequest request) {
            return base.Channel.CrearAsientoContableAsync(request);
        }
        
        public System.Threading.Tasks.Task<ConsumirWebService.svSAP.CrearAsientoContableResponse> CrearAsientoContableAsync(string xmlDoc) {
            ConsumirWebService.svSAP.CrearAsientoContableRequest inValue = new ConsumirWebService.svSAP.CrearAsientoContableRequest();
            inValue.Body = new ConsumirWebService.svSAP.CrearAsientoContableRequestBody();
            inValue.Body.xmlDoc = xmlDoc;
            return ((ConsumirWebService.svSAP.WS_SB1Soap)(this)).CrearAsientoContableAsync(inValue);
        }
    }
}
