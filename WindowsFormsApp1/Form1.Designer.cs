﻿namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Kod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nazvanie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Forma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stoimost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kolvo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Postavschik = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataDostavki = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aptekaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bD_AptekaDataSet = new WindowsFormsApp1.BD_AptekaDataSet();
            this.save_all = new System.Windows.Forms.Button();
            this.Drag_information = new System.Windows.Forms.GroupBox();
            this.save = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.edit = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.date_delivery = new System.Windows.Forms.TextBox();
            this.Delivery_Date = new System.Windows.Forms.Label();
            this.the_supplier = new System.Windows.Forms.TextBox();
            this.Provider = new System.Windows.Forms.Label();
            this.quantity = new System.Windows.Forms.TextBox();
            this.Amount = new System.Windows.Forms.Label();
            this.Rub = new System.Windows.Forms.Label();
            this.price = new System.Windows.Forms.TextBox();
            this.Cost = new System.Windows.Forms.Label();
            this.type = new System.Windows.Forms.TextBox();
            this.Shape_Type = new System.Windows.Forms.Label();
            this.name_medicine = new System.Windows.Forms.TextBox();
            this.Drag_name = new System.Windows.Forms.Label();
            this.delete = new System.Windows.Forms.Button();
            this.Scan = new System.Windows.Forms.GroupBox();
            this.off = new System.Windows.Forms.Button();
            this.Find = new System.Windows.Forms.Button();
            this.po_postavchiky = new System.Windows.Forms.RadioButton();
            this.po_type = new System.Windows.Forms.RadioButton();
            this.Parameters = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.find_poloska = new System.Windows.Forms.TextBox();
            this.po_nazvaniy_lekarstva = new System.Windows.Forms.RadioButton();
            this.rezyltat = new System.Windows.Forms.DataGridView();
            this.Deselect = new System.Windows.Forms.Button();
            this.aptekaTableAdapter = new WindowsFormsApp1.BD_AptekaDataSetTableAdapters.AptekaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aptekaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD_AptekaDataSet)).BeginInit();
            this.Drag_information.SuspendLayout();
            this.Scan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rezyltat)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Kod,
            this.Nazvanie,
            this.Forma,
            this.Stoimost,
            this.Kolvo,
            this.Postavschik,
            this.DataDostavki});
            this.dataGridView1.DataSource = this.aptekaBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(6, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(983, 228);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            this.dataGridView1.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dataGridView1_UserDeletingRow);
            // 
            // Kod
            // 
            this.Kod.DataPropertyName = "Код";
            this.Kod.HeaderText = "Код";
            this.Kod.Name = "Kod";
            // 
            // Nazvanie
            // 
            this.Nazvanie.DataPropertyName = "Название товара";
            this.Nazvanie.HeaderText = "Название товара";
            this.Nazvanie.Name = "Nazvanie";
            // 
            // Forma
            // 
            this.Forma.DataPropertyName = "Форма/Тип";
            this.Forma.HeaderText = "Форма/Тип";
            this.Forma.Name = "Forma";
            // 
            // Stoimost
            // 
            this.Stoimost.DataPropertyName = "Стоимость";
            this.Stoimost.HeaderText = "Стоимость";
            this.Stoimost.Name = "Stoimost";
            // 
            // Kolvo
            // 
            this.Kolvo.DataPropertyName = "Кол-во";
            this.Kolvo.HeaderText = "Кол-во";
            this.Kolvo.Name = "Kolvo";
            // 
            // Postavschik
            // 
            this.Postavschik.DataPropertyName = "Поставщик";
            this.Postavschik.HeaderText = "Поставщик";
            this.Postavschik.Name = "Postavschik";
            // 
            // DataDostavki
            // 
            this.DataDostavki.DataPropertyName = "Дата доставки";
            this.DataDostavki.HeaderText = "Дата доставки";
            this.DataDostavki.Name = "DataDostavki";
            // 
            // aptekaBindingSource
            // 
            this.aptekaBindingSource.DataMember = "Apteka";
            this.aptekaBindingSource.DataSource = this.bD_AptekaDataSet;
            // 
            // bD_AptekaDataSet
            // 
            this.bD_AptekaDataSet.DataSetName = "BD_AptekaDataSet";
            this.bD_AptekaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // save_all
            // 
            this.save_all.Location = new System.Drawing.Point(346, 483);
            this.save_all.Name = "save_all";
            this.save_all.Size = new System.Drawing.Size(309, 33);
            this.save_all.TabIndex = 1;
            this.save_all.Text = "Сохранить всё";
            this.save_all.UseVisualStyleBackColor = true;
            this.save_all.Click += new System.EventHandler(this.Save_Click);
            // 
            // Drag_information
            // 
            this.Drag_information.Controls.Add(this.save);
            this.Drag_information.Controls.Add(this.back);
            this.Drag_information.Controls.Add(this.edit);
            this.Drag_information.Controls.Add(this.add);
            this.Drag_information.Controls.Add(this.date_delivery);
            this.Drag_information.Controls.Add(this.Delivery_Date);
            this.Drag_information.Controls.Add(this.the_supplier);
            this.Drag_information.Controls.Add(this.Provider);
            this.Drag_information.Controls.Add(this.quantity);
            this.Drag_information.Controls.Add(this.Amount);
            this.Drag_information.Controls.Add(this.Rub);
            this.Drag_information.Controls.Add(this.price);
            this.Drag_information.Controls.Add(this.Cost);
            this.Drag_information.Controls.Add(this.type);
            this.Drag_information.Controls.Add(this.Shape_Type);
            this.Drag_information.Controls.Add(this.name_medicine);
            this.Drag_information.Controls.Add(this.Drag_name);
            this.Drag_information.Location = new System.Drawing.Point(0, 234);
            this.Drag_information.Name = "Drag_information";
            this.Drag_information.Size = new System.Drawing.Size(511, 237);
            this.Drag_information.TabIndex = 3;
            this.Drag_information.TabStop = false;
            this.Drag_information.Text = "Инфомация о препарате";
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(393, 198);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(103, 33);
            this.save.TabIndex = 13;
            this.save.Text = "Сохранить";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click_1);
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(268, 198);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(101, 33);
            this.back.TabIndex = 12;
            this.back.Text = "Вернуть";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // edit
            // 
            this.edit.Location = new System.Drawing.Point(141, 198);
            this.edit.Name = "edit";
            this.edit.Size = new System.Drawing.Size(101, 33);
            this.edit.TabIndex = 11;
            this.edit.Text = "Изменить";
            this.edit.UseVisualStyleBackColor = true;
            this.edit.Click += new System.EventHandler(this.edit_Click);
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(12, 199);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(101, 33);
            this.add.TabIndex = 4;
            this.add.Text = "Добавить";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // date_delivery
            // 
            this.date_delivery.Location = new System.Drawing.Point(302, 153);
            this.date_delivery.Name = "date_delivery";
            this.date_delivery.Size = new System.Drawing.Size(142, 22);
            this.date_delivery.TabIndex = 4;
            // 
            // Delivery_Date
            // 
            this.Delivery_Date.AutoSize = true;
            this.Delivery_Date.Location = new System.Drawing.Point(299, 133);
            this.Delivery_Date.Name = "Delivery_Date";
            this.Delivery_Date.Size = new System.Drawing.Size(106, 17);
            this.Delivery_Date.TabIndex = 10;
            this.Delivery_Date.Text = "Дата доставки";
            // 
            // the_supplier
            // 
            this.the_supplier.Location = new System.Drawing.Point(302, 103);
            this.the_supplier.Name = "the_supplier";
            this.the_supplier.Size = new System.Drawing.Size(142, 22);
            this.the_supplier.TabIndex = 4;
            // 
            // Provider
            // 
            this.Provider.AutoSize = true;
            this.Provider.Location = new System.Drawing.Point(299, 83);
            this.Provider.Name = "Provider";
            this.Provider.Size = new System.Drawing.Size(81, 17);
            this.Provider.TabIndex = 9;
            this.Provider.Text = "Поставщик";
            // 
            // quantity
            // 
            this.quantity.Location = new System.Drawing.Point(302, 58);
            this.quantity.Name = "quantity";
            this.quantity.Size = new System.Drawing.Size(142, 22);
            this.quantity.TabIndex = 8;
            // 
            // Amount
            // 
            this.Amount.AutoSize = true;
            this.Amount.Location = new System.Drawing.Point(299, 34);
            this.Amount.Name = "Amount";
            this.Amount.Size = new System.Drawing.Size(57, 17);
            this.Amount.TabIndex = 7;
            this.Amount.Text = "Кол-во:";
            // 
            // Rub
            // 
            this.Rub.AutoSize = true;
            this.Rub.Location = new System.Drawing.Point(166, 160);
            this.Rub.Name = "Rub";
            this.Rub.Size = new System.Drawing.Size(35, 17);
            this.Rub.TabIndex = 6;
            this.Rub.Text = "руб.";
            // 
            // price
            // 
            this.price.Location = new System.Drawing.Point(59, 157);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(104, 22);
            this.price.TabIndex = 5;
            // 
            // Cost
            // 
            this.Cost.AutoSize = true;
            this.Cost.Location = new System.Drawing.Point(56, 133);
            this.Cost.Name = "Cost";
            this.Cost.Size = new System.Drawing.Size(82, 17);
            this.Cost.TabIndex = 4;
            this.Cost.Text = "Стоимость:";
            // 
            // type
            // 
            this.type.Location = new System.Drawing.Point(59, 103);
            this.type.Name = "type";
            this.type.Size = new System.Drawing.Size(142, 22);
            this.type.TabIndex = 3;
            // 
            // Shape_Type
            // 
            this.Shape_Type.AutoSize = true;
            this.Shape_Type.Location = new System.Drawing.Point(56, 83);
            this.Shape_Type.Name = "Shape_Type";
            this.Shape_Type.Size = new System.Drawing.Size(87, 17);
            this.Shape_Type.TabIndex = 2;
            this.Shape_Type.Text = "Форма/Тип:";
            // 
            // name_medicine
            // 
            this.name_medicine.Location = new System.Drawing.Point(59, 54);
            this.name_medicine.Name = "name_medicine";
            this.name_medicine.Size = new System.Drawing.Size(142, 22);
            this.name_medicine.TabIndex = 1;
            // 
            // Drag_name
            // 
            this.Drag_name.AutoSize = true;
            this.Drag_name.Location = new System.Drawing.Point(56, 34);
            this.Drag_name.Name = "Drag_name";
            this.Drag_name.Size = new System.Drawing.Size(148, 17);
            this.Drag_name.TabIndex = 0;
            this.Drag_name.Text = "Название лекарства:";
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(680, 483);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(309, 33);
            this.delete.TabIndex = 4;
            this.delete.Text = "Удалить";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // Scan
            // 
            this.Scan.Controls.Add(this.off);
            this.Scan.Controls.Add(this.Find);
            this.Scan.Controls.Add(this.po_postavchiky);
            this.Scan.Controls.Add(this.po_type);
            this.Scan.Controls.Add(this.Parameters);
            this.Scan.Controls.Add(this.label8);
            this.Scan.Controls.Add(this.find_poloska);
            this.Scan.Controls.Add(this.po_nazvaniy_lekarstva);
            this.Scan.Location = new System.Drawing.Point(517, 234);
            this.Scan.Name = "Scan";
            this.Scan.Size = new System.Drawing.Size(472, 237);
            this.Scan.TabIndex = 14;
            this.Scan.TabStop = false;
            this.Scan.Text = "Поиск";
            // 
            // off
            // 
            this.off.Location = new System.Drawing.Point(263, 198);
            this.off.Name = "off";
            this.off.Size = new System.Drawing.Size(162, 32);
            this.off.TabIndex = 22;
            this.off.Text = "Сбросить";
            this.off.UseVisualStyleBackColor = true;
            this.off.Click += new System.EventHandler(this.off_Click);
            // 
            // Find
            // 
            this.Find.Location = new System.Drawing.Point(43, 198);
            this.Find.Name = "Find";
            this.Find.Size = new System.Drawing.Size(162, 33);
            this.Find.TabIndex = 21;
            this.Find.Text = "Найти";
            this.Find.UseVisualStyleBackColor = true;
            this.Find.Click += new System.EventHandler(this.search_Click);
            // 
            // po_postavchiky
            // 
            this.po_postavchiky.AutoSize = true;
            this.po_postavchiky.Location = new System.Drawing.Point(9, 113);
            this.po_postavchiky.Name = "po_postavchiky";
            this.po_postavchiky.Size = new System.Drawing.Size(129, 21);
            this.po_postavchiky.TabIndex = 20;
            this.po_postavchiky.TabStop = true;
            this.po_postavchiky.Text = "по Поставщику";
            this.po_postavchiky.UseVisualStyleBackColor = true;
            // 
            // po_type
            // 
            this.po_type.AutoSize = true;
            this.po_type.Location = new System.Drawing.Point(9, 86);
            this.po_type.Name = "po_type";
            this.po_type.Size = new System.Drawing.Size(131, 21);
            this.po_type.TabIndex = 19;
            this.po_type.TabStop = true;
            this.po_type.Text = "по Форме/Типу";
            this.po_type.UseVisualStyleBackColor = true;
            // 
            // Parameters
            // 
            this.Parameters.AutoSize = true;
            this.Parameters.Location = new System.Drawing.Point(6, 34);
            this.Parameters.Name = "Parameters";
            this.Parameters.Size = new System.Drawing.Size(432, 17);
            this.Parameters.TabIndex = 18;
            this.Parameters.Text = "Выберите параментр, по которому будет осуществляться поис:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 59);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 17);
            this.label8.TabIndex = 17;
            // 
            // find_poloska
            // 
            this.find_poloska.Location = new System.Drawing.Point(9, 140);
            this.find_poloska.Name = "find_poloska";
            this.find_poloska.Size = new System.Drawing.Size(429, 22);
            this.find_poloska.TabIndex = 16;
            // 
            // po_nazvaniy_lekarstva
            // 
            this.po_nazvaniy_lekarstva.AutoSize = true;
            this.po_nazvaniy_lekarstva.Location = new System.Drawing.Point(9, 59);
            this.po_nazvaniy_lekarstva.Name = "po_nazvaniy_lekarstva";
            this.po_nazvaniy_lekarstva.Size = new System.Drawing.Size(187, 21);
            this.po_nazvaniy_lekarstva.TabIndex = 15;
            this.po_nazvaniy_lekarstva.TabStop = true;
            this.po_nazvaniy_lekarstva.Text = "по Названию лекарства";
            this.po_nazvaniy_lekarstva.UseVisualStyleBackColor = true;
            // 
            // rezyltat
            // 
            this.rezyltat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.rezyltat.Location = new System.Drawing.Point(6, 0);
            this.rezyltat.Name = "rezyltat";
            this.rezyltat.RowTemplate.Height = 24;
            this.rezyltat.Size = new System.Drawing.Size(983, 228);
            this.rezyltat.TabIndex = 22;
            this.rezyltat.SelectionChanged += new System.EventHandler(this.rezyltat_SelectionChanged);
            // 
            // Deselect
            // 
            this.Deselect.Location = new System.Drawing.Point(12, 483);
            this.Deselect.Name = "Deselect";
            this.Deselect.Size = new System.Drawing.Size(309, 33);
            this.Deselect.TabIndex = 23;
            this.Deselect.Text = "Снять выделения";
            this.Deselect.UseVisualStyleBackColor = true;
            this.Deselect.Click += new System.EventHandler(this.Deselect_Click);
            // 
            // aptekaTableAdapter
            // 
            this.aptekaTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 533);
            this.Controls.Add(this.Deselect);
            this.Controls.Add(this.Scan);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.Drag_information);
            this.Controls.Add(this.save_all);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.rezyltat);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aptekaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD_AptekaDataSet)).EndInit();
            this.Drag_information.ResumeLayout(false);
            this.Drag_information.PerformLayout();
            this.Scan.ResumeLayout(false);
            this.Scan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rezyltat)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView dataGridView1;
        //public System.Windows.Forms.BindingSource аптекаBindingSource;
        private System.Windows.Forms.Button save_all;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kod;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nazvanie;
        private System.Windows.Forms.DataGridViewTextBoxColumn Forma;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stoimost;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kolvo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Postavschik;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataDostavki;
        private System.Windows.Forms.GroupBox Drag_information;
        private System.Windows.Forms.Label Rub;
        private System.Windows.Forms.TextBox price;
        private System.Windows.Forms.Label Cost;
        private System.Windows.Forms.TextBox type;
        private System.Windows.Forms.Label Shape_Type;
        private System.Windows.Forms.TextBox name_medicine;
        private System.Windows.Forms.Label Drag_name;
        private System.Windows.Forms.TextBox date_delivery;
        private System.Windows.Forms.Label Delivery_Date;
        private System.Windows.Forms.TextBox the_supplier;
        private System.Windows.Forms.Label Provider;
        private System.Windows.Forms.TextBox quantity;
        private System.Windows.Forms.Label Amount;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Button edit;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.GroupBox Scan;
        private System.Windows.Forms.Button Find;
        private System.Windows.Forms.RadioButton po_postavchiky;
        private System.Windows.Forms.RadioButton po_type;
        private System.Windows.Forms.Label Parameters;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox find_poloska;
        private System.Windows.Forms.RadioButton po_nazvaniy_lekarstva;
        private System.Windows.Forms.DataGridView rezyltat;
        private System.Windows.Forms.Button off;
        private System.Windows.Forms.Button Deselect;
        private BD_AptekaDataSet bD_AptekaDataSet;
        private System.Windows.Forms.BindingSource aptekaBindingSource;
        private BD_AptekaDataSetTableAdapters.AptekaTableAdapter aptekaTableAdapter;
        //public WindowsFormsApp1._База_данных__Аптека_DataSet _База_данных__Аптека_DataSet;
        //public WindowsFormsApp1._База_данных__Аптека_DataSetTableAdapters.АптекаTableAdapter аптекаTableAdapter;
    }
}

