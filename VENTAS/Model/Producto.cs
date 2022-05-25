//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace VENTAS.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Producto
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Producto()
        {
            this.Detalle_Compra = new HashSet<Detalle_Compra>();
            this.Detalle_Venta = new HashSet<Detalle_Venta>();
            this.Producto_Espera = new HashSet<Producto_Espera>();
        }
    
        public int id_producto { get; set; }
        public int id_categoria { get; set; }
        public int id_proveedor { get; set; }
        public string nombre_producto { get; set; }
        public Nullable<int> cantidad { get; set; }
        public Nullable<decimal> costo { get; set; }
        public Nullable<decimal> precio_venta { get; set; }
    
        public virtual Categoria Categoria { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Detalle_Compra> Detalle_Compra { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Detalle_Venta> Detalle_Venta { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Producto_Espera> Producto_Espera { get; set; }
        public virtual Proveedore Proveedore { get; set; }
    }
}
