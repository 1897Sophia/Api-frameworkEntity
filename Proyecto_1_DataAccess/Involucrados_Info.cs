//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Proyecto_1_DataAccess
{
    using System;
    using System.Collections.Generic;
    
    public partial class Involucrados_Info
    {
        public int IdInvolucradoInfo { get; set; }
        public Nullable<int> IdInvolucrado { get; set; }
        public Nullable<int> IdRol { get; set; }
        public Nullable<int> IdPelicula { get; set; }
        public int OrdenAparicion { get; set; }
    
        public virtual Involucrados Involucrados { get; set; }
        public virtual Involucrados Involucrados1 { get; set; }
        public virtual Peliculas Peliculas { get; set; }
        public virtual Peliculas Peliculas1 { get; set; }
        public virtual Roles Roles { get; set; }
        public virtual Roles Roles1 { get; set; }
    }
}