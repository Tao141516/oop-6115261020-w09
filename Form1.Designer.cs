namespace oop_6115261020_w09
{
    partial class Form1
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
            this.lblWeight = new System.Windows.Forms.Label();
            this.lblHeight = new System.Windows.Forms.Label();
            this.lblBMI = new System.Windows.Forms.Label();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.btnCaleulate = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.lblSalary = new System.Windows.Forms.Label();
            this.lblTax = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.taxCalculate = new System.Windows.Forms.Button();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblWeight
            // 
            this.lblWeight.AutoSize = true;
            this.lblWeight.Location = new System.Drawing.Point(12, 37);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(49, 17);
            this.lblWeight.TabIndex = 0;
            this.lblWeight.Text = "น้ำหนัก";
            // 
            // lblHeight
            // 
            this.lblHeight.AutoSize = true;
            this.lblHeight.Location = new System.Drawing.Point(12, 102);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(44, 17);
            this.lblHeight.TabIndex = 1;
            this.lblHeight.Text = "ส่วนสูง";
            // 
            // lblBMI
            // 
            this.lblBMI.AutoSize = true;
            this.lblBMI.Location = new System.Drawing.Point(12, 194);
            this.lblBMI.Name = "lblBMI";
            this.lblBMI.Size = new System.Drawing.Size(76, 17);
            this.lblBMI.TabIndex = 2;
            this.lblBMI.Text = "ดัชนีมวลกาย";
            // 
            // txtWeight
            // 
            this.txtWeight.Location = new System.Drawing.Point(111, 37);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(100, 22);
            this.txtWeight.TabIndex = 3;
            // 
            // txtHeight
            // 
            this.txtHeight.Location = new System.Drawing.Point(111, 115);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(100, 22);
            this.txtHeight.TabIndex = 4;
            // 
            // btnCaleulate
            // 
            this.btnCaleulate.Location = new System.Drawing.Point(152, 194);
            this.btnCaleulate.Name = "btnCaleulate";
            this.btnCaleulate.Size = new System.Drawing.Size(75, 23);
            this.btnCaleulate.TabIndex = 5;
            this.btnCaleulate.Text = "คำนวน";
            this.btnCaleulate.UseVisualStyleBackColor = true;
            this.btnCaleulate.Click += new System.EventHandler(this.btnCaleulate_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(12, 280);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(23, 17);
            this.lblName.TabIndex = 6;
            this.lblName.Text = "ชื่อ";
            // 
            // lblSalary
            // 
            this.lblSalary.AutoSize = true;
            this.lblSalary.Location = new System.Drawing.Point(12, 338);
            this.lblSalary.Name = "lblSalary";
            this.lblSalary.Size = new System.Drawing.Size(55, 17);
            this.lblSalary.TabIndex = 7;
            this.lblSalary.Text = "เงินเดือน";
            // 
            // lblTax
            // 
            this.lblTax.AutoSize = true;
            this.lblTax.Location = new System.Drawing.Point(12, 409);
            this.lblTax.Name = "lblTax";
            this.lblTax.Size = new System.Drawing.Size(31, 17);
            this.lblTax.TabIndex = 8;
            this.lblTax.Text = "ภาษี";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(111, 280);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 22);
            this.txtName.TabIndex = 9;
            // 
            // taxCalculate
            // 
            this.taxCalculate.Location = new System.Drawing.Point(152, 406);
            this.taxCalculate.Name = "taxCalculate";
            this.taxCalculate.Size = new System.Drawing.Size(100, 23);
            this.taxCalculate.TabIndex = 11;
            this.taxCalculate.Text = "คำนวนภาษี";
            this.taxCalculate.UseVisualStyleBackColor = true;
            this.taxCalculate.Click += new System.EventHandler(this.taxCalculate_Click);
            // 
            // txtSalary
            // 
            this.txtSalary.Location = new System.Drawing.Point(111, 338);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(100, 22);
            this.txtSalary.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtSalary);
            this.Controls.Add(this.taxCalculate);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblTax);
            this.Controls.Add(this.lblSalary);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.btnCaleulate);
            this.Controls.Add(this.txtHeight);
            this.Controls.Add(this.txtWeight);
            this.Controls.Add(this.lblBMI);
            this.Controls.Add(this.lblHeight);
            this.Controls.Add(this.lblWeight);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWeight;
        private System.Windows.Forms.Label lblHeight;
        private System.Windows.Forms.Label lblBMI;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.Button btnCaleulate;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblSalary;
        private System.Windows.Forms.Label lblTax;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button taxCalculate;
        private System.Windows.Forms.TextBox txtSalary;
    }
}

