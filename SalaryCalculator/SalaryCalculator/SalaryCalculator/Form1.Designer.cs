namespace SalaryCalculator
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
            this.lbl_basic = new System.Windows.Forms.Label();
            this.lbl_allowance = new System.Windows.Forms.Label();
            this.lbl_net = new System.Windows.Forms.Label();
            this.txt_basic = new System.Windows.Forms.TextBox();
            this.txt_allowance = new System.Windows.Forms.TextBox();
            this.txt_net = new System.Windows.Forms.TextBox();
            this.bt_calculate = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_basic
            // 
            this.lbl_basic.AutoSize = true;
            this.lbl_basic.Font = new System.Drawing.Font("JetBrains Mono", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_basic.Location = new System.Drawing.Point(137, 67);
            this.lbl_basic.Name = "lbl_basic";
            this.lbl_basic.Size = new System.Drawing.Size(130, 22);
            this.lbl_basic.TabIndex = 0;
            this.lbl_basic.Text = "Basic Salary";
            // 
            // lbl_allowance
            // 
            this.lbl_allowance.AutoSize = true;
            this.lbl_allowance.Font = new System.Drawing.Font("JetBrains Mono", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_allowance.Location = new System.Drawing.Point(137, 147);
            this.lbl_allowance.Name = "lbl_allowance";
            this.lbl_allowance.Size = new System.Drawing.Size(100, 22);
            this.lbl_allowance.TabIndex = 1;
            this.lbl_allowance.Text = "Allowance";
            // 
            // lbl_net
            // 
            this.lbl_net.AutoSize = true;
            this.lbl_net.Font = new System.Drawing.Font("JetBrains Mono", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_net.Location = new System.Drawing.Point(137, 237);
            this.lbl_net.Name = "lbl_net";
            this.lbl_net.Size = new System.Drawing.Size(110, 22);
            this.lbl_net.TabIndex = 2;
            this.lbl_net.Text = "Net Salary";
            // 
            // txt_basic
            // 
            this.txt_basic.Location = new System.Drawing.Point(491, 75);
            this.txt_basic.Name = "txt_basic";
            this.txt_basic.Size = new System.Drawing.Size(100, 22);
            this.txt_basic.TabIndex = 3;
            // 
            // txt_allowance
            // 
            this.txt_allowance.Location = new System.Drawing.Point(491, 148);
            this.txt_allowance.Name = "txt_allowance";
            this.txt_allowance.Size = new System.Drawing.Size(100, 22);
            this.txt_allowance.TabIndex = 4;
            // 
            // txt_net
            // 
            this.txt_net.Location = new System.Drawing.Point(491, 237);
            this.txt_net.Name = "txt_net";
            this.txt_net.Size = new System.Drawing.Size(100, 22);
            this.txt_net.TabIndex = 5;
            // 
            // bt_calculate
            // 
            this.bt_calculate.Font = new System.Drawing.Font("JetBrains Mono", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_calculate.Location = new System.Drawing.Point(104, 324);
            this.bt_calculate.Name = "bt_calculate";
            this.bt_calculate.Size = new System.Drawing.Size(133, 65);
            this.bt_calculate.TabIndex = 6;
            this.bt_calculate.Text = "Calculate";
            this.bt_calculate.UseVisualStyleBackColor = true;
            this.bt_calculate.Click += new System.EventHandler(this.btn_calculate_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Font = new System.Drawing.Font("JetBrains Mono", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clear.Location = new System.Drawing.Point(279, 324);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(133, 65);
            this.btn_clear.TabIndex = 7;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Font = new System.Drawing.Font("JetBrains Mono", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exit.Location = new System.Drawing.Point(458, 324);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(133, 65);
            this.btn_exit.TabIndex = 8;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.bt_calculate);
            this.Controls.Add(this.txt_net);
            this.Controls.Add(this.txt_allowance);
            this.Controls.Add(this.txt_basic);
            this.Controls.Add(this.lbl_net);
            this.Controls.Add(this.lbl_allowance);
            this.Controls.Add(this.lbl_basic);
            this.Name = "Form1";
            this.Text = "Net Salary Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_basic;
        private System.Windows.Forms.Label lbl_allowance;
        private System.Windows.Forms.Label lbl_net;
        private System.Windows.Forms.TextBox txt_basic;
        private System.Windows.Forms.TextBox txt_allowance;
        private System.Windows.Forms.TextBox txt_net;
        private System.Windows.Forms.Button bt_calculate;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_exit;
    }
}

