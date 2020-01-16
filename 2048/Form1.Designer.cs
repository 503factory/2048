namespace _2048
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.LabelEtat = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.NouveauJeu = new System.Windows.Forms.ToolStripMenuItem();
            this.Grille = new System.Windows.Forms.TableLayoutPanel();
            this.Cases00 = new System.Windows.Forms.Label();
            this.Cases10 = new System.Windows.Forms.Label();
            this.Cases20 = new System.Windows.Forms.Label();
            this.Cases30 = new System.Windows.Forms.Label();
            this.Cases01 = new System.Windows.Forms.Label();
            this.Cases11 = new System.Windows.Forms.Label();
            this.Cases21 = new System.Windows.Forms.Label();
            this.Cases31 = new System.Windows.Forms.Label();
            this.Cases02 = new System.Windows.Forms.Label();
            this.Cases12 = new System.Windows.Forms.Label();
            this.Cases22 = new System.Windows.Forms.Label();
            this.Cases32 = new System.Windows.Forms.Label();
            this.Cases03 = new System.Windows.Forms.Label();
            this.Cases13 = new System.Windows.Forms.Label();
            this.Cases23 = new System.Windows.Forms.Label();
            this.Cases33 = new System.Windows.Forms.Label();
            this.TexteScore = new System.Windows.Forms.Label();
            this.LabelScore = new System.Windows.Forms.Label();
            this.TexteMouvement = new System.Windows.Forms.Label();
            this.LabelMouvement = new System.Windows.Forms.Label();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.Grille.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LabelEtat});
            this.statusStrip1.Location = new System.Drawing.Point(0, 370);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(334, 22);
            this.statusStrip1.TabIndex = 0;
            // 
            // LabelEtat
            // 
            this.LabelEtat.Name = "LabelEtat";
            this.LabelEtat.Size = new System.Drawing.Size(27, 17);
            this.LabelEtat.Text = "Etat";
            this.LabelEtat.Click += new System.EventHandler(this.LabelEtat_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NouveauJeu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(334, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // NouveauJeu
            // 
            this.NouveauJeu.Name = "NouveauJeu";
            this.NouveauJeu.Size = new System.Drawing.Size(67, 20);
            this.NouveauJeu.Text = "&Nouveau";
            this.NouveauJeu.Click += new System.EventHandler(this.NouveauJeu_Click);
            // 
            // Grille
            // 
            this.Grille.ColumnCount = 4;
            this.Grille.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.Grille.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.Grille.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.Grille.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.Grille.Controls.Add(this.Cases33, 3, 3);
            this.Grille.Controls.Add(this.Cases23, 2, 3);
            this.Grille.Controls.Add(this.Cases13, 1, 3);
            this.Grille.Controls.Add(this.Cases03, 0, 3);
            this.Grille.Controls.Add(this.Cases32, 3, 2);
            this.Grille.Controls.Add(this.Cases22, 2, 2);
            this.Grille.Controls.Add(this.Cases12, 1, 2);
            this.Grille.Controls.Add(this.Cases02, 0, 2);
            this.Grille.Controls.Add(this.Cases31, 3, 1);
            this.Grille.Controls.Add(this.Cases21, 2, 1);
            this.Grille.Controls.Add(this.Cases11, 1, 1);
            this.Grille.Controls.Add(this.Cases01, 0, 1);
            this.Grille.Controls.Add(this.Cases30, 3, 0);
            this.Grille.Controls.Add(this.Cases20, 2, 0);
            this.Grille.Controls.Add(this.Cases10, 1, 0);
            this.Grille.Controls.Add(this.Cases00, 0, 0);
            this.Grille.Location = new System.Drawing.Point(20, 54);
            this.Grille.Name = "Grille";
            this.Grille.RowCount = 4;
            this.Grille.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.Grille.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.Grille.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.Grille.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.Grille.Size = new System.Drawing.Size(300, 300);
            this.Grille.TabIndex = 2;
            // 
            // Cases00
            // 
            this.Cases00.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Cases00.BackColor = System.Drawing.Color.Red;
            this.Cases00.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cases00.Location = new System.Drawing.Point(2, 2);
            this.Cases00.Margin = new System.Windows.Forms.Padding(2);
            this.Cases00.Name = "Cases00";
            this.Cases00.Size = new System.Drawing.Size(71, 71);
            this.Cases00.TabIndex = 0;
            this.Cases00.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Cases00.UseMnemonic = false;
            // 
            // Cases10
            // 
            this.Cases10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Cases10.BackColor = System.Drawing.Color.Red;
            this.Cases10.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cases10.Location = new System.Drawing.Point(77, 2);
            this.Cases10.Margin = new System.Windows.Forms.Padding(2);
            this.Cases10.Name = "Cases10";
            this.Cases10.Size = new System.Drawing.Size(71, 71);
            this.Cases10.TabIndex = 1;
            this.Cases10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Cases10.UseMnemonic = false;
            // 
            // Cases20
            // 
            this.Cases20.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Cases20.BackColor = System.Drawing.Color.Red;
            this.Cases20.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cases20.Location = new System.Drawing.Point(152, 2);
            this.Cases20.Margin = new System.Windows.Forms.Padding(2);
            this.Cases20.Name = "Cases20";
            this.Cases20.Size = new System.Drawing.Size(71, 71);
            this.Cases20.TabIndex = 2;
            this.Cases20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Cases20.UseMnemonic = false;
            // 
            // Cases30
            // 
            this.Cases30.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Cases30.BackColor = System.Drawing.Color.Red;
            this.Cases30.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cases30.Location = new System.Drawing.Point(227, 2);
            this.Cases30.Margin = new System.Windows.Forms.Padding(2);
            this.Cases30.Name = "Cases30";
            this.Cases30.Size = new System.Drawing.Size(71, 71);
            this.Cases30.TabIndex = 3;
            this.Cases30.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Cases30.UseMnemonic = false;
            // 
            // Cases01
            // 
            this.Cases01.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Cases01.BackColor = System.Drawing.Color.Red;
            this.Cases01.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cases01.Location = new System.Drawing.Point(2, 77);
            this.Cases01.Margin = new System.Windows.Forms.Padding(2);
            this.Cases01.Name = "Cases01";
            this.Cases01.Size = new System.Drawing.Size(71, 71);
            this.Cases01.TabIndex = 4;
            this.Cases01.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Cases01.UseMnemonic = false;
            // 
            // Cases11
            // 
            this.Cases11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Cases11.BackColor = System.Drawing.Color.Red;
            this.Cases11.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cases11.Location = new System.Drawing.Point(77, 77);
            this.Cases11.Margin = new System.Windows.Forms.Padding(2);
            this.Cases11.Name = "Cases11";
            this.Cases11.Size = new System.Drawing.Size(71, 71);
            this.Cases11.TabIndex = 5;
            this.Cases11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Cases11.UseMnemonic = false;
            // 
            // Cases21
            // 
            this.Cases21.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Cases21.BackColor = System.Drawing.Color.Red;
            this.Cases21.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cases21.Location = new System.Drawing.Point(152, 77);
            this.Cases21.Margin = new System.Windows.Forms.Padding(2);
            this.Cases21.Name = "Cases21";
            this.Cases21.Size = new System.Drawing.Size(71, 71);
            this.Cases21.TabIndex = 6;
            this.Cases21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Cases21.UseMnemonic = false;
            // 
            // Cases31
            // 
            this.Cases31.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Cases31.BackColor = System.Drawing.Color.Red;
            this.Cases31.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cases31.Location = new System.Drawing.Point(227, 77);
            this.Cases31.Margin = new System.Windows.Forms.Padding(2);
            this.Cases31.Name = "Cases31";
            this.Cases31.Size = new System.Drawing.Size(71, 71);
            this.Cases31.TabIndex = 7;
            this.Cases31.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Cases31.UseMnemonic = false;
            // 
            // Cases02
            // 
            this.Cases02.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Cases02.BackColor = System.Drawing.Color.Red;
            this.Cases02.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cases02.Location = new System.Drawing.Point(2, 152);
            this.Cases02.Margin = new System.Windows.Forms.Padding(2);
            this.Cases02.Name = "Cases02";
            this.Cases02.Size = new System.Drawing.Size(71, 71);
            this.Cases02.TabIndex = 8;
            this.Cases02.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Cases02.UseMnemonic = false;
            // 
            // Cases12
            // 
            this.Cases12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Cases12.BackColor = System.Drawing.Color.Red;
            this.Cases12.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cases12.Location = new System.Drawing.Point(77, 152);
            this.Cases12.Margin = new System.Windows.Forms.Padding(2);
            this.Cases12.Name = "Cases12";
            this.Cases12.Size = new System.Drawing.Size(71, 71);
            this.Cases12.TabIndex = 9;
            this.Cases12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Cases12.UseMnemonic = false;
            // 
            // Cases22
            // 
            this.Cases22.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Cases22.BackColor = System.Drawing.Color.Red;
            this.Cases22.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cases22.Location = new System.Drawing.Point(152, 152);
            this.Cases22.Margin = new System.Windows.Forms.Padding(2);
            this.Cases22.Name = "Cases22";
            this.Cases22.Size = new System.Drawing.Size(71, 71);
            this.Cases22.TabIndex = 10;
            this.Cases22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Cases22.UseMnemonic = false;
            // 
            // Cases32
            // 
            this.Cases32.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Cases32.BackColor = System.Drawing.Color.Red;
            this.Cases32.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cases32.Location = new System.Drawing.Point(227, 152);
            this.Cases32.Margin = new System.Windows.Forms.Padding(2);
            this.Cases32.Name = "Cases32";
            this.Cases32.Size = new System.Drawing.Size(71, 71);
            this.Cases32.TabIndex = 11;
            this.Cases32.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Cases32.UseMnemonic = false;
            // 
            // Cases03
            // 
            this.Cases03.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Cases03.BackColor = System.Drawing.Color.Red;
            this.Cases03.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cases03.Location = new System.Drawing.Point(2, 227);
            this.Cases03.Margin = new System.Windows.Forms.Padding(2);
            this.Cases03.Name = "Cases03";
            this.Cases03.Size = new System.Drawing.Size(71, 71);
            this.Cases03.TabIndex = 12;
            this.Cases03.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Cases03.UseMnemonic = false;
            // 
            // Cases13
            // 
            this.Cases13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Cases13.BackColor = System.Drawing.Color.Red;
            this.Cases13.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cases13.Location = new System.Drawing.Point(77, 227);
            this.Cases13.Margin = new System.Windows.Forms.Padding(2);
            this.Cases13.Name = "Cases13";
            this.Cases13.Size = new System.Drawing.Size(71, 71);
            this.Cases13.TabIndex = 13;
            this.Cases13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Cases13.UseMnemonic = false;
            // 
            // Cases23
            // 
            this.Cases23.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Cases23.BackColor = System.Drawing.Color.Red;
            this.Cases23.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cases23.Location = new System.Drawing.Point(152, 227);
            this.Cases23.Margin = new System.Windows.Forms.Padding(2);
            this.Cases23.Name = "Cases23";
            this.Cases23.Size = new System.Drawing.Size(71, 71);
            this.Cases23.TabIndex = 14;
            this.Cases23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Cases23.UseMnemonic = false;
            // 
            // Cases33
            // 
            this.Cases33.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Cases33.BackColor = System.Drawing.Color.Red;
            this.Cases33.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cases33.Location = new System.Drawing.Point(227, 227);
            this.Cases33.Margin = new System.Windows.Forms.Padding(2);
            this.Cases33.Name = "Cases33";
            this.Cases33.Size = new System.Drawing.Size(71, 71);
            this.Cases33.TabIndex = 15;
            this.Cases33.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Cases33.UseMnemonic = false;
            // 
            // TexteScore
            // 
            this.TexteScore.AutoSize = true;
            this.TexteScore.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TexteScore.Location = new System.Drawing.Point(7, 35);
            this.TexteScore.Name = "TexteScore";
            this.TexteScore.Size = new System.Drawing.Size(47, 17);
            this.TexteScore.TabIndex = 3;
            this.TexteScore.Text = "Score";
            // 
            // LabelScore
            // 
            this.LabelScore.AutoSize = true;
            this.LabelScore.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelScore.Location = new System.Drawing.Point(60, 36);
            this.LabelScore.Name = "LabelScore";
            this.LabelScore.Size = new System.Drawing.Size(0, 17);
            this.LabelScore.TabIndex = 4;
            // 
            // TexteMouvement
            // 
            this.TexteMouvement.AutoSize = true;
            this.TexteMouvement.Font = new System.Drawing.Font("Arial", 11.25F);
            this.TexteMouvement.Location = new System.Drawing.Point(148, 34);
            this.TexteMouvement.Name = "TexteMouvement";
            this.TexteMouvement.Size = new System.Drawing.Size(95, 17);
            this.TexteMouvement.TabIndex = 5;
            this.TexteMouvement.Text = "Mouvements:";
            // 
            // LabelMouvement
            // 
            this.LabelMouvement.AutoSize = true;
            this.LabelMouvement.Location = new System.Drawing.Point(243, 34);
            this.LabelMouvement.Name = "LabelMouvement";
            this.LabelMouvement.Size = new System.Drawing.Size(0, 13);
            this.LabelMouvement.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 392);
            this.Controls.Add(this.LabelMouvement);
            this.Controls.Add(this.TexteMouvement);
            this.Controls.Add(this.LabelScore);
            this.Controls.Add(this.TexteScore);
            this.Controls.Add(this.Grille);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(350, 430);
            this.Name = "Form1";
            this.Text = "2048";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Jeu_FormClosing_1);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Jeu_KeyDown);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.Grille.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel LabelEtat;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem NouveauJeu;
        private System.Windows.Forms.TableLayoutPanel Grille;
        private System.Windows.Forms.Label Cases33;
        private System.Windows.Forms.Label Cases23;
        private System.Windows.Forms.Label Cases13;
        private System.Windows.Forms.Label Cases03;
        private System.Windows.Forms.Label Cases32;
        private System.Windows.Forms.Label Cases22;
        private System.Windows.Forms.Label Cases12;
        private System.Windows.Forms.Label Cases02;
        private System.Windows.Forms.Label Cases31;
        private System.Windows.Forms.Label Cases21;
        private System.Windows.Forms.Label Cases11;
        private System.Windows.Forms.Label Cases01;
        private System.Windows.Forms.Label Cases30;
        private System.Windows.Forms.Label Cases20;
        private System.Windows.Forms.Label Cases10;
        private System.Windows.Forms.Label Cases00;
        private System.Windows.Forms.Label TexteScore;
        private System.Windows.Forms.Label LabelScore;
        private System.Windows.Forms.Label TexteMouvement;
        private System.Windows.Forms.Label LabelMouvement;
    }
}

