namespace calculatrice
{
    partial class Calculatrice
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
            components = new System.ComponentModel.Container();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton3 = new RadioButton();
            radioButton4 = new RadioButton();
            radioButton5 = new RadioButton();
            grpOp = new GroupBox();
            calculer = new Button();
            label1 = new Label();
            txtOp1 = new TextBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            txtOp2 = new TextBox();
            label2 = new Label();
            txt = new Label();
            txt1 = new Label();
            txtExpression = new TextBox();
            txtResultat = new TextBox();
            cmdInitialiser = new Button();
            cmdQuitter = new Button();
            grpOp.SuspendLayout();
            SuspendLayout();
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(31, 27);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(86, 24);
            radioButton1.TabIndex = 4;
            radioButton1.TabStop = true;
            radioButton1.Text = "addition";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(31, 61);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(110, 24);
            radioButton2.TabIndex = 5;
            radioButton2.TabStop = true;
            radioButton2.Text = "soustraction";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += soustraction_CheckedChanged;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(31, 100);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(122, 24);
            radioButton3.TabIndex = 6;
            radioButton3.TabStop = true;
            radioButton3.Text = "multiplication";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Location = new Point(31, 144);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(81, 24);
            radioButton4.TabIndex = 7;
            radioButton4.TabStop = true;
            radioButton4.Text = "division";
            radioButton4.UseVisualStyleBackColor = true;
            radioButton4.CheckedChanged += radioButton4_CheckedChanged;
            // 
            // radioButton5
            // 
            radioButton5.AutoSize = true;
            radioButton5.Location = new Point(31, 195);
            radioButton5.Name = "radioButton5";
            radioButton5.Size = new Size(54, 24);
            radioButton5.TabIndex = 8;
            radioButton5.TabStop = true;
            radioButton5.Text = "rest";
            radioButton5.UseVisualStyleBackColor = true;
            // 
            // grpOp
            // 
            grpOp.Controls.Add(calculer);
            grpOp.Controls.Add(radioButton5);
            grpOp.Controls.Add(radioButton2);
            grpOp.Controls.Add(radioButton3);
            grpOp.Controls.Add(radioButton4);
            grpOp.Controls.Add(radioButton1);
            grpOp.Location = new Point(385, 12);
            grpOp.Name = "grpOp";
            grpOp.Size = new Size(199, 283);
            grpOp.TabIndex = 9;
            grpOp.TabStop = false;
            grpOp.Text = "les operateurs";
            // 
            // calculer
            // 
            calculer.Location = new Point(31, 238);
            calculer.Name = "calculer";
            calculer.Size = new Size(94, 29);
            calculer.TabIndex = 9;
            calculer.Text = "calculer";
            calculer.UseVisualStyleBackColor = true;
            calculer.Click += calculer_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(199, 39);
            label1.Name = "label1";
            label1.Size = new Size(77, 20);
            label1.TabIndex = 10;
            label1.Text = "operand 1";
            // 
            // txtOp1
            // 
            txtOp1.Location = new Point(163, 70);
            txtOp1.Name = "txtOp1";
            txtOp1.Size = new Size(125, 27);
            txtOp1.TabIndex = 11;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // txtOp2
            // 
            txtOp2.Location = new Point(163, 139);
            txtOp2.Name = "txtOp2";
            txtOp2.Size = new Size(125, 27);
            txtOp2.TabIndex = 13;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(199, 116);
            label2.Name = "label2";
            label2.Size = new Size(77, 20);
            label2.TabIndex = 14;
            label2.Text = "operand 2";
            // 
            // txt
            // 
            txt.AutoSize = true;
            txt.Location = new Point(46, 303);
            txt.Name = "txt";
            txt.Size = new Size(79, 20);
            txt.TabIndex = 15;
            txt.Text = "expression";
            txt.Click += expression_Click;
            // 
            // txt1
            // 
            txt1.AutoSize = true;
            txt1.Location = new Point(46, 350);
            txt1.Name = "txt1";
            txt1.Size = new Size(58, 20);
            txt1.TabIndex = 16;
            txt1.Text = "resultat";
            // 
            // txtExpression
            // 
            txtExpression.Location = new Point(151, 296);
            txtExpression.Name = "txtExpression";
            txtExpression.Size = new Size(125, 27);
            txtExpression.TabIndex = 17;
            txtExpression.TextChanged += textBox1_TextChanged;
            // 
            // txtResultat
            // 
            txtResultat.Location = new Point(151, 343);
            txtResultat.Name = "txtResultat";
            txtResultat.Size = new Size(125, 27);
            txtResultat.TabIndex = 18;
            // 
            // cmdInitialiser
            // 
            cmdInitialiser.Location = new Point(46, 427);
            cmdInitialiser.Name = "cmdInitialiser";
            cmdInitialiser.Size = new Size(94, 29);
            cmdInitialiser.TabIndex = 19;
            cmdInitialiser.Text = "initializer";
            cmdInitialiser.UseVisualStyleBackColor = true;
            cmdInitialiser.Click += cmdInitialiser_Click;
            // 
            // cmdQuitter
            // 
            cmdQuitter.Location = new Point(233, 427);
            cmdQuitter.Name = "cmdQuitter";
            cmdQuitter.Size = new Size(94, 29);
            cmdQuitter.TabIndex = 20;
            cmdQuitter.Text = "quitter";
            cmdQuitter.UseVisualStyleBackColor = true;
            cmdQuitter.Click += cmdQuitter_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 535);
            Controls.Add(cmdQuitter);
            Controls.Add(cmdInitialiser);
            Controls.Add(txtResultat);
            Controls.Add(txtExpression);
            Controls.Add(txt1);
            Controls.Add(txt);
            Controls.Add(label2);
            Controls.Add(txtOp2);
            Controls.Add(txtOp1);
            Controls.Add(label1);
            Controls.Add(grpOp);
            Name = "Form1";
            Text = "Form1";
            grpOp.ResumeLayout(false);
            grpOp.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
        private RadioButton radioButton4;
        private RadioButton radioButton5;
        private GroupBox grpOp;
        private Button calculer;
        private Label label1;
        private TextBox txtOp1;
        private ContextMenuStrip contextMenuStrip1;
        private TextBox txtOp2;
        private Label label2;
        private Label txt;
        private Label txt1;
        private TextBox txtExpression;
        private TextBox txtResultat;
        private Button cmdInitialiser;
        private Button cmdQuitter;
    }
}
