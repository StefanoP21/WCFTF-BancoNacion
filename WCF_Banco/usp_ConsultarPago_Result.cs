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
    
    public partial class usp_ConsultarPago_Result
    {
        public string Codigo { get; set; }
        public string Numero_Cuota { get; set; }
        public decimal Monto { get; set; }
        public System.DateTime Fecha_Programada { get; set; }
        public System.DateTime Fecha_Real { get; set; }
        public string Codigo_Prestamo { get; set; }
        public string Estado { get; set; }
        public string Usuario_Registro { get; set; }
        public System.DateTime Fecha_Registro { get; set; }
        public string Usuario_Ultima_Modificacion { get; set; }
        public Nullable<System.DateTime> Fecha_Ultima_Modificacion { get; set; }
    }
}
