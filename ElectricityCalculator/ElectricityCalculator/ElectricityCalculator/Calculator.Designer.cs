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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.rad_domestic = new System.Windows.Forms.RadioButton();
            this.rad_business = new System.Windows.Forms.RadioButton();
            this.lbl_type = new System.Windows.Forms.Label();
            this.lbl_units = new System.Windows.Forms.Label();
            this.txt_units = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_amount = new System.Windows.Forms.Label();
            this.btn_calculate = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rad_domestic
            // 
            this.rad_domestic.AutoSize = true;
            this.rad_domestic.Font = new System.Drawing.Font("JetBrains Mono", 10F);
            this.rad_domestic.ForeColor = System.Drawing.Color.White;
            this.rad_domestic.Location = new System.Drawing.Point(44, 87);
            this.rad_domestic.Name = "rad_domestic";
            this.rad_domestic.Size = new System.Drawing.Size(111, 26);
            this.rad_domestic.TabIndex = 0;
            this.rad_domestic.TabStop = true;
            this.rad_domestic.Text = "Domestic";
            this.rad_domestic.UseVisualStyleBackColor = true;
            // 
            // rad_business
            // 
            this.rad_business.AutoSize = true;
            this.rad_business.Font = new System.Drawing.Font("JetBrains Mono", 10F);
            this.rad_business.ForeColor = System.Drawing.Color.White;
            this.rad_business.Location = new System.Drawing.Point(44, 124);
            this.rad_business.Name = "rad_business";
            this.rad_business.Size = new System.Drawing.Size(111, 26);
            this.rad_business.TabIndex = 1;
            this.rad_business.TabStop = true;
            this.rad_business.Text = "Business";
            this.rad_business.UseVisualStyleBackColor = true;
            // 
            // lbl_type
            // 
            this.lbl_type.AutoSize = true;
            this.lbl_type.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_type.ForeColor = System.Drawing.Color.White;
            this.lbl_type.Location = new System.Drawing.Point(17, 58);
            this.lbl_type.Name = "lbl_type";
            this.lbl_type.Size = new System.Drawing.Size(252, 26);
            this.lbl_type.TabIndex = 2;
            this.lbl_type.Text = "Select Customer Type";
            // 
            // lbl_units
            // 
            this.lbl_units.AutoSize = true;
            this.lbl_units.Font = new System.Drawing.Font("JetBrains Mono", 11F, System.Drawing.FontStyle.Bold);
            this.lbl_units.ForeColor = System.Drawing.Color.White;
            this.lbl_units.Location = new System.Drawing.Point(12, 189);
            this.lbl_units.Name = "lbl_units";
            this.lbl_units.Size = new System.Drawing.Size(342, 25);
            this.lbl_units.TabIndex = 3;
            this.lbl_units.Text = "Enter Number of Units Consumed";
            // 
            // txt_units
            // 
            this.txt_units.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_units.Font = new System.Drawing.Font("JetBrains Mono", 10F);
            this.txt_units.ForeColor = System.Drawing.Color.Black;
            this.txt_units.Location = new System.Drawing.Point(23, 226);
            this.txt_units.Name = "txt_units";
            this.txt_units.Size = new System.Drawing.Size(255, 22);
            this.txt_units.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("JetBrains Mono", 10F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(284, 226);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 22);
            this.label1.TabIndex = 5;
            this.label1.Text = "Units";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("JetBrains Mono", 10F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(27, 340);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 22);
            this.label2.TabIndex = 6;
            this.label2.Text = "Total Payable:";
            // 
            // lbl_amount
            // 
            this.lbl_amount.AutoSize = true;
            this.lbl_amount.Font = new System.Drawing.Font("JetBrains Mono", 10F);
            this.lbl_amount.ForeColor = System.Drawing.Color.White;
            this.lbl_amount.Location = new System.Drawing.Point(254, 340);
            this.lbl_amount.Name = "lbl_amount";
            this.lbl_amount.Size = new System.Drawing.Size(90, 22);
            this.lbl_amount.TabIndex = 7;
            this.lbl_amount.Text = "Rs. 0.00";
            // 
            // btn_calculate
            // 
            this.btn_calculate.Font = new System.Drawing.Font("JetBrains Mono", 10F);
            this.btn_calculate.ForeColor = System.Drawing.Color.Black;
            this.btn_calculate.Location = new System.Drawing.Point(22, 262);
            this.btn_calculate.Name = "btn_calculate";
            this.btn_calculate.Size = new System.Drawing.Size(155, 39);
            this.btn_calculate.TabIndex = 8;
            this.btn_calculate.Text = "Calculate";
            this.btn_calculate.UseVisualStyleBackColor = true;
            this.btn_calculate.Click += new System.EventHandler(this.btn_calculate_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Font = new System.Drawing.Font("JetBrains Mono", 10F);
            this.btn_clear.ForeColor = System.Drawing.Color.Black;
            this.btn_clear.Location = new System.Drawing.Point(182, 262);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(94, 39);
            this.btn_clear.TabIndex = 9;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Font = new System.Drawing.Font("JetBrains Mono", 10F);
            this.btn_exit.ForeColor = System.Drawing.Color.Black;
            this.btn_exit.Location = new System.Drawing.Point(240, 389);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(113, 39);
            this.btn_exit.TabIndex = 10;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(401, 461);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_calculate);
            this.Controls.Add(this.lbl_amount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_units);
            this.Controls.Add(this.lbl_units);
            this.Controls.Add(this.lbl_type);
            this.Controls.Add(this.rad_business);
            this.Controls.Add(this.rad_domestic);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Electricity Bill Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
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
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_exit;
    }
}

