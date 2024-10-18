namespace formulaire1
{
    partial class FORmulaire_windows
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtNom = new TextBox();
            txtPen = new TextBox();
            nom = new Label();
            prenom = new Label();
            label1 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label2 = new Label();
            cmbSexe = new ComboBox();
            grpSitFam = new GroupBox();
            button_divorse = new RadioButton();
            button_marieé = new RadioButton();
            button_celibataire = new RadioButton();
            grpEnf = new GroupBox();
            nbrenf = new NumericUpDown();
            label3 = new Label();
            cmdValider = new Button();
            cmdInitialiser = new Button();
            cmdQuitter = new Button();
            grpSitFam.SuspendLayout();
            grpEnf.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nbrenf).BeginInit();
            SuspendLayout();
            // 
            // txtNom
            // 
            txtNom.Location = new Point(186, 79);
            txtNom.Name = "txtNom";
            txtNom.Size = new Size(125, 27);
            txtNom.TabIndex = 0;
            // 
            // txtPen
            // 
            txtPen.Location = new Point(186, 149);
            txtPen.Name = "txtPen";
            txtPen.Size = new Size(125, 27);
            txtPen.TabIndex = 1;
            // 
            // nom
            // 
            nom.AutoSize = true;
            nom.Location = new Point(31, 82);
            nom.Name = "nom";
            nom.Size = new Size(42, 20);
            nom.TabIndex = 2;
            nom.Text = "Nom";
            nom.Click += txtNom_Click;
            // 
            // prenom
            // 
            prenom.AutoSize = true;
            prenom.Location = new Point(31, 156);
            prenom.Name = "prenom";
            prenom.Size = new Size(61, 20);
            prenom.TabIndex = 3;
            prenom.Text = "prenom";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 227);
            label1.Name = "label1";
            label1.Size = new Size(127, 20);
            label1.TabIndex = 4;
            label1.Text = "date de naissance";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(186, 220);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(31, 289);
            label2.Name = "label2";
            label2.Size = new Size(38, 20);
            label2.TabIndex = 6;
            label2.Text = "sexe";
            // 
            // cmbSexe
            // 
            cmbSexe.FormattingEnabled = true;
            cmbSexe.Location = new Point(186, 281);
            cmbSexe.Name = "cmbSexe";
            cmbSexe.Size = new Size(151, 28);
            cmbSexe.TabIndex = 7;
            cmbSexe.SelectedIndexChanged += cmbSexe_SelectedIndexChanged;
            // 
            // grpSitFam
            // 
            grpSitFam.Controls.Add(button_divorse);
            grpSitFam.Controls.Add(button_marieé);
            grpSitFam.Controls.Add(button_celibataire);
            grpSitFam.Location = new Point(186, 350);
            grpSitFam.Name = "grpSitFam";
            grpSitFam.Size = new Size(250, 156);
            grpSitFam.TabIndex = 8;
            grpSitFam.TabStop = false;
            grpSitFam.Text = "situation familale";
            grpSitFam.Enter += grpSitFam_Enter;
            // 
            // button_divorse
            // 
            button_divorse.AutoSize = true;
            button_divorse.Location = new Point(26, 114);
            button_divorse.Name = "button_divorse";
            button_divorse.Size = new Size(96, 24);
            button_divorse.TabIndex = 2;
            button_divorse.TabStop = true;
            button_divorse.Text = "divorsé(e)";
            button_divorse.UseVisualStyleBackColor = true;
            button_divorse.CheckedChanged += radioButton3_CheckedChanged;
            // 
            // button_marieé
            // 
            button_marieé.AutoSize = true;
            button_marieé.Location = new Point(26, 75);
            button_marieé.Name = "button_marieé";
            button_marieé.Size = new Size(86, 24);
            button_marieé.TabIndex = 1;
            button_marieé.TabStop = true;
            button_marieé.Text = "marié(e)";
            button_marieé.UseVisualStyleBackColor = true;
            button_marieé.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // button_celibataire
            // 
            button_celibataire.AutoSize = true;
            button_celibataire.Location = new Point(26, 31);
            button_celibataire.Name = "button_celibataire";
            button_celibataire.Size = new Size(102, 24);
            button_celibataire.TabIndex = 0;
            button_celibataire.TabStop = true;
            button_celibataire.Text = "Celibataire";
            button_celibataire.TextAlign = ContentAlignment.MiddleCenter;
            button_celibataire.UseVisualStyleBackColor = true;
            button_celibataire.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // grpEnf
            // 
            grpEnf.Controls.Add(nbrenf);
            grpEnf.Controls.Add(label3);
            grpEnf.Location = new Point(31, 541);
            grpEnf.Name = "grpEnf";
            grpEnf.Size = new Size(405, 55);
            grpEnf.TabIndex = 9;
            grpEnf.TabStop = false;
            grpEnf.Text = "Enfants";
            // 
            // nbrenf
            // 
            nbrenf.Location = new Point(203, 21);
            nbrenf.Name = "nbrenf";
            nbrenf.Size = new Size(150, 27);
            nbrenf.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 23);
            label3.Name = "label3";
            label3.Size = new Size(128, 20);
            label3.TabIndex = 0;
            label3.Text = "Nombre d'enfants";
            // 
            // cmdValider
            // 
            cmdValider.Location = new Point(582, 118);
            cmdValider.Name = "cmdValider";
            cmdValider.Size = new Size(94, 29);
            cmdValider.TabIndex = 10;
            cmdValider.Text = "valider";
            cmdValider.UseVisualStyleBackColor = true;
            cmdValider.Click += cmdValider_Click;
            // 
            // cmdInitialiser
            // 
            cmdInitialiser.Location = new Point(582, 218);
            cmdInitialiser.Name = "cmdInitialiser";
            cmdInitialiser.Size = new Size(94, 29);
            cmdInitialiser.TabIndex = 11;
            cmdInitialiser.Text = "initializer";
            cmdInitialiser.UseVisualStyleBackColor = true;
            cmdInitialiser.Click += cmdInitialiser_Click;
            // 
            // cmdQuitter
            // 
            cmdQuitter.Location = new Point(582, 323);
            cmdQuitter.Name = "cmdQuitter";
            cmdQuitter.Size = new Size(94, 29);
            cmdQuitter.TabIndex = 12;
            cmdQuitter.Text = "quitter";
            cmdQuitter.UseVisualStyleBackColor = true;
            cmdQuitter.Click += cmdQuitter_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 652);
            Controls.Add(cmdQuitter);
            Controls.Add(cmdInitialiser);
            Controls.Add(cmdValider);
            Controls.Add(grpEnf);
            Controls.Add(grpSitFam);
            Controls.Add(cmbSexe);
            Controls.Add(label2);
            Controls.Add(dateTimePicker1);
            Controls.Add(label1);
            Controls.Add(prenom);
            Controls.Add(nom);
            Controls.Add(txtPen);
            Controls.Add(txtNom);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            grpSitFam.ResumeLayout(false);
            grpSitFam.PerformLayout();
            grpEnf.ResumeLayout(false);
            grpEnf.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nbrenf).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNom;
        private TextBox txtPen;
        private Label nom;
        private Label prenom;
        private Label label1;
        private DateTimePicker dateTimePicker1;
        private Label label2;
        private ComboBox cmbSexe;
        private GroupBox grpSitFam;
        private RadioButton button_divorse;
        private RadioButton button_marieé;
        private RadioButton button_celibataire;
        private GroupBox grpEnf;
        private Label label3;
        private NumericUpDown nbrenf;
        private Button cmdValider;
        private Button cmdInitialiser;
        private Button cmdQuitter;
    }
}
