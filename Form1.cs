using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsAppAP;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace WindowsFormsAppAnastasija
{
    public partial class Form1 : Form
    {
        SqlConnection konekcija = new SqlConnection(Konekcija.konString);
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.Trening' table. You can move, or remove it, as needed.
            this.treningTableAdapter.Fill(this.dataSet1.Trening);
            // TODO: This line of code loads data into the 'dataSet1.Clan' table. You can move, or remove it, as needed.
            this.clanTableAdapter.Fill(this.dataSet1.Clan);
            puniKOmbo();
        }

        
        private string vratiIzabrano()
        {
            string temp = "";
            foreach (RadioButton rb in gbVrste.Controls)
            {
                if (rb.Checked == true)
                {
                    temp = rb.Text;
                }
            }
            return temp;
        }
        private void puniKOmbo()
        {
            try
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT DISTINCT (Ime+' '+Prezime)as ImePrezime FROM Clan", konekcija);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                cmbIme.DataSource = dataTable;
                cmbIme.DisplayMember = "ImePrezime";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void rbKardio_CheckedChanged(object sender, EventArgs e)
        {

            try
            {
                konekcija.Open();
                SqlCommand komanda = new SqlCommand();
                SqlParameter pom = new SqlParameter("@pom", vratiIzabrano());
                komanda.Connection = konekcija;
                komanda.Parameters.Add(pom);
                komanda.CommandText = "SELECT COUNT(*) FROM Clan c JOIN Trening t ON c.IDTreninga = t.IDTreninga WHERE t.VrstaTreninga= @pom";
                tbBroj.Text = komanda.ExecuteScalar().ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                konekcija.Close();
            }
        }

        private void cmbIme_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbPrikaz.Items.Clear();
            try
            {
                konekcija.Open();
                using (SqlCommand komanda = new SqlCommand("SELECT Ime, Prezime,IDClana, VrstaTreninga from Clan c join Trening t on c.IDTreninga=t.IDTreninga  WHERE (Ime+' '+Prezime)=@clan", konekcija))
                {
                    komanda.Parameters.Add(new SqlParameter("clan", cmbIme.Text));
                    SqlDataReader reader = komanda.ExecuteReader();
                    while (reader.Read())
                    {
                        lbPrikaz.Items.Add("Clan - " + reader[0].ToString() + " " + reader[1].ToString() + " sa identifikacionim brojem - " + reader[2].ToString() + " - koristi vrstu treninga: " + reader[3].ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                konekcija.Close();
            }
        }

        private void noviClanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.ShowDialog();
            clanTableAdapter.Fill(dataSet1.Clan);
            dataGridView1.Refresh();
        }

        private void btnAzuriraj_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Da li zelite da sacuvate promene?", "Potvrda", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    this.clanTableAdapter.Update(dataSet1.Clan);
                    MessageBox.Show("Uspenso unete izmene");
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Greska: " + ex.Message);
                }
            }
            else
            {
                this.clanTableAdapter.Fill(this.dataSet1.Clan);
            }
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Zelite da izbrisete clana?", "Potvrda", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int celija = (int)dataGridView1.CurrentRow.Cells[0].Value;
                try
                {
                    konekcija.Open();
                    using (SqlCommand komanda = new SqlCommand("DELETE FROM Clan WHERE IDClana=" + celija.ToString(), konekcija))
                    {
                        komanda.ExecuteNonQuery();
                    }
                    clanTableAdapter.Fill(dataSet1.Clan);
                    MessageBox.Show("Uspesno obrisan clan");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    konekcija.Close();
                }
            }
        }
    }
}
