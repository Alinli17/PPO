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
    public partial class AddForm : Form
    {
        public AddForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Addbutton_Click(object sender, EventArgs e)
        {
            Form1 main = this.Owner as Form1;
            if (main != null)
            {
                DataRow nRow = main._База_данных__Аптека_DataSet.Tables[0].NewRow();
                int rc = main.dataGridView1.RowCount + 1;

                for (int i = 0; i < main.dataGridView1.RowCount; i++)
                {
                    if (Convert.ToInt32(main.dataGridView1.Rows[i].Cells[0].Value) != rc) nRow[0] = rc;
                    else
                    {
                        rc++;
                        nRow[0] = rc;
                    }
                }
                nRow[1] = textBox1.Text;
                nRow[2] = textBox2.Text;
                nRow[3] = textBox3.Text;
                nRow[4] = textBox4.Text;
                nRow[5] = textBox5.Text;
                nRow[6] = Convert.ToDateTime(dateTimePicker1.Value);
                main._База_данных__Аптека_DataSet.Tables[0].Rows.Add(nRow);
                main.аптекаTableAdapter.Update(main._База_данных__Аптека_DataSet.Аптека);
                main._База_данных__Аптека_DataSet.Tables[0].AcceptChanges();
                main.dataGridView1.Refresh();
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
                dateTimePicker1.CustomFormat = "1/1/2000";
            }

        }
    }
}
    
