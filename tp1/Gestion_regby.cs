using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP1
{
    public partial class Gestion_regby : Form
    {
        int eq1 = 0, eq2 = 0;
        public Gestion_regby()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmb_np.Items.Add("Transformation");
            cmb_np.Items.Add("Pénalité");
            cmb_np.Items.Add("Drop");
            cmb_np.Items.Add("Essai");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Btn_Ajout_Click(object sender, EventArgs e)
        {
            string[] arrtxt = { "Transformation (2 points)", "Penalité (3 points)", "Drop(3 points)", "Essai: (5 points)" };
            int[] arrval = { 2, 3, 3, 5 };
            if (rdb_eq1.Checked)
            {
                List_eq1.Items.Add(arrtxt[cmb_np.SelectedIndex]);
                eq1 += arrval[cmb_np.SelectedIndex];
            }
            else if (rdb_eq2.Checked)
            {
                List_eq2.Items.Add(arrtxt[cmb_np.SelectedIndex]);
                eq2 += arrval[cmb_np.SelectedIndex];

            }
        }

        private void Btn_Résultat_Click(object sender, EventArgs e)
        {
            MessageBox.Show(txt_eq1.Text + " " + eq1 + " " + txt_eq2.Text + " " + eq2);
        }

        private void Btn_RAZ_Click(object sender, EventArgs e)
        {
            txt_eq1.Text = "";
            txt_eq2.Text = "";
            rdb_eq1.Checked = false;
            rdb_eq2.Checked = false;
            List_eq1.Items.Clear();
            List_eq2.Items.Clear();
            eq1 = 0;
            eq2 = 0;
        }
    }
}
