//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Import.ADO
{
    using System;
    using System.Collections.Generic;
    
    public partial class Products
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Products()
        {
            this.Products_Materials = new HashSet<Products_Materials>();
        }
    
        public int Product_ID { get; set; }
        public string Name { get; set; }
        public int Article { get; set; }
        public int Min_Agent_Price { get; set; }
        public string Image { get; set; }
        public int Product_Type_ID { get; set; }
        public int People_Amount { get; set; }
        public int Workshop_Number { get; set; }
    
        public virtual Product_Type Product_Type { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Products_Materials> Products_Materials { get; set; }
    }
}
