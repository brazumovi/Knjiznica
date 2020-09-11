using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using Knjiznica.Properties;

namespace Knjiznica
{
    public partial class knjiznicaMainForm : Form
    {
        public knjiznicaMainForm()
        {
            InitializeComponent();
        }

        private void knjiznicaMainForm_Load(object sender, EventArgs e)
        {
            comboBoxPretraga.Items.Add("ID");
            comboBoxPretraga.Items.Add("Naziv knjige");
            comboBoxPretraga.Items.Add("Autor");
            comboBoxPretraga.Items.Add("Godina izdanja");
            comboBoxPretraga.SelectedIndex = 0;

            if (Properties.Settings.Default.VelicinaForme.Width != 0 && Properties.Settings.Default.VelicinaForme.Height != 0 )
            {
                this.Size = Properties.Settings.Default.VelicinaForme;
            }
            this.BackColor = Properties.Settings.Default.BojaPozadine;
        }
    

        OleDbConnection conn = new OleDbConnection();
        OleDbCommand cmd = new OleDbCommand();

        private void labelID_Click(object sender, EventArgs e)
        {
            txtID.Focus();
        }

        private void labelKnjiga_Click(object sender, EventArgs e)
        {
            txtKnjiga.Focus();
        }

        private void labelAutor_Click(object sender, EventArgs e)
        {
            txtAutor.Focus();
        }

        private void labelGod_Click(object sender, EventArgs e)
        {
            txtGod.Focus();
        }

        private void labelIzdavac_Click(object sender, EventArgs e)
        {
            txtIzdavac.Focus();
        }

        private void labelISBN_Click(object sender, EventArgs e)
        {
            txtISBN.Focus();
        }

        private void labelPosudio_Click(object sender, EventArgs e)
        {
            txtPosudio.Focus();
        }

        private void zatvoriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bojaPozadineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog dijalog = new ColorDialog();
            if(dijalog.ShowDialog() == DialogResult.OK)
            {
                this.BackColor = dijalog.Color;
            }
        }

        private void btnSpajanje_Click(object sender, EventArgs e)
        {
            try
            {
                conn.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=..\..\Knjiznica.accdb;Persist Security Info=False;";
                conn.Open();
                MessageBox.Show("Uspostavili ste uspješnu konekciju sa bazom!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška pri spajanju sa bazom podataka!\n" + ex);
            }
        }

        private void btnOdspoji_Click(object sender, EventArgs e)
        {
            conn.Close();
            MessageBox.Show("Uspješno ste se odspojili od baze!");
        }

        private void btnAzur_Click(object sender, EventArgs e)
        {
            try
            {
                cmd.Connection = conn;
                cmd.CommandText = "select *from Knjige";
                OleDbDataAdapter data = new OleDbDataAdapter(cmd);
                DataTable table = new DataTable();
                data.Fill(table);

                if (table.Rows.Count.ToString().Equals("0"))
                {
                    MessageBox.Show("Baza je prazna");
                }

                dataGridView.DataSource = table;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Niste se spojili na bazu!\n" + ex.Message);
            }
        }

