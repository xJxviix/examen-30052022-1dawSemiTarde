using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JavierSuarezHuacon24
{
    public partial class Form1 : Form
    {
        AñadirPreguntasRespuestas a;
        Jugar j;
        public Form1()
        {
            InitializeComponent();
            a = new AñadirPreguntasRespuestas();
            j = new Jugar();
        }

        private void btnAñadirPreguntasRespuestas_Click(object sender, EventArgs e)
        {
            a.Show();
            this.Hide();
        }

        private void btnJugar_Click(object sender, EventArgs e)
        {
            if(a.textBoxPregunta.Text == "")
            {
                a.Show();
                this.Hide();
            }
            else
            {
                j.Show();
                this.Hide();
            }
        }
    }
}
