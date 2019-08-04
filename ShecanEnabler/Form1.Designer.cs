namespace ShecanEnabler
{
    partial class DNSChanger
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DNSChanger));
            this.rdDefault = new System.Windows.Forms.RadioButton();
            this.rdGoogle = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.rdShecan1 = new System.Windows.Forms.RadioButton();
            this.btnCheck = new System.Windows.Forms.Button();
            this.txtOpen = new System.Windows.Forms.TextBox();
            this.txtShecanDNS1 = new System.Windows.Forms.TextBox();
            this.txtShecanDNS2 = new System.Windows.Forms.TextBox();
            this.rdShecan2 = new System.Windows.Forms.RadioButton();
            this.rdOpenDNS = new System.Windows.Forms.RadioButton();
            this.txtGoogle = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // rdDefault
            // 
            this.rdDefault.AutoSize = true;
            this.rdDefault.Checked = true;
            this.rdDefault.Location = new System.Drawing.Point(23, 25);
            this.rdDefault.Name = "rdDefault";
            this.rdDefault.Size = new System.Drawing.Size(59, 17);
            this.rdDefault.TabIndex = 0;
            this.rdDefault.TabStop = true;
            this.rdDefault.Text = "Default";
            this.rdDefault.UseVisualStyleBackColor = true;
            this.rdDefault.CheckedChanged += new System.EventHandler(this.rdDefault_CheckedChanged);
            // 
            // rdGoogle
            // 
            this.rdGoogle.AutoSize = true;
            this.rdGoogle.Location = new System.Drawing.Point(23, 48);
            this.rdGoogle.Name = "rdGoogle";
            this.rdGoogle.Size = new System.Drawing.Size(59, 17);
            this.rdGoogle.TabIndex = 0;
            this.rdGoogle.Text = "Google";
            this.rdGoogle.UseVisualStyleBackColor = true;
            this.rdGoogle.CheckedChanged += new System.EventHandler(this.rdGoogle_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "DNS Changer";
            // 
            // rdShecan1
            // 
            this.rdShecan1.AutoSize = true;
            this.rdShecan1.Location = new System.Drawing.Point(23, 96);
            this.rdShecan1.Name = "rdShecan1";
            this.rdShecan1.Size = new System.Drawing.Size(68, 17);
            this.rdShecan1.TabIndex = 0;
            this.rdShecan1.Text = "Shecan1";
            this.rdShecan1.UseVisualStyleBackColor = true;
            this.rdShecan1.CheckedChanged += new System.EventHandler(this.rdShecan1_CheckedChanged);
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(109, 9);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(100, 33);
            this.btnCheck.TabIndex = 2;
            this.btnCheck.Text = "CHK";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // txtOpen
            // 
            this.txtOpen.Location = new System.Drawing.Point(109, 73);
            this.txtOpen.Name = "txtOpen";
            this.txtOpen.Size = new System.Drawing.Size(100, 20);
            this.txtOpen.TabIndex = 3;
            this.txtOpen.Text = "4.2.2.4";
            // 
            // txtShecanDNS1
            // 
            this.txtShecanDNS1.Location = new System.Drawing.Point(109, 98);
            this.txtShecanDNS1.Name = "txtShecanDNS1";
            this.txtShecanDNS1.Size = new System.Drawing.Size(100, 20);
            this.txtShecanDNS1.TabIndex = 3;
            this.txtShecanDNS1.Text = "178.22.122.100";
            // 
            // txtShecanDNS2
            // 
            this.txtShecanDNS2.Location = new System.Drawing.Point(109, 123);
            this.txtShecanDNS2.Name = "txtShecanDNS2";
            this.txtShecanDNS2.Size = new System.Drawing.Size(100, 20);
            this.txtShecanDNS2.TabIndex = 3;
            this.txtShecanDNS2.Text = "185.51.200.2";
            // 
            // rdShecan2
            // 
            this.rdShecan2.AutoSize = true;
            this.rdShecan2.Location = new System.Drawing.Point(23, 120);
            this.rdShecan2.Name = "rdShecan2";
            this.rdShecan2.Size = new System.Drawing.Size(68, 17);
            this.rdShecan2.TabIndex = 4;
            this.rdShecan2.Text = "Shecan2";
            this.rdShecan2.UseVisualStyleBackColor = true;
            this.rdShecan2.CheckedChanged += new System.EventHandler(this.rdShecan2_CheckedChanged);
            // 
            // rdOpenDNS
            // 
            this.rdOpenDNS.AutoSize = true;
            this.rdOpenDNS.Location = new System.Drawing.Point(23, 72);
            this.rdOpenDNS.Name = "rdOpenDNS";
            this.rdOpenDNS.Size = new System.Drawing.Size(74, 17);
            this.rdOpenDNS.TabIndex = 5;
            this.rdOpenDNS.Text = "OpenDNS";
            this.rdOpenDNS.UseVisualStyleBackColor = true;
            this.rdOpenDNS.CheckedChanged += new System.EventHandler(this.rdOpenDNS_CheckedChanged);
            // 
            // txtGoogle
            // 
            this.txtGoogle.Location = new System.Drawing.Point(109, 48);
            this.txtGoogle.Name = "txtGoogle";
            this.txtGoogle.Size = new System.Drawing.Size(100, 20);
            this.txtGoogle.TabIndex = 3;
            this.txtGoogle.Text = "8.8.8.8";
            // 
            // DNSChanger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(219, 151);
            this.Controls.Add(this.rdOpenDNS);
            this.Controls.Add(this.rdShecan2);
            this.Controls.Add(this.txtShecanDNS2);
            this.Controls.Add(this.txtShecanDNS1);
            this.Controls.Add(this.txtGoogle);
            this.Controls.Add(this.txtOpen);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rdShecan1);
            this.Controls.Add(this.rdGoogle);
            this.Controls.Add(this.rdDefault);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DNSChanger";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DNS Changer";
            this.Load += new System.EventHandler(this.DNSChanger_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdDefault;
        private System.Windows.Forms.RadioButton rdGoogle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdShecan1;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.TextBox txtOpen;
        private System.Windows.Forms.TextBox txtShecanDNS1;
        private System.Windows.Forms.TextBox txtShecanDNS2;
        private System.Windows.Forms.RadioButton rdShecan2;
        private System.Windows.Forms.RadioButton rdOpenDNS;
        private System.Windows.Forms.TextBox txtGoogle;
    }
}

