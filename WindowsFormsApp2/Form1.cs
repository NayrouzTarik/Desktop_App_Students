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
using Npgsql;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        NpgsqlConnection conn;

        public Form1()
        {
            InitializeComponent();
            conn = new NpgsqlConnection("host=localhost;port=5432;Database=postgres;Username=postgres;Password=1234");
        }

        // Check Connection Button Click Event
        private void btn_check_cnt(object sender, EventArgs e)
        {
            conn.Open();
            MessageBox.Show(conn.State.ToString());
            conn.Close();
            MessageBox.Show(conn.State.ToString());
        }

        // Form Load Event
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        // Affichage du data from data base
        private void LoadData()
        {
            string query = "SELECT * FROM public.\"TB1\"";
            using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(query, conn))
            {
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                dataGridView1.DataSource = dataTable;
            }
        }

        // Ajout Data Button Click Event
        private void btnAddData_Click(object sender, EventArgs e)
        {
            string nom = txtNom.Text;
            string prenom = txtPrenom.Text;
            string age = txtAge.Text;
            string gender = txtGenre.Text;
            string branche = txtBranche.Text;

            string query = "INSERT INTO public.\"TB1\" (nom, prenom, age, gender, branche) VALUES (@Nom, @Prenom, @Age, @Gender, @Branche)";

            using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@Nom", nom);
                cmd.Parameters.AddWithValue("@Prenom", prenom);
                cmd.Parameters.AddWithValue("@Age", age);
                cmd.Parameters.AddWithValue("@Gender", gender);
                cmd.Parameters.AddWithValue("@Branche", branche);

                try
                {
                    conn.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();
                    MessageBox.Show($"{rowsAffected} row(s) inserted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error inserting data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        // Supprimer Data Button Click Event
        private void btnDeleteData_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["id_etu"].Value);

                string query = "DELETE FROM public.\"TB1\" WHERE ID_ETU = @ID";
                using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ID", id);

                    try
                    {
                        conn.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();
                        MessageBox.Show($"{rowsAffected} row(s) deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadData();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error deleting data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        conn.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a row to delete.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        
        //Updater le Data Button Click Event
        private void btnUpdateData_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["id_etu"].Value);

                string nom = txtNom.Text;
                string prenom = txtPrenom.Text;
                string age = txtAge.Text;
                string genre = txtGenre.Text;
                string branche = txtBranche.Text;

                string query = "UPDATE public.\"TB1\" SET nom = @Nom, prenom = @Prenom, age = @Age, gender = @Genre, branche = @Branche WHERE ID_ETU = @ID";

                using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Nom", nom);
                    cmd.Parameters.AddWithValue("@Prenom", prenom);
                    cmd.Parameters.AddWithValue("@Age", age);
                    cmd.Parameters.AddWithValue("@Genre", genre);
                    cmd.Parameters.AddWithValue("@Branche", branche);
                    cmd.Parameters.AddWithValue("@ID", id);

                    try
                    {
                        conn.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();
                        MessageBox.Show($"{rowsAffected} row(s) updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadData();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error updating data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        conn.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a row to update.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

    }
}
