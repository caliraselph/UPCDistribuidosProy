//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace upcDistribuidos.DAO
{
    using System;
    using System.Collections.Generic;
    
    public partial class tb_material
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tb_material()
        {
            this.tb_prestamo_det = new HashSet<tb_prestamo_det>();
        }
    
        public int mat_id { get; set; }
        public string mat_cod { get; set; }
        public string titulo { get; set; }
        public string autor { get; set; }
        public string año { get; set; }
        public string editorial { get; set; }
        public bool flag_sala { get; set; }
        public byte stock { get; set; }
        public int cat_id { get; set; }
        public int tip_mat_id { get; set; }
    
        public virtual tb_categoria tb_categoria { get; set; }
        public virtual tb_tipoMaterial tb_tipoMaterial { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_prestamo_det> tb_prestamo_det { get; set; }
    }
}
