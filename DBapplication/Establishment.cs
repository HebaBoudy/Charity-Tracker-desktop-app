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
    
    public partial class Establishment
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Establishment()
        {
            this.Blood_Donation = new HashSet<Blood_Donation>();
            this.Money_Donations = new HashSet<Money_Donations>();
            this.Visits = new HashSet<Visit>();
        }
    
        public string Name { get; set; }
        public string Phone_No { get; set; }
        public string Bank_Account { get; set; }
        public string Email { get; set; }
        public Nullable<int> Total_Donations { get; set; }
        public Nullable<int> Total_Visits { get; set; }
        public string Location { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Blood_Donation> Blood_Donation { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Money_Donations> Money_Donations { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Visit> Visits { get; set; }
    }
}