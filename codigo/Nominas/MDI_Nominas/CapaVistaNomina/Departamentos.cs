using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaVistaNomina
{
    public partial class Departamentos : Form
    {
        public Departamentos()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            AgregarDepto b = new AgregarDepto();
            b.Show();
        }

        private void navegador1_Load(object sender, EventArgs e)
        {
            NavegadorVista.Navegador.idApp = "6003";
            TextBox[] Grupotextbox = { txtidDerechos, txtnombrepeli };
            TextBox[] Idtextbox = { txtidDerechos, txtnombrepeli };
            navegador1.textbox = Grupotextbox;
            navegador1.tabla = dataGridDerechos;
            navegador1.textboxi = Idtextbox;
            navegador1.actual = this;
            navegador1.cargar(dataGridDerechos, Grupotextbox, "modulo_Nominas");
        }


    }
}
