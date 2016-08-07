﻿using System;
using System.Collections.Generic;
using Hl7.Fhir.Introspection;
using Hl7.Fhir.Validation;
using System.Linq;
using System.Runtime.Serialization;
using System.ComponentModel;

/*
  Copyright (c) 2011+, HL7, Inc.
  All rights reserved.
  
  Redistribution and use in source and binary forms, with or without modification, 
  are permitted provided that the following conditions are met:
  
   * Redistributions of source code must retain the above copyright notice, this 
     list of conditions and the following disclaimer.
   * Redistributions in binary form must reproduce the above copyright notice, 
     this list of conditions and the following disclaimer in the documentation 
     and/or other materials provided with the distribution.
   * Neither the name of HL7 nor the names of its contributors may be used to 
     endorse or promote products derived from this software without specific 
     prior written permission.
  
  THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS IS" AND 
  ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE IMPLIED 
  WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE ARE DISCLAIMED. 
  IN NO EVENT SHALL THE COPYRIGHT HOLDER OR CONTRIBUTORS BE LIABLE FOR ANY DIRECT, 
  INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES (INCLUDING, BUT 
  NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES; LOSS OF USE, DATA, OR 
  PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND ON ANY THEORY OF LIABILITY, 
  WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT (INCLUDING NEGLIGENCE OR OTHERWISE) 
  ARISING IN ANY WAY OUT OF THE USE OF THIS SOFTWARE, EVEN IF ADVISED OF THE 
  POSSIBILITY OF SUCH DAMAGE.
  

*/

//
// Generated for FHIR v1.5.0
//
namespace Hl7.Fhir.Model
{
    /// <summary>
    /// The technical details of an endpoint that can be used for electronic services
    /// </summary>
    [FhirType("Endpoint", IsResource=true)]
    [DataContract]
    public partial class Endpoint : Hl7.Fhir.Model.DomainResource, System.ComponentModel.INotifyPropertyChanged
    {
        [NotMapped]
        public override ResourceType ResourceType { get { return ResourceType.Endpoint; } }
        [NotMapped]
        public override string TypeName { get { return "Endpoint"; } }
        
