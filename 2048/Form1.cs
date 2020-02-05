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
            log4net.GlobalContext.Properties["fichierLog"] =
                $"C:\\Users\\{ Environment.UserName}\\AppData\\Local\\temp\\2048.log";
            log4net.Config.XmlConfigurator.Configure();
            Logs.Debug("Debut du programme");
        }

        private void LabelEtat_Click(object sender, EventArgs e)
        {
            MessageEtat("Version 1.0");
        }

        private void NouveauJeu_Click(object sender, EventArgs e)
        {
            Logs.Warn("Nouvelle partie");
            MessageEtat("Nouvelle partie");
            _case[2, 0] = 4;
            _case[1, 1] = 2;
            _case[3, 3] = 2;
            Affiche();
        }

        private void Jeu_KeyDown(object sender, KeyEventArgs e)
        {
            Sens touche = Direction(e);
            MessageEtat($"touche {touche}");
            if (Bouge(touche))
            {
                _mouvements += 1;
                Affiche();
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
                          String.Format("fermeture de l'application pour {0}. Voulez-vous quitter?", e.CloseReason), "fermeture...", MessageBoxButtons.YesNo) == DialogResult.No;
            Logs.Debug("Fin du programme");
        }

        private void Affiche(int x, int y)
        {
            var ctrl = Grille.Controls.Find($"Cases{x}{y}", true)[0];
            ctrl.Text = (_case[x, y] == 0) ? "" : _case[x, y].ToString();
            var couleur = Outils.Couleurs(_case[x, y]);
            ctrl.BackColor = couleur["fond"];
            ctrl.ForeColor = couleur["fonte"];
        }
        private void Affiche()
        {
            for (int i = 0; i <= 3; i += 1)
            {
                for (int j = 0; j <= 3; j += 1)
                {
                    Affiche(i, j);
                }
            }
            LabelMouvement.Text = _mouvements.ToString();
        }

        private bool Bouge(Sens s)
        {
            bool changement = false;

            switch (s)
            {
                case Sens.droite:
                    // pour chaque ligne
                    for (int j = 0; j <= 3; j++)
                    {
                        // pour chaque colonne
                        for (int i = 2; i >= 0; i--)
                        {
                            if (_case[i, j] != 0)
                            {
                                //avancer tant que possible
                                int k = i;
                                int liberte = i;
                                do
                                {
                                    if (_case[k + 1, j] == 0) { liberte = k + 1; }
                                    k += 1;
                                } while ((k < 3) && (_case[k, j] == 0));
                                if (liberte != i)
                                {
                                    _case[liberte, j] = _case[i, j];
                                    _case[i, j] = 0;
                                    changement = true;
                                    Logs.Info($"déplacement à {s} : {_case[i, j]} de {i},{j}");
                                }
                            }
                        }
                    }
                    return changement;

                case Sens.gauche:
                    // pour chaque ligne
                    for (int j = 0; j <= 3; j++)
                    {
                        // pour chaque colonne
                        for (int i = 2; i >= 0; i--)
                        {
                            if (_case[i, j] != 0)
                            {
                                //avancer tant que possible
                                int k = i;
                                int liberte = i;
                                do
                                {
                                    if (_case[k + 1, j] == 0) { liberte = k + 1; }
                                    k += 1;
                                } while ((k < 3) && (_case[k, j] == 0));
                                if (liberte != i)
                                {
                                    _case[liberte, j] = _case[i, j];
                                    _case[i, j] = 0;
                                    changement = true;
                                    Logs.Info($"déplacement à {s} : {_case[i, j]} de {i},{j}");
                                }
                            }
                        }
                    }
                    return changement;

                case Sens.bas:
                    // pour chaque ligne
                    for (int j = 0; j <= 3; j++)
                    {
                        // pour chaque colonne
                        for (int i = 2; i >= 0; i--)
                        {
                            if (_case[i, j] != 0)
                            {
                                //avancer tant que possible
                                int k = i;
                                int liberte = i;
                                do
                                {
                                    if (_case[k + 1, j] == 0) { liberte = k + 1; }
                                    k += 1;
                                } while ((k < 3) && (_case[k, j] == 0));
                                if (liberte != i)
                                {
                                    _case[liberte, j] = _case[i, j];
                                    _case[i, j] = 0;
                                    changement = true;
                                    Logs.Info($"déplacement à {s} : {_case[i, j]} de {i},{j}");
                                }
                            }
                        }
                    }
                    return changement;

                case Sens.haut:
                    // pour chaque ligne
                    for (int j = 0; j <= 3; j++)
                    {
                        // pour chaque colonne
                        for (int i = 2; i >= 0; i--)
                        {
                            if (_case[i, j] != 0)
                            {
                                //avancer tant que possible
                                int k = i;
                                int liberte = i;
                                do
                                {
                                    if (_case[k + 1, j] == 0) { liberte = k + 1; }
                                    k += 1;
                                } while ((k < 3) && (_case[k, j] == 0));
                                if (liberte != i)
                                {
                                    _case[liberte, j] = _case[i, j];
                                    _case[i, j] = 0;
                                    changement = true;
                                    Logs.Info($"déplacement à {s} : {_case[i, j]} de {i},{j}");
                                }
                            }
                        }
                    }
                    return changement;
            }
            return changement;
        }
    }
}
    