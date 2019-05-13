using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private int previousOrganizationsAmount;
        private int previousYearsAmount;
        private int previousColumnsAmount;

        public Form1()
        {            
            InitializeComponent();
            InitializeForm();
            numericOrganizations.ValueChanged += NumericOrganizations_ValueChanged;
            this.dataGridView1.RowsAdded += new DataGridViewRowsAddedEventHandler(this.DataGridView1_RowsAdded);
            this.dataGridView1.RowsRemoved += new DataGridViewRowsRemovedEventHandler(DataGridView1_RowsRemoved);
            this.dataGridView1.ColumnAdded += DataGridView1_ColumnAdded;
            this.dataGridView1.ColumnRemoved += DataGridView1_ColumnRemoved;
            numericColumns.ValueChanged += NumericColumns_ValueChanged;
        }

        private void NumericColumns_ValueChanged(object sender, EventArgs e)
        {
            int currentColumnsAmount = Convert.ToInt32(numericColumns.Value);
            if (previousColumnsAmount < currentColumnsAmount)
            {
                dataGridView1.Columns.Add("Column" + currentColumnsAmount, "");
                previousColumnsAmount++;               
            }
            else
            {
                previousColumnsAmount--;
                dataGridView1.Columns.RemoveAt(previousColumnsAmount);                               
            }
        }

        private void DataGridView1_ColumnRemoved(object sender, DataGridViewColumnEventArgs e)
        {
            ChangeWidth();
        }

        private void DataGridView1_ColumnAdded(object sender, DataGridViewColumnEventArgs e)
        {
            ChangeWidth();
        }

        private void DataGridView1_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            ChangeHeight();
        }

        private void DataGridView1_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            ChangeHeight();
        }

        private void ChangeHeight()
        {
            dataGridView1.Height = dataGridView1.Rows.GetRowsHeight(DataGridViewElementStates.Visible);
        }

        private void ChangeWidth()
        {
            dataGridView1.Width = dataGridView1.Columns.GetColumnsWidth(DataGridViewElementStates.Visible)+20;
        }

        /// <summary>
        /// Method to add one row if user increase organizations amount, and remove one row
        /// if user decrease organizations amount
        /// </summary>        
        private void NumericOrganizations_ValueChanged(object sender, EventArgs e)
        {
            int currentOrganizationsAmount = Convert.ToInt32(numericOrganizations.Value);            
            if (previousOrganizationsAmount < currentOrganizationsAmount)
            {           
                dataGridView1.Rows.Add();                
                int i = previousOrganizationsAmount++;
                dataGridView1.Rows[i+1].Cells[0].Value = "f" + (i + 1) + "(X" + (i + 1) + ")";
            }
            else
            {
                dataGridView1.Rows.Remove(dataGridView1.Rows[dataGridView1.Rows.Count-1] );
               int i = --previousOrganizationsAmount-1;
                dataGridView1.Rows[i+1].Cells[0].Value = "f" + (i + 1) + "(X" + (i + 1) + ")";
            }
        }        

        private void InitializeForm()
        {   
            //initialize default values
            previousOrganizationsAmount = Convert.ToInt32(numericOrganizations.Value);
            previousYearsAmount = Convert.ToInt32(numericYears.Value);
            previousColumnsAmount = Convert.ToInt32(numericColumns.Value);

            //first row reserved to heads of the table
            dataGridView1.Rows.Add();
            dataGridView1.Rows[0].Cells[0].Value = "Xi";

            //number of rows depends on default organizations amount
            for (int i = 0; i < numericOrganizations.Value; i++)
            {
                dataGridView1.Rows.Add();
                dataGridView1.Rows[i+1].Cells[0].Value = "f"+(i+1)+"(X"+(i+1)+")";
            }

            //number of columns depends on default columns amount
            for (int i = 0; i < numericColumns.Value; i++)
            {
                dataGridView1.Columns.Add("Column"+(i+1),"0");
            }           
        }
       
    }
}
