using Oracle.DataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Annual_Layout_V2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            // TODO: This line of code loads data into the 'annual_Layout1.QMM_ALL_ANNUAL_LAYOUT' table. You can move, or remove it, as needed.
            this.qMM_ALL_ANNUAL_LAYOUTTableAdapter.Fill(this.annual_Layout1.QMM_ALL_ANNUAL_LAYOUT);
            
        }



        private void dgv_FilterStringChanged(object sender, EventArgs e)
        {
            this.qMMALLANNUALLAYOUTBindingSource1.Filter = this.dgv.FilterString;
        }

        private void dgv_SortStringChanged(object sender, EventArgs e)
        {
            this.qMMALLANNUALLAYOUTBindingSource1.Sort = this.dgv.SortString;
        }

        private void Savebtn_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                qMMALLANNUALLAYOUTBindingSource.EndEdit();
                qMM_ALL_ANNUAL_LAYOUTTableAdapter.Update(this.annual_Layout1.QMM_ALL_ANNUAL_LAYOUT);
                MessageBox.Show("you have been successfully save!!", "Message",MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Message",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Cursor.Current = Cursors.Default;
        }
       

        private void delbtn_Click(object sender, EventArgs e)
        {
            int rowIndex = dgv.CurrentCell.RowIndex;
            dgv.Rows.RemoveAt(rowIndex);        }
    } 
}