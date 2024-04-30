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
using WindowsFormsAppAP.DataSet1TableAdapters;

namespace WindowsFormsAppAnastasija
{
    public partial class Form2 : Form
    {
        SqlConnection konekcija = new SqlConnection(Konekcija.konString);

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.Trening' table. You can move, or remove it, as needed.
            this.treningTableAdapter.Fill(this.dataSet1.Trening);

        }
        private bool metoda()
        {
            if (cbDodatno.Checked)
            {
                return true;
            }
            else
                return false;
        }
       
        private void btnUpisi_Click(object sender, EventArgs e)
        {
            try
            {
                
                konekcija.Open();

   
                SqlCommand komanda = new SqlCommand("INSERT INTO Clan (IDClana, Ime, Prezime, BrojTelefona, DodatneUsluge,IDTreninga) VALUES (@id,@ime, @prezime, @broj,@dodatno,@idtrening)", konekcija);

               
                komanda.Parameters.AddWithValue("@id", tbID.Text);
                komanda.Parameters.AddWithValue("@ime", tbIme.Text);
                komanda.Parameters.AddWithValue("@prezime", tbPrezime.Text);
                komanda.Parameters.AddWithValue("@broj", tbBroj.Text);
                komanda.Parameters.AddWithValue("@dodatno", metoda());
                komanda.Parameters.AddWithValue("@idtrening", cmbID.SelectedValue);



                
                int rowsAffected = komanda.ExecuteNonQuery();

                
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Novi član je uspešno dodat!");
                }
                else
                {
                    MessageBox.Show("Došlo je do greške pri dodavanju novog člana!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Došlo je do greške: " + ex.Message);
            }
            finally
            {
                
                konekcija.Close();
            }
            
        }
    }
    }


    

