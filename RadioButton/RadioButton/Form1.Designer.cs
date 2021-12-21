
namespace RadioButton
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtnbus = new System.Windows.Forms.RadioButton();
            this.rbtnvlak = new System.Windows.Forms.RadioButton();
            this.rbtnavion = new System.Windows.Forms.RadioButton();
            this.btnrezerviraj = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtnavion);
            this.groupBox1.Controls.Add(this.rbtnvlak);
            this.groupBox1.Controls.Add(this.rbtnbus);
            this.groupBox1.Location = new System.Drawing.Point(88, 87);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Odaberite vrstu prijevoza:";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // rbtnbus
            // 
            this.rbtnbus.AutoSize = true;
            this.rbtnbus.Location = new System.Drawing.Point(0, 20);
            this.rbtnbus.Name = "rbtnbus";
            this.rbtnbus.Size = new System.Drawing.Size(64, 17);
            this.rbtnbus.TabIndex = 0;
            this.rbtnbus.TabStop = true;
            this.rbtnbus.Text = "Autobus";
            this.rbtnbus.UseVisualStyleBackColor = true;
            // 
            // rbtnvlak
            // 
            this.rbtnvlak.AutoSize = true;
            this.rbtnvlak.Location = new System.Drawing.Point(0, 44);
            this.rbtnvlak.Name = "rbtnvlak";
            this.rbtnvlak.Size = new System.Drawing.Size(46, 17);
            this.rbtnvlak.TabIndex = 1;
            this.rbtnvlak.TabStop = true;
            this.rbtnvlak.Text = "Vlak";
            this.rbtnvlak.UseVisualStyleBackColor = true;
            // 
            // rbtnavion
            // 
            this.rbtnavion.AutoSize = true;
            this.rbtnavion.Location = new System.Drawing.Point(0, 67);
            this.rbtnavion.Name = "rbtnavion";
            this.rbtnavion.Size = new System.Drawing.Size(73, 17);
            this.rbtnavion.TabIndex = 2;
            this.rbtnavion.TabStop = true;
            this.rbtnavion.Text = "Zrakoplov";
            this.rbtnavion.UseVisualStyleBackColor = true;
            // 
            // btnrezerviraj
            // 
            this.btnrezerviraj.Location = new System.Drawing.Point(133, 230);
            this.btnrezerviraj.Name = "btnrezerviraj";
            this.btnrezerviraj.Size = new System.Drawing.Size(75, 23);
            this.btnrezerviraj.TabIndex = 1;
            this.btnrezerviraj.Text = "Rrezerviraj";
            this.btnrezerviraj.UseVisualStyleBackColor = true;
            this.btnrezerviraj.Click += new System.EventHandler(this.btnrezerviraj_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(88, 278);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(200, 117);
            this.textBox1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 467);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnrezerviraj);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtnavion;
        private System.Windows.Forms.RadioButton rbtnvlak;
        private System.Windows.Forms.RadioButton rbtnbus;
        private System.Windows.Forms.Button btnrezerviraj;
        private System.Windows.Forms.TextBox textBox1;
    }
}

