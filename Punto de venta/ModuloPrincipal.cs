//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Punto_de_venta
{
    using System;
    using System.Collections.Generic;
    
    public partial class ModuloPrincipal
    {
        public ModuloPrincipal()
        {
            this.Modulos = new HashSet<Modulo>();
        }
    
        public short IdModuloPrincipal { get; set; }
        public string DescripcionModuloPrin { get; set; }
        public bool EstadoModuloPrin { get; set; }
    
        public virtual ICollection<Modulo> Modulos { get; set; }
    }
}
