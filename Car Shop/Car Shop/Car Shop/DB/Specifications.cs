//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Car_Shop.DB
{
    using System;
    using System.Collections.Generic;
    
    public partial class Specifications
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Specifications()
        {
            this.Car = new HashSet<Car>();
        }
    
        public int ID { get; set; }
        public string Engine { get; set; }
        public string DriveUnit { get; set; }
        public string Fuel { get; set; }
        public Nullable<int> SizeID { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Car> Car { get; set; }
        public virtual Size Size { get; set; }
    }
}
