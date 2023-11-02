﻿using ProxyCliente;
using ProxyUbigeo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyBanco_GUI.ClienteGUI
{
    public partial class ClienteMan02 : Form
    {
        // ClienteBE objClienteBE = new ClienteBE();
        // ClienteBL objClienteBL = new ClienteBL();
        ServicioClienteClient objServiceCliente = new ServicioClienteClient();
        ClienteDC objClienteDC = new ClienteDC();

        public ClienteMan02()
        {
            InitializeComponent();
        }

        public ClienteMan02(string clienteDNI)
        {
            InitializeComponent();

            txtDocumento.Text = clienteDNI;
        }

        #region Configuración estética
        private void btnSalir_MouseEnter(object sender, EventArgs e)
        {
            btnSalir.ForeColor = Color.Red;
        }

        private void btnSalir_MouseLeave(object sender, EventArgs e)
        {
            btnSalir.ForeColor = Color.Black;
        }
        #endregion

        private void ClienteMan02_Load(object sender, EventArgs e)
        {
            try
            {
                CargarUbigeo("14", "01", "01");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }

            dtpAnioNacimiento.MaxDate = DateTime.Now.AddDays(1);
            dtpAnioNacimiento.Value = DateTime.Now;
        }

        private void CargarUbigeo(String IdDepa, String IdProv, String IdDist)
        {
            ServicioUbigeoClient objServiceUbigeo = new ServicioUbigeoClient();

            cboDepartamento.DataSource = objServiceUbigeo.Ubigeo_Departamentos();
            cboDepartamento.ValueMember = "IdDepa";
            cboDepartamento.DisplayMember = "Departamento";
            cboDepartamento.SelectedValue = IdDepa;

            cboProvincia.DataSource = objServiceUbigeo.Ubigeo_ProvinciasDepartamento(IdDepa);
            cboProvincia.ValueMember = "IdProv";
            cboProvincia.DisplayMember = "Provincia";
            cboProvincia.SelectedValue = IdProv;

            cboDistrito.DataSource = objServiceUbigeo.Ubigeo_DistritosProvinciaDepartamento(IdDepa, IdProv);
            cboDistrito.ValueMember = "IdDist";
            cboDistrito.DisplayMember = "Distrito";
            cboDistrito.SelectedValue = IdDist;
        }

        // Función general para detectar números
        private void DetectarNumeros(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8)
            {
                if (char.IsDigit(e.KeyChar) == false)
                {
                    e.Handled = true;
                }
            }
        }

        private void DetectarDocumento(object sender, EventArgs e)
        {
            if (optDNI.Checked)
            {
                txtDocumento.MaxLength = 8;
            }
            else
            {
                txtDocumento.MaxLength = 12;
            }
        }

        // Función para verificar el patrón de correo
        private bool VerificarCorreo(String strCorreo)
        {
            // Patrón de expresión regular para validar el formato del correo electrónico
            string patron = @"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$";

            // Verificar si el correo electrónico coincide con el patrón
            bool esValido = Regex.IsMatch(strCorreo, patron);

            return esValido;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                // Validaciones
                if (txtNombre.Text.Trim() == String.Empty)
                {
                    throw new Exception("El nombre es olbigatorio.");
                }

                if (txtApellidoP.Text.Trim() == String.Empty)
                {
                    throw new Exception("El apellido paterno es obligatorio.");
                }

                if (txtApellidoM.Text.Trim() == String.Empty)
                {
                    throw new Exception("El apellido materno es obligatorio.");
                }

                if (txtTelefono.Text.Trim() == String.Empty)
                {
                    throw new Exception("El número de telefono es obligatorio.");
                }

                if (txtTelefono.Text.Trim().Length < 9)
                {
                    throw new Exception("El número de telefono debe tener 9 digitos.");
                }

                if (txtCorreo.Text.Trim() == String.Empty)
                {
                    throw new Exception("La dirección de correo es obligatoria.");
                }

                if (!VerificarCorreo(txtCorreo.Text.Trim()))
                {
                    throw new Exception("La dirección de correo es errónea.");
                }

                if (txtDireccion.Text.Trim() == String.Empty)
                {
                    throw new Exception("La dirección es obligatoria.");
                }

                if (dtpAnioNacimiento.Value > DateTime.Now.AddYears(-18))
                {
                    throw new Exception("El cliente debe ser mayor a 18 años.");
                }

                if (txtDocumento.Text.Trim() == String.Empty)
                {
                    throw new Exception("El número de documento es obligatorio.");
                }

                if (optDNI.Checked && txtDocumento.Text.Length < 8)
                {
                    throw new Exception("El número de DNI debe tener 8 dígitos.");
                }

                if (optDNI.Checked && txtDocumento.Text.Length > 8)
                {
                    // Por si acaso
                    throw new Exception("El número de DNI solo puede tener 8 dígitos.");
                }

                if ((optCarnet.Checked || optPasaporte.Checked) && txtDocumento.Text.Length < 12)
                {
                    throw new Exception("El Carnet de Extranjería o Pasaporte debe tener 12 dígitos.");
                }

                // Definición
                Int16 tipoDocumento;
                if (optDNI.Checked)
                {
                    tipoDocumento = 1;
                }
                else if (optCarnet.Checked)
                {
                    tipoDocumento = 2;
                }
                else
                {
                    tipoDocumento = 3;
                }

                // Insertamos
                objClienteDC.Nom_Cli = txtNombre.Text.Trim();
                objClienteDC.Ape_pat_Cli = txtApellidoP.Text.Trim();
                objClienteDC.Ape_mat_Cli = txtApellidoM.Text.Trim();
                objClienteDC.Tel_Cli = txtTelefono.Text.Trim();
                objClienteDC.Cor_Cli = txtCorreo.Text.Trim();
                objClienteDC.Dir_Cli = txtDireccion.Text.Trim();
                objClienteDC.Tip_doc_Cli = tipoDocumento;
                objClienteDC.Fec_nac_Cli = dtpAnioNacimiento.Value;
                objClienteDC.Num_doc_Cli = txtDocumento.Text.Trim();
                objClienteDC.Id_Ubigeo = cboDepartamento.SelectedValue.ToString() +
                    cboProvincia.SelectedValue.ToString() +
                    cboDistrito.SelectedValue.ToString();
                objClienteDC.Est_Cli = Convert.ToInt16(chkActivo.Checked);

                objClienteDC.Usu_Registro = clsCredenciales.Usuario;

                // Enviamos los datos...
                if (objServiceCliente.InsertarCliente(objClienteDC))
                {
                    this.Close();
                }
                else
                {
                    throw new Exception("No se insertó el registro, contacte con TI.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void cboDepartamento_SelectionChangeCommitted(object sender, EventArgs e)
        {
            CargarUbigeo(cboDepartamento.SelectedValue.ToString(), "01", "01");
        }

        private void cboProvincia_SelectionChangeCommitted(object sender, EventArgs e)
        {
            CargarUbigeo(cboDepartamento.SelectedValue.ToString(), cboProvincia.SelectedValue.ToString(), "01");
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