        /// <summary>
        /// The status of the encounter.
        /// (url: http://hl7.org/fhir/ValueSet/endpoint-status)
        /// </summary>
        [FhirEnumeration("EndpointStatus")]
        public enum EndpointStatus
        {
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/endpoint-status)
            /// </summary>
            [EnumLiteral("active"), Description("Active")]
            Active,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/endpoint-status)
            /// </summary>
            [EnumLiteral("suspended"), Description("Suspended")]
            Suspended,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/endpoint-status)
            /// </summary>
            [EnumLiteral("error"), Description("Error")]
            Error,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/endpoint-status)
            /// </summary>
            [EnumLiteral("off"), Description("Off")]
            Off,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/endpoint-status)
            /// </summary>
            [EnumLiteral("entered-in-error"), Description("Entered in error")]
            EnteredInError,
        }

        /// <summary>
        /// Identifies this endpoint across multiple systems
        /// </summary>
        [FhirElement("identifier", InSummary=true, Order=90)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Hl7.Fhir.Model.Identifier> Identifier
        {
            get { if(_Identifier==null) _Identifier = new List<Hl7.Fhir.Model.Identifier>(); return _Identifier; }
            set { _Identifier = value; OnPropertyChanged("Identifier"); }
        }
        
        private List<Hl7.Fhir.Model.Identifier> _Identifier;
        
        /// <summary>
        /// active | suspended | error | off | entered-in-error
        /// </summary>
        [FhirElement("status", InSummary=true, Order=100)]
        [Cardinality(Min=1,Max=1)]
        [DataMember]
        public Code<Hl7.Fhir.Model.Endpoint.EndpointStatus> StatusElement
        {
            get { return _StatusElement; }
            set { _StatusElement = value; OnPropertyChanged("StatusElement"); }
        }
        
        private Code<Hl7.Fhir.Model.Endpoint.EndpointStatus> _StatusElement;
        
        /// <summary>
        /// active | suspended | error | off | entered-in-error
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMemberAttribute]
        public Hl7.Fhir.Model.Endpoint.EndpointStatus? Status
        {
            get { return StatusElement != null ? StatusElement.Value : null; }
            set
            {
                if (!value.HasValue)
                  StatusElement = null; 
                else
                  StatusElement = new Code<Hl7.Fhir.Model.Endpoint.EndpointStatus>(value);
                OnPropertyChanged("Status");
            }
        }
        
        /// <summary>
        /// A name that this endpoint can be identified by
        /// </summary>
        [FhirElement("name", InSummary=true, Order=110)]
        [DataMember]
        public Hl7.Fhir.Model.FhirString NameElement
        {
            get { return _NameElement; }
            set { _NameElement = value; OnPropertyChanged("NameElement"); }
        }
        
        private Hl7.Fhir.Model.FhirString _NameElement;
        
        /// <summary>
        /// A name that this endpoint can be identified by
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMemberAttribute]
        public string Name
        {
            get { return NameElement != null ? NameElement.Value : null; }
            set
            {
                if (value == null)
                  NameElement = null; 
                else
                  NameElement = new Hl7.Fhir.Model.FhirString(value);
                OnPropertyChanged("Name");
            }
        }
        
        /// <summary>
        /// Organization that manages this endpoint (may not be the organization that exposes the endpoint)
        /// </summary>
        [FhirElement("managingOrganization", InSummary=true, Order=120)]
        [References("Organization")]
        [DataMember]
        public Hl7.Fhir.Model.ResourceReference ManagingOrganization
        {
            get { return _ManagingOrganization; }
            set { _ManagingOrganization = value; OnPropertyChanged("ManagingOrganization"); }
        }
        
        private Hl7.Fhir.Model.ResourceReference _ManagingOrganization;
        
        /// <summary>
        /// Contact details for source (e.g. troubleshooting)
        /// </summary>
        [FhirElement("contact", Order=130)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Hl7.Fhir.Model.ContactPoint> Contact
        {
            get { if(_Contact==null) _Contact = new List<Hl7.Fhir.Model.ContactPoint>(); return _Contact; }
            set { _Contact = value; OnPropertyChanged("Contact"); }
        }
        
        private List<Hl7.Fhir.Model.ContactPoint> _Contact;
        
        /// <summary>
        /// rest-hook | websocket | email | sms | message
        /// </summary>
        [FhirElement("connectionType", InSummary=true, Order=140)]
        [Cardinality(Min=1,Max=1)]
        [DataMember]
        public Hl7.Fhir.Model.Coding ConnectionType
        {
            get { return _ConnectionType; }
            set { _ConnectionType = value; OnPropertyChanged("ConnectionType"); }
        }
        
        private Hl7.Fhir.Model.Coding _ConnectionType;
        
        /// <summary>
        /// The http verb to be used when calling this endpoint
        /// </summary>
        [FhirElement("method", InSummary=true, Order=150)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Hl7.Fhir.Model.Coding> Method
        {
            get { if(_Method==null) _Method = new List<Hl7.Fhir.Model.Coding>(); return _Method; }
            set { _Method = value; OnPropertyChanged("Method"); }
        }
        
        private List<Hl7.Fhir.Model.Coding> _Method;
        
        /// <summary>
        /// Interval during responsibility is assumed
        /// </summary>
        [FhirElement("period", InSummary=true, Order=160)]
        [DataMember]
        public Hl7.Fhir.Model.Period Period
        {
            get { return _Period; }
            set { _Period = value; OnPropertyChanged("Period"); }
        }
        
        private Hl7.Fhir.Model.Period _Period;
        
        /// <summary>
        /// Where the channel points to
        /// </summary>
        [FhirElement("address", InSummary=true, Order=170)]
        [Cardinality(Min=1,Max=1)]
        [DataMember]
        public Hl7.Fhir.Model.FhirUri AddressElement
        {
            get { return _AddressElement; }
            set { _AddressElement = value; OnPropertyChanged("AddressElement"); }
        }
        
        private Hl7.Fhir.Model.FhirUri _AddressElement;
        
        /// <summary>
        /// Where the channel points to
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMemberAttribute]
        public string Address
        {
            get { return AddressElement != null ? AddressElement.Value : null; }
            set
            {
                if (value == null)
                  AddressElement = null; 
                else
                  AddressElement = new Hl7.Fhir.Model.FhirUri(value);
                OnPropertyChanged("Address");
            }
        }
        
        /// <summary>
        /// Mimetype to send, or blank for no payload
        /// </summary>
        [FhirElement("payloadFormat", Order=180)]
        [Cardinality(Min=1,Max=1)]
        [DataMember]
        public Hl7.Fhir.Model.FhirString PayloadFormatElement
        {
            get { return _PayloadFormatElement; }
            set { _PayloadFormatElement = value; OnPropertyChanged("PayloadFormatElement"); }
        }
        
        private Hl7.Fhir.Model.FhirString _PayloadFormatElement;
        
        /// <summary>
        /// Mimetype to send, or blank for no payload
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMemberAttribute]
        public string PayloadFormat
        {
            get { return PayloadFormatElement != null ? PayloadFormatElement.Value : null; }
            set
            {
                if (value == null)
                  PayloadFormatElement = null; 
                else
                  PayloadFormatElement = new Hl7.Fhir.Model.FhirString(value);
                OnPropertyChanged("PayloadFormat");
            }
        }
        
        /// <summary>
        /// The type of content that may be used at this endpoint (e.g. XDS Discharge summaries)
        /// </summary>
        [FhirElement("payloadType", InSummary=true, Order=190)]
        [Cardinality(Min=1,Max=-1)]
        [DataMember]
        public List<Hl7.Fhir.Model.CodeableConcept> PayloadType
        {
            get { if(_PayloadType==null) _PayloadType = new List<Hl7.Fhir.Model.CodeableConcept>(); return _PayloadType; }
            set { _PayloadType = value; OnPropertyChanged("PayloadType"); }
        }
        
        private List<Hl7.Fhir.Model.CodeableConcept> _PayloadType;
        
        /// <summary>
        /// Usage depends on the channel type
        /// </summary>
        [FhirElement("header", Order=200)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Hl7.Fhir.Model.FhirString> HeaderElement
        {
            get { if(_HeaderElement==null) _HeaderElement = new List<Hl7.Fhir.Model.FhirString>(); return _HeaderElement; }
            set { _HeaderElement = value; OnPropertyChanged("HeaderElement"); }
        }
        
        private List<Hl7.Fhir.Model.FhirString> _HeaderElement;
        
        /// <summary>
        /// Usage depends on the channel type
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMemberAttribute]
        public IEnumerable<string> Header
        {
            get { return HeaderElement != null ? HeaderElement.Select(elem => elem.Value) : null; }
            set
            {
                if (value == null)
                  HeaderElement = null; 
                else
                  HeaderElement = new List<Hl7.Fhir.Model.FhirString>(value.Select(elem=>new Hl7.Fhir.Model.FhirString(elem)));
                OnPropertyChanged("Header");
            }
        }
        
        /// <summary>
        /// PKI Public keys to support secure communications
        /// </summary>
        [FhirElement("publicKey", Order=210)]
        [DataMember]
        public Hl7.Fhir.Model.FhirString PublicKeyElement
        {
            get { return _PublicKeyElement; }
            set { _PublicKeyElement = value; OnPropertyChanged("PublicKeyElement"); }
        }
        
        private Hl7.Fhir.Model.FhirString _PublicKeyElement;
        
        /// <summary>
        /// PKI Public keys to support secure communications
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMemberAttribute]
        public string PublicKey
        {
            get { return PublicKeyElement != null ? PublicKeyElement.Value : null; }
            set
            {
                if (value == null)
                  PublicKeyElement = null; 
                else
                  PublicKeyElement = new Hl7.Fhir.Model.FhirString(value);
                OnPropertyChanged("PublicKey");
            }
        }
        

        public static ElementDefinition.ConstraintComponent Endpoint_DOM_2 = new ElementDefinition.ConstraintComponent()
        {
            Expression = "contained.contained.empty()",
            Key = "dom-2",
            Severity = ElementDefinition.ConstraintSeverity.Warning,
            Human = "If the resource is contained in another resource, it SHALL NOT contain nested Resources",
            Xpath = "not(parent::f:contained and f:contained)"
        };

        public static ElementDefinition.ConstraintComponent Endpoint_DOM_1 = new ElementDefinition.ConstraintComponent()
        {
            Expression = "contained.text.empty()",
            Key = "dom-1",
            Severity = ElementDefinition.ConstraintSeverity.Warning,
            Human = "If the resource is contained in another resource, it SHALL NOT contain any narrative",
            Xpath = "not(parent::f:contained and f:text)"
        };

        public static ElementDefinition.ConstraintComponent Endpoint_DOM_4 = new ElementDefinition.ConstraintComponent()
        {
            Expression = "contained.meta.versionId.empty() and contained.meta.lastUpdated.empty()",
            Key = "dom-4",
            Severity = ElementDefinition.ConstraintSeverity.Warning,
            Human = "If a resource is contained in another resource, it SHALL NOT have a meta.versionId or a meta.lastUpdated",
            Xpath = "not(exists(f:contained/*/f:meta/f:versionId)) and not(exists(f:contained/*/f:meta/f:lastUpdated))"
        };

        public static ElementDefinition.ConstraintComponent Endpoint_DOM_3 = new ElementDefinition.ConstraintComponent()
        {
            Expression = "contained.where(('#'+id in %resource.descendents().reference).not()).empty()",
            Key = "dom-3",
            Severity = ElementDefinition.ConstraintSeverity.Warning,
            Human = "If the resource is contained in another resource, it SHALL be referred to from elsewhere in the resource",
            Xpath = "not(exists(for $id in f:contained/*/@id return $id[not(ancestor::f:contained/parent::*/descendant::f:reference/@value=concat('#', $id))]))"
        };

        public override IDeepCopyable CopyTo(IDeepCopyable other)
        {
            var dest = other as Endpoint;
            
            if (dest != null)
            {
                base.CopyTo(dest);
                if(Identifier != null) dest.Identifier = new List<Hl7.Fhir.Model.Identifier>(Identifier.DeepCopy());
                if(StatusElement != null) dest.StatusElement = (Code<Hl7.Fhir.Model.Endpoint.EndpointStatus>)StatusElement.DeepCopy();
                if(NameElement != null) dest.NameElement = (Hl7.Fhir.Model.FhirString)NameElement.DeepCopy();
                if(ManagingOrganization != null) dest.ManagingOrganization = (Hl7.Fhir.Model.ResourceReference)ManagingOrganization.DeepCopy();
                if(Contact != null) dest.Contact = new List<Hl7.Fhir.Model.ContactPoint>(Contact.DeepCopy());
                if(ConnectionType != null) dest.ConnectionType = (Hl7.Fhir.Model.Coding)ConnectionType.DeepCopy();
                if(Method != null) dest.Method = new List<Hl7.Fhir.Model.Coding>(Method.DeepCopy());
                if(Period != null) dest.Period = (Hl7.Fhir.Model.Period)Period.DeepCopy();
                if(AddressElement != null) dest.AddressElement = (Hl7.Fhir.Model.FhirUri)AddressElement.DeepCopy();
                if(PayloadFormatElement != null) dest.PayloadFormatElement = (Hl7.Fhir.Model.FhirString)PayloadFormatElement.DeepCopy();
                if(PayloadType != null) dest.PayloadType = new List<Hl7.Fhir.Model.CodeableConcept>(PayloadType.DeepCopy());
                if(HeaderElement != null) dest.HeaderElement = new List<Hl7.Fhir.Model.FhirString>(HeaderElement.DeepCopy());
                if(PublicKeyElement != null) dest.PublicKeyElement = (Hl7.Fhir.Model.FhirString)PublicKeyElement.DeepCopy();
                return dest;
            }
            else
            	throw new ArgumentException("Can only copy to an object of the same type", "other");
        }
        
        public override IDeepCopyable DeepCopy()
        {
            return CopyTo(new Endpoint());
        }
        
        public override bool Matches(IDeepComparable other)
        {
            var otherT = other as Endpoint;
            if(otherT == null) return false;
            
            if(!base.Matches(otherT)) return false;
            if( !DeepComparable.Matches(Identifier, otherT.Identifier)) return false;
            if( !DeepComparable.Matches(StatusElement, otherT.StatusElement)) return false;
            if( !DeepComparable.Matches(NameElement, otherT.NameElement)) return false;
            if( !DeepComparable.Matches(ManagingOrganization, otherT.ManagingOrganization)) return false;
            if( !DeepComparable.Matches(Contact, otherT.Contact)) return false;
            if( !DeepComparable.Matches(ConnectionType, otherT.ConnectionType)) return false;
            if( !DeepComparable.Matches(Method, otherT.Method)) return false;
            if( !DeepComparable.Matches(Period, otherT.Period)) return false;
            if( !DeepComparable.Matches(AddressElement, otherT.AddressElement)) return false;
            if( !DeepComparable.Matches(PayloadFormatElement, otherT.PayloadFormatElement)) return false;
            if( !DeepComparable.Matches(PayloadType, otherT.PayloadType)) return false;
            if( !DeepComparable.Matches(HeaderElement, otherT.HeaderElement)) return false;
            if( !DeepComparable.Matches(PublicKeyElement, otherT.PublicKeyElement)) return false;
            
            return true;
        }
        
        public override bool IsExactly(IDeepComparable other)
        {
            var otherT = other as Endpoint;
            if(otherT == null) return false;
            
            if(!base.IsExactly(otherT)) return false;
            if( !DeepComparable.IsExactly(Identifier, otherT.Identifier)) return false;
            if( !DeepComparable.IsExactly(StatusElement, otherT.StatusElement)) return false;
            if( !DeepComparable.IsExactly(NameElement, otherT.NameElement)) return false;
            if( !DeepComparable.IsExactly(ManagingOrganization, otherT.ManagingOrganization)) return false;
            if( !DeepComparable.IsExactly(Contact, otherT.Contact)) return false;
            if( !DeepComparable.IsExactly(ConnectionType, otherT.ConnectionType)) return false;
            if( !DeepComparable.IsExactly(Method, otherT.Method)) return false;
            if( !DeepComparable.IsExactly(Period, otherT.Period)) return false;
            if( !DeepComparable.IsExactly(AddressElement, otherT.AddressElement)) return false;
            if( !DeepComparable.IsExactly(PayloadFormatElement, otherT.PayloadFormatElement)) return false;
            if( !DeepComparable.IsExactly(PayloadType, otherT.PayloadType)) return false;
            if( !DeepComparable.IsExactly(HeaderElement, otherT.HeaderElement)) return false;
            if( !DeepComparable.IsExactly(PublicKeyElement, otherT.PublicKeyElement)) return false;
            
            return true;
        }
        
    }
    
}
