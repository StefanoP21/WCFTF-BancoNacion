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
    
    public partial class Tb_Transferencia
    {
        public string Cod_Tran { get; set; }
        public decimal Mon_Tran { get; set; }
        public string Cuen_Dest { get; set; }
        public string Cuen_Orig { get; set; }
        public Nullable<int> Tran_Int { get; set; }
        public Nullable<System.DateTime> Fec_Tran { get; set; }
    
        public virtual Tb_Cuenta Tb_Cuenta { get; set; }
    }
}
