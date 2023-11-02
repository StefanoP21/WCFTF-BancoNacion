using ProxyCliente;
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
    public partial class ClienteMan03 : Form
    {
        // ClienteBE objClienteBE = new ClienteBE();
        // ClienteBE objClienteBE_Temp = new ClienteBE();
        // ClienteBL objClienteBL = new ClienteBL();

        ClienteDC objClienteDC = new ClienteDC();
        ClienteDC objClienteDC_Temp = new ClienteDC();
        ServicioClienteClient objServiceCliente = new ServicioClienteClient();

        public ClienteMan03()
        {
            InitializeComponent();
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

        public String Codigo { get; set; }

        private void ClienteMan03_Load(object sender, EventArgs e)
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

            // Mostrar Cliente a Actualizar
            objClienteDC = objServiceCliente.ConsultarCliente(Codigo);
            objClienteDC_Temp = objServiceCliente.ConsultarCliente(Codigo);

            lblCodigoIng.Text = objClienteDC.Cod_Cli;
            txtNombre.Text = objClienteDC.Nom_Cli;
            txtApellidoP.Text = objClienteDC.Ape_pat_Cli;
            txtApellidoM.Text = objClienteDC.Ape_mat_Cli;
            txtTelefono.Text = objClienteDC.Tel_Cli;
            txtCorreo.Text = objClienteDC.Cor_Cli;
            txtDireccion.Text = objClienteDC.Dir_Cli;
            switch (objClienteDC.Tip_doc_Cli)
            {
                case 1:
                    optDNI.Checked = true;
                    break;
                case 2:
                    optCarnet.Checked = true;
                    break;
                case 3:
                    optPasaporte.Checked = true;
                    break;
            }
            dtpAnioNacimiento.Value = objClienteDC.Fec_nac_Cli;
            txtDocumento.Text = objClienteDC.Num_doc_Cli;
            String Id_Ubigeo = objClienteDC.Id_Ubigeo;
            CargarUbigeo(Id_Ubigeo.Substring(0, 2), Id_Ubigeo.Substring(2, 2), Id_Ubigeo.Substring(4, 2));
            chkActivo.Checked = Convert.ToBoolean(objClienteDC.Est_Cli);
        }

        private void CargarUbigeo(String IdDep, String IdProv, String IdDist)
        {
            ServicioUbigeoClient objServiceUbigeo = new ServicioUbigeoClient();

            cboDepartamento.DataSource = objServiceUbigeo.Ubigeo_Departamentos();
            cboDepartamento.ValueMember = "IdDepa";
            cboDepartamento.DisplayMember = "Departamento";
            cboDepartamento.SelectedValue = IdDep;

            cboProvincia.DataSource = objServiceUbigeo.Ubigeo_ProvinciasDepartamento(IdDep);
            cboProvincia.ValueMember = "IdProv";
            cboProvincia.DisplayMember = "Provincia";
            cboProvincia.SelectedValue = IdProv;

            cboDistrito.DataSource = objServiceUbigeo.Ubigeo_DistritosProvinciaDepartamento(IdDep, IdProv);
            cboDistrito.ValueMember = "IdDist";
            cboDistrito.DisplayMember = "Distrito";
            cboDistrito.SelectedValue = IdDist;
        }

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

        // Función que evita que se hagan falsas modificaciones
        private bool VerificarCambios(Int16 tipoDocumento)
        {
            String Id_Ubigeo = cboDepartamento.SelectedValue.ToString() +
                    cboProvincia.SelectedValue.ToString() +
                    cboDistrito.SelectedValue.ToString();

            if (txtNombre.Text.Trim() != objClienteDC_Temp.Nom_Cli ||
                txtApellidoP.Text.Trim() != objClienteDC_Temp.Ape_pat_Cli ||
                txtApellidoM.Text.Trim() != objClienteDC_Temp.Ape_mat_Cli ||
                txtTelefono.Text.Trim() != objClienteDC_Temp.Tel_Cli ||
                txtCorreo.Text.Trim() != objClienteDC_Temp.Cor_Cli ||
                txtDireccion.Text.Trim() != objClienteDC_Temp.Dir_Cli ||
                tipoDocumento != objClienteDC_Temp.Tip_doc_Cli ||
                dtpAnioNacimiento.Value != objClienteDC_Temp.Fec_nac_Cli ||
                txtDocumento.Text.Trim() != objClienteDC_Temp.Num_doc_Cli ||
                Id_Ubigeo != objClienteDC_Temp.Id_Ubigeo ||
                Convert.ToInt16(chkActivo.Checked) != objClienteDC_Temp.Est_Cli)
            {
                // Hay cambios
                return false;
            }

            // No hay cambios
            return true;
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

                if (VerificarCambios(tipoDocumento))
                {
                    throw new Exception("No se ha hecho ningún cambio.");
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

                objClienteDC.Usu_Ult_Mod = clsCredenciales.Usuario;

                // Enviamos los datos...
                if (objServiceCliente.ActualizarCliente(objClienteDC))
                {
                    this.Close();
                }
                else
                {
                    throw new Exception("No se actualizó el registro, contacte con TI.");
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