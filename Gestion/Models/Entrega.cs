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
    
    public partial class Entrega
    {
        public string Cod_Pedido { get; set; }
        public System.DateTime Fecha_Hora { get; set; }
    
        public virtual Pedido_de_Venta Pedido_de_Venta { get; set; }
    }
}
