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
        private int _mouvements = 0;
        private int[,] _case = new int[4, 4];
        
       
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
            MessageEtat("Version 1.0");
        }

        private void NouveauJeu_Click(object sender, EventArgs e)
        {
            MessageEtat("Nouvelle partie");
            LabelMouvement.Text = _mouvements.ToString();
            _case[2, 0] = 4;
            Cases20.Text = _case[2, 0].ToString();
            Cases20.BackColor = Outils.Couleurs(_case[2, 0])["fond"];
            Cases20.ForeColor = Outils.Couleurs(_case[2, 0])["fonte"];
        }

        private void Jeu_KeyDown(object sender, KeyEventArgs e)
        {
            Sens touche = Direction(e);
            MessageEtat($"touche {touche}");
            if (touche != Sens.autre)
            {
                _mouvements += 1;
                LabelMouvement.Text = _mouvements.ToString();
            }
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
        private void MessageEtat(string message)
        { LabelEtat.Text = message; }

        private void Jeu_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            e.Cancel =
                      MessageBox.Show(
                          String.Format("fermeture de l'application pour {0}. Voulez-vous quitter?" , e.CloseReason), "fermeture...", MessageBoxButtons.YesNo) == DialogResult.No;
        }
    


    }


}
