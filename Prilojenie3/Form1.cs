using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prilojenie3
{
    public partial class Form1 : Form
    {
        private int GetNextID()
        {
            int nextID = 1;

            if (database4DataSet.Gradove.Rows.Count > 0)
            {
                nextID = database4DataSet.Gradove.Max(row => row.ID) + 1;
            }

            return nextID;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.gradoveTableAdapter.Fill(this.database4DataSet.Gradove);
            gradoveBindingSource.DataSource = this.database4DataSet.Gradove;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNaselenie.Text) || string.IsNullOrEmpty(txtKod.Text) || string.IsNullOrEmpty(txtBudget.Text) || string.IsNullOrEmpty(txtGrad.Text) || string.IsNullOrEmpty(txtKmet.Text))
            {
                MessageBox.Show("Please fill in all fields before creating a new row.");
                return;
            }

            var newRow = this.database4DataSet.Gradove.NewGradoveRow();
            newRow.ID = GetNextID();
            newRow.Град = txtGrad.Text;
            newRow.Население = Convert.ToInt32(txtNaselenie.Text);
            newRow.Пощенски_код = Convert.ToInt32(txtKod.Text);
            newRow.Кмет = txtKmet.Text;
            newRow.Бюджет = Convert.ToDecimal(txtBudget.Text);

            this.database4DataSet.Gradove.AddGradoveRow(newRow);

            this.gradoveTableAdapter.Update(this.database4DataSet.Gradove);

            dataGridView1.Refresh();
        }


        private void btnRead_Click(object sender, EventArgs e)
        {
            string searchValue = txtSearch.Text.Trim();

            if (string.IsNullOrEmpty(searchValue))
            {
                MessageBox.Show("Please enter a value to search for.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Find the row in the dataset
            DataRow[] result = database4DataSet.Gradove.Select(string.Format("Град = '{0}'", searchValue));

            if (result.Length == 0)
            {
                MessageBox.Show("Град not found in the database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Select the row in the DataGridView
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["градDataGridViewTextBoxColumn"].Value.ToString() == searchValue)
                {
                    dataGridView1.CurrentCell = row.Cells["градDataGridViewTextBoxColumn"];
                    dataGridView1.Rows[row.Index].Selected = true;
                    break;
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                int rowIndex = dataGridView1.CurrentCell.RowIndex;
                var row = this.database4DataSet.Gradove[rowIndex];

                // Update the values in the row
                row.Град = txtGrad.Text;
                row.Население = Convert.ToInt32(txtNaselenie.Text);
                row.Пощенски_код = Convert.ToInt32(txtKod.Text);
                row.Кмет = txtKmet.Text;
                row.Бюджет = Convert.ToDecimal(txtBudget.Text);

                // Check if the row has been updated by another user or process
                var originalRow = this.database4DataSet.Gradove.GetChanges(DataRowState.Modified).Rows[0];
                if (originalRow != null && originalRow["Timestamp"].ToString() != row["Timestamp"].ToString())
                {
                    MessageBox.Show("The row has been modified by another user. Please refresh the data and try again.");
                }
                else
                {
                    // Update the row in the database
                    this.gradoveTableAdapter.Update(row);
                    MessageBox.Show("The row has been updated successfully.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Updated.");
            }
        }



        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
               
                // Delete the selected row
                dataGridView1.Rows.Remove(dataGridView1.SelectedRows[0]);

                // Update the database
                this.gradoveTableAdapter.Update(this.database4DataSet.Gradove);
            }
            catch (DBConcurrencyException ex)
            {
                // Display an error message to the user
                MessageBox.Show("Row deleted.", "Action", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Select a new row", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        
    }
}
