//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Handyman
{
    using System;
    using System.Collections.Generic;
    
    public partial class skill
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public skill()
        {
            this.handyman_ability = new HashSet<handyman_ability>();
        }
    
        public int skill_id { get; set; }
        public int service_id { get; set; }
        public string skill_name { get; set; }
        public string skill_desc { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<handyman_ability> handyman_ability { get; set; }
        public virtual service service { get; set; }
    }
}
