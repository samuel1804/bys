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
    
    public partial class Perfil
    {
        public Perfil()
        {
            this.OfertaLaboral = new HashSet<OfertaLaboral>();
        }
    
        public int IdPerfil { get; set; }
        public Nullable<int> IdPuesto { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string Competencias { get; set; }
        public string Caracteristicas { get; set; }
        public Nullable<decimal> SueldoIni { get; set; }
        public Nullable<decimal> SueldoFin { get; set; }
        public double Estado { get; set; }
    
        public virtual ICollection<OfertaLaboral> OfertaLaboral { get; set; }
        public virtual Puesto Puesto { get; set; }
    }
}
