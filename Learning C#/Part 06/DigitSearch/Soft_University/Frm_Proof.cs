using Soft_University.Frameworks;
using Soft_University.Models;
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

namespace Soft_University
{
    public partial class Frm_Proof : Form
    {
        List<Proof> proofs = null;
        Proof selectedProof = null;
        public Frm_Proof()
        {
            InitializeComponent();
            proofs = new List<Proof>();
        }

        private void Register_Click(object sender, EventArgs e)
        {
            if (txt_ProofName.Text.Trim() == "")
            {
                MyMessageBox.ValidationErrorMessage();
                return;
            }

            string cmd = "";

            if (selectedProof == null)
            {
                cmd = $"INSERT INTO dbo.Proof(ProofName) VALUES(N'{txt_ProofName.Text.Trim()}')";
            }
            else
            {
                cmd = $"UPDATE dbo.Proof SET ProofName = N'{txt_ProofName.Text.Trim()}' WHERE ID = {selectedProof.Id}";
            }
            
            SqlConnection connection = new SqlConnection("Data Source=ICT10111109;Initial Catalog=UnivDB;Integrated Security=true;");
            SqlCommand command = new SqlCommand();
            command.CommandText = cmd;
            command.Connection = connection;

            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();

            MyMessageBox.SuccessMessage();
            ClearText();
            //Update Grid
            Show_Proof();
        }

        private void ClearText()
        {
            txt_ProofName.Text = "";
            txt_ProofName.Focus();
        }

        private void Frm_Proof_Load(object sender, EventArgs e)
        {
            Show_Proof();
        }

        private void Show_Proof()
        {
            proofs.Clear();

            string cmd = $"SELECT * FROM dbo.Proof";
            SqlConnection connection = new SqlConnection("Data Source=ICT10111109;Initial Catalog=UnivDB;Integrated Security=true;");
            SqlCommand command = new SqlCommand();
            command.CommandText = cmd;
            command.Connection = connection;

            connection.Open();

            var reader = command.ExecuteReader();
            while (reader.Read())
            {
                Proof proof = new Proof
                {
                    Id = Convert.ToInt32(reader[0]),
                    ProofName = reader[1].ToString()
                };

                proofs.Add(proof);
            }

            connection.Close();
            ShoW_Grid();           
        }

        private void ShoW_Grid()
        {
            Grid.AutoGenerateColumns = false;
            Grid.DataSource = proofs.ToList();
            if (Grid.RowCount != 0)
            {
                Grid.Rows[0].Selected = false;
            }
        }

        private void Grid_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }

            int _id = Convert.ToInt32(Grid["Col_ID", e.RowIndex].Value);
            selectedProof = Find_Proof(_id);

            if (selectedProof != null)
            {
                txt_ProofName.Text = selectedProof.ProofName;
            }          
        }

        private Proof Find_Proof(int id)
        {
            foreach (var proof in proofs)
            {
                if (proof.Id == id)
                {
                    return proof;
                }
            }

            return null;
        }

        private void Remove_Click(object sender, EventArgs e)
        {
            if (selectedProof == null)
            {
                MyMessageBox.SelectionErrorMessage();
                return;
            }

            if (!MyMessageBox.ConfirmedMessage())
            {
                return;
            }

            string cmd = $"DELETE FROM dbo.Proof WHERE ID = {selectedProof.Id}";
            SqlConnection connection = new SqlConnection("Data Source=ICT10111109;Initial Catalog=UnivDB;Integrated Security=true;");
            SqlCommand command = new SqlCommand();
            command.CommandText = cmd;
            command.Connection = connection;

            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();

            MyMessageBox.SuccessMessage();
            ClearText();
            //Update Grid
            Show_Proof();
        }

        private void NewRegister_Click(object sender, EventArgs e)
        {
            ClearText();
        }

        private void Return_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
