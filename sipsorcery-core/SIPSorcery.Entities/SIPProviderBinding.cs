//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SIPSorcery.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class SIPProviderBinding
    {
        public string AdminMemberID { get; set; }
        public int BindingExpiry { get; set; }
        public string BindingURI { get; set; }
        public int CSeq { get; set; }
        public string ID { get; set; }
        public bool IsRegistered { get; set; }
        public string LastRegisterAttempt { get; set; }
        public string LastRegisterTime { get; set; }
        public string NextRegistrationTime { get; set; }
        public string Owner { get; set; }
        public string ProviderID { get; set; }
        public string ProviderName { get; set; }
        public string RegistrarSIPSocket { get; set; }
        public string RegistrationFailureMessage { get; set; }
    
        public virtual SIPProvider sipprovider { get; set; }
    }
}