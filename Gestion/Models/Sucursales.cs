//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Gestion.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class Sucursales
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Sucursales()
        {
            this.Pedido_de_Venta = new HashSet<Pedido_de_Venta>();
            this.Producto_Sucursal = new HashSet<Producto_Sucursal>();
        }
        [Required]
        [Display(Name = "Código Sucursal:")]
        public string Cod_Sucursal { get; set; }
        [Required]
        [Display(Name = "Dirección:")]
        public string Direccion_Sucursal { get; set; }
        [Required]
        [Display(Name = "Teléfono")]
        public int Telefono_Sucursal { get; set; }
        [Required]
        [Display(Name = "Latitud:")]
        public double Latitud { get; set; }
        [Required]
        [Display(Name = "Longitud")]
        public double Longitud { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Pedido_de_Venta> Pedido_de_Venta { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Producto_Sucursal> Producto_Sucursal { get; set; }
    }
}
