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
    
    public partial class Usuario
    {
        public Usuario()
        {
            this.Compra = new HashSet<Compra>();
            this.Detalle_Venta_Tiempo = new HashSet<Detalle_Venta_Tiempo>();
            this.Estado1 = new HashSet<Estado>();
        }
    
        public short IdUsuario { get; set; }
        public string Usr { get; set; }
        public string Pwd { get; set; }
        public bool Estado { get; set; }
        public short FKPerfil { get; set; }
    
        public virtual ICollection<Compra> Compra { get; set; }
        public virtual ICollection<Detalle_Venta_Tiempo> Detalle_Venta_Tiempo { get; set; }
        public virtual Perfiles Perfiles { get; set; }
        public virtual ICollection<Estado> Estado1 { get; set; }
        public virtual Usuario Usuario1 { get; set; }
        public virtual Usuario Usuario2 { get; set; }
        public virtual UsuarioDetalles UsuarioDetalles { get; set; }
    }
}
