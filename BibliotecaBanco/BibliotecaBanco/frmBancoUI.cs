using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BibliotecaBanco
{
    public partial class frmBancoUI : Form
    {
        protected int CuentaTexBox = 4;

        public enum IndicesTextBos
        {
            CUENTA,
            NOMBRE,
            APELLIDO,
            SALDO
        }
        public frmBancoUI()
        {
            InitializeComponent();
        }

        public void LimpiarControlesTexBox()
        {
            for(int i = 0; i < Controls.Count; i++)
            {
                Control niControl = Controls[i];

                if(niControl is TextBox)
                {
                    niControl.Text= "";
                }
            }
        }
        public void EstablecerValoresControlesTextBox(string[] valores)
        {
            if(valores.Length != CuentaTexBox)
            {
                throw (new ArgumentException("Debe haber" +
                    (CuentaTexBox + 1) + "Objetos string en el arreglo"));
            }
            else
            {
                txtCuenta.Text = valores[(int)IndicesTextBos.CUENTA];
                txtPrimerNombre.Text = valores[(int)IndicesTextBos.NOMBRE];
                txtApellidoPaterno.Text = valores[(int)IndicesTextBos.APELLIDO];
                txtSaldo.Text = valores[(int)IndicesTextBos.SALDO];
            }
        }
        public string[] ObtenerValoresControlesTextBox()
        {
            string[] valores = new string[CuentaTexBox];

            valores[(int)IndicesTextBos.CUENTA] = txtCuenta.Text;
            valores[(int)IndicesTextBos.NOMBRE] = txtPrimerNombre.Text;
            valores[(int)IndicesTextBos.APELLIDO] = txtApellidoPaterno.Text;
            valores[(int)IndicesTextBos.SALDO] = txtSaldo.Text;

            return valores;
        }

        private void frmBancoUI_Load(object sender, EventArgs e)
        {

        }
    }
}
