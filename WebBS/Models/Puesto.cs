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
    
    public partial class Puesto
    {
        public Puesto()
        {
            this.Perfil = new HashSet<Perfil>();
        }
    
        public int IdPuesto { get; set; }
        public string Nombre { get; set; }
        public Nullable<int> IdArea { get; set; }
        public int Estado { get; set; }
    
        public virtual Area Area { get; set; }
        public virtual ICollection<Perfil> Perfil { get; set; }
    }
}
