//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DBapplication
{
    using System;
    using System.Collections.Generic;
    
    public partial class Visit
    {
        public int Event_ID { get; set; }
        public string Establishment_Name { get; set; }
    
        public virtual Establishment Establishment { get; set; }
        public virtual Event Event { get; set; }
    }
}