        private void spajanjeSBazomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnSpajanje_Click(sender, e);
        }

        private void odspojiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnOdspoji_Click(sender, e);
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            try
            {
                cmd.CommandText = "insert into Knjige (ID, Knjiga, Autor, GodinaIzdanja, Izdavac, ISBN, Status) values ('" + txtID.Text + "','" + txtKnjiga.Text + "', '" + txtAutor.Text + "', '" + txtGod.Text + "', '" + txtIzdavac.Text + "', '" + txtISBN.Text +"', 'neposudjena')";
                cmd.ExecuteNonQuery();
                MessageBox.Show("Knjiga je uspješno dodana u knjižnicu! Ažurirajte pregled!");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška prilikom spremanja. Krivo uneseni podaci!\n" + ex);
            }
        }

        private void btnBrisi_Click(object sender, EventArgs e)
        {
            try
            { 
                int id = Int32.Parse(txtID.Text);
                cmd.CommandText = "select *from Knjige where ID=" + id +"";
                OleDbDataAdapter data = new OleDbDataAdapter(cmd);
                DataTable table = new DataTable();
                data.Fill(table);

                if (table.Rows.Count.ToString().Equals("0"))
                {
                    MessageBox.Show("Ta knjiga ne postoji u bazi!");
                }
                else
                {

                    cmd.CommandText = "delete from Knjige where ID= " + id + "";
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Knjiga je uspješno obrisana. Ažurirajte pregled!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška pri brisanju!\n" + ex);
            }
        }

        private void dodajToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnDodaj_Click(sender, e);
        }

        private void obrišiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnBrisi_Click(sender, e);
        }

        private void btnIzmjeni_Click(object sender, EventArgs e)
        {
            try
            {               
                    cmd.CommandText = "update Knjige set Knjiga = '" + txtKnjiga.Text + "', Autor='" + txtAutor.Text + "', GodinaIzdanja='" + txtGod.Text + "', Izdavac='" + txtIzdavac.Text + "', ISBN='" + txtISBN.Text + "' where ID =" + txtID.Text + "";
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Podaci su uspješno ažurirani! Ažurirajte pregled!");
            }
            catch(Exception ex) {
                MessageBox.Show("Greška pri izmjeni podataka!\n" + ex);
            }
        }

        private void izmjeniToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnIzmjeni_Click(sender, e);
        }

        private void btnPosudi_Click(object sender, EventArgs e)
        {
                String timeStamp = DateTime.Now.ToString();
                try
                {
                    cmd.CommandText = "update Knjige set Status = 'posudjena', Posudio = '" + txtPosudio.Text + "', Datum ='" + timeStamp + "' where ID =" + txtID.Text + "";
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Knjiga uspješno posuđena! Ažurirajte pregled!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Nepravilno uneseni podaci. Greška pri izmjeni podataka!\n" + ex);
                }
        }

        private void btnVrati_Click(object sender, EventArgs e)
        {
            try
            {
                cmd.CommandText = "update Knjige set Status = 'neposudjena', Posudio = '', Datum = '' where ID =" + txtID.Text + "";
                cmd.ExecuteNonQuery();
                MessageBox.Show("Knjiga uspješno vraćena! Ažurirajte pregled!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nepravilno uneseni podaci. Greška pri izmjeni podataka!\n" + ex);
            }
        }

        private void txtPretraga_TextChanged(object sender, EventArgs e)
        {
            try
            {
                switch (comboBoxPretraga.SelectedIndex)
                {
                    case 0:
                        cmd.CommandText = "select *from Knjige where ID like '" + txtPretraga.Text + "%'";
                        cmd.ExecuteNonQuery();
                        break;
                    case 1:
                        cmd.CommandText = "select *from Knjige where Knjiga like '" + txtPretraga.Text + "%'";
                        cmd.ExecuteNonQuery();
                        break;
                    case 2:
                        cmd.CommandText = "select *from Knjige where Autor like '" + txtPretraga.Text + "%'";
                        cmd.ExecuteNonQuery();
                        break;
                    case 3:
                        cmd.CommandText = "select *from Knjige where GodinaIzdanja like '" + txtPretraga.Text + "%'";
                        cmd.ExecuteNonQuery();
                        break;
                }
                OleDbDataAdapter data = new OleDbDataAdapter(cmd);
                DataTable table2 = new DataTable();
                data.Fill(table2);
                dataGridView.DataSource = table2;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška pri pretraživanju!\n" + ex);
            }
        }

        private void btnCisti_Click(object sender, EventArgs e)
        {
            txtID.Clear();
            txtKnjiga.Clear();
            txtAutor.Clear();
            txtGod.Clear();
            txtIzdavac.Clear();
            txtISBN.Clear();
            txtPosudio.Clear();
        }

        private void knjiznicaMainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                Properties.Settings.Default.VelicinaForme = this.Size;
                Properties.Settings.Default.BojaPozadine = this.BackColor;
                Properties.Settings.Default.Save();
            }
        }
    }
}

