namespace Create_PW_Database
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.NextGenDBName = new System.Windows.Forms.TextBox();
            this.DatabaseSetName = new System.Windows.Forms.TextBox();
            this.DPMSDBIdentifier = new System.Windows.Forms.TextBox();
            this.ServerName = new System.Windows.Forms.TextBox();
            this.InstanceName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.User = new System.Windows.Forms.TextBox();
            this.Pass = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.pmsType = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(299, 312);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 32);
            this.button1.TabIndex = 0;
            this.button1.Text = "Make it So";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "NextGen Database Information";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "NextGen Database Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Database Set Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(52, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "DPMS DB Identifier:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 169);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "SQL Server Information";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(82, 192);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Server Name:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(72, 222);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Instance Name:";
            // 
            // NextGenDBName
            // 
            this.NextGenDBName.Location = new System.Drawing.Point(161, 35);
            this.NextGenDBName.Name = "NextGenDBName";
            this.NextGenDBName.Size = new System.Drawing.Size(250, 20);
            this.NextGenDBName.TabIndex = 9;
            this.NextGenDBName.TextChanged += new System.EventHandler(this.NextGenDBName_TextChanged);
            // 
            // DatabaseSetName
            // 
            this.DatabaseSetName.Location = new System.Drawing.Point(161, 64);
            this.DatabaseSetName.Name = "DatabaseSetName";
            this.DatabaseSetName.Size = new System.Drawing.Size(250, 20);
            this.DatabaseSetName.TabIndex = 10;
            this.DatabaseSetName.TextChanged += new System.EventHandler(this.DatabaseSetName_TextChanged);
            // 
            // DPMSDBIdentifier
            // 
            this.DPMSDBIdentifier.Location = new System.Drawing.Point(161, 93);
            this.DPMSDBIdentifier.Name = "DPMSDBIdentifier";
            this.DPMSDBIdentifier.Size = new System.Drawing.Size(250, 20);
            this.DPMSDBIdentifier.TabIndex = 11;
            this.DPMSDBIdentifier.TextChanged += new System.EventHandler(this.DPMSDBIdentifier_TextChanged);
            // 
            // ServerName
            // 
            this.ServerName.Location = new System.Drawing.Point(161, 189);
            this.ServerName.Name = "ServerName";
            this.ServerName.Size = new System.Drawing.Size(250, 20);
            this.ServerName.TabIndex = 13;
            this.ServerName.TextChanged += new System.EventHandler(this.ServerName_TextChanged);
            // 
            // InstanceName
            // 
            this.InstanceName.Location = new System.Drawing.Point(161, 219);
            this.InstanceName.Name = "InstanceName";
            this.InstanceName.Size = new System.Drawing.Size(250, 20);
            this.InstanceName.TabIndex = 14;
            this.InstanceName.TextChanged += new System.EventHandler(this.InstanceName_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(91, 250);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "User Name:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(98, 279);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 13);
            this.label10.TabIndex = 16;
            this.label10.Text = "Password:";
            // 
            // User
            // 
            this.User.Location = new System.Drawing.Point(161, 247);
            this.User.Name = "User";
            this.User.Size = new System.Drawing.Size(250, 20);
            this.User.TabIndex = 17;
            this.User.TextChanged += new System.EventHandler(this.User_TextChanged);
            // 
            // Pass
            // 
            this.Pass.Location = new System.Drawing.Point(161, 276);
            this.Pass.Name = "Pass";
            this.Pass.Size = new System.Drawing.Size(250, 20);
            this.Pass.TabIndex = 18;
            this.Pass.TextChanged += new System.EventHandler(this.Pass_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(86, 127);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(68, 13);
            this.label12.TabIndex = 20;
            this.label12.Text = "DPMS Type:";
            // 
            // pmsType
            // 
            this.pmsType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.pmsType.FormattingEnabled = true;
            this.pmsType.Items.AddRange(new object[] {
            "SoftDent",
            "PWOffice"});
            this.pmsType.Location = new System.Drawing.Point(160, 124);
            this.pmsType.Name = "pmsType";
            this.pmsType.Size = new System.Drawing.Size(251, 21);
            this.pmsType.TabIndex = 12;
            this.pmsType.SelectedIndexChanged += new System.EventHandler(this.pmsType_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 353);
            this.Controls.Add(this.pmsType);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.Pass);
            this.Controls.Add(this.User);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.InstanceName);
            this.Controls.Add(this.ServerName);
            this.Controls.Add(this.DPMSDBIdentifier);
            this.Controls.Add(this.DatabaseSetName);
            this.Controls.Add(this.NextGenDBName);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mike\'s Cloud Database Creator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox NextGenDBName;
        private System.Windows.Forms.TextBox DatabaseSetName;
        private System.Windows.Forms.TextBox DPMSDBIdentifier;
        private System.Windows.Forms.TextBox ServerName;
        private System.Windows.Forms.TextBox InstanceName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox User;
        private System.Windows.Forms.TextBox Pass;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox pmsType;
    }
}

