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
    
    public partial class Clothes_Donation
    {
        public int ID { get; set; }
        public string Size { get; set; }
        public string Gender { get; set; }
        public Nullable<int> Quantity { get; set; }
        public Nullable<System.DateTime> Donation_date { get; set; }
        public Nullable<int> At_Office { get; set; }
        public string Type { get; set; }
        public int Handler_ID { get; set; }
        public int Donor_ID { get; set; }
    
        public virtual Employee Employee { get; set; }
        public virtual Participant Participant { get; set; }
    }
}
