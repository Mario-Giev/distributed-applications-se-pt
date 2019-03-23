﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MC.Website.GenreReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="GenreDto", Namespace="http://schemas.datacontract.org/2004/07/MC.ApplicationServices.DTOs")]
    [System.SerializableAttribute()]
    public partial class GenreDto : MC.Website.GenreReference.BaseDto {
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
                }
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="BaseDto", Namespace="http://schemas.datacontract.org/2004/07/MC.ApplicationServices.DTOs")]
    [System.SerializableAttribute()]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(MC.Website.GenreReference.GenreDto))]
    public partial class BaseDto : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool IsActiveField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool IsActive {
            get {
                return this.IsActiveField;
            }
            set {
                if ((this.IsActiveField.Equals(value) != true)) {
                    this.IsActiveField = value;
                    this.RaisePropertyChanged("IsActive");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="GenreReference.IGenre")]
    public interface IGenre {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGenre/GetGenres", ReplyAction="http://tempuri.org/IGenre/GetGenresResponse")]
        MC.Website.GenreReference.GenreDto[] GetGenres();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGenre/GetGenres", ReplyAction="http://tempuri.org/IGenre/GetGenresResponse")]
        System.Threading.Tasks.Task<MC.Website.GenreReference.GenreDto[]> GetGenresAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGenre/PostGenre", ReplyAction="http://tempuri.org/IGenre/PostGenreResponse")]
        string PostGenre(MC.Website.GenreReference.GenreDto genreDto);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGenre/PostGenre", ReplyAction="http://tempuri.org/IGenre/PostGenreResponse")]
        System.Threading.Tasks.Task<string> PostGenreAsync(MC.Website.GenreReference.GenreDto genreDto);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGenre/DeleteGenre", ReplyAction="http://tempuri.org/IGenre/DeleteGenreResponse")]
        string DeleteGenre(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGenre/DeleteGenre", ReplyAction="http://tempuri.org/IGenre/DeleteGenreResponse")]
        System.Threading.Tasks.Task<string> DeleteGenreAsync(int id);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IGenreChannel : MC.Website.GenreReference.IGenre, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class GenreClient : System.ServiceModel.ClientBase<MC.Website.GenreReference.IGenre>, MC.Website.GenreReference.IGenre {
        
        public GenreClient() {
        }
        
        public GenreClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public GenreClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public GenreClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public GenreClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public MC.Website.GenreReference.GenreDto[] GetGenres() {
            return base.Channel.GetGenres();
        }
        
        public System.Threading.Tasks.Task<MC.Website.GenreReference.GenreDto[]> GetGenresAsync() {
            return base.Channel.GetGenresAsync();
        }
        
        public string PostGenre(MC.Website.GenreReference.GenreDto genreDto) {
            return base.Channel.PostGenre(genreDto);
        }
        
        public System.Threading.Tasks.Task<string> PostGenreAsync(MC.Website.GenreReference.GenreDto genreDto) {
            return base.Channel.PostGenreAsync(genreDto);
        }
        
        public string DeleteGenre(int id) {
            return base.Channel.DeleteGenre(id);
        }
        
        public System.Threading.Tasks.Task<string> DeleteGenreAsync(int id) {
            return base.Channel.DeleteGenreAsync(id);
        }
    }
}