//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Medical_Laboratory
{
    using System;
    using System.Collections.Generic;
    
    public partial class Специализация_врача__Specialization_
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Специализация_врача__Specialization_()
        {
            this.Врачи__Doctors_ = new HashSet<Врачи__Doctors_>();
        }
    
        public int Specialization_ID { get; set; }
        public string Specialization { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Врачи__Doctors_> Врачи__Doctors_ { get; set; }
    }
}
