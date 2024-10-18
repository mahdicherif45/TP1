namespace TP1
{
    partial class gestion_eploye
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
            groupBox1 = new GroupBox();
            Txt_Mat = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            Txt_NP = new TextBox();
            Txt_Sal = new TextBox();
            Cmb_Situation = new ComboBox();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            Op_Mas = new RadioButton();
            Op_Fem = new RadioButton();
            Chk_transp = new RadioButton();
            Chk_Prod = new RadioButton();
            label5 = new Label();
            Cmb_fonction = new ComboBox();
            Btn_ajouter = new Button();
            label6 = new Label();
            Lst_Mat = new ListBox();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            Lst_Emp = new ListBox();
            label11 = new Label();
            Lst_Sal = new ListBox();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            Btn_Quit = new Button();
            Lbl_Nb_Emp = new Label();
            Lbl_Total_Sal = new Label();
            Lbl_Moyene_Sal = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(Btn_ajouter);
            groupBox1.Controls.Add(Cmb_fonction);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(groupBox3);
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Controls.Add(Cmb_Situation);
            groupBox1.Controls.Add(Txt_Sal);
            groupBox1.Controls.Add(Txt_NP);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(Txt_Mat);
            groupBox1.Location = new Point(57, 29);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(708, 280);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Saisir des donneés d'employees";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // Txt_Mat
            // 
            Txt_Mat.Location = new Point(154, 48);
            Txt_Mat.Name = "Txt_Mat";
            Txt_Mat.Size = new Size(190, 27);
            Txt_Mat.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 48);
            label1.Name = "label1";
            label1.Size = new Size(71, 20);
            label1.TabIndex = 1;
            label1.Text = "matricule";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 101);
            label2.Name = "label2";
            label2.Size = new Size(114, 20);
            label2.TabIndex = 2;
            label2.Text = "Nom et Prenom";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 144);
            label3.Name = "label3";
            label3.Size = new Size(110, 20);
            label3.TabIndex = 3;
            label3.Text = "Salaire de base";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(15, 197);
            label4.Name = "label4";
            label4.Size = new Size(130, 20);
            label4.TabIndex = 4;
            label4.Text = "Situation familiale";
            label4.Click += label4_Click;
            // 
            // Txt_NP
            // 
            Txt_NP.Location = new Point(154, 101);
            Txt_NP.Name = "Txt_NP";
            Txt_NP.Size = new Size(190, 27);
            Txt_NP.TabIndex = 5;
            // 
            // Txt_Sal
            // 
            Txt_Sal.Location = new Point(154, 144);
            Txt_Sal.Name = "Txt_Sal";
            Txt_Sal.Size = new Size(190, 27);
            Txt_Sal.TabIndex = 6;
            // 
            // Cmb_Situation
            // 
            Cmb_Situation.FormattingEnabled = true;
            Cmb_Situation.Location = new Point(166, 189);
            Cmb_Situation.Name = "Cmb_Situation";
            Cmb_Situation.Size = new Size(136, 28);
            Cmb_Situation.TabIndex = 7;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(Op_Fem);
            groupBox2.Controls.Add(Op_Mas);
            groupBox2.Location = new Point(359, 45);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(144, 129);
            groupBox2.TabIndex = 8;
            groupBox2.TabStop = false;
            groupBox2.Text = "Sexe";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(Chk_Prod);
            groupBox3.Controls.Add(Chk_transp);
            groupBox3.Location = new Point(520, 49);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(123, 125);
            groupBox3.TabIndex = 9;
            groupBox3.TabStop = false;
            groupBox3.Text = "Primes";
            // 
            // Op_Mas
            // 
            Op_Mas.AutoSize = true;
            Op_Mas.Location = new Point(23, 26);
            Op_Mas.Name = "Op_Mas";
            Op_Mas.Size = new Size(84, 24);
            Op_Mas.TabIndex = 0;
            Op_Mas.TabStop = true;
            Op_Mas.Text = "Homme";
            Op_Mas.UseVisualStyleBackColor = true;
            // 
            // Op_Fem
            // 
            Op_Fem.AutoSize = true;
            Op_Fem.Location = new Point(23, 67);
            Op_Fem.Name = "Op_Fem";
            Op_Fem.Size = new Size(79, 24);
            Op_Fem.TabIndex = 1;
            Op_Fem.TabStop = true;
            Op_Fem.Text = "Femme";
            Op_Fem.UseVisualStyleBackColor = true;
            // 
            // Chk_transp
            // 
            Chk_transp.AutoSize = true;
            Chk_transp.Location = new Point(11, 33);
            Chk_transp.Name = "Chk_transp";
            Chk_transp.Size = new Size(92, 24);
            Chk_transp.TabIndex = 0;
            Chk_transp.TabStop = true;
            Chk_transp.Text = "Transport";
            Chk_transp.UseVisualStyleBackColor = true;
            // 
            // Chk_Prod
            // 
            Chk_Prod.AutoSize = true;
            Chk_Prod.Location = new Point(13, 73);
            Chk_Prod.Name = "Chk_Prod";
            Chk_Prod.Size = new Size(103, 24);
            Chk_Prod.TabIndex = 1;
            Chk_Prod.TabStop = true;
            Chk_Prod.Text = "production";
            Chk_Prod.UseVisualStyleBackColor = true;
            Chk_Prod.CheckedChanged += radioButton4_CheckedChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(317, 197);
            label5.Name = "label5";
            label5.Size = new Size(64, 20);
            label5.TabIndex = 10;
            label5.Text = "fonction";
            // 
            // Cmb_fonction
            // 
            Cmb_fonction.FormattingEnabled = true;
            Cmb_fonction.Location = new Point(387, 189);
            Cmb_fonction.Name = "Cmb_fonction";
            Cmb_fonction.Size = new Size(151, 28);
            Cmb_fonction.TabIndex = 11;
            // 
            // Btn_ajouter
            // 
            Btn_ajouter.Location = new Point(549, 188);
            Btn_ajouter.Name = "Btn_ajouter";
            Btn_ajouter.Size = new Size(148, 29);
            Btn_ajouter.TabIndex = 12;
            Btn_ajouter.Text = "ajouter employe";
            Btn_ajouter.UseVisualStyleBackColor = true;
            Btn_ajouter.Click += Btn_ajouter_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(97, 322);
            label6.Name = "label6";
            label6.Size = new Size(71, 20);
            label6.TabIndex = 1;
            label6.Text = "Matricule";
            // 
            // Lst_Mat
            // 
            Lst_Mat.FormattingEnabled = true;
            Lst_Mat.Location = new Point(57, 365);
            Lst_Mat.Name = "Lst_Mat";
            Lst_Mat.Size = new Size(150, 184);
            Lst_Mat.TabIndex = 2;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(223, 322);
            label7.Name = "label7";
            label7.Size = new Size(42, 20);
            label7.TabIndex = 3;
            label7.Text = "Nom";
            label7.Click += label7_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(299, 322);
            label8.Name = "label8";
            label8.Size = new Size(60, 20);
            label8.TabIndex = 4;
            label8.Text = "Prenom";
            label8.Click += label8_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(374, 322);
            label9.Name = "label9";
            label9.Size = new Size(126, 20);
            label9.TabIndex = 5;
            label9.Text = "Situation familale";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(529, 322);
            label10.Name = "label10";
            label10.Size = new Size(66, 20);
            label10.TabIndex = 6;
            label10.Text = "Fonction";
            // 
            // Lst_Emp
            // 
            Lst_Emp.FormattingEnabled = true;
            Lst_Emp.Location = new Point(223, 365);
            Lst_Emp.Name = "Lst_Emp";
            Lst_Emp.Size = new Size(372, 184);
            Lst_Emp.TabIndex = 7;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(639, 322);
            label11.Name = "label11";
            label11.RightToLeft = RightToLeft.Yes;
            label11.Size = new Size(82, 20);
            label11.TabIndex = 8;
            label11.Text = "Salaire Net";
            // 
            // Lst_Sal
            // 
            Lst_Sal.FormattingEnabled = true;
            Lst_Sal.Location = new Point(615, 365);
            Lst_Sal.Name = "Lst_Sal";
            Lst_Sal.Size = new Size(150, 184);
            Lst_Sal.TabIndex = 9;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(63, 584);
            label12.Name = "label12";
            label12.Size = new Size(99, 20);
            label12.TabIndex = 10;
            label12.Text = "Nombre total";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(506, 584);
            label13.Name = "label13";
            label13.Size = new Size(92, 20);
            label13.TabIndex = 11;
            label13.Text = "Total sal net:";
            label13.Click += label13_Click;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(503, 626);
            label14.Name = "label14";
            label14.Size = new Size(124, 20);
            label14.TabIndex = 12;
            label14.Text = "Moyenne sal net: ";
            // 
            // Btn_Quit
            // 
            Btn_Quit.Location = new Point(57, 627);
            Btn_Quit.Name = "Btn_Quit";
            Btn_Quit.Size = new Size(186, 29);
            Btn_Quit.TabIndex = 13;
            Btn_Quit.Text = "quitter";
            Btn_Quit.UseVisualStyleBackColor = true;
            // 
            // Lbl_Nb_Emp
            // 
            Lbl_Nb_Emp.AutoSize = true;
            Lbl_Nb_Emp.Location = new Point(259, 582);
            Lbl_Nb_Emp.Name = "Lbl_Nb_Emp";
            Lbl_Nb_Emp.Size = new Size(58, 20);
            Lbl_Nb_Emp.TabIndex = 14;
            Lbl_Nb_Emp.Text = "label15";
            // 
            // Lbl_Total_Sal
            // 
            Lbl_Total_Sal.AutoSize = true;
            Lbl_Total_Sal.Location = new Point(663, 584);
            Lbl_Total_Sal.Name = "Lbl_Total_Sal";
            Lbl_Total_Sal.Size = new Size(58, 20);
            Lbl_Total_Sal.TabIndex = 15;
            Lbl_Total_Sal.Text = "label15";
            // 
            // Lbl_Moyene_Sal
            // 
            Lbl_Moyene_Sal.AutoSize = true;
            Lbl_Moyene_Sal.Location = new Point(663, 626);
            Lbl_Moyene_Sal.Name = "Lbl_Moyene_Sal";
            Lbl_Moyene_Sal.Size = new Size(58, 20);
            Lbl_Moyene_Sal.TabIndex = 16;
            Lbl_Moyene_Sal.Text = "label15";
            // 
            // gestion_eploye
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 668);
            Controls.Add(Lbl_Moyene_Sal);
            Controls.Add(Lbl_Total_Sal);
            Controls.Add(Lbl_Nb_Emp);
            Controls.Add(Btn_Quit);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(Lst_Sal);
            Controls.Add(label11);
            Controls.Add(Lst_Emp);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(Lst_Mat);
            Controls.Add(label6);
            Controls.Add(groupBox1);
            Name = "gestion_eploye";
            Text = "gestion_eploye";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox Txt_Mat;
        private GroupBox groupBox3;
        private GroupBox groupBox2;
        private ComboBox Cmb_Situation;
        private TextBox Txt_Sal;
        private TextBox Txt_NP;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private RadioButton Op_Fem;
        private RadioButton Op_Mas;
        private ComboBox Cmb_fonction;
        private Label label5;
        private RadioButton Chk_Prod;
        private RadioButton Chk_transp;
        private Button Btn_ajouter;
        private Label label6;
        private ListBox Lst_Mat;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private ListBox Lst_Emp;
        private Label label11;
        private ListBox Lst_Sal;
        private Label label12;
        private Label label13;
        private Label label14;
        private Button Btn_Quit;
        private Label Lbl_Nb_Emp;
        private Label Lbl_Total_Sal;
        private Label Lbl_Moyene_Sal;
    }
}