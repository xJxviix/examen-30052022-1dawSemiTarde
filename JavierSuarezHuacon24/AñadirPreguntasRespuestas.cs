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
    public partial class AñadirPreguntasRespuestas : Form
    {
        QuestionModel p;

        public AñadirPreguntasRespuestas()
        {
            InitializeComponent();
            p = new QuestionModel();

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
           
            Jugar j = new Jugar();
            j.labelPregunta.Text = textBoxPregunta.Text;
            j.comboBoxRespuestas.Items.Add(textBoxRespuestaA.Text);
            j.comboBoxRespuestas.Items.Add(textBoxRespuestaB.Text);
            j.comboBoxRespuestas.Items.Add(textBoxRespuestaC.Text);
            p.Value = Int32.Parse(textBoxValor.Text.ToString());
            j.Show();


        }
    }
}
