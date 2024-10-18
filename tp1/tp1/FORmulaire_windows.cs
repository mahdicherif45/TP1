namespace formulaire1
{
    public partial class FORmulaire_windows : Form
    {
        public FORmulaire_windows()
        {
            InitializeComponent();
        }

        private void cmbSexe_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbSexe.Items.Add("Homme");
            cmbSexe.Items.Add("Femme");
            grpEnf.Visible = false;
        }

        private void grpSitFam_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (button_celibataire.Checked)
            {
                grpEnf.Visible = false;
            }
        }

        private void cmdValider_Click(object sender, EventArgs e)
        {
            string txt = $"vous êtes : {txtNom.Text} {txtPen.Text} vous êtes nés le : {dateTimePicker1.Text} ans vous êtes :";
            if (button_celibataire.Checked)
            {
                txt += button_celibataire.Text + " " + "Vous avez :0 enfants";
            }
            else if (button_marieé.Checked)
            {
                txt += button_marieé.Text + " " + "Vous avez :" + nbrenf.Value + " enfants";
            }
            else if (button_divorse.Checked)
            {
                txt += button_divorse.Text + " " + "Vous avez :" + nbrenf.Value + " enfants";
            }
            MessageBox.Show(txt);

        }

        private void txtNom_Click(object sender, EventArgs e)
        {

        }

        private void cmdInitialiser_Click(object sender, EventArgs e)
        {
            txtNom.Text = "";
            txtPen.Text = "";
            cmbSexe.SelectedIndex = 0;
            dateTimePicker1.Value = DateTime.Now;
            button_celibataire.Checked = false;
            button_marieé.Checked = false;
            button_divorse.Checked = false;
            nbrenf.Value = 0;
            grpEnf.Visible = false;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (button_marieé.Checked)
            {
                grpEnf.Visible = true;
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (button_divorse.Checked)
            {
                grpEnf.Visible = true;
            }
        }

        private void cmdQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
