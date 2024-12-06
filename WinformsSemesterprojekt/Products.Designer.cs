namespace WinformsSemesterprojekt
{
    partial class Products
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.productView = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.btnMainmenu = new System.Windows.Forms.Button();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.button3 = new System.Windows.Forms.Button();
            this.vScrollBar2 = new System.Windows.Forms.VScrollBar();
            ((System.ComponentModel.ISupportInitialize)(this.productView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 49);
            this.label1.TabIndex = 0;
            this.label1.Text = "Produkter";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 55);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(187, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Filtrer efter kategori";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(4, 254);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(212, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Filtrer efter lagerstatus";
            // 
            // textBox1
            // 
            this.textBox1.AcceptsReturn = true;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Location = new System.Drawing.Point(244, 23);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(298, 20);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "Søg efter et produkt...";
            // 
            // productView
            // 
            this.productView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productView.Location = new System.Drawing.Point(244, 92);
            this.productView.Margin = new System.Windows.Forms.Padding(2);
            this.productView.Name = "productView";
            this.productView.RowHeadersWidth = 51;
            this.productView.RowTemplate.Height = 24;
            this.productView.Size = new System.Drawing.Size(322, 264);
            this.productView.TabIndex = 4;
            this.productView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(547, 21);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(44, 19);
            this.button1.TabIndex = 5;
            this.button1.Text = "Søg";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(8, 89);
            this.checkedListBox1.Margin = new System.Windows.Forms.Padding(2);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(151, 154);
            this.checkedListBox1.TabIndex = 6;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(8, 279);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(64, 17);
            this.radioButton1.TabIndex = 7;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "På lager";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(8, 300);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(87, 17);
            this.radioButton2.TabIndex = 8;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Ikke på lager";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // btnMainmenu
            // 
            this.btnMainmenu.Location = new System.Drawing.Point(10, 337);
            this.btnMainmenu.Margin = new System.Windows.Forms.Padding(2);
            this.btnMainmenu.Name = "btnMainmenu";
            this.btnMainmenu.Size = new System.Drawing.Size(77, 19);
            this.btnMainmenu.TabIndex = 9;
            this.btnMainmenu.Text = "Hovedmenu";
            this.btnMainmenu.UseVisualStyleBackColor = true;
            this.btnMainmenu.Click += new System.EventHandler(this.btnMainmenu_Click);
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(568, 92);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(21, 264);
            this.vScrollBar1.TabIndex = 10;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(514, 55);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(77, 19);
            this.button3.TabIndex = 11;
            this.button3.Text = "Sorter efter";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // vScrollBar2
            // 
            this.vScrollBar2.Location = new System.Drawing.Point(161, 89);
            this.vScrollBar2.Name = "vScrollBar2";
            this.vScrollBar2.Size = new System.Drawing.Size(21, 155);
            this.vScrollBar2.TabIndex = 12;
            // 
            // Products
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.vScrollBar2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.vScrollBar1);
            this.Controls.Add(this.btnMainmenu);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.productView);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Products";
            this.Text = "Products";
            ((System.ComponentModel.ISupportInitialize)(this.productView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView productView;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Button btnMainmenu;
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.VScrollBar vScrollBar2;
    }
}