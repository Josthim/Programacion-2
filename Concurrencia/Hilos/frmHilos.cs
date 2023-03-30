using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hilos
{
    public partial class frmHilos : Form
    {

        
        public frmHilos()
        {
            InitializeComponent();
        }

        private void Temporalizador_Tick(object sender, EventArgs e)
        {
            lblHoras.Text = DateTime.Now.ToLongTimeString();
        }

        Thread hiloSecundario;
        private delegate void SetValueDelegate(int prValue);

        private void SetValue_pbProgreso(int hecho)
        {
            if (pbProgreso.InvokeRequired)
            {
                SetValueDelegate delegado = new SetValueDelegate(SetValue_pbProgreso);
                pbProgreso.Invoke(delegado, new object[] {hecho});
            }
            else
            {
                pbProgreso.Value = hecho;
            }
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            btnCalcular.Enabled = false;
            numCargaCPU.Enabled = false;
            pbProgreso.Value = 0;
            //TareaSecundaria();

            // DELEGADO QUE HACE REFERENCIA AL METODO QUE TIENE QUE EJECUTAR EL HILO
            ThreadStart delegadoPS = new ThreadStart(TareaSecundaria);
            // Crear el Hilo
            hiloSecundario = new Thread(delegadoPS);
            // Ejecutar el Hilo
            hiloSecundario.Start();
        }

        private void TareaSecundaria()
        {
            int hecho = 0, tphecho = 0;

            while(hecho < numCargaCPU.Value)
            {
                hecho++;
                tphecho = (int)(hecho / numCargaCPU.Value * 100);
                if(tphecho > pbProgreso.Value)
                {
                    //pbProgreso.Value = tphecho;
                    SetValue_pbProgreso(tphecho);
                }
            }

            MethodInvoker delegado;

            //btnCalcular.Enabled = true;
            delegado = new MethodInvoker(SetEnabled_btnCalcular);
            btnCalcular.Invoke(delegado);
            //numCargaCPU.Enabled = true;
            delegado = new MethodInvoker(SetEnabled_numCargaCPU);
            numCargaCPU.Invoke(delegado);
        }

        private void SetEnabled_numCargaCPU()
        {
            numCargaCPU.Enabled = true;
        }

        private void SetEnabled_btnCalcular()
        {
            btnCalcular.Enabled = true;
        }
    }
}
