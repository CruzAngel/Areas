﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.34014
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Areas_Perimetros.Areas {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="Areas.AreasSoap")]
    public interface AreasSoap {
        
        // CODEGEN: Se está generando un contrato de mensaje, ya que el nombre de elemento AreaTrianguloResult del espacio de nombres http://tempuri.org/ no está marcado para aceptar valores nil.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/AreaTriangulo", ReplyAction="*")]
        Areas_Perimetros.Areas.AreaTrianguloResponse AreaTriangulo(Areas_Perimetros.Areas.AreaTrianguloRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/AreaTriangulo", ReplyAction="*")]
        System.Threading.Tasks.Task<Areas_Perimetros.Areas.AreaTrianguloResponse> AreaTrianguloAsync(Areas_Perimetros.Areas.AreaTrianguloRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class AreaTrianguloRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="AreaTriangulo", Namespace="http://tempuri.org/", Order=0)]
        public Areas_Perimetros.Areas.AreaTrianguloRequestBody Body;
        
        public AreaTrianguloRequest() {
        }
        
        public AreaTrianguloRequest(Areas_Perimetros.Areas.AreaTrianguloRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class AreaTrianguloRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public float vase;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=1)]
        public float altura;
        
        public AreaTrianguloRequestBody() {
        }
        
        public AreaTrianguloRequestBody(float vase, float altura) {
            this.vase = vase;
            this.altura = altura;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class AreaTrianguloResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="AreaTrianguloResponse", Namespace="http://tempuri.org/", Order=0)]
        public Areas_Perimetros.Areas.AreaTrianguloResponseBody Body;
        
        public AreaTrianguloResponse() {
        }
        
        public AreaTrianguloResponse(Areas_Perimetros.Areas.AreaTrianguloResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class AreaTrianguloResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string AreaTrianguloResult;
        
        public AreaTrianguloResponseBody() {
        }
        
        public AreaTrianguloResponseBody(string AreaTrianguloResult) {
            this.AreaTrianguloResult = AreaTrianguloResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface AreasSoapChannel : Areas_Perimetros.Areas.AreasSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class AreasSoapClient : System.ServiceModel.ClientBase<Areas_Perimetros.Areas.AreasSoap>, Areas_Perimetros.Areas.AreasSoap {
        
        public AreasSoapClient() {
        }
        
        public AreasSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public AreasSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AreasSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AreasSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Areas_Perimetros.Areas.AreaTrianguloResponse Areas_Perimetros.Areas.AreasSoap.AreaTriangulo(Areas_Perimetros.Areas.AreaTrianguloRequest request) {
            return base.Channel.AreaTriangulo(request);
        }
        
        public string AreaTriangulo(float vase, float altura) {
            Areas_Perimetros.Areas.AreaTrianguloRequest inValue = new Areas_Perimetros.Areas.AreaTrianguloRequest();
            inValue.Body = new Areas_Perimetros.Areas.AreaTrianguloRequestBody();
            inValue.Body.vase = vase;
            inValue.Body.altura = altura;
            Areas_Perimetros.Areas.AreaTrianguloResponse retVal = ((Areas_Perimetros.Areas.AreasSoap)(this)).AreaTriangulo(inValue);
            return retVal.Body.AreaTrianguloResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Areas_Perimetros.Areas.AreaTrianguloResponse> Areas_Perimetros.Areas.AreasSoap.AreaTrianguloAsync(Areas_Perimetros.Areas.AreaTrianguloRequest request) {
            return base.Channel.AreaTrianguloAsync(request);
        }
        
        public System.Threading.Tasks.Task<Areas_Perimetros.Areas.AreaTrianguloResponse> AreaTrianguloAsync(float vase, float altura) {
            Areas_Perimetros.Areas.AreaTrianguloRequest inValue = new Areas_Perimetros.Areas.AreaTrianguloRequest();
            inValue.Body = new Areas_Perimetros.Areas.AreaTrianguloRequestBody();
            inValue.Body.vase = vase;
            inValue.Body.altura = altura;
            return ((Areas_Perimetros.Areas.AreasSoap)(this)).AreaTrianguloAsync(inValue);
        }
    }
}