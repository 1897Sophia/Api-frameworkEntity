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
    
    public partial class Comentarios
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Comentarios()
        {
            this.Comentarios1 = new HashSet<Comentarios>();
        }
    
        public int IdComentario { get; set; }
        public Nullable<int> IdPelicula { get; set; }
        public Nullable<int> IdUsuario { get; set; }
        public string ComentarioTexto { get; set; }
        public Nullable<int> IdComentarioPadre { get; set; }
        public Nullable<System.DateTime> Fecha { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Comentarios> Comentarios1 { get; set; }
        public virtual Comentarios Comentarios2 { get; set; }
        public virtual Peliculas Peliculas { get; set; }
        public virtual Usuarios Usuarios { get; set; }
    }
}
