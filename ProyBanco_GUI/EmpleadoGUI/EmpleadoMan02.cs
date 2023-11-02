﻿using ProxyEmpleado;
using ProxyUbigeo;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyBanco_GUI.EmpleadoGUI
{
    public partial class EmpleadoMan02 : Form
    {
        // EmpleadoBE objEmpleadoBE = new EmpleadoBE();
        // EmpleadoBL objEmpleadoBL = new EmpleadoBL();
        EmpleadoDC objEmpleadoDC = new EmpleadoDC();
        ServicioEmpleadoClient objServiceEmpleado = new ServicioEmpleadoClient();

        public EmpleadoMan02()
        {
            InitializeComponent();
        }

        private void EmpleadoMan02_Load(object sender, EventArgs e)
        {
            try
            {
                CargarUbigeo("14", "01", "01");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void CargarUbigeo(String IdDepa, String IdProv, String IdDist)
        {
            // UbigeoBL objUbigeoBL = new UbigeoBL();
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

                if (pbFoto.Image == null)
                {
                    throw new Exception("La foto es obligatoria.");
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
                objEmpleadoDC.Nom_Emp = txtNombre.Text.Trim();
                objEmpleadoDC.Ape_pat_Emp = txtApellidoP.Text.Trim();
                objEmpleadoDC.Ape_mat_Emp = txtApellidoM.Text.Trim();
                objEmpleadoDC.Tel_Emp = txtTelefono.Text.Trim();
                objEmpleadoDC.Cor_Emp = txtCorreo.Text.Trim();
                objEmpleadoDC.Tip_doc_Emp = tipoDocumento;
                objEmpleadoDC.Num_doc_Emp = txtDocumento.Text.Trim();
                objEmpleadoDC.Id_Ubigeo = cboDepartamento.SelectedValue.ToString() + cboProvincia.SelectedValue.ToString() + cboDistrito.SelectedValue.ToString();
                objEmpleadoDC.Est_Emp = Convert.ToInt16(chkActivo.Checked);

                objEmpleadoDC.Img_Emp = File.ReadAllBytes(openFileDialog1.FileName);

                // Auditoría
                objEmpleadoDC.Usu_Registro = clsCredenciales.Usuario;

                // Enviamos los datos
                if (objServiceEmpleado.InsertarEmpleado(objEmpleadoDC))
                {
                    this.Close();
                }
                else
                {
                    MessageBox.Show("No se pudo guardar el registro.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        # region Configuración estética

        private void btnSalir_MouseEnter(object sender, EventArgs e)
        {
            btnSalir.ForeColor = Color.Red;
        }

        private void btnSalir_MouseLeave(object sender, EventArgs e)
        {
            btnSalir.ForeColor = Color.Black;
        }

        #endregion

        private void btnFoto_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog1.FileName = String.Empty;
                openFileDialog1.Multiselect = false;
                openFileDialog1.Filter = "Archivos de imagen (*.jpg, *.png) | *.jpg; *.png";
                openFileDialog1.ShowDialog();

                if (openFileDialog1.FileName != String.Empty)
                {
                    pbFoto.Image = Image.FromFile(openFileDialog1.FileName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
