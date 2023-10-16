
namespace projectfastfood
{
    partial class items
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(items));
            this.label8 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.CatTb = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.priceTb = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.categoriesTb = new System.Windows.Forms.ComboBox();
            this.nameTb = new System.Windows.Forms.TextBox();
            this.quantityTb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.manageitemsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.fnfDataSet1 = new projectfastfood.fnfDataSet1();
            this.manageitemsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fnfDataSet = new projectfastfood.fnfDataSet();
            this.itemTblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cafeVbDbDataSet1 = new projectfastfood.CafeVbDbDataSet1();
            this.cafeVbDbDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cafeVbDbDataSet = new projectfastfood.CafeVbDbDataSet();
            this.button6 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.itemTblTableAdapter = new projectfastfood.CafeVbDbDataSet1TableAdapters.ItemTblTableAdapter();
            this.manage_itemsTableAdapter = new projectfastfood.fnfDataSetTableAdapters.manage_itemsTableAdapter();
            this.manage_itemsTableAdapter1 = new projectfastfood.fnfDataSet1TableAdapters.manage_itemsTableAdapter();
            this.Close1b1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.manageitemsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fnfDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.manageitemsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fnfDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemTblBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cafeVbDbDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cafeVbDbDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cafeVbDbDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(41, 709);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 28);
            this.label8.TabIndex = 26;
            this.label8.Text = "Logout";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.CatTb);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(158, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1261, 706);
            this.panel1.TabIndex = 25;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Silver;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(373, 80);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(254, 34);
            this.button1.TabIndex = 20;
            this.button1.Text = "Add Category";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Silver;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(96, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 23);
            this.label6.TabIndex = 18;
            this.label6.Text = "Name";
            // 
            // CatTb
            // 
            this.CatTb.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CatTb.ForeColor = System.Drawing.Color.Black;
            this.CatTb.Location = new System.Drawing.Point(183, 80);
            this.CatTb.Name = "CatTb";
            this.CatTb.Size = new System.Drawing.Size(184, 32);
            this.CatTb.TabIndex = 19;
            this.CatTb.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.priceTb);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.categoriesTb);
            this.panel2.Controls.Add(this.nameTb);
            this.panel2.Controls.Add(this.quantityTb);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(187, 120);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(957, 152);
            this.panel2.TabIndex = 17;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkGray;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(416, 115);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(123, 32);
            this.button2.TabIndex = 21;
            this.button2.Text = "Add";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // priceTb
            // 
            this.priceTb.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceTb.ForeColor = System.Drawing.Color.Black;
            this.priceTb.Location = new System.Drawing.Point(512, 65);
            this.priceTb.Name = "priceTb";
            this.priceTb.Size = new System.Drawing.Size(177, 32);
            this.priceTb.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.LavenderBlush;
            this.label4.Location = new System.Drawing.Point(267, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(176, 37);
            this.label4.TabIndex = 16;
            this.label4.Text = "Categories";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.LavenderBlush;
            this.label5.Location = new System.Drawing.Point(34, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 37);
            this.label5.TabIndex = 7;
            this.label5.Text = "Name";
            // 
            // categoriesTb
            // 
            this.categoriesTb.FormattingEnabled = true;
            this.categoriesTb.Location = new System.Drawing.Point(271, 65);
            this.categoriesTb.Name = "categoriesTb";
            this.categoriesTb.Size = new System.Drawing.Size(179, 31);
            this.categoriesTb.TabIndex = 15;
            // 
            // nameTb
            // 
            this.nameTb.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTb.ForeColor = System.Drawing.Color.Black;
            this.nameTb.Location = new System.Drawing.Point(38, 65);
            this.nameTb.Name = "nameTb";
            this.nameTb.Size = new System.Drawing.Size(184, 32);
            this.nameTb.TabIndex = 10;
            this.nameTb.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // quantityTb
            // 
            this.quantityTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.quantityTb.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantityTb.ForeColor = System.Drawing.Color.Black;
            this.quantityTb.Location = new System.Drawing.Point(757, 65);
            this.quantityTb.Name = "quantityTb";
            this.quantityTb.Size = new System.Drawing.Size(160, 32);
            this.quantityTb.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LavenderBlush;
            this.label1.Location = new System.Drawing.Point(508, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 37);
            this.label1.TabIndex = 11;
            this.label1.Text = "Price";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.LavenderBlush;
            this.label2.Location = new System.Drawing.Point(753, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 37);
            this.label2.TabIndex = 13;
            this.label2.Text = "Quantity";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Consolas", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.AliceBlue;
            this.label3.Location = new System.Drawing.Point(526, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(215, 38);
            this.label3.TabIndex = 4;
            this.label3.Text = "Bulk Orders";
            // 
            // manageitemsBindingSource1
            // 
            this.manageitemsBindingSource1.DataMember = "manage_items";
            this.manageitemsBindingSource1.DataSource = this.fnfDataSet1;
            // 
            // fnfDataSet1
            // 
            this.fnfDataSet1.DataSetName = "fnfDataSet1";
            this.fnfDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // manageitemsBindingSource
            // 
            this.manageitemsBindingSource.DataMember = "manage_items";
            this.manageitemsBindingSource.DataSource = this.fnfDataSet;
            // 
            // fnfDataSet
            // 
            this.fnfDataSet.DataSetName = "fnfDataSet";
            this.fnfDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // itemTblBindingSource
            // 
            this.itemTblBindingSource.DataMember = "ItemTbl";
            this.itemTblBindingSource.DataSource = this.cafeVbDbDataSet1;
            // 
            // cafeVbDbDataSet1
            // 
            this.cafeVbDbDataSet1.DataSetName = "CafeVbDbDataSet1";
            this.cafeVbDbDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cafeVbDbDataSetBindingSource
            // 
            this.cafeVbDbDataSetBindingSource.DataSource = this.cafeVbDbDataSet;
            this.cafeVbDbDataSetBindingSource.Position = 0;
            // 
            // cafeVbDbDataSet
            // 
            this.cafeVbDbDataSet.DataSetName = "CafeVbDbDataSet";
            this.cafeVbDbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(14, 39);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(138, 45);
            this.button6.TabIndex = 30;
            this.button6.Text = "Menu list";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.Location = new System.Drawing.Point(12, 122);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(138, 45);
            this.button8.TabIndex = 32;
            this.button8.Text = "view orders";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // itemTblTableAdapter
            // 
            this.itemTblTableAdapter.ClearBeforeFill = true;
            // 
            // manage_itemsTableAdapter
            // 
            this.manage_itemsTableAdapter.ClearBeforeFill = true;
            // 
            // manage_itemsTableAdapter1
            // 
            this.manage_itemsTableAdapter1.ClearBeforeFill = true;
            // 
            // Close1b1
            // 
            this.Close1b1.AutoSize = true;
            this.Close1b1.BackColor = System.Drawing.Color.Transparent;
            this.Close1b1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Close1b1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Close1b1.Location = new System.Drawing.Point(1384, -1);
            this.Close1b1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Close1b1.Name = "Close1b1";
            this.Close1b1.Size = new System.Drawing.Size(35, 37);
            this.Close1b1.TabIndex = 33;
            this.Close1b1.Text = "X";
            this.Close1b1.Click += new System.EventHandler(this.Close1b1_Click);
            // 
            // items
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1431, 777);
            this.Controls.Add(this.Close1b1);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "items";
            this.Text = "items";
            this.Load += new System.EventHandler(this.items_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.manageitemsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fnfDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.manageitemsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fnfDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemTblBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cafeVbDbDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cafeVbDbDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cafeVbDbDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox CatTb;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox priceTb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox categoriesTb;
        private System.Windows.Forms.TextBox nameTb;
        private System.Windows.Forms.TextBox quantityTb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.BindingSource cafeVbDbDataSetBindingSource;
        private CafeVbDbDataSet cafeVbDbDataSet;
        private CafeVbDbDataSet1 cafeVbDbDataSet1;
        private System.Windows.Forms.BindingSource itemTblBindingSource;
        private CafeVbDbDataSet1TableAdapters.ItemTblTableAdapter itemTblTableAdapter;
        private fnfDataSet fnfDataSet;
        private System.Windows.Forms.BindingSource manageitemsBindingSource;
        private fnfDataSetTableAdapters.manage_itemsTableAdapter manage_itemsTableAdapter;
        private fnfDataSet1 fnfDataSet1;
        private System.Windows.Forms.BindingSource manageitemsBindingSource1;
        private fnfDataSet1TableAdapters.manage_itemsTableAdapter manage_itemsTableAdapter1;
        private System.Windows.Forms.Label Close1b1;
    }
}