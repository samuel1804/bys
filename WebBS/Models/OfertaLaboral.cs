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
    
    public partial class OfertaLaboral
    {
        public int IdOfertaLaboral { get; set; }
        public string Titulo { get; set; }
        public int IdPerfil { get; set; }
        public int IdSucursal { get; set; }
        public string FuncionesAdicionales { get; set; }
        public Nullable<int> TiempoValidez { get; set; }
        public Nullable<System.DateTime> FechaCrea { get; set; }
        public int Estado { get; set; }
    
        public virtual Perfil Perfil { get; set; }
        public virtual Sucursal Sucursal { get; set; }
    }
}
