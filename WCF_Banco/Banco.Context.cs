﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class BancoEntities : DbContext
    {
        public BancoEntities()
            : base("name=BancoEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Tb_Agencia> Tb_Agencia { get; set; }
        public virtual DbSet<Tb_Cliente> Tb_Cliente { get; set; }
        public virtual DbSet<Tb_Cuenta> Tb_Cuenta { get; set; }
        public virtual DbSet<Tb_Empleado> Tb_Empleado { get; set; }
        public virtual DbSet<Tb_Pago> Tb_Pago { get; set; }
        public virtual DbSet<Tb_Prestamo> Tb_Prestamo { get; set; }
        public virtual DbSet<Tb_Seguro> Tb_Seguro { get; set; }
        public virtual DbSet<Tb_Transferencia> Tb_Transferencia { get; set; }
        public virtual DbSet<Tb_Ubigeo> Tb_Ubigeo { get; set; }
        public virtual DbSet<Tb_Usuario> Tb_Usuario { get; set; }
        public virtual DbSet<vw_VistaEmpleados> vw_VistaEmpleados { get; set; }
        public virtual DbSet<vw_VistaPrestamo> vw_VistaPrestamo { get; set; }
    
        public virtual int usp_ActualizarEmpleado(string cod_Emp, string num_doc_Emp, string tip_doc_Emp, string nom_Emp, string ape_pat_Emp, string ape_mat_Emp, string tel_Emp, string cor_Emp, byte[] img_Emp, string id_Ubigeo, string est_Emp, string usu_Ult_Mod)
        {
            var cod_EmpParameter = cod_Emp != null ?
                new ObjectParameter("Cod_Emp", cod_Emp) :
                new ObjectParameter("Cod_Emp", typeof(string));
    
            var num_doc_EmpParameter = num_doc_Emp != null ?
                new ObjectParameter("Num_doc_Emp", num_doc_Emp) :
                new ObjectParameter("Num_doc_Emp", typeof(string));
    
            var tip_doc_EmpParameter = tip_doc_Emp != null ?
                new ObjectParameter("Tip_doc_Emp", tip_doc_Emp) :
                new ObjectParameter("Tip_doc_Emp", typeof(string));
    
            var nom_EmpParameter = nom_Emp != null ?
                new ObjectParameter("Nom_Emp", nom_Emp) :
                new ObjectParameter("Nom_Emp", typeof(string));
    
            var ape_pat_EmpParameter = ape_pat_Emp != null ?
                new ObjectParameter("Ape_pat_Emp", ape_pat_Emp) :
                new ObjectParameter("Ape_pat_Emp", typeof(string));
    
            var ape_mat_EmpParameter = ape_mat_Emp != null ?
                new ObjectParameter("Ape_mat_Emp", ape_mat_Emp) :
                new ObjectParameter("Ape_mat_Emp", typeof(string));
    
            var tel_EmpParameter = tel_Emp != null ?
                new ObjectParameter("Tel_Emp", tel_Emp) :
                new ObjectParameter("Tel_Emp", typeof(string));
    
            var cor_EmpParameter = cor_Emp != null ?
                new ObjectParameter("Cor_Emp", cor_Emp) :
                new ObjectParameter("Cor_Emp", typeof(string));
    
            var img_EmpParameter = img_Emp != null ?
                new ObjectParameter("Img_Emp", img_Emp) :
                new ObjectParameter("Img_Emp", typeof(byte[]));
    
            var id_UbigeoParameter = id_Ubigeo != null ?
                new ObjectParameter("Id_Ubigeo", id_Ubigeo) :
                new ObjectParameter("Id_Ubigeo", typeof(string));
    
            var est_EmpParameter = est_Emp != null ?
                new ObjectParameter("Est_Emp", est_Emp) :
                new ObjectParameter("Est_Emp", typeof(string));
    
            var usu_Ult_ModParameter = usu_Ult_Mod != null ?
                new ObjectParameter("Usu_Ult_Mod", usu_Ult_Mod) :
                new ObjectParameter("Usu_Ult_Mod", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("usp_ActualizarEmpleado", cod_EmpParameter, num_doc_EmpParameter, tip_doc_EmpParameter, nom_EmpParameter, ape_pat_EmpParameter, ape_mat_EmpParameter, tel_EmpParameter, cor_EmpParameter, img_EmpParameter, id_UbigeoParameter, est_EmpParameter, usu_Ult_ModParameter);
        }
    
        public virtual ObjectResult<usp_ConsultarEmpleado_Result> usp_ConsultarEmpleado(string codigo)
        {
            var codigoParameter = codigo != null ?
                new ObjectParameter("codigo", codigo) :
                new ObjectParameter("codigo", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<usp_ConsultarEmpleado_Result>("usp_ConsultarEmpleado", codigoParameter);
        }
    
        public virtual int usp_EliminarEmpleado(string codigo)
        {
            var codigoParameter = codigo != null ?
                new ObjectParameter("codigo", codigo) :
                new ObjectParameter("codigo", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("usp_EliminarEmpleado", codigoParameter);
        }
    
        public virtual int usp_InsertarEmpleado(string num_doc_Emp, string tip_doc_Emp, string nom_Emp, string ape_pat_Emp, string ape_mat_Emp, string tel_Emp, string cor_Emp, byte[] img_Emp, string id_Ubigeo, string est_Emp, string usu_Registro)
        {
            var num_doc_EmpParameter = num_doc_Emp != null ?
                new ObjectParameter("Num_doc_Emp", num_doc_Emp) :
                new ObjectParameter("Num_doc_Emp", typeof(string));
    
            var tip_doc_EmpParameter = tip_doc_Emp != null ?
                new ObjectParameter("Tip_doc_Emp", tip_doc_Emp) :
                new ObjectParameter("Tip_doc_Emp", typeof(string));
    
            var nom_EmpParameter = nom_Emp != null ?
                new ObjectParameter("Nom_Emp", nom_Emp) :
                new ObjectParameter("Nom_Emp", typeof(string));
    
            var ape_pat_EmpParameter = ape_pat_Emp != null ?
                new ObjectParameter("Ape_pat_Emp", ape_pat_Emp) :
                new ObjectParameter("Ape_pat_Emp", typeof(string));
    
            var ape_mat_EmpParameter = ape_mat_Emp != null ?
                new ObjectParameter("Ape_mat_Emp", ape_mat_Emp) :
                new ObjectParameter("Ape_mat_Emp", typeof(string));
    
            var tel_EmpParameter = tel_Emp != null ?
                new ObjectParameter("Tel_Emp", tel_Emp) :
                new ObjectParameter("Tel_Emp", typeof(string));
    
            var cor_EmpParameter = cor_Emp != null ?
                new ObjectParameter("Cor_Emp", cor_Emp) :
                new ObjectParameter("Cor_Emp", typeof(string));
    
            var img_EmpParameter = img_Emp != null ?
                new ObjectParameter("Img_Emp", img_Emp) :
                new ObjectParameter("Img_Emp", typeof(byte[]));
    
            var id_UbigeoParameter = id_Ubigeo != null ?
                new ObjectParameter("Id_Ubigeo", id_Ubigeo) :
                new ObjectParameter("Id_Ubigeo", typeof(string));
    
            var est_EmpParameter = est_Emp != null ?
                new ObjectParameter("Est_Emp", est_Emp) :
                new ObjectParameter("Est_Emp", typeof(string));
    
            var usu_RegistroParameter = usu_Registro != null ?
                new ObjectParameter("Usu_Registro", usu_Registro) :
                new ObjectParameter("Usu_Registro", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("usp_InsertarEmpleado", num_doc_EmpParameter, tip_doc_EmpParameter, nom_EmpParameter, ape_pat_EmpParameter, ape_mat_EmpParameter, tel_EmpParameter, cor_EmpParameter, img_EmpParameter, id_UbigeoParameter, est_EmpParameter, usu_RegistroParameter);
        }
    
        public virtual ObjectResult<usp_ListarEmpleado_Result> usp_ListarEmpleado()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<usp_ListarEmpleado_Result>("usp_ListarEmpleado");
        }
    
        public virtual ObjectResult<usp_ListarPrestamos_Cli_Emp_Result> usp_ListarPrestamos_Cli_Emp(string cod_Cli, string cod_Emp)
        {
            var cod_CliParameter = cod_Cli != null ?
                new ObjectParameter("Cod_Cli", cod_Cli) :
                new ObjectParameter("Cod_Cli", typeof(string));
    
            var cod_EmpParameter = cod_Emp != null ?
                new ObjectParameter("Cod_Emp", cod_Emp) :
                new ObjectParameter("Cod_Emp", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<usp_ListarPrestamos_Cli_Emp_Result>("usp_ListarPrestamos_Cli_Emp", cod_CliParameter, cod_EmpParameter);
        }
    
        public virtual int usp_ActualizarCliente(string cod_Cli, string num_doc_Cli, string tip_doc_Cli, string nom_Cli, string ape_pat_Cli, string ape_mat_Cli, string tel_Cli, string cor_Cli, string dir_Cli, Nullable<System.DateTime> fec_nac_Cli, string id_Ubigeo, string est_Cli, string usu_Ult_Mod)
        {
            var cod_CliParameter = cod_Cli != null ?
                new ObjectParameter("Cod_Cli", cod_Cli) :
                new ObjectParameter("Cod_Cli", typeof(string));
    
            var num_doc_CliParameter = num_doc_Cli != null ?
                new ObjectParameter("Num_doc_Cli", num_doc_Cli) :
                new ObjectParameter("Num_doc_Cli", typeof(string));
    
            var tip_doc_CliParameter = tip_doc_Cli != null ?
                new ObjectParameter("Tip_doc_Cli", tip_doc_Cli) :
                new ObjectParameter("Tip_doc_Cli", typeof(string));
    
            var nom_CliParameter = nom_Cli != null ?
                new ObjectParameter("Nom_Cli", nom_Cli) :
                new ObjectParameter("Nom_Cli", typeof(string));
    
            var ape_pat_CliParameter = ape_pat_Cli != null ?
                new ObjectParameter("Ape_pat_Cli", ape_pat_Cli) :
                new ObjectParameter("Ape_pat_Cli", typeof(string));
    
            var ape_mat_CliParameter = ape_mat_Cli != null ?
                new ObjectParameter("Ape_mat_Cli", ape_mat_Cli) :
                new ObjectParameter("Ape_mat_Cli", typeof(string));
    
            var tel_CliParameter = tel_Cli != null ?
                new ObjectParameter("Tel_Cli", tel_Cli) :
                new ObjectParameter("Tel_Cli", typeof(string));
    
            var cor_CliParameter = cor_Cli != null ?
                new ObjectParameter("Cor_Cli", cor_Cli) :
                new ObjectParameter("Cor_Cli", typeof(string));
    
            var dir_CliParameter = dir_Cli != null ?
                new ObjectParameter("Dir_Cli", dir_Cli) :
                new ObjectParameter("Dir_Cli", typeof(string));
    
            var fec_nac_CliParameter = fec_nac_Cli.HasValue ?
                new ObjectParameter("Fec_nac_Cli", fec_nac_Cli) :
                new ObjectParameter("Fec_nac_Cli", typeof(System.DateTime));
    
            var id_UbigeoParameter = id_Ubigeo != null ?
                new ObjectParameter("Id_Ubigeo", id_Ubigeo) :
                new ObjectParameter("Id_Ubigeo", typeof(string));
    
            var est_CliParameter = est_Cli != null ?
                new ObjectParameter("Est_Cli", est_Cli) :
                new ObjectParameter("Est_Cli", typeof(string));
    
            var usu_Ult_ModParameter = usu_Ult_Mod != null ?
                new ObjectParameter("Usu_Ult_Mod", usu_Ult_Mod) :
                new ObjectParameter("Usu_Ult_Mod", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("usp_ActualizarCliente", cod_CliParameter, num_doc_CliParameter, tip_doc_CliParameter, nom_CliParameter, ape_pat_CliParameter, ape_mat_CliParameter, tel_CliParameter, cor_CliParameter, dir_CliParameter, fec_nac_CliParameter, id_UbigeoParameter, est_CliParameter, usu_Ult_ModParameter);
        }
    
        public virtual ObjectResult<usp_ConsultarCliente_Result> usp_ConsultarCliente(string codigo)
        {
            var codigoParameter = codigo != null ?
                new ObjectParameter("codigo", codigo) :
                new ObjectParameter("codigo", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<usp_ConsultarCliente_Result>("usp_ConsultarCliente", codigoParameter);
        }
    
        public virtual ObjectResult<usp_ConsultarClienteDNI_Result> usp_ConsultarClienteDNI(string dNI)
        {
            var dNIParameter = dNI != null ?
                new ObjectParameter("DNI", dNI) :
                new ObjectParameter("DNI", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<usp_ConsultarClienteDNI_Result>("usp_ConsultarClienteDNI", dNIParameter);
        }
    
        public virtual int usp_EliminarCliente(string codigo)
        {
            var codigoParameter = codigo != null ?
                new ObjectParameter("codigo", codigo) :
                new ObjectParameter("codigo", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("usp_EliminarCliente", codigoParameter);
        }
    
        public virtual int usp_InsertarCliente(string num_doc_Cli, string tip_doc_Cli, string nom_Cli, string ape_pat_Cli, string ape_mat_Cli, string tel_Cli, string cor_Cli, string dir_Cli, Nullable<System.DateTime> fec_nac_Cli, string id_Ubigeo, string est_Cli, string usu_Registro)
        {
            var num_doc_CliParameter = num_doc_Cli != null ?
                new ObjectParameter("Num_doc_Cli", num_doc_Cli) :
                new ObjectParameter("Num_doc_Cli", typeof(string));
    
            var tip_doc_CliParameter = tip_doc_Cli != null ?
                new ObjectParameter("Tip_doc_Cli", tip_doc_Cli) :
                new ObjectParameter("Tip_doc_Cli", typeof(string));
    
            var nom_CliParameter = nom_Cli != null ?
                new ObjectParameter("Nom_Cli", nom_Cli) :
                new ObjectParameter("Nom_Cli", typeof(string));
    
            var ape_pat_CliParameter = ape_pat_Cli != null ?
                new ObjectParameter("Ape_pat_Cli", ape_pat_Cli) :
                new ObjectParameter("Ape_pat_Cli", typeof(string));
    
            var ape_mat_CliParameter = ape_mat_Cli != null ?
                new ObjectParameter("Ape_mat_Cli", ape_mat_Cli) :
                new ObjectParameter("Ape_mat_Cli", typeof(string));
    
            var tel_CliParameter = tel_Cli != null ?
                new ObjectParameter("Tel_Cli", tel_Cli) :
                new ObjectParameter("Tel_Cli", typeof(string));
    
            var cor_CliParameter = cor_Cli != null ?
                new ObjectParameter("Cor_Cli", cor_Cli) :
                new ObjectParameter("Cor_Cli", typeof(string));
    
            var dir_CliParameter = dir_Cli != null ?
                new ObjectParameter("Dir_Cli", dir_Cli) :
                new ObjectParameter("Dir_Cli", typeof(string));
    
            var fec_nac_CliParameter = fec_nac_Cli.HasValue ?
                new ObjectParameter("Fec_nac_Cli", fec_nac_Cli) :
                new ObjectParameter("Fec_nac_Cli", typeof(System.DateTime));
    
            var id_UbigeoParameter = id_Ubigeo != null ?
                new ObjectParameter("Id_Ubigeo", id_Ubigeo) :
                new ObjectParameter("Id_Ubigeo", typeof(string));
    
            var est_CliParameter = est_Cli != null ?
                new ObjectParameter("Est_Cli", est_Cli) :
                new ObjectParameter("Est_Cli", typeof(string));
    
            var usu_RegistroParameter = usu_Registro != null ?
                new ObjectParameter("Usu_Registro", usu_Registro) :
                new ObjectParameter("Usu_Registro", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("usp_InsertarCliente", num_doc_CliParameter, tip_doc_CliParameter, nom_CliParameter, ape_pat_CliParameter, ape_mat_CliParameter, tel_CliParameter, cor_CliParameter, dir_CliParameter, fec_nac_CliParameter, id_UbigeoParameter, est_CliParameter, usu_RegistroParameter);
        }
    
        public virtual ObjectResult<usp_ListarCliente_Result> usp_ListarCliente()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<usp_ListarCliente_Result>("usp_ListarCliente");
        }
    }
}
