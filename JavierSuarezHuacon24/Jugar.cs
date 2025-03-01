﻿using JavierSuarezHuacon24.models;
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

        QuestionModel res;
        public Jugar()
        {
            InitializeComponent();
            res = new QuestionModel();
        }

        private void btnNiIdea_Click(object sender, EventArgs e)
        {
            AñadirPreguntasRespuestas a = new AñadirPreguntasRespuestas();
            MessageBox.Show("Has fallado, te restamos -2 puntos");
            a.Show();
            this.Hide();
        }

        private void btnEstoySeguro_Click(object sender, EventArgs e)
        {
            //res.Value =
            if (comboBoxRespuestas.SelectedItem.ToString() == "Madrid")
            {
                MessageBox.Show("Has Acertado, has ganado un total de " + res.Value);
            }
            else
            {
                MessageBox.Show("Has fallado.");
            }
        }
    }
}
