﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Terminal.joaquin24 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="joaquin24.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetLineas", ReplyAction="http://tempuri.org/IService1/GetLineasResponse")]
        Share.entities.ELinea[] GetLineas();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetLineas", ReplyAction="http://tempuri.org/IService1/GetLineasResponse")]
        System.Threading.Tasks.Task<Share.entities.ELinea[]> GetLineasAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetSalidas", ReplyAction="http://tempuri.org/IService1/GetSalidasResponse")]
        Share.entities.ESalida[] GetSalidas(int lineaSelected);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetSalidas", ReplyAction="http://tempuri.org/IService1/GetSalidasResponse")]
        System.Threading.Tasks.Task<Share.entities.ESalida[]> GetSalidasAsync(int lineaSelected);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetParadasD", ReplyAction="http://tempuri.org/IService1/GetParadasDResponse")]
        Share.entities.EParada[] GetParadasD(int IdLinea, int IdParada);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetParadasD", ReplyAction="http://tempuri.org/IService1/GetParadasDResponse")]
        System.Threading.Tasks.Task<Share.entities.EParada[]> GetParadasDAsync(int IdLinea, int IdParada);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/canSelectSeat", ReplyAction="http://tempuri.org/IService1/canSelectSeatResponse")]
        bool canSelectSeat(int IdLinea, int idParadaOrigen, int idParadaDestino);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/canSelectSeat", ReplyAction="http://tempuri.org/IService1/canSelectSeatResponse")]
        System.Threading.Tasks.Task<bool> canSelectSeatAsync(int IdLinea, int idParadaOrigen, int idParadaDestino);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/precioDelPasaje", ReplyAction="http://tempuri.org/IService1/precioDelPasajeResponse")]
        int precioDelPasaje(int IdLinea, int idParadaOrigen, int idParadaDestino);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/precioDelPasaje", ReplyAction="http://tempuri.org/IService1/precioDelPasajeResponse")]
        System.Threading.Tasks.Task<int> precioDelPasajeAsync(int IdLinea, int idParadaOrigen, int idParadaDestino);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetAsientos", ReplyAction="http://tempuri.org/IService1/GetAsientosResponse")]
        int[] GetAsientos(int fechaSelected);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetAsientos", ReplyAction="http://tempuri.org/IService1/GetAsientosResponse")]
        System.Threading.Tasks.Task<int[]> GetAsientosAsync(int fechaSelected);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetFechasViajes", ReplyAction="http://tempuri.org/IService1/GetFechasViajesResponse")]
        Share.entities.EViaje[] GetFechasViajes(int IdSalida);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetFechasViajes", ReplyAction="http://tempuri.org/IService1/GetFechasViajesResponse")]
        System.Threading.Tasks.Task<Share.entities.EViaje[]> GetFechasViajesAsync(int IdSalida);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetParadas", ReplyAction="http://tempuri.org/IService1/GetParadasResponse")]
        Share.entities.EParada[] GetParadas(int IdLinea);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetParadas", ReplyAction="http://tempuri.org/IService1/GetParadasResponse")]
        System.Threading.Tasks.Task<Share.entities.EParada[]> GetParadasAsync(int IdLinea);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetData", ReplyAction="http://tempuri.org/IService1/GetDataResponse")]
        string GetData(int value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetData", ReplyAction="http://tempuri.org/IService1/GetDataResponse")]
        System.Threading.Tasks.Task<string> GetDataAsync(int value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/comprarPasaje", ReplyAction="http://tempuri.org/IService1/comprarPasajeResponse")]
        void comprarPasaje(int IdViaje, int UserId, int paradaOId, int paradaDId, int TipoDocumento, string Documento, int Asiento);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/comprarPasaje", ReplyAction="http://tempuri.org/IService1/comprarPasajeResponse")]
        System.Threading.Tasks.Task comprarPasajeAsync(int IdViaje, int UserId, int paradaOId, int paradaDId, int TipoDocumento, string Documento, int Asiento);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetDataUsingDataContract", ReplyAction="http://tempuri.org/IService1/GetDataUsingDataContractResponse")]
        API_SOAP.CompositeType GetDataUsingDataContract(API_SOAP.CompositeType composite);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetDataUsingDataContract", ReplyAction="http://tempuri.org/IService1/GetDataUsingDataContractResponse")]
        System.Threading.Tasks.Task<API_SOAP.CompositeType> GetDataUsingDataContractAsync(API_SOAP.CompositeType composite);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : Terminal.joaquin24.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<Terminal.joaquin24.IService1>, Terminal.joaquin24.IService1 {
        
        public Service1Client() {
        }
        
        public Service1Client(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Service1Client(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public Share.entities.ELinea[] GetLineas() {
            return base.Channel.GetLineas();
        }
        
        public System.Threading.Tasks.Task<Share.entities.ELinea[]> GetLineasAsync() {
            return base.Channel.GetLineasAsync();
        }
        
        public Share.entities.ESalida[] GetSalidas(int lineaSelected) {
            return base.Channel.GetSalidas(lineaSelected);
        }
        
        public System.Threading.Tasks.Task<Share.entities.ESalida[]> GetSalidasAsync(int lineaSelected) {
            return base.Channel.GetSalidasAsync(lineaSelected);
        }
        
        public Share.entities.EParada[] GetParadasD(int IdLinea, int IdParada) {
            return base.Channel.GetParadasD(IdLinea, IdParada);
        }
        
        public System.Threading.Tasks.Task<Share.entities.EParada[]> GetParadasDAsync(int IdLinea, int IdParada) {
            return base.Channel.GetParadasDAsync(IdLinea, IdParada);
        }
        
        public bool canSelectSeat(int IdLinea, int idParadaOrigen, int idParadaDestino) {
            return base.Channel.canSelectSeat(IdLinea, idParadaOrigen, idParadaDestino);
        }
        
        public System.Threading.Tasks.Task<bool> canSelectSeatAsync(int IdLinea, int idParadaOrigen, int idParadaDestino) {
            return base.Channel.canSelectSeatAsync(IdLinea, idParadaOrigen, idParadaDestino);
        }
        
        public int precioDelPasaje(int IdLinea, int idParadaOrigen, int idParadaDestino) {
            return base.Channel.precioDelPasaje(IdLinea, idParadaOrigen, idParadaDestino);
        }
        
        public System.Threading.Tasks.Task<int> precioDelPasajeAsync(int IdLinea, int idParadaOrigen, int idParadaDestino) {
            return base.Channel.precioDelPasajeAsync(IdLinea, idParadaOrigen, idParadaDestino);
        }
        
        public int[] GetAsientos(int fechaSelected) {
            return base.Channel.GetAsientos(fechaSelected);
        }
        
        public System.Threading.Tasks.Task<int[]> GetAsientosAsync(int fechaSelected) {
            return base.Channel.GetAsientosAsync(fechaSelected);
        }
        
        public Share.entities.EViaje[] GetFechasViajes(int IdSalida) {
            return base.Channel.GetFechasViajes(IdSalida);
        }
        
        public System.Threading.Tasks.Task<Share.entities.EViaje[]> GetFechasViajesAsync(int IdSalida) {
            return base.Channel.GetFechasViajesAsync(IdSalida);
        }
        
        public Share.entities.EParada[] GetParadas(int IdLinea) {
            return base.Channel.GetParadas(IdLinea);
        }
        
        public System.Threading.Tasks.Task<Share.entities.EParada[]> GetParadasAsync(int IdLinea) {
            return base.Channel.GetParadasAsync(IdLinea);
        }
        
        public string GetData(int value) {
            return base.Channel.GetData(value);
        }
        
        public System.Threading.Tasks.Task<string> GetDataAsync(int value) {
            return base.Channel.GetDataAsync(value);
        }
        
        public void comprarPasaje(int IdViaje, int UserId, int paradaOId, int paradaDId, int TipoDocumento, string Documento, int Asiento) {
            base.Channel.comprarPasaje(IdViaje, UserId, paradaOId, paradaDId, TipoDocumento, Documento, Asiento);
        }
        
        public System.Threading.Tasks.Task comprarPasajeAsync(int IdViaje, int UserId, int paradaOId, int paradaDId, int TipoDocumento, string Documento, int Asiento) {
            return base.Channel.comprarPasajeAsync(IdViaje, UserId, paradaOId, paradaDId, TipoDocumento, Documento, Asiento);
        }
        
        public API_SOAP.CompositeType GetDataUsingDataContract(API_SOAP.CompositeType composite) {
            return base.Channel.GetDataUsingDataContract(composite);
        }
        
        public System.Threading.Tasks.Task<API_SOAP.CompositeType> GetDataUsingDataContractAsync(API_SOAP.CompositeType composite) {
            return base.Channel.GetDataUsingDataContractAsync(composite);
        }
    }
}