namespace formsApp
{
    partial class Home
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
            this.btn_display = new System.Windows.Forms.Button();
            this.txt_entry = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_display = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_display
            // 
            this.btn_display.Font = new System.Drawing.Font("JetBrains Mono", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_display.Location = new System.Drawing.Point(334, 214);
            this.btn_display.Name = "btn_display";
            this.btn_display.Size = new System.Drawing.Size(108, 69);
            this.btn_display.TabIndex = 0;
            this.btn_display.Text = "Display";
            this.btn_display.UseVisualStyleBackColor = true;
            this.btn_display.Click += new System.EventHandler(this.btn_display_Click);
            // 
            // txt_entry
            // 
            this.txt_entry.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_entry.Location = new System.Drawing.Point(243, 151);
            this.txt_entry.Name = "txt_entry";
            this.txt_entry.Size = new System.Drawing.Size(316, 30);
            this.txt_entry.TabIndex = 1;
            this.txt_entry.TextChanged += new System.EventHandler(this.txt_entry_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("JetBrains Mono", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(278, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(255, 36);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter your name";
            // 
            // lbl_display
            // 
            this.lbl_display.AutoSize = true;
            this.lbl_display.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_display.Location = new System.Drawing.Point(360, 304);
            this.lbl_display.Name = "lbl_display";
            this.lbl_display.Size = new System.Drawing.Size(0, 20);
            this.lbl_display.TabIndex = 3;
            this.lbl_display.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_display);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_entry);
            this.Controls.Add(this.btn_display);
            this.Name = "Home";
            this.Text = "Home";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_display;
        private System.Windows.Forms.TextBox txt_entry;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_display;
    }
}

