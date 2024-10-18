namespace TP1
{
    partial class Gestion_regby
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            txt_eq1 = new TextBox();
            txt_eq2 = new TextBox();
            groupBox1 = new GroupBox();
            rdb_eq2 = new RadioButton();
            rdb_eq1 = new RadioButton();
            label3 = new Label();
            cmb_np = new ComboBox();
            label4 = new Label();
            label5 = new Label();
            List_eq1 = new ListBox();
            List_eq2 = new ListBox();
            Btn_Ajout = new Button();
            Btn_Résultat = new Button();
            Btn_RAZ = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(41, 80);
            label1.Name = "label1";
            label1.Size = new Size(63, 20);
            label1.TabIndex = 0;
            label1.Text = "equipe1";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(41, 158);
            label2.Name = "label2";
            label2.Size = new Size(63, 20);
            label2.TabIndex = 1;
            label2.Text = "equipe2";
            // 
            // txt_eq1
            // 
            txt_eq1.Location = new Point(159, 80);
            txt_eq1.Name = "txt_eq1";
            txt_eq1.Size = new Size(125, 27);
            txt_eq1.TabIndex = 2;
            // 
            // txt_eq2
            // 
            txt_eq2.Location = new Point(159, 155);
            txt_eq2.Name = "txt_eq2";
            txt_eq2.Size = new Size(125, 27);
            txt_eq2.TabIndex = 3;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rdb_eq2);
            groupBox1.Controls.Add(rdb_eq1);
            groupBox1.Location = new Point(41, 236);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(243, 125);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "point marqué par";
            // 
            // rdb_eq2
            // 
            rdb_eq2.AutoSize = true;
            rdb_eq2.Location = new Point(46, 76);
            rdb_eq2.Name = "rdb_eq2";
            rdb_eq2.Size = new Size(88, 24);
            rdb_eq2.TabIndex = 1;
            rdb_eq2.TabStop = true;
            rdb_eq2.Text = "equipe 2";
            rdb_eq2.UseVisualStyleBackColor = true;
            // 
            // rdb_eq1
            // 
            rdb_eq1.AutoSize = true;
            rdb_eq1.Location = new Point(46, 36);
            rdb_eq1.Name = "rdb_eq1";
            rdb_eq1.Size = new Size(88, 24);
            rdb_eq1.TabIndex = 0;
            rdb_eq1.TabStop = true;
            rdb_eq1.Text = "equipe 1";
            rdb_eq1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(28, 391);
            label3.Name = "label3";
            label3.Size = new Size(119, 20);
            label3.TabIndex = 2;
            label3.Text = "type d'operation";
            label3.Click += label3_Click;
            // 
            // cmb_np
            // 
            cmb_np.FormattingEnabled = true;
            cmb_np.Location = new Point(187, 388);
            cmb_np.Name = "cmb_np";
            cmb_np.Size = new Size(151, 28);
            cmb_np.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(423, 27);
            label4.Name = "label4";
            label4.Size = new Size(67, 20);
            label4.TabIndex = 7;
            label4.Text = "equipe 1";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(655, 27);
            label5.Name = "label5";
            label5.Size = new Size(67, 20);
            label5.TabIndex = 8;
            label5.Text = "equipe 2";
            label5.Click += label5_Click;
            // 
            // List_eq1
            // 
            List_eq1.FormattingEnabled = true;
            List_eq1.Location = new Point(382, 80);
            List_eq1.Name = "List_eq1";
            List_eq1.Size = new Size(213, 324);
            List_eq1.TabIndex = 9;
            // 
            // List_eq2
            // 
            List_eq2.FormattingEnabled = true;
            List_eq2.Location = new Point(644, 80);
            List_eq2.Name = "List_eq2";
            List_eq2.Size = new Size(203, 324);
            List_eq2.TabIndex = 10;
            List_eq2.SelectedIndexChanged += listBox2_SelectedIndexChanged;
            // 
            // Btn_Ajout
            // 
            Btn_Ajout.Location = new Point(382, 462);
            Btn_Ajout.Name = "Btn_Ajout";
            Btn_Ajout.Size = new Size(94, 29);
            Btn_Ajout.TabIndex = 11;
            Btn_Ajout.Text = "ajouter";
            Btn_Ajout.UseVisualStyleBackColor = true;
            Btn_Ajout.Click += Btn_Ajout_Click;
            // 
            // Btn_Résultat
            // 
            Btn_Résultat.Location = new Point(564, 462);
            Btn_Résultat.Name = "Btn_Résultat";
            Btn_Résultat.Size = new Size(94, 29);
            Btn_Résultat.TabIndex = 12;
            Btn_Résultat.Text = "resultat";
            Btn_Résultat.UseVisualStyleBackColor = true;
            Btn_Résultat.Click += Btn_Résultat_Click;
            // 
            // Btn_RAZ
            // 
            Btn_RAZ.Location = new Point(730, 462);
            Btn_RAZ.Name = "Btn_RAZ";
            Btn_RAZ.Size = new Size(94, 29);
            Btn_RAZ.TabIndex = 13;
            Btn_RAZ.Text = "RAZ";
            Btn_RAZ.UseVisualStyleBackColor = true;
            Btn_RAZ.Click += Btn_RAZ_Click;
            // 
            // Gestion_regby
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(940, 543);
            Controls.Add(Btn_RAZ);
            Controls.Add(Btn_Résultat);
            Controls.Add(Btn_Ajout);
            Controls.Add(List_eq2);
            Controls.Add(List_eq1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(cmb_np);
            Controls.Add(label3);
            Controls.Add(groupBox1);
            Controls.Add(txt_eq2);
            Controls.Add(txt_eq1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Gestion_regby";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txt_eq1;
        private TextBox txt_eq2;
        private GroupBox groupBox1;
        private RadioButton rdb_eq2;
        private RadioButton rdb_eq1;
        private Label label3;
        private ComboBox cmb_np;
        private Label label4;
        private Label label5;
        private ListBox List_eq1;
        private ListBox List_eq2;
        private Button Btn_Ajout;
        private Button Btn_Résultat;
        private Button Btn_RAZ;
    }
}