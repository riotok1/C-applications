//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Mining_Application.DB
{
    using System;
    using System.Collections.Generic;
    
    public partial class Field
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Field()
        {
            this.PickupPoint = new HashSet<PickupPoint>();
        }
    
        public int ID { get; set; }
        public string FieldName { get; set; }
        public string Stocks { get; set; }
        public string DevMethod { get; set; }
        public string AnnualProd { get; set; }
        public string CostForUnit { get; set; }
        public int MineralID { get; set; }
    
        public virtual Mineral Mineral { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PickupPoint> PickupPoint { get; set; }
    }
}