//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace YouFinancialHelper.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class User
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public User()
        {
            this.Expenditure_Base = new HashSet<Expenditure_Base>();
        }
    
        public int id { get; set; }
        public string Name { get; set; }
        public string Last_Name { get; set; }
        public string Nickname { get; set; }
        public string Password { get; set; }
        public string Currency { get; set; }
        public byte status { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Expenditure_Base> Expenditure_Base { get; set; }
    }
}
