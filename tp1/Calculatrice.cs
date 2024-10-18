namespace calculatrice
{
    public partial class Calculatrice : Form
    {
        public Calculatrice()
        {
            InitializeComponent();
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void calculer_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtOp1.Text) || string.IsNullOrEmpty(txtOp2.Text))
                    MessageBox.Show("Attention zone vide");
                else
                {
                    int resultat;
                    int op1 = Convert.ToInt32(txtOp1.Text);
                    int op2 = Convert.ToInt32(txtOp2.Text);
                    if (radioButton1.Checked)
                    {
                        resultat = op1 + op2;
                        txtResultat.Text = resultat.ToString();
                        txtExpression.Text = txtOp1.Text + "+" + txtOp2.Text;
                    }
                    else if (radioButton2.Checked)
                    {
                        resultat = op1 - op2;
                        txtResultat.Text = resultat.ToString();
                        txtExpression.Text = txtOp1.Text + "-" + txtOp2.Text;
                    }
                    else if (radioButton3.Checked)
                    {
                        resultat = op1 * op2;
                        txtResultat.Text = resultat.ToString();
                        txtExpression.Text = txtOp1.Text + "*" + txtOp2.Text;
                    }
                    else if (radioButton4.Checked)
                    {

                        resultat = op1 / op2;
                        txtResultat.Text = resultat.ToString();
                        txtExpression.Text = txtOp1.Text + "/" + txtOp2.Text;
                    }
                    else if (radioButton5.Checked)
                    {
                        resultat = op1 % op2;
                        txtResultat.Text = resultat.ToString();
                        txtExpression.Text = txtOp1.Text + "%" + txtOp2.Text;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void expression_Click(object sender, EventArgs e)
        {

        }

        private void soustraction_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmdInitialiser_Click(object sender, EventArgs e)
        {
            txtOp1.Text = "";
            txtOp2.Text = "";
            txtResultat.Text = "";
            txtExpression.Text = "";
            radioButton1.Checked = true;
        }

        private void cmdQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
