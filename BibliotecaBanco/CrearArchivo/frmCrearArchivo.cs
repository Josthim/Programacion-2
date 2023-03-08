using BibliotecaBanco;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrearArchivo
{
    public partial class frmCrearArchivo : frmBancoUI
    {
        private StreamWriter archivoWriter;
        private FileStream Salida;
        public frmCrearArchivo()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            SaveFileDialog selectorArchivo = new SaveFileDialog();
            DialogResult resultado = selectorArchivo.ShowDialog();
            string nombreArchivo;

            selectorArchivo.CheckFileExists = false;

            if (resultado == DialogResult.Cancel)
                return;

            nombreArchivo = selectorArchivo.FileName;

            if (nombreArchivo == "" || nombreArchivo == null)
                MessageBox.Show("Nombre de Archivo Invalido", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            

            
        }
    }
}
