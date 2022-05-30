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
    public partial class Jugar : Form
    {

        public Jugar()
        {
            InitializeComponent();
        }

        private void btnNiIdea_Click(object sender, EventArgs e)
        {

        }

        private void btnEstoySeguro_Click(object sender, EventArgs e)
        {
            if (comboBoxRespuestas.SelectedItem.ToString() == "Madrid")
            {
                MessageBox.Show("Has Acertado, has ganado un total de " + );
            }
            else
            {
                MessageBox.Show("Has fallado");
            }
        }
    }
}
