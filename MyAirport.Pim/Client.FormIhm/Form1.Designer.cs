namespace Client.FormIhm
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
            this.button1 = new System.Windows.Forms.Button();
            this.Recherche = new System.Windows.Forms.GroupBox();
            this.LabelCodeIATA = new System.Windows.Forms.Label();
            this.codeIATATB = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ClasseBagageTB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ItineraireTB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.RushCB = new System.Windows.Forms.CheckBox();
            this.ContinuationCB = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.JourExploitTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Ligne2TB = new System.Windows.Forms.TextBox();
            this.Ligne1TB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CompagnieTB = new System.Windows.Forms.TextBox();
            this.AnnulerBtn = new System.Windows.Forms.Button();
            this.AjouterBtn = new System.Windows.Forms.Button();
            this.Recherche.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(480, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(39, 20);
            this.button1.TabIndex = 0;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Recherche
            // 
            this.Recherche.Controls.Add(this.LabelCodeIATA);
            this.Recherche.Controls.Add(this.button1);
            this.Recherche.Controls.Add(this.codeIATATB);
            this.Recherche.Location = new System.Drawing.Point(13, 13);
            this.Recherche.Name = "Recherche";
            this.Recherche.Size = new System.Drawing.Size(525, 48);
            this.Recherche.TabIndex = 1;
            this.Recherche.TabStop = false;
            this.Recherche.Text = "Recherche";
            // 
            // LabelCodeIATA
            // 
            this.LabelCodeIATA.AutoSize = true;
            this.LabelCodeIATA.Location = new System.Drawing.Point(6, 22);
            this.LabelCodeIATA.Name = "LabelCodeIATA";
            this.LabelCodeIATA.Size = new System.Drawing.Size(59, 13);
            this.LabelCodeIATA.TabIndex = 1;
            this.LabelCodeIATA.Text = "Code IATA";
            this.LabelCodeIATA.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.LabelCodeIATA.Click += new System.EventHandler(this.label1_Click);
            // 
            // codeIATATB
            // 
            this.codeIATATB.Location = new System.Drawing.Point(72, 19);
            this.codeIATATB.Name = "codeIATATB";
            this.codeIATATB.Size = new System.Drawing.Size(402, 20);
            this.codeIATATB.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(13, 68);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(525, 289);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Résultat";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.ClasseBagageTB);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.ItineraireTB);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.RushCB);
            this.groupBox3.Controls.Add(this.ContinuationCB);
            this.groupBox3.Location = new System.Drawing.Point(259, 20);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(260, 263);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Bagage";
            // 
            // ClasseBagageTB
            // 
            this.ClasseBagageTB.Location = new System.Drawing.Point(91, 47);
            this.ClasseBagageTB.Name = "ClasseBagageTB";
            this.ClasseBagageTB.Size = new System.Drawing.Size(163, 20);
            this.ClasseBagageTB.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Classe Bagage";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // ItineraireTB
            // 
            this.ItineraireTB.Location = new System.Drawing.Point(91, 16);
            this.ItineraireTB.Name = "ItineraireTB";
            this.ItineraireTB.Size = new System.Drawing.Size(163, 20);
            this.ItineraireTB.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Itinéraire";
            // 
            // RushCB
            // 
            this.RushCB.AutoSize = true;
            this.RushCB.Location = new System.Drawing.Point(91, 102);
            this.RushCB.Name = "RushCB";
            this.RushCB.Size = new System.Drawing.Size(51, 17);
            this.RushCB.TabIndex = 1;
            this.RushCB.Text = "Rush";
            this.RushCB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.RushCB.UseVisualStyleBackColor = true;
            // 
            // ContinuationCB
            // 
            this.ContinuationCB.AutoSize = true;
            this.ContinuationCB.Location = new System.Drawing.Point(91, 79);
            this.ContinuationCB.Name = "ContinuationCB";
            this.ContinuationCB.Size = new System.Drawing.Size(85, 17);
            this.ContinuationCB.TabIndex = 0;
            this.ContinuationCB.Text = "Continuation";
            this.ContinuationCB.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.JourExploitTB);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.Ligne2TB);
            this.groupBox2.Controls.Add(this.Ligne1TB);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.CompagnieTB);
            this.groupBox2.Location = new System.Drawing.Point(7, 20);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(246, 263);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Vol";
            // 
            // JourExploitTB
            // 
            this.JourExploitTB.Location = new System.Drawing.Point(106, 74);
            this.JourExploitTB.Name = "JourExploitTB";
            this.JourExploitTB.Size = new System.Drawing.Size(134, 20);
            this.JourExploitTB.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Jour d\'exploitation";
            // 
            // Ligne2TB
            // 
            this.Ligne2TB.Location = new System.Drawing.Point(179, 46);
            this.Ligne2TB.Name = "Ligne2TB";
            this.Ligne2TB.Size = new System.Drawing.Size(61, 20);
            this.Ligne2TB.TabIndex = 4;
            // 
            // Ligne1TB
            // 
            this.Ligne1TB.Location = new System.Drawing.Point(72, 46);
            this.Ligne1TB.Name = "Ligne1TB";
            this.Ligne1TB.Size = new System.Drawing.Size(100, 20);
            this.Ligne1TB.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ligne";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Compagnie";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // CompagnieTB
            // 
            this.CompagnieTB.Location = new System.Drawing.Point(72, 19);
            this.CompagnieTB.Name = "CompagnieTB";
            this.CompagnieTB.Size = new System.Drawing.Size(168, 20);
            this.CompagnieTB.TabIndex = 0;
            // 
            // AnnulerBtn
            // 
            this.AnnulerBtn.Location = new System.Drawing.Point(428, 369);
            this.AnnulerBtn.Name = "AnnulerBtn";
            this.AnnulerBtn.Size = new System.Drawing.Size(110, 23);
            this.AnnulerBtn.TabIndex = 3;
            this.AnnulerBtn.Text = "Réinitialiser";
            this.AnnulerBtn.UseVisualStyleBackColor = true;
            this.AnnulerBtn.Click += new System.EventHandler(this.AnnulerBtn_Click);
            // 
            // AjouterBtn
            // 
            this.AjouterBtn.Location = new System.Drawing.Point(307, 370);
            this.AjouterBtn.Name = "AjouterBtn";
            this.AjouterBtn.Size = new System.Drawing.Size(110, 23);
            this.AjouterBtn.TabIndex = 4;
            this.AjouterBtn.Text = "Ajouter";
            this.AjouterBtn.UseVisualStyleBackColor = true;
            this.AjouterBtn.Click += new System.EventHandler(this.AjouterBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 404);
            this.Controls.Add(this.AjouterBtn);
            this.Controls.Add(this.AnnulerBtn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Recherche);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Recherche.ResumeLayout(false);
            this.Recherche.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox Recherche;
        private System.Windows.Forms.Label LabelCodeIATA;
        private System.Windows.Forms.TextBox codeIATATB;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox CompagnieTB;
        private System.Windows.Forms.TextBox ClasseBagageTB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox ItineraireTB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox RushCB;
        private System.Windows.Forms.CheckBox ContinuationCB;
        private System.Windows.Forms.TextBox JourExploitTB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Ligne2TB;
        private System.Windows.Forms.TextBox Ligne1TB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button AnnulerBtn;
        private System.Windows.Forms.Button AjouterBtn;
    }
}

