//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace People_application.DB
{
    using System;
    using System.Collections.Generic;
    
    public partial class Passport
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Passport()
        {
            this.Human = new HashSet<Human>();
        }
    
        public int ID { get; set; }
        public int Series { get; set; }
        public int Number { get; set; }
        public int BankID { get; set; }
    
        public virtual Bank Bank { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Human> Human { get; set; }
    }
}
