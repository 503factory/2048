using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2048
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public enum Sens
        {
            haut,
            bas,
            droite,
            gauche,
            autre
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void LabelEtat_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Version 1.0");
        }

        private void NouveauJeu_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nouvelle partie");
        }

        private void Jeu_KeyDown(object sender, KeyEventArgs e)
        {
            MessageBox.Show($"touche {Direction(e)}");
        }
        private Sens Direction(KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Down:
                    {
                        return Sens.bas;
                    }
                case Keys.Up:
                    {
                        return Sens.haut;
                    }
                case Keys.Right:
                    {
                        return Sens.droite;
                    }
                case Keys.Left:
                    {
                        return Sens.gauche;
                    }
                default:
                    {
                        return Sens.autre;
                    }
            }
        }
    }
}
