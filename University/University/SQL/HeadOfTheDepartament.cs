//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace University.SQL
{
    using System;
    using System.Collections.Generic;
    
    public partial class HeadOfTheDepartament
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HeadOfTheDepartament()
        {
            this.MainInfoTable = new HashSet<MainInfoTable>();
        }
    
        public int ID { get; set; }
        public int NumberManager { get; set; }
        public string NameManager { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MainInfoTable> MainInfoTable { get; set; }
    }
}
