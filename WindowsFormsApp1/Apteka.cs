using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public class Apteka
    {
        private string name;
        private string type;
        private string supplier;
        private DateTime delivery_date;
        private int num;
        private double price;
        public string Name {
            get {return name; }
            set { name=value; }
        }
        public string Type
        {
            get { return type; }
            set { type = value; }
        }
        public string Supplier
        {
            get { return supplier; }
            set { supplier = value; }
        }
        public DateTime DeliveryDate
        {
            get { return delivery_date; }
            set { delivery_date = value; }
        }
        public int Num
        {
            get { return num; }
            set { num = value; }
        }
        public double Price
        {
            get { return price; }
            set { price = value; }
        }
        public Apteka() { }
        public void ConvertToApteka (DataGridViewRow row)
        {
            this.Name = row.Cells["Nazvanie"].Value.ToString();
            this.Type = row.Cells["Forma"].Value.ToString();
            this.Price = Convert.ToDouble(row.Cells["Stoimost"].Value);
            this.Num = Convert.ToInt32(row.Cells["Kolvo"].Value);
            this.Supplier = row.Cells["Postavschik"].Value.ToString();
            this.DeliveryDate = Convert.ToDateTime(row.Cells["DataDostavki"].Value);
        }
    }
}

