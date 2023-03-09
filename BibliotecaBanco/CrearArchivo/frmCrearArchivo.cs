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
            else
            {
                //guarda el archivo mediante el objeto FileStream, si el usuario especifico un archivo válido

                try
                {
                    //abre el archivo con acceso de escritura
                    Salida = new FileStream(nombreArchivo, FileMode.OpenOrCreate, FileAccess.Write);

                    //establece el archivo para escribir los datos
                    archivoWriter = new StreamWriter(Salida);

                    //deshabilita el boton guardar y habilita el boton entrar
                    btnGuardar.Enabled = false;
                    btnEntrar.Enabled = true;
                }
                //Maneja la excepcion si hay un problema al abrir el archivo
                catch (IOException)
                {
                    //notifica al usuario si el archivo no existe
                    MessageBox.Show("Error al abrir el archivo", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            
        }
        // manejador de eventos para el boton Salir
        private void btnSalir_Click(object sender, EventArgs e)
        {
            //determina si el archivo existe o no
            if(Salida != null)
            {
                try
                {
                    archivoWriter.Close();
                    Salida.Close();
                }
                //notifica al usuario del error al cerrar el archivo
                catch (IOException)
                {
                    MessageBox.Show("No se puede cerrar el archivo", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            Application.Exit();
        }

        private void frmCrearArchivo_Load(object sender, EventArgs e)
        {

        }
        // manejador de eventos para el boton Entrar
        private void btnEntrar_Click(object sender, EventArgs e)
        {
            // almacena el arreglo string de valores de los controles TextBox
            string[] valores = ObtenerValoresControlesTextBox();

            //registro que contiene los valores de los controles de TextBox
            Registro registro = new Registro();

            // determina si el campo del control TextBox esta vacio
            if(valores[(int)IndicesTextBos.CUENTA] != "")
            {
                try
                {

                    // Obtiene el valor del numero de cuenta del control TextBox
                    int numeroCuenta = int.Parse(valores[(int)IndicesTextBos.CUENTA]);

                    if (numeroCuenta > 0)
                    {
                        //almacena los campos TextBox en Registro
                        registro.Cuenta = numeroCuenta;
                        registro.PrimerNombre = valores[(int)IndicesTextBos.NOMBRE];
                        registro.ApellidoPaterno = valores[(int)IndicesTextBos.APELLIDO];
                        registro.Saldo = decimal.Parse(valores[(int)IndicesTextBos.SALDO]);

                        //escribe el Registro al archivo, los campos separados por comas
                        archivoWriter.WriteLine(registro.Cuenta + "," +
                            registro.PrimerNombre + "," + registro.ApellidoPaterno +
                            "," + registro.Saldo);
                    }
                    else
                    {
                        //notifica al usuario si el numero de cuenta es valido
                        MessageBox.Show("Número de cuenta inválido", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (IOException)
                {
                    MessageBox.Show("Error al escribir en archivo", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    
                }
                catch (FormatException)
                {
                    MessageBox.Show("Formato inválido", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            LimpiarControlesTexBox();
        }
    }
}
