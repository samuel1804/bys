//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebBS.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Area
    {
        public Area()
        {
            this.Puesto = new HashSet<Puesto>();
        }
    
        public int IdArea { get; set; }
        public string Nombre { get; set; }
        public int Estado { get; set; }

    
        public virtual ICollection<Puesto> Puesto { get; set; }
    }
}
