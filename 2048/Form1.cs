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
        private int _score = 0;
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
                $"C:\\Users\\{ Environment.UserName}\\Desktop\\2048.log";
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
            _case = new int[4, 4];
            _case[2, 0] = 4;
            _case[1, 1] = 2;
            _case[3, 3] = 2;
            Affiche();
        }

        private void Jeu_KeyDown(object sender, KeyEventArgs e)
        {
            Sens touche = Direction(e);
            MessageEtat($"touche {touche}");
            (bool changement, int points) = Bouge(touche);
            if (changement)
            {
                _score += points;
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
            LabelScore.Text = _score.ToString();
        }

        private (bool, int) Bouge(Sens s)
        {
            bool changement = false;
            int points = 0;
            bool[,] fusion = new bool[4, 4];

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
                                    if ((_case[k + 1, j] == 0)
                                    || (!fusion[k + 1, j] && (_case[k + 1, j] == _case[i, j])))
                                    { liberte = k + 1; }
                                    k += 1;
                                } while ((k < 3) && (_case[k, j] == 0));
                                if (liberte !=i)
                                {
                                    if (_case[liberte, j] == 0)
                                    {
                                        _case[liberte, j] = _case[i, j];
                                    }
                                    else {
                                        _case[liberte, j] *= 2;
                                        points += _case[liberte, j];
                                        fusion[liberte, j] = true;
                                         }


                                    _case[i, j] = 0;
                                    changement = true;
                                    Logs.Info($"déplacement à {s} : {_case[i, j]} de {i},{j}");
                                }
                            }
                        }
                    }
                    return (changement,points);

                case Sens.gauche:
                    // pour chaque ligne
                    for (int j = 0; j <= 3; j++)
                    {
                        // pour chaque colonne
                        for (int i = 1; i <= 3; i++)
                        {
                            if (_case[i, j] != 0)
                            {
                                //avancer tant que possible
                                int k = i;
                                int liberte = i;
                                do
                                {
                                    if (_case[k - 1, j] == 0) { liberte = k - 1; }
                                    k -= 1;
                                } while ((k > 0) && (_case[k, j] == 0));
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
                    return (changement, points);

                case Sens.bas:
                    // pour chaque ligne
                    for (int i = 0; i <= 3; i++)
                    {
                        // pour chaque colonne
                        for (int j = 2;j >= 0; j--)
                        {
                            if (_case[i, j] != 0)
                            {
                                //avancer tant que possible
                                int k = j;
                                int liberte = j;
                                do
                                {
                                    if (_case[i,k+1] == 0) { liberte = k + 1; }
                                    k += 1;
                                } while ((k < 3) && (_case[i,k] == 0));
                                if (liberte != j)
                                {
                                    _case[i,liberte] = _case[i, j];
                                    _case[i, j] = 0;
                                    changement = true;
                                    Logs.Info($"déplacement à {s} : {_case[i, j]} de {i},{j}");
                                }
                            }
                        }
                    }
                    return (changement, points);

                case Sens.haut:
                    // pour chaque ligne
                    for (int i = 0; i <= 3; i++)
                    {
                        // pour chaque colonne
                        for (int j = 1; j <= 3; j++)
                        {
                            if (_case[i, j] != 0)
                            {
                                //avancer tant que possible
                                int k =j;
                                int liberte = j;
                                do
                                {
                                    if (_case[i,k - 1] == 0) { liberte = k - 1; }
                                    k -= 1;
                                } while ((k > 0) && (_case[i,k] == 0));
                                if (liberte != j)
                                {
                                    _case[i,liberte] = _case[i, j];
                                    _case[i, j] = 0;
                                    changement = true;
                                    Logs.Info($"déplacement à {s} : {_case[i, j]} de {i},{j}");
                                }
                            }
                        }
                    }
                    return (changement, points);
            }
            return (changement, points);
        }
    }
}
    