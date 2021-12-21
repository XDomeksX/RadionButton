namespace RadioButton1
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
            this.GBOVPrijevoza = new System.Windows.Forms.GroupBox();
            this.RBAvion = new System.Windows.Forms.RadioButton();
            this.RBAutobus = new System.Windows.Forms.RadioButton();
            this.RBVlastiti = new System.Windows.Forms.RadioButton();
            this.BRezerviraj = new System.Windows.Forms.Button();
            this.TB1 = new System.Windows.Forms.TextBox();
            this.GBOVPrijevoza.SuspendLayout();
            this.SuspendLayout();
            // 
            // GBOVPrijevoza
            // 
            this.GBOVPrijevoza.Controls.Add(this.RBVlastiti);
            this.GBOVPrijevoza.Controls.Add(this.RBAutobus);
            this.GBOVPrijevoza.Controls.Add(this.RBAvion);
            this.GBOVPrijevoza.Location = new System.Drawing.Point(318, 107);
            this.GBOVPrijevoza.Name = "GBOVPrijevoza";
            this.GBOVPrijevoza.Size = new System.Drawing.Size(200, 92);
            this.GBOVPrijevoza.TabIndex = 0;
            this.GBOVPrijevoza.TabStop = false;
            this.GBOVPrijevoza.Text = "Odaberite vrstu prijevoza";
            // 
            // RBAvion
            // 
            this.RBAvion.AutoSize = true;
            this.RBAvion.Location = new System.Drawing.Point(7, 20);
            this.RBAvion.Name = "RBAvion";
            this.RBAvion.Size = new System.Drawing.Size(52, 17);
            this.RBAvion.TabIndex = 0;
            this.RBAvion.TabStop = true;
            this.RBAvion.Text = "Avion";
            this.RBAvion.UseVisualStyleBackColor = true;
            this.RBAvion.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // RBAutobus
            // 
            this.RBAutobus.AutoSize = true;
            this.RBAutobus.Location = new System.Drawing.Point(7, 44);
            this.RBAutobus.Name = "RBAutobus";
            this.RBAutobus.Size = new System.Drawing.Size(64, 17);
            this.RBAutobus.TabIndex = 1;
            this.RBAutobus.TabStop = true;
            this.RBAutobus.Text = "Autobus";
            this.RBAutobus.UseVisualStyleBackColor = true;
            // 
            // RBVlastiti
            // 
            this.RBVlastiti.AutoSize = true;
            this.RBVlastiti.Location = new System.Drawing.Point(7, 68);
            this.RBVlastiti.Name = "RBVlastiti";
            this.RBVlastiti.Size = new System.Drawing.Size(94, 17);
            this.RBVlastiti.TabIndex = 2;
            this.RBVlastiti.TabStop = true;
            this.RBVlastiti.Text = "Vlastiti prijevoz";
            this.RBVlastiti.UseVisualStyleBackColor = true;
            // 
            // BRezerviraj
            // 
            this.BRezerviraj.Location = new System.Drawing.Point(380, 230);
            this.BRezerviraj.Name = "BRezerviraj";
            this.BRezerviraj.Size = new System.Drawing.Size(75, 23);
            this.BRezerviraj.TabIndex = 1;
            this.BRezerviraj.Text = "Rezerviraj";
            this.BRezerviraj.UseVisualStyleBackColor = true;
            this.BRezerviraj.Click += new System.EventHandler(this.BRezerviraj_Click);
            // 
            // TB1
            // 
            this.TB1.Location = new System.Drawing.Point(318, 283);
            this.TB1.Multiline = true;
            this.TB1.Name = "TB1";
            this.TB1.Size = new System.Drawing.Size(200, 84);
            this.TB1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TB1);
            this.Controls.Add(this.BRezerviraj);
            this.Controls.Add(this.GBOVPrijevoza);
            this.Name = "Form1";
            this.Text = "Form1";
            this.GBOVPrijevoza.ResumeLayout(false);
            this.GBOVPrijevoza.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox GBOVPrijevoza;
        private System.Windows.Forms.RadioButton RBVlastiti;
        private System.Windows.Forms.RadioButton RBAutobus;
        private System.Windows.Forms.RadioButton RBAvion;
        private System.Windows.Forms.Button BRezerviraj;
        private System.Windows.Forms.TextBox TB1;
    }
}

