
namespace Siete_U2
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
            this.radioButtonA = new System.Windows.Forms.RadioButton();
            this.radioButtonB = new System.Windows.Forms.RadioButton();
            this.radioButtonC = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxIPAddress = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxHostAddressRange = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxSubnetID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxBroadcastAddress = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxSubnetBitmap = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxFirstOctetRange = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxHexIPAddress = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBoxWildcardMask = new System.Windows.Forms.TextBox();
            this.comboBoxSubnetMask = new System.Windows.Forms.ComboBox();
            this.comboBoxSubnetBits = new System.Windows.Forms.ComboBox();
            this.comboBoxMaximumSubnets = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.comboBoxMaskBits = new System.Windows.Forms.ComboBox();
            this.comboBoxHostsperSubnet = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // radioButtonA
            // 
            this.radioButtonA.AutoSize = true;
            this.radioButtonA.Checked = true;
            this.radioButtonA.Location = new System.Drawing.Point(45, 33);
            this.radioButtonA.Name = "radioButtonA";
            this.radioButtonA.Size = new System.Drawing.Size(32, 17);
            this.radioButtonA.TabIndex = 0;
            this.radioButtonA.TabStop = true;
            this.radioButtonA.Text = "A";
            this.radioButtonA.UseVisualStyleBackColor = true;
            this.radioButtonA.Click += new System.EventHandler(this.radioButtonA_Click);
            // 
            // radioButtonB
            // 
            this.radioButtonB.AutoSize = true;
            this.radioButtonB.Location = new System.Drawing.Point(127, 33);
            this.radioButtonB.Name = "radioButtonB";
            this.radioButtonB.Size = new System.Drawing.Size(32, 17);
            this.radioButtonB.TabIndex = 1;
            this.radioButtonB.Text = "B";
            this.radioButtonB.UseVisualStyleBackColor = true;
            this.radioButtonB.Click += new System.EventHandler(this.radioButtonB_Click);
            // 
            // radioButtonC
            // 
            this.radioButtonC.AutoSize = true;
            this.radioButtonC.Location = new System.Drawing.Point(229, 33);
            this.radioButtonC.Name = "radioButtonC";
            this.radioButtonC.Size = new System.Drawing.Size(32, 17);
            this.radioButtonC.TabIndex = 2;
            this.radioButtonC.Text = "C";
            this.radioButtonC.UseVisualStyleBackColor = true;
            this.radioButtonC.Click += new System.EventHandler(this.radioButtonC_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "IP Adress";
            // 
            // textBoxIPAddress
            // 
            this.textBoxIPAddress.Location = new System.Drawing.Point(45, 90);
            this.textBoxIPAddress.MaxLength = 15;
            this.textBoxIPAddress.Name = "textBoxIPAddress";
            this.textBoxIPAddress.Size = new System.Drawing.Size(100, 20);
            this.textBoxIPAddress.TabIndex = 4;
            this.textBoxIPAddress.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxIPAddress_KeyDown);
            this.textBoxIPAddress.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxIPAddress_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Subnet Mask";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Subnet Bits";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 217);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Maximum Subnets";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(47, 297);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Host Adress Range";
            // 
            // textBoxHostAddressRange
            // 
            this.textBoxHostAddressRange.Location = new System.Drawing.Point(51, 314);
            this.textBoxHostAddressRange.Name = "textBoxHostAddressRange";
            this.textBoxHostAddressRange.ReadOnly = true;
            this.textBoxHostAddressRange.Size = new System.Drawing.Size(365, 20);
            this.textBoxHostAddressRange.TabIndex = 12;
            this.textBoxHostAddressRange.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(47, 354);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Subnet ID";
            // 
            // textBoxSubnetID
            // 
            this.textBoxSubnetID.Location = new System.Drawing.Point(51, 371);
            this.textBoxSubnetID.Name = "textBoxSubnetID";
            this.textBoxSubnetID.ReadOnly = true;
            this.textBoxSubnetID.Size = new System.Drawing.Size(100, 20);
            this.textBoxSubnetID.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(322, 353);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Broadcast Address";
            // 
            // textBoxBroadcastAddress
            // 
            this.textBoxBroadcastAddress.Location = new System.Drawing.Point(312, 370);
            this.textBoxBroadcastAddress.Name = "textBoxBroadcastAddress";
            this.textBoxBroadcastAddress.ReadOnly = true;
            this.textBoxBroadcastAddress.Size = new System.Drawing.Size(100, 20);
            this.textBoxBroadcastAddress.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(94, 398);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Subnet Bitmap";
            // 
            // textBoxSubnetBitmap
            // 
            this.textBoxSubnetBitmap.Location = new System.Drawing.Point(50, 418);
            this.textBoxSubnetBitmap.Name = "textBoxSubnetBitmap";
            this.textBoxSubnetBitmap.ReadOnly = true;
            this.textBoxSubnetBitmap.Size = new System.Drawing.Size(362, 20);
            this.textBoxSubnetBitmap.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(335, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "First Octet Range";
            // 
            // textBoxFirstOctetRange
            // 
            this.textBoxFirstOctetRange.Location = new System.Drawing.Point(338, 33);
            this.textBoxFirstOctetRange.Name = "textBoxFirstOctetRange";
            this.textBoxFirstOctetRange.ReadOnly = true;
            this.textBoxFirstOctetRange.Size = new System.Drawing.Size(100, 20);
            this.textBoxFirstOctetRange.TabIndex = 20;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(337, 60);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "Hex IP Adress";
            // 
            // textBoxHexIPAddress
            // 
            this.textBoxHexIPAddress.Location = new System.Drawing.Point(340, 76);
            this.textBoxHexIPAddress.Name = "textBoxHexIPAddress";
            this.textBoxHexIPAddress.ReadOnly = true;
            this.textBoxHexIPAddress.Size = new System.Drawing.Size(100, 20);
            this.textBoxHexIPAddress.TabIndex = 22;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(340, 103);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(78, 13);
            this.label11.TabIndex = 23;
            this.label11.Text = "Wildcard Mask";
            // 
            // textBoxWildcardMask
            // 
            this.textBoxWildcardMask.Location = new System.Drawing.Point(338, 120);
            this.textBoxWildcardMask.Name = "textBoxWildcardMask";
            this.textBoxWildcardMask.ReadOnly = true;
            this.textBoxWildcardMask.Size = new System.Drawing.Size(100, 20);
            this.textBoxWildcardMask.TabIndex = 24;
            // 
            // comboBoxSubnetMask
            // 
            this.comboBoxSubnetMask.FormattingEnabled = true;
            this.comboBoxSubnetMask.Location = new System.Drawing.Point(45, 149);
            this.comboBoxSubnetMask.Name = "comboBoxSubnetMask";
            this.comboBoxSubnetMask.Size = new System.Drawing.Size(121, 21);
            this.comboBoxSubnetMask.TabIndex = 27;
            this.comboBoxSubnetMask.SelectedIndexChanged += new System.EventHandler(this.comboBoxSubnetMask_SelectedIndexChanged);
            // 
            // comboBoxSubnetBits
            // 
            this.comboBoxSubnetBits.FormattingEnabled = true;
            this.comboBoxSubnetBits.Location = new System.Drawing.Point(45, 189);
            this.comboBoxSubnetBits.Name = "comboBoxSubnetBits";
            this.comboBoxSubnetBits.Size = new System.Drawing.Size(121, 21);
            this.comboBoxSubnetBits.TabIndex = 28;
            this.comboBoxSubnetBits.SelectedIndexChanged += new System.EventHandler(this.comboBoxSubnetBits_SelectedIndexChanged);
            // 
            // comboBoxMaximumSubnets
            // 
            this.comboBoxMaximumSubnets.FormattingEnabled = true;
            this.comboBoxMaximumSubnets.Location = new System.Drawing.Point(45, 234);
            this.comboBoxMaximumSubnets.Name = "comboBoxMaximumSubnets";
            this.comboBoxMaximumSubnets.Size = new System.Drawing.Size(121, 21);
            this.comboBoxMaximumSubnets.TabIndex = 29;
            this.comboBoxMaximumSubnets.SelectedIndexChanged += new System.EventHandler(this.comboBoxMaximumSubnets_SelectedIndexChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(337, 173);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 13);
            this.label12.TabIndex = 30;
            this.label12.Text = "Mask Bits";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(325, 217);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(89, 13);
            this.label13.TabIndex = 31;
            this.label13.Text = "Hosts per Subnet";
            // 
            // comboBoxMaskBits
            // 
            this.comboBoxMaskBits.FormattingEnabled = true;
            this.comboBoxMaskBits.Location = new System.Drawing.Point(312, 189);
            this.comboBoxMaskBits.Name = "comboBoxMaskBits";
            this.comboBoxMaskBits.Size = new System.Drawing.Size(121, 21);
            this.comboBoxMaskBits.TabIndex = 32;
            this.comboBoxMaskBits.SelectedIndexChanged += new System.EventHandler(this.comboBoxMaskBits_SelectedIndexChanged);
            // 
            // comboBoxHostsperSubnet
            // 
            this.comboBoxHostsperSubnet.FormattingEnabled = true;
            this.comboBoxHostsperSubnet.Location = new System.Drawing.Point(312, 233);
            this.comboBoxHostsperSubnet.Name = "comboBoxHostsperSubnet";
            this.comboBoxHostsperSubnet.Size = new System.Drawing.Size(121, 21);
            this.comboBoxHostsperSubnet.TabIndex = 33;
            this.comboBoxHostsperSubnet.SelectedIndexChanged += new System.EventHandler(this.comboBoxHostsperSubnet_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 450);
            this.Controls.Add(this.comboBoxHostsperSubnet);
            this.Controls.Add(this.comboBoxMaskBits);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.comboBoxMaximumSubnets);
            this.Controls.Add(this.comboBoxSubnetBits);
            this.Controls.Add(this.comboBoxSubnetMask);
            this.Controls.Add(this.textBoxWildcardMask);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.textBoxHexIPAddress);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBoxFirstOctetRange);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBoxSubnetBitmap);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBoxBroadcastAddress);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxSubnetID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxHostAddressRange);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxIPAddress);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radioButtonC);
            this.Controls.Add(this.radioButtonB);
            this.Controls.Add(this.radioButtonA);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButtonA;
        private System.Windows.Forms.RadioButton radioButtonB;
        private System.Windows.Forms.RadioButton radioButtonC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxIPAddress;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxHostAddressRange;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxSubnetID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxBroadcastAddress;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxSubnetBitmap;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxFirstOctetRange;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxHexIPAddress;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBoxWildcardMask;
        private System.Windows.Forms.ComboBox comboBoxSubnetMask;
        private System.Windows.Forms.ComboBox comboBoxSubnetBits;
        private System.Windows.Forms.ComboBox comboBoxMaximumSubnets;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox comboBoxMaskBits;
        private System.Windows.Forms.ComboBox comboBoxHostsperSubnet;
    }
}

