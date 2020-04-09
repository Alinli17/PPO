using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Data_Base
    {
       
        public void data_recover(DataGridView a, List<Apteka> l)
        {
            foreach (DataGridViewRow row in a.Rows)
            {
                Apteka buf = new Apteka();
                buf.ConvertToApteka(row);
                l.Add(buf);
            }
        }
        public void data_update(DataGridView a, List<Apteka> l)
        {

            l.Clear();
            foreach (DataGridViewRow row in a.Rows)
            {
                Apteka buf = new Apteka();
                buf.ConvertToApteka(row);
                l.Add(buf);
            }
        }

        
        public void edit(List<TextBox>textBoxes, DataGridViewRow row)
        {
            row.Cells["Nazvanie"].Value = textBoxes[0].Text.ToString();
            row.Cells["Forma"].Value = textBoxes[1].Text.ToString();
            row.Cells["Stoimost"].Value = textBoxes[2].Text.ToString();
            row.Cells["Kolvo"].Value = Convert.ToInt32(textBoxes[3].Text.ToString());
            row.Cells["Postavschik"].Value = textBoxes[4].Text.ToString();
            row.Cells["DataDostavki"].Value = textBoxes[5].Text.ToString();
        }
        

        
        public void position_delete(DataGridView a, List<Apteka> l)
        {
            foreach (DataGridViewRow row in a.SelectedRows)
            {
                a.Rows.Remove(row);
            }
            this.data_update(a, l);
        }
        public List<Apteka> find_name_medicine(List<Apteka> l, string s)
        {
            List<Apteka> find = new List<Apteka>();
            foreach (Apteka medicine in l)
            {
                if (medicine.Name.Contains(s))
                {
                    find.Add(medicine);
                }
            }
            return find;
        }
        public List<Apteka> find_type_medicine(List<Apteka> l, string s)
        {
            List<Apteka> find = new List<Apteka>();
            foreach (Apteka medicine in l)
            {
                if (medicine.Type.Contains(s))
                {
                    find.Add(medicine);
                }
            }
            return find;
        }
        public List<Apteka> find_postavshik_medicine(List<Apteka> l, string s)
        {
            List<Apteka> find = new List<Apteka>();
            foreach (Apteka medicine in l)
            {
                if (medicine.Supplier.Contains(s))
                {
                    find.Add(medicine);
                }
            }
            return find;
        }
        
        public void Show(List<TextBox> f, DataGridViewRow row)
        {
            f[0].Text = row.Cells["Nazvanie"].Value.ToString();
            f[1].Text = row.Cells["Forma"].Value.ToString();
            f[2].Text = row.Cells["Stoimost"].Value.ToString();
            f[3].Text = row.Cells["Kolvo"].Value.ToString();
            f[4].Text = row.Cells["Postavschik"].Value.ToString();
            f[5].Text = row.Cells["DataDostavki"].Value.ToString();
        }
        public void Show_find(List<TextBox> f, DataGridViewRow row)
        {
            f[0].Text = row.Cells["Name"].Value.ToString();
            f[1].Text = row.Cells["Type"].Value.ToString();
            f[2].Text = row.Cells["Supplier"].Value.ToString();
            f[3].Text = row.Cells["DeliveryDate"].Value.ToString();
            f[4].Text = row.Cells["Num"].Value.ToString();
            f[5].Text = row.Cells["Price"].Value.ToString();
        }
    }
}
