namespace FirstGraphic
{
    partial class Calculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calculator));
            this.add = new System.Windows.Forms.Button();
            this.sub = new System.Windows.Forms.Button();
            this.div = new System.Windows.Forms.Button();
            this.mul = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.number1 = new System.Windows.Forms.Label();
            this.number2 = new System.Windows.Forms.Label();
            this.answer = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // add
            // 
            resources.ApplyResources(this.add, "add");
            this.add.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.add.Name = "add";
            this.add.UseVisualStyleBackColor = true;
            this.add.UseWaitCursor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // sub
            // 
            resources.ApplyResources(this.sub, "sub");
            this.sub.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.sub.Name = "sub";
            this.sub.UseVisualStyleBackColor = true;
            this.sub.UseWaitCursor = true;
            this.sub.Click += new System.EventHandler(this.sub_Click);
            // 
            // div
            // 
            resources.ApplyResources(this.div, "div");
            this.div.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.div.Name = "div";
            this.div.UseVisualStyleBackColor = true;
            this.div.UseWaitCursor = true;
            this.div.Click += new System.EventHandler(this.div_Click);
            // 
            // mul
            // 
            resources.ApplyResources(this.mul, "mul");
            this.mul.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.mul.Name = "mul";
            this.mul.UseVisualStyleBackColor = true;
            this.mul.UseWaitCursor = true;
            this.mul.Click += new System.EventHandler(this.mul_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Window;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.textBox1, "textBox1");
            this.textBox1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.textBox1.Name = "textBox1";
            this.textBox1.UseWaitCursor = true;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.Window;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.textBox2, "textBox2");
            this.textBox2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.textBox2.Name = "textBox2";
            this.textBox2.UseWaitCursor = true;
            // 
            // number1
            // 
            resources.ApplyResources(this.number1, "number1");
            this.number1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.number1.Name = "number1";
            this.number1.UseWaitCursor = true;
            // 
            // number2
            // 
            resources.ApplyResources(this.number2, "number2");
            this.number2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.number2.Name = "number2";
            this.number2.UseWaitCursor = true;
            // 
            // answer
            // 
            resources.ApplyResources(this.answer, "answer");
            this.answer.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.answer.Name = "answer";
            this.answer.UseWaitCursor = true;
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label1.Name = "label1";
            this.label1.UseWaitCursor = true;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Calculator
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.answer);
            this.Controls.Add(this.number2);
            this.Controls.Add(this.number1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.div);
            this.Controls.Add(this.mul);
            this.Controls.Add(this.sub);
            this.Controls.Add(this.add);
            this.Name = "Calculator";
            this.UseWaitCursor = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button sub;
        private System.Windows.Forms.Button div;
        private System.Windows.Forms.Button mul;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label number1;
        private System.Windows.Forms.Label number2;
        private System.Windows.Forms.Label answer;
        private System.Windows.Forms.Label label1;
    }
}

