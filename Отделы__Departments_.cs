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
    
    public partial class Отделы__Departments_
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Отделы__Departments_()
        {
            this.Врачи__Doctors_ = new HashSet<Врачи__Doctors_>();
        }
    
        public int Department_id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Supplier_id { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Врачи__Doctors_> Врачи__Doctors_ { get; set; }
        public virtual Поставщики__Suppliers_ Поставщики__Suppliers_ { get; set; }
    }
}
