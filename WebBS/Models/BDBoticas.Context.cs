﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class BDBoticasEntities : DbContext
    {
        public BDBoticasEntities()
            : base("name=BDBoticasEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Almacen> Almacen { get; set; }
        public virtual DbSet<Area> Area { get; set; }
        public virtual DbSet<Chofer> Chofer { get; set; }
        public virtual DbSet<Control_Asignacion> Control_Asignacion { get; set; }
        public virtual DbSet<DetalleKardex> DetalleKardex { get; set; }
        public virtual DbSet<DetalleNotaIngreso> DetalleNotaIngreso { get; set; }
        public virtual DbSet<DetalleNotaSalida> DetalleNotaSalida { get; set; }
        public virtual DbSet<DetallePedido> DetallePedido { get; set; }
        public virtual DbSet<Kardex> Kardex { get; set; }
        public virtual DbSet<NotaIngreso> NotaIngreso { get; set; }
        public virtual DbSet<NotaSalida> NotaSalida { get; set; }
        public virtual DbSet<OfertaLaboral> OfertaLaboral { get; set; }
        public virtual DbSet<Pedido> Pedido { get; set; }
        public virtual DbSet<Perfil> Perfil { get; set; }
        public virtual DbSet<Productos> Productos { get; set; }
        public virtual DbSet<Puesto> Puesto { get; set; }
        public virtual DbSet<Sucursal> Sucursal { get; set; }
        public virtual DbSet<Ubicacion> Ubicacion { get; set; }
        public virtual DbSet<UbicacionProducto> UbicacionProducto { get; set; }
        public virtual DbSet<Vehiculo> Vehiculo { get; set; }
    
        public virtual int sp_DetalleReceta_Buscar(string wHERE)
        {
            var wHEREParameter = wHERE != null ?
                new ObjectParameter("WHERE", wHERE) :
                new ObjectParameter("WHERE", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_DetalleReceta_Buscar", wHEREParameter);
        }
    
        public virtual int sp_Kardex_ObtenerUltimoMovimiento(string wHERE)
        {
            var wHEREParameter = wHERE != null ?
                new ObjectParameter("WHERE", wHERE) :
                new ObjectParameter("WHERE", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_Kardex_ObtenerUltimoMovimiento", wHEREParameter);
        }
    
        public virtual int sp_Orden_Anular(string codigo)
        {
            var codigoParameter = codigo != null ?
                new ObjectParameter("codigo", codigo) :
                new ObjectParameter("codigo", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_Orden_Anular", codigoParameter);
        }
    
        public virtual int sp_OrdenPreparado_Actualizar(string codigo_Orden, Nullable<System.DateTime> fecha, string tecnico_Farmaceutico, string receta_Cliente, string codigo_Sucursal, string codigo_Receta, string estado)
        {
            var codigo_OrdenParameter = codigo_Orden != null ?
                new ObjectParameter("Codigo_Orden", codigo_Orden) :
                new ObjectParameter("Codigo_Orden", typeof(string));
    
            var fechaParameter = fecha.HasValue ?
                new ObjectParameter("Fecha", fecha) :
                new ObjectParameter("Fecha", typeof(System.DateTime));
    
            var tecnico_FarmaceuticoParameter = tecnico_Farmaceutico != null ?
                new ObjectParameter("Tecnico_Farmaceutico", tecnico_Farmaceutico) :
                new ObjectParameter("Tecnico_Farmaceutico", typeof(string));
    
            var receta_ClienteParameter = receta_Cliente != null ?
                new ObjectParameter("Receta_Cliente", receta_Cliente) :
                new ObjectParameter("Receta_Cliente", typeof(string));
    
            var codigo_SucursalParameter = codigo_Sucursal != null ?
                new ObjectParameter("Codigo_Sucursal", codigo_Sucursal) :
                new ObjectParameter("Codigo_Sucursal", typeof(string));
    
            var codigo_RecetaParameter = codigo_Receta != null ?
                new ObjectParameter("Codigo_Receta", codigo_Receta) :
                new ObjectParameter("Codigo_Receta", typeof(string));
    
            var estadoParameter = estado != null ?
                new ObjectParameter("Estado", estado) :
                new ObjectParameter("Estado", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_OrdenPreparado_Actualizar", codigo_OrdenParameter, fechaParameter, tecnico_FarmaceuticoParameter, receta_ClienteParameter, codigo_SucursalParameter, codigo_RecetaParameter, estadoParameter);
        }
    
        public virtual int sp_OrdenPreparado_Crear(string codigo_Orden, Nullable<System.DateTime> fecha, string tecnico_Farmaceutico, string receta_Cliente, string codigo_Sucursal, string codigo_Receta, string estado)
        {
            var codigo_OrdenParameter = codigo_Orden != null ?
                new ObjectParameter("Codigo_Orden", codigo_Orden) :
                new ObjectParameter("Codigo_Orden", typeof(string));
    
            var fechaParameter = fecha.HasValue ?
                new ObjectParameter("Fecha", fecha) :
                new ObjectParameter("Fecha", typeof(System.DateTime));
    
            var tecnico_FarmaceuticoParameter = tecnico_Farmaceutico != null ?
                new ObjectParameter("Tecnico_Farmaceutico", tecnico_Farmaceutico) :
                new ObjectParameter("Tecnico_Farmaceutico", typeof(string));
    
            var receta_ClienteParameter = receta_Cliente != null ?
                new ObjectParameter("Receta_Cliente", receta_Cliente) :
                new ObjectParameter("Receta_Cliente", typeof(string));
    
            var codigo_SucursalParameter = codigo_Sucursal != null ?
                new ObjectParameter("Codigo_Sucursal", codigo_Sucursal) :
                new ObjectParameter("Codigo_Sucursal", typeof(string));
    
            var codigo_RecetaParameter = codigo_Receta != null ?
                new ObjectParameter("Codigo_Receta", codigo_Receta) :
                new ObjectParameter("Codigo_Receta", typeof(string));
    
            var estadoParameter = estado != null ?
                new ObjectParameter("Estado", estado) :
                new ObjectParameter("Estado", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_OrdenPreparado_Crear", codigo_OrdenParameter, fechaParameter, tecnico_FarmaceuticoParameter, receta_ClienteParameter, codigo_SucursalParameter, codigo_RecetaParameter, estadoParameter);
        }
    
        public virtual int sp_Receta_Buscar(string wHERE)
        {
            var wHEREParameter = wHERE != null ?
                new ObjectParameter("WHERE", wHERE) :
                new ObjectParameter("WHERE", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_Receta_Buscar", wHEREParameter);
        }
    
        public virtual int sp_Table_List(string tabla)
        {
            var tablaParameter = tabla != null ?
                new ObjectParameter("Tabla", tabla) :
                new ObjectParameter("Tabla", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_Table_List", tablaParameter);
        }
    
        public virtual int sp_Table_List_Codigo_Orden(string filtro)
        {
            var filtroParameter = filtro != null ?
                new ObjectParameter("filtro", filtro) :
                new ObjectParameter("filtro", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_Table_List_Codigo_Orden", filtroParameter);
        }
    
        public virtual int sp_Table_List_Nom_Receta(string filtro)
        {
            var filtroParameter = filtro != null ?
                new ObjectParameter("filtro", filtro) :
                new ObjectParameter("filtro", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_Table_List_Nom_Receta", filtroParameter);
        }
    
        public virtual int sp_Table_List_Nom_Sucursal(string filtro)
        {
            var filtroParameter = filtro != null ?
                new ObjectParameter("filtro", filtro) :
                new ObjectParameter("filtro", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_Table_List_Nom_Sucursal", filtroParameter);
        }
    
        public virtual int sp_Table_List_Todos(string tabla)
        {
            var tablaParameter = tabla != null ?
                new ObjectParameter("Tabla", tabla) :
                new ObjectParameter("Tabla", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_Table_List_Todos", tablaParameter);
        }
    
        public virtual ObjectResult<usp_Chofer_GetAll_Result> usp_Chofer_GetAll()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<usp_Chofer_GetAll_Result>("usp_Chofer_GetAll");
        }
    }
}
