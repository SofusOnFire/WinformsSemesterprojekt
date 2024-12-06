namespace WinformsSemesterprojekt
{
    partial class Hovedmenu
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
            this.btnProducts = new System.Windows.Forms.Button();
            this.btnOrders = new System.Windows.Forms.Button();
            this.btnCustomers = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(163, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(434, 76);
            this.label1.TabIndex = 0;
            this.label1.Text = "ProductionPro";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(228, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(315, 49);
            this.label2.TabIndex = 1;
            this.label2.Text = "Lagerhåndtering";
            // 
            // btnProducts
            // 
            this.btnProducts.Font = new System.Drawing.Font("Trebuchet MS", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProducts.Location = new System.Drawing.Point(237, 189);
            this.btnProducts.Name = "btnProducts";
            this.btnProducts.Size = new System.Drawing.Size(306, 65);
            this.btnProducts.TabIndex = 2;
            this.btnProducts.Text = "Products";
            this.btnProducts.UseVisualStyleBackColor = true;
            this.btnProducts.Click += new System.EventHandler(this.btnProducts_Click);
            // 
            // btnOrders
            // 
            this.btnOrders.Font = new System.Drawing.Font("Trebuchet MS", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrders.Location = new System.Drawing.Point(237, 260);
            this.btnOrders.Name = "btnOrders";
            this.btnOrders.Size = new System.Drawing.Size(306, 65);
            this.btnOrders.TabIndex = 3;
            this.btnOrders.Text = "Ordrer";
            this.btnOrders.UseVisualStyleBackColor = true;
            // 
            // btnCustomers
            // 
            this.btnCustomers.Font = new System.Drawing.Font("Trebuchet MS", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomers.Location = new System.Drawing.Point(237, 331);
            this.btnCustomers.Name = "btnCustomers";
            this.btnCustomers.Size = new System.Drawing.Size(306, 65);
            this.btnCustomers.TabIndex = 4;
            this.btnCustomers.Text = "Kunder";
            this.btnCustomers.UseVisualStyleBackColor = true;
            // 
            // Hovedmenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCustomers);
            this.Controls.Add(this.btnOrders);
            this.Controls.Add(this.btnProducts);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Hovedmenu";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnProducts;
        private System.Windows.Forms.Button btnOrders;
        private System.Windows.Forms.Button btnCustomers;
    }
}

