//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WCF_Banco
{
    using System;
    using System.Collections.Generic;
    
    public partial class Tb_Cliente
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Tb_Cliente()
        {
            this.Tb_Cuenta = new HashSet<Tb_Cuenta>();
            this.Tb_Prestamo = new HashSet<Tb_Prestamo>();
            this.Tb_Seguro = new HashSet<Tb_Seguro>();
        }
    
        public string Cod_Cli { get; set; }
        public string Num_doc_Cli { get; set; }
        public string Tip_doc_Cli { get; set; }
        public string Nom_Cli { get; set; }
        public string Ape_pat_Cli { get; set; }
        public string Ape_mat_Cli { get; set; }
        public string Tel_Cli { get; set; }
        public string Cor_Cli { get; set; }
        public string Dir_Cli { get; set; }
        public System.DateTime Fec_nac_Cli { get; set; }
        public string Id_Ubigeo { get; set; }
        public string Est_Cli { get; set; }
        public string Usu_Registro { get; set; }
        public System.DateTime Fec_Registro { get; set; }
        public string Usu_Ult_Mod { get; set; }
        public Nullable<System.DateTime> Fec_Ult_Mod { get; set; }
    
        public virtual Tb_Ubigeo Tb_Ubigeo { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tb_Cuenta> Tb_Cuenta { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tb_Prestamo> Tb_Prestamo { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tb_Seguro> Tb_Seguro { get; set; }
    }
}