using ProxyAgencia;
using ProxyCuenta;
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

namespace ProyBanco_GUI.CuentaGUI
{
    public partial class CuentaMan03 : Form
    {
        // CuentaBE objCuentaBE = new CuentaBE();
        // CuentaBE objCuentaBE_Temp = new CuentaBE();
        // CuentaBL objCuentaBL = new CuentaBL();

        CuentaDC objCuentaDC = new CuentaDC();
        CuentaDC objCuentaDC_Temp = new CuentaDC();
        ServicioCuentaClient objServiceCuenta = new ServicioCuentaClient();
        ServicioAgenciaClient objServiceAgencia = new ServicioAgenciaClient();

        public CuentaMan03()
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

        private void CuentaMan03_Load(object sender, EventArgs e)
        {

            //dtpFechaApertura.MaxDate = DateTime.Now.AddDays(1);

            // Mostrar Cuenta a Actualizar
            objCuentaDC = objServiceCuenta.ConsultarCuenta(Codigo);
            objCuentaDC_Temp = objServiceCuenta.ConsultarCuenta(Codigo);

            lblNumCuenIng.Text = objCuentaDC.Num_Cuen;
            txtCodCli.Text = objCuentaDC.Cod_Cli;

            try
            {
                cboAgencia.DataSource = objServiceAgencia.ListarAgencia();
                cboAgencia.ValueMember = "Cod_Age";
                cboAgencia.DisplayMember = "Nom_Age";
                cboAgencia.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

            mskSaldo.Text = Convert.ToString(objCuentaDC.Sal_Cuen);

            switch (objCuentaDC.Tip_Mon)
            {
                case 1:
                    optSoles.Checked = true;
                    break;
                case 2:
                    optDolares.Checked = true;
                    break;
            }

            switch (objCuentaDC.Tipo)
            {
                case 1:
                    optCorriente.Checked = true;
                    break;
                case 2:
                    optAhorro.Checked = true;
                    break;
            }



            chkActivo.Checked = Convert.ToBoolean(objCuentaDC.Est_Cuen);
        }


        // Función que evita que se hagan falsas modificaciones
        private bool VerificarCambios(Int16 tipoMoneda, Int16 tipo)
        {

            if (txtCodCli.Text.Trim() != objCuentaDC_Temp.Cod_Cli ||
                cboAgencia.SelectedValue.ToString() != objCuentaDC_Temp.Cod_Age ||
                Convert.ToString(mskSaldo.Text.Trim()) != Convert.ToString(objCuentaDC_Temp.Sal_Cuen) ||
                tipoMoneda != objCuentaDC_Temp.Tip_Mon ||
                tipo != objCuentaDC_Temp.Tipo ||
                Convert.ToInt16(chkActivo.Checked) != objCuentaDC_Temp.Est_Cuen)
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
                if (txtCodCli.Text.Trim() == String.Empty)
                {
                    throw new Exception("El Código del cliente es obligatorio.");
                }

                if (txtCodCli.Text.Trim().Length < 4 || txtCodCli.Text.Trim().Length > 4)
                {
                    throw new Exception("El Código del Cliente debe tener 4 Caracteres.");
                }

                // Definición
                Int16 tipoMoneda;
                if (optSoles.Checked)
                {
                    tipoMoneda = 1;
                }
                else
                {
                    tipoMoneda = 2;
                }

                Int16 tipoCuenta;
                if (optCorriente.Checked)
                {
                    tipoCuenta = 1;
                }
                else
                {
                    tipoCuenta = 2;
                }

                if (VerificarCambios(tipoMoneda, tipoCuenta))
                {
                    throw new Exception("No se ha hecho ningún cambio.");
                }

                // Insertamos
                objCuentaDC.Tip_Mon = tipoMoneda;
                objCuentaDC.Sal_Cuen = Convert.ToSingle(mskSaldo.Text.Trim());
                objCuentaDC.Tipo = tipoCuenta;
                objCuentaDC.Cod_Cli = txtCodCli.Text.Trim();
                objCuentaDC.Cod_Age = cboAgencia.SelectedValue.ToString();
                objCuentaDC.Est_Cuen = Convert.ToInt16(chkActivo.Checked);

                objCuentaDC.Usu_Ult_Mod = clsCredenciales.Usuario;

                // Enviamos los datos...
                if (objServiceCuenta.ActualizarCuenta(objCuentaDC))
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

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}