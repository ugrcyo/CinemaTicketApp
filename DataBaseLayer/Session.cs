//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataBaseLayer
{
    using System;
    using System.Collections.Generic;
    
    public partial class Session
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Session()
        {
            this.Film_Day_Session = new HashSet<Film_Day_Session>();
        }
    
        public int ID { get; set; }
        public int Film_ID { get; set; }
        public System.TimeSpan Session_Beginning { get; set; }
        public System.TimeSpan Session_Finishing { get; set; }
        public System.TimeSpan Film_Duration { get; set; }
    
        public virtual Film Film { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Film_Day_Session> Film_Day_Session { get; set; }
    }
}