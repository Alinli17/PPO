using System;
using System.Globalization;
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
        public Data_Base data_base = new Data_Base();
        public List<TextBox> List_Text_Box = new List<TextBox>();
        public List<Apteka> ap_list = new List<Apteka>();
        public Form1()
        {
            InitializeComponent();
            List_Text_Box.Add(name_medicine);
            List_Text_Box.Add(type);
            List_Text_Box.Add(price);
            List_Text_Box.Add(quantity);
            List_Text_Box.Add(the_supplier);
            List_Text_Box.Add(date_delivery);
            data_base.data_recover(dataGridView1, ap_list);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_База_данных__Аптека_DataSet.Аптека". При необходимости она может быть перемещена или удалена.
            this.аптекаTableAdapter.Fill(this._База_данных__Аптека_DataSet.Аптека);
            data_base.data_recover(dataGridView1, ap_list);
        }

        private void Save_Click(object sender, EventArgs e)
        {
            //аптекаTableAdapter.Update(this._База_данных__Аптека_DataSet);
            DialogResult dr = MessageBox.Show("Сохранить изменения?",
                                "сохранение",
                                MessageBoxButtons.OKCancel,
                                MessageBoxIcon.Question,
                                MessageBoxDefaultButton.Button2);
            if (dr == DialogResult.OK)
            {
                this.Validate();
                this.аптекаBindingSource.EndEdit();
                this.аптекаTableAdapter.Update(this._База_данных__Аптека_DataSet.Аптека);
                _База_данных__Аптека_DataSet.Tables[0].AcceptChanges();
                data_base.data_update(this.dataGridView1, this.ap_list);
                MessageBox.Show("Изменения сохранены!");
            }
        }

        private void dataGridView1_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Удалить запись?",
                "Удаление",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2);
            if (dr == DialogResult.Cancel) e.Cancel = true;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            AddForm af = new AddForm();
            af.Owner = this;
            af.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e) 
        {
            if (name_medicine.Text != "" && type.Text != "" && price.Text != "" && quantity.Text != "")
            {
                DialogResult dr = MessageBox.Show("Добавить запись?",
                "Добавление",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2);
                if (dr == DialogResult.OK)
                {
                    DataRow nRow = _База_данных__Аптека_DataSet.Tables[0].NewRow();
                    nRow["Название товара"] = name_medicine.Text.ToString();
                    nRow["Форма/Тип"] = type.Text.ToString();
                    nRow["Стоимость"] = price.Text.ToString();
                    nRow["Кол-во"] = quantity.Text.ToString();
                    nRow["Поставщик"] = the_supplier.Text.ToString();
                    nRow["Дата доставки"] = date_delivery.Text.ToString();

                    _База_данных__Аптека_DataSet.Tables[0].Rows.Add(nRow);
                    аптекаTableAdapter.Update(_База_данных__Аптека_DataSet.Аптека);
                    _База_данных__Аптека_DataSet.Tables[0].AcceptChanges();
                    dataGridView1.Refresh();
                    data_base.data_update(dataGridView1, ap_list);
                    name_medicine.Clear();
                    type.Clear();
                    price.Clear();
                    quantity.Clear();
                    the_supplier.Clear();
                    date_delivery.Clear();
                }
            }
            else
            {
                DialogResult dr = MessageBox.Show("Некорректный ввод! Поля пусты.",
                "Добавление",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1);
            }

        }

        private void save_Click_1(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Изменить запись?",
                "Изменение",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2);
            if (dr == DialogResult.OK)
            {
                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    data_base.edit(List_Text_Box, row);
                }
                dataGridView1.Refresh();
                data_base.data_update(dataGridView1, ap_list);
            }

        }

        private void delete_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Удалить запись?",
                "Удаление",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2);
            if (dr == DialogResult.OK) data_base.position_delete(this.dataGridView1, this.ap_list);

        }
        private void button_on()
        {
            save.Enabled = true;
            back.Enabled = true;
            add.Enabled = true;
            name_medicine.Enabled = true;
            type.Enabled = true;
            price.Enabled = true;
            quantity.Enabled = true;
            the_supplier.Enabled = true;
            date_delivery.Enabled = true;
        }
        private void button_off()
        {
            save.Enabled = false;
            back.Enabled = false;
            add.Enabled = false;
            name_medicine.Enabled = false;
            type.Enabled = false;
            price.Enabled = false;
            quantity.Enabled = false;
            the_supplier.Enabled = false;
            date_delivery.Enabled = false;
        }

        private void edit_Click(object sender, EventArgs e)
        {
            button_on();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            button_off();
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                data_base.Show(List_Text_Box, row);
            }
        }

        private void back_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Отменить изменения?",
                "Изменение",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2);
            if (dr == DialogResult.OK)
            {
                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                    data_base.Show(List_Text_Box, row);
            }

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (po_nazvaniy_lekarstva.Checked)
            {
                if (find_poloska.Text.Length == 0) find_poloska.Text = "Вы не ввели параметр для поиска";
                else
                {
                    List<Apteka> find_pos = new List<Apteka>();
                    find_pos = data_base.find_name_medicine(this.ap_list, find_poloska.Text);
                    if (find_pos.Count == 0)
                    {
                        DialogResult dr = MessageBox.Show("Записи не найдены",
                        "Поиск",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning,
                        MessageBoxDefaultButton.Button1);
                    }
                    else
                    {
                        rezyltat.BringToFront();
                        rezyltat.DataSource = find_pos;
                    }
                }
            }
            if (po_type.Checked)
            {
                if (find_poloska.Text.Length == 0) find_poloska.Text = "Вы не ввели параметр для поиска";
                else
                {
                    List<Apteka> find_pos = new List<Apteka>();
                    find_pos = data_base.find_type_medicine(this.ap_list, find_poloska.Text);
                    if (find_pos.Count == 0)
                    {
                        DialogResult dr = MessageBox.Show("Записи не найдены",
                        "Поиск",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning,
                        MessageBoxDefaultButton.Button1);
                    }
                    else
                    {
                        rezyltat.BringToFront();
                        rezyltat.DataSource = find_pos;
                    }
                }
            }
            if (po_postavchiky.Checked)
            {
                List<Apteka> find_pos = new List<Apteka>();
                find_pos = data_base.find_postavshik_medicine(this.ap_list, find_poloska.Text);
                if (find_pos.Count == 0)
                {
                    DialogResult dr = MessageBox.Show("Записи не найдены",
                    "Поиск",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning,
                    MessageBoxDefaultButton.Button1);
                }
                else
                {
                    rezyltat.BringToFront();
                    rezyltat.DataSource = find_pos;
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void off_Click(object sender, EventArgs e)
        {
            dataGridView1.BringToFront();
            find_poloska.Clear();
        }

        private void rezyltat_SelectionChanged(object sender, EventArgs e)
        {
            button_off();
            foreach (DataGridViewRow row in rezyltat.SelectedRows)
            {
                data_base.Show_find(List_Text_Box, row);
                foreach (DataGridViewRow Drow in dataGridView1.Rows)
                {
                    if (row.Cells["Name"].Value.ToString() ==
                    Drow.Cells["Nazvanie"].Value.ToString() &&
                    row.Cells["Type"].Value.ToString() ==
                    Drow.Cells["Forma"].Value.ToString() &&
                    row.Cells["Supplier"].Value.ToString() ==
                    Drow.Cells["Postavschik"].Value.ToString() &&
                    row.Cells["DeliveryDate"].Value.ToString() ==
                    Drow.Cells["DataDostavki"].Value.ToString() &&
                    row.Cells["Num"].Value.ToString() ==
                    Drow.Cells["Kolvo"].Value.ToString() &&
                    row.Cells["Price"].Value.ToString() ==
                    Drow.Cells["Stoimost"].Value.ToString())
                    {
                        foreach (DataGridViewRow Drow2 in
                        dataGridView1.SelectedRows)
                        {
                            Drow2.Selected = false;
                        }
                        Drow.Selected = true;
                    }
                }
            }
        }

        private void Deselect_Click(object sender, EventArgs e)
        {
            button_off();
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                row.Selected = false;
            }
            name_medicine.Clear(); type.Clear(); price.Clear(); quantity.Clear();
            the_supplier.Clear(); date_delivery.Clear();
        }
    }
}
