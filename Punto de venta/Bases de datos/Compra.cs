//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Punto_de_venta.Bases_de_datos
{
    using System;
    using System.Collections.Generic;
    
    public partial class Compra
    {
        public Compra()
        {
            this.CompraDetalle = new HashSet<CompraDetalle>();
        }
    
        public int IdCompra { get; set; }
        public short idUsuario { get; set; }
        public System.DateTime Fecha { get; set; }
        public double Total { get; set; }
    
        public virtual Usuario Usuario { get; set; }
        public virtual ICollection<CompraDetalle> CompraDetalle { get; set; }
    }
}
