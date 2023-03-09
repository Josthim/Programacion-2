using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BibliotecaBanco;

namespace LeerArchivo
{
    public partial class frmLeerArchivo : frmBancoUI
    {
        private FileStream entrada; // mantiene la conexion a un archivo
        private StreamReader archivoReader; // Lee datos de un archivo e texto
        public frmLeerArchivo()
        {
            InitializeComponent();
        }

        private void frmLeerArchivo_Load(object sender, EventArgs e)
        {

        }
        
        private void btnAbrir_Click(object sender, EventArgs e)
        {
            // crea un cuadro de dialogo que permite el usuario abrir el archivo
            OpenFileDialog selectorArchivo = new OpenFileDialog();
            DialogResult resultado = selectorArchivo.ShowDialog();
            string nombreArchivo; // nombre de los archivos que contienen los datos

            //sale del manejador de eventos si el usuario hace clic en cancelar
            if(resultado == DialogResult.Cancel)
                return;

            nombreArchivo = selectorArchivo.FileName; //obtiene el nombre del archivo espesificado
            LimpiarControlesTexBox();

            //muestra error si el usuario espesifica un archivo inválido
            if(nombreArchivo == "" || nombreArchivo == null)
                MessageBox.Show("Nombre del archivo inválido", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);

            else
            {
                try
                {
                    //crea el objeto FileStream para obtener acceso de lectura del archivo
                    entrada = new FileStream(nombreArchivo, FileMode.Open, FileAccess.Read);

                    //establece el archivo del que se van a leer los datos
                    archivoReader = new StreamReader(entrada);

                    btnAbrir.Enabled = false;
                    btnSiguiente.Enabled = true;
                }
                catch (IOException)
                {
                    MessageBox.Show("Error al abrir el archivo", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            try
            {
                // obtiene el siguiente registro disponible en el archivo
                string registroEntrada = archivoReader.ReadLine();
                string[] camposEntrada; // almacena partes individuales  de datos 

                if (registroEntrada != null)
                {
                    camposEntrada = registroEntrada.Split(',');
                    Registro registro = new Registro(Convert.ToInt32(camposEntrada[0]), camposEntrada[1], camposEntrada[2],
                        Convert.ToDecimal(camposEntrada[3]));

                    //copia  los valores del arreglo string a los valores de los controles TextBox
                    EstablecerValoresControlesTextBox(camposEntrada);
                }
                else
                {
                    archivoReader.Close(); // Cierra StreamReader
                    entrada.Close(); // Cierra  FileStream si no hay registro en el archivo
                    btnAbrir.Enabled = true;
                    btnSiguiente.Enabled = false;
                    LimpiarControlesTexBox();

                    //notifica al usuario que no hay mas registro en el archivo
                    MessageBox.Show("No hay mas registro en el archivo", "",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (IOException)
            {
                MessageBox.Show("Error al leer el archivo", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            
        }
    }
}
