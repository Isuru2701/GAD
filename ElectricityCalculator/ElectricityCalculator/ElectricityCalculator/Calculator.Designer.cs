namespace ElectricityCalculator
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
            this.rad_domestic = new System.Windows.Forms.RadioButton();
            this.rad_business = new System.Windows.Forms.RadioButton();
            this.lbl_type = new System.Windows.Forms.Label();
            this.lbl_units = new System.Windows.Forms.Label();
            this.txt_units = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_amount = new System.Windows.Forms.Label();
            this.btn_calculate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rad_domestic
            // 
            this.rad_domestic.AutoSize = true;
            this.rad_domestic.Location = new System.Drawing.Point(43, 101);
            this.rad_domestic.Name = "rad_domestic";
            this.rad_domestic.Size = new System.Drawing.Size(85, 20);
            this.rad_domestic.TabIndex = 0;
            this.rad_domestic.TabStop = true;
            this.rad_domestic.Text = "Domestic";
            this.rad_domestic.UseVisualStyleBackColor = true;
            // 
            // rad_business
            // 
            this.rad_business.AutoSize = true;
            this.rad_business.Location = new System.Drawing.Point(43, 138);
            this.rad_business.Name = "rad_business";
            this.rad_business.Size = new System.Drawing.Size(83, 20);
            this.rad_business.TabIndex = 1;
            this.rad_business.TabStop = true;
            this.rad_business.Text = "Business";
            this.rad_business.UseVisualStyleBackColor = true;
            // 
            // lbl_type
            // 
            this.lbl_type.AutoSize = true;
            this.lbl_type.Location = new System.Drawing.Point(40, 72);
            this.lbl_type.Name = "lbl_type";
            this.lbl_type.Size = new System.Drawing.Size(140, 16);
            this.lbl_type.TabIndex = 2;
            this.lbl_type.Text = "Select Customer Type";
            // 
            // lbl_units
            // 
            this.lbl_units.AutoSize = true;
            this.lbl_units.Location = new System.Drawing.Point(40, 206);
            this.lbl_units.Name = "lbl_units";
            this.lbl_units.Size = new System.Drawing.Size(204, 16);
            this.lbl_units.TabIndex = 3;
            this.lbl_units.Text = "Enter Number of Units Consumed";
            // 
            // txt_units
            // 
            this.txt_units.Location = new System.Drawing.Point(43, 235);
            this.txt_units.Name = "txt_units";
            this.txt_units.Size = new System.Drawing.Size(201, 22);
            this.txt_units.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(250, 241);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Units";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 333);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Total Payable:";
            // 
            // lbl_amount
            // 
            this.lbl_amount.AutoSize = true;
            this.lbl_amount.Location = new System.Drawing.Point(180, 333);
            this.lbl_amount.Name = "lbl_amount";
            this.lbl_amount.Size = new System.Drawing.Size(30, 16);
            this.lbl_amount.TabIndex = 7;
            this.lbl_amount.Text = "Rs. ";
            // 
            // btn_calculate
            // 
            this.btn_calculate.Location = new System.Drawing.Point(43, 263);
            this.btn_calculate.Name = "btn_calculate";
            this.btn_calculate.Size = new System.Drawing.Size(137, 23);
            this.btn_calculate.TabIndex = 8;
            this.btn_calculate.Text = "Calculate";
            this.btn_calculate.UseVisualStyleBackColor = true;
            this.btn_calculate.Click += new System.EventHandler(this.btn_calculate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 450);
            this.Controls.Add(this.btn_calculate);
            this.Controls.Add(this.lbl_amount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_units);
            this.Controls.Add(this.lbl_units);
            this.Controls.Add(this.lbl_type);
            this.Controls.Add(this.rad_business);
            this.Controls.Add(this.rad_domestic);
            this.Name = "Form1";
            this.Text = "Electricity Bill Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rad_domestic;
        private System.Windows.Forms.RadioButton rad_business;
        private System.Windows.Forms.Label lbl_type;
        private System.Windows.Forms.Label lbl_units;
        private System.Windows.Forms.TextBox txt_units;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_amount;
        private System.Windows.Forms.Button btn_calculate;
    }
}

