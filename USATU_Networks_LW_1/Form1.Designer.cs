namespace USATU_Networks_LW_1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridPingRequests = new System.Windows.Forms.DataGridView();
            this.buttonClearPingRequests = new System.Windows.Forms.Button();
            this.buttonScanRangeIP = new System.Windows.Forms.Button();
            this.textBoxFromAddress = new System.Windows.Forms.TextBox();
            this.panelFromAddress = new System.Windows.Forms.Panel();
            this.labelFromAddress = new System.Windows.Forms.Label();
            this.panelToAddress = new System.Windows.Forms.Panel();
            this.labelToAddress = new System.Windows.Forms.Label();
            this.textBoxToAddress = new System.Windows.Forms.TextBox();
            this.panelAddressUserActions = new System.Windows.Forms.Panel();
            this.panelLocalInfo = new System.Windows.Forms.Panel();
            this.panelAddressMAC = new System.Windows.Forms.Panel();
            this.textBoxAddressMAC = new System.Windows.Forms.TextBox();
            this.labelAddressMac = new System.Windows.Forms.Label();
            this.panelNetworkAddress = new System.Windows.Forms.Panel();
            this.textBoxNetworkAddress = new System.Windows.Forms.TextBox();
            this.labelNetworkAddress = new System.Windows.Forms.Label();
            this.panelBroadcastAddress = new System.Windows.Forms.Panel();
            this.textBoxBroadcastAddress = new System.Windows.Forms.TextBox();
            this.labelBroadcastAddress = new System.Windows.Forms.Label();
            this.panelSubnetMask = new System.Windows.Forms.Panel();
            this.textBoxSubnetMask = new System.Windows.Forms.TextBox();
            this.labelSubnetMask = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize) (this.dataGridPingRequests)).BeginInit();
            this.panelFromAddress.SuspendLayout();
            this.panelToAddress.SuspendLayout();
            this.panelAddressUserActions.SuspendLayout();
            this.panelLocalInfo.SuspendLayout();
            this.panelAddressMAC.SuspendLayout();
            this.panelNetworkAddress.SuspendLayout();
            this.panelBroadcastAddress.SuspendLayout();
            this.panelSubnetMask.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridPingRequests
            // 
            this.dataGridPingRequests.AllowUserToAddRows = false;
            this.dataGridPingRequests.AllowUserToDeleteRows = false;
            this.dataGridPingRequests.AllowUserToResizeColumns = false;
            this.dataGridPingRequests.AllowUserToResizeRows = false;
            this.dataGridPingRequests.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridPingRequests.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridPingRequests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridPingRequests.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridPingRequests.Location = new System.Drawing.Point(12, 12);
            this.dataGridPingRequests.Name = "dataGridPingRequests";
            this.dataGridPingRequests.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridPingRequests.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridPingRequests.RowHeadersVisible = false;
            this.dataGridPingRequests.Size = new System.Drawing.Size(532, 215);
            this.dataGridPingRequests.TabIndex = 0;
            // 
            // buttonClearPingRequests
            // 
            this.buttonClearPingRequests.Location = new System.Drawing.Point(3, 3);
            this.buttonClearPingRequests.Name = "buttonClearPingRequests";
            this.buttonClearPingRequests.Size = new System.Drawing.Size(101, 23);
            this.buttonClearPingRequests.TabIndex = 1;
            this.buttonClearPingRequests.Text = "Clear";
            this.buttonClearPingRequests.UseVisualStyleBackColor = true;
            this.buttonClearPingRequests.MouseClick += new System.Windows.Forms.MouseEventHandler(this.buttonClearPingRequests_MouseClick);
            // 
            // buttonScanRangeIP
            // 
            this.buttonScanRangeIP.Location = new System.Drawing.Point(110, 3);
            this.buttonScanRangeIP.Name = "buttonScanRangeIP";
            this.buttonScanRangeIP.Size = new System.Drawing.Size(101, 23);
            this.buttonScanRangeIP.TabIndex = 2;
            this.buttonScanRangeIP.Text = "Check";
            this.buttonScanRangeIP.UseVisualStyleBackColor = true;
            this.buttonScanRangeIP.MouseClick += new System.Windows.Forms.MouseEventHandler(this.buttonScanRangeIP_MouseClick);
            // 
            // textBoxFromAddress
            // 
            this.textBoxFromAddress.Location = new System.Drawing.Point(46, 6);
            this.textBoxFromAddress.Name = "textBoxFromAddress";
            this.textBoxFromAddress.Size = new System.Drawing.Size(159, 20);
            this.textBoxFromAddress.TabIndex = 4;
            this.textBoxFromAddress.Text = "192.168.0.1";
            // 
            // panelFromAddress
            // 
            this.panelFromAddress.Controls.Add(this.labelFromAddress);
            this.panelFromAddress.Controls.Add(this.textBoxFromAddress);
            this.panelFromAddress.Location = new System.Drawing.Point(3, 32);
            this.panelFromAddress.Name = "panelFromAddress";
            this.panelFromAddress.Size = new System.Drawing.Size(208, 32);
            this.panelFromAddress.TabIndex = 5;
            // 
            // labelFromAddress
            // 
            this.labelFromAddress.Location = new System.Drawing.Point(3, 4);
            this.labelFromAddress.Name = "labelFromAddress";
            this.labelFromAddress.Size = new System.Drawing.Size(37, 23);
            this.labelFromAddress.TabIndex = 5;
            this.labelFromAddress.Text = "from:";
            this.labelFromAddress.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panelToAddress
            // 
            this.panelToAddress.Controls.Add(this.labelToAddress);
            this.panelToAddress.Controls.Add(this.textBoxToAddress);
            this.panelToAddress.Location = new System.Drawing.Point(3, 70);
            this.panelToAddress.Name = "panelToAddress";
            this.panelToAddress.Size = new System.Drawing.Size(208, 32);
            this.panelToAddress.TabIndex = 5;
            // 
            // labelToAddress
            // 
            this.labelToAddress.Location = new System.Drawing.Point(3, 4);
            this.labelToAddress.Name = "labelToAddress";
            this.labelToAddress.Size = new System.Drawing.Size(37, 23);
            this.labelToAddress.TabIndex = 5;
            this.labelToAddress.Text = "to:";
            this.labelToAddress.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBoxToAddress
            // 
            this.textBoxToAddress.Location = new System.Drawing.Point(46, 6);
            this.textBoxToAddress.Name = "textBoxToAddress";
            this.textBoxToAddress.Size = new System.Drawing.Size(159, 20);
            this.textBoxToAddress.TabIndex = 4;
            this.textBoxToAddress.Text = "192.168.0.254";
            // 
            // panelAddressUserActions
            // 
            this.panelAddressUserActions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelAddressUserActions.Controls.Add(this.panelFromAddress);
            this.panelAddressUserActions.Controls.Add(this.panelToAddress);
            this.panelAddressUserActions.Controls.Add(this.buttonClearPingRequests);
            this.panelAddressUserActions.Controls.Add(this.buttonScanRangeIP);
            this.panelAddressUserActions.Location = new System.Drawing.Point(12, 233);
            this.panelAddressUserActions.Name = "panelAddressUserActions";
            this.panelAddressUserActions.Size = new System.Drawing.Size(227, 110);
            this.panelAddressUserActions.TabIndex = 6;
            // 
            // panelLocalInfo
            // 
            this.panelLocalInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelLocalInfo.Controls.Add(this.panelAddressMAC);
            this.panelLocalInfo.Controls.Add(this.panelNetworkAddress);
            this.panelLocalInfo.Controls.Add(this.panelBroadcastAddress);
            this.panelLocalInfo.Controls.Add(this.panelSubnetMask);
            this.panelLocalInfo.Location = new System.Drawing.Point(245, 233);
            this.panelLocalInfo.Name = "panelLocalInfo";
            this.panelLocalInfo.Size = new System.Drawing.Size(299, 282);
            this.panelLocalInfo.TabIndex = 7;
            // 
            // panelAddressMAC
            // 
            this.panelAddressMAC.Controls.Add(this.textBoxAddressMAC);
            this.panelAddressMAC.Controls.Add(this.labelAddressMac);
            this.panelAddressMAC.Location = new System.Drawing.Point(3, 204);
            this.panelAddressMAC.Name = "panelAddressMAC";
            this.panelAddressMAC.Size = new System.Drawing.Size(290, 61);
            this.panelAddressMAC.TabIndex = 0;
            // 
            // textBoxAddressMAC
            // 
            this.textBoxAddressMAC.Location = new System.Drawing.Point(0, 26);
            this.textBoxAddressMAC.Name = "textBoxAddressMAC";
            this.textBoxAddressMAC.ReadOnly = true;
            this.textBoxAddressMAC.Size = new System.Drawing.Size(282, 20);
            this.textBoxAddressMAC.TabIndex = 1;
            // 
            // labelAddressMac
            // 
            this.labelAddressMac.Location = new System.Drawing.Point(3, 0);
            this.labelAddressMac.Name = "labelAddressMac";
            this.labelAddressMac.Size = new System.Drawing.Size(282, 23);
            this.labelAddressMac.TabIndex = 0;
            this.labelAddressMac.Text = "MAC address:";
            this.labelAddressMac.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelNetworkAddress
            // 
            this.panelNetworkAddress.Controls.Add(this.textBoxNetworkAddress);
            this.panelNetworkAddress.Controls.Add(this.labelNetworkAddress);
            this.panelNetworkAddress.Location = new System.Drawing.Point(3, 137);
            this.panelNetworkAddress.Name = "panelNetworkAddress";
            this.panelNetworkAddress.Size = new System.Drawing.Size(290, 61);
            this.panelNetworkAddress.TabIndex = 0;
            // 
            // textBoxNetworkAddress
            // 
            this.textBoxNetworkAddress.Location = new System.Drawing.Point(0, 26);
            this.textBoxNetworkAddress.Name = "textBoxNetworkAddress";
            this.textBoxNetworkAddress.ReadOnly = true;
            this.textBoxNetworkAddress.Size = new System.Drawing.Size(282, 20);
            this.textBoxNetworkAddress.TabIndex = 1;
            // 
            // labelNetworkAddress
            // 
            this.labelNetworkAddress.Location = new System.Drawing.Point(3, 0);
            this.labelNetworkAddress.Name = "labelNetworkAddress";
            this.labelNetworkAddress.Size = new System.Drawing.Size(282, 23);
            this.labelNetworkAddress.TabIndex = 0;
            this.labelNetworkAddress.Text = "Network address:";
            this.labelNetworkAddress.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelBroadcastAddress
            // 
            this.panelBroadcastAddress.Controls.Add(this.textBoxBroadcastAddress);
            this.panelBroadcastAddress.Controls.Add(this.labelBroadcastAddress);
            this.panelBroadcastAddress.Location = new System.Drawing.Point(3, 70);
            this.panelBroadcastAddress.Name = "panelBroadcastAddress";
            this.panelBroadcastAddress.Size = new System.Drawing.Size(290, 61);
            this.panelBroadcastAddress.TabIndex = 0;
            // 
            // textBoxBroadcastAddress
            // 
            this.textBoxBroadcastAddress.Location = new System.Drawing.Point(0, 26);
            this.textBoxBroadcastAddress.Name = "textBoxBroadcastAddress";
            this.textBoxBroadcastAddress.ReadOnly = true;
            this.textBoxBroadcastAddress.Size = new System.Drawing.Size(282, 20);
            this.textBoxBroadcastAddress.TabIndex = 1;
            // 
            // labelBroadcastAddress
            // 
            this.labelBroadcastAddress.Location = new System.Drawing.Point(3, 0);
            this.labelBroadcastAddress.Name = "labelBroadcastAddress";
            this.labelBroadcastAddress.Size = new System.Drawing.Size(282, 23);
            this.labelBroadcastAddress.TabIndex = 0;
            this.labelBroadcastAddress.Text = "Broadcast address:";
            this.labelBroadcastAddress.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelSubnetMask
            // 
            this.panelSubnetMask.Controls.Add(this.textBoxSubnetMask);
            this.panelSubnetMask.Controls.Add(this.labelSubnetMask);
            this.panelSubnetMask.Location = new System.Drawing.Point(3, 3);
            this.panelSubnetMask.Name = "panelSubnetMask";
            this.panelSubnetMask.Size = new System.Drawing.Size(290, 61);
            this.panelSubnetMask.TabIndex = 0;
            // 
            // textBoxSubnetMask
            // 
            this.textBoxSubnetMask.Location = new System.Drawing.Point(0, 26);
            this.textBoxSubnetMask.Name = "textBoxSubnetMask";
            this.textBoxSubnetMask.ReadOnly = true;
            this.textBoxSubnetMask.Size = new System.Drawing.Size(282, 20);
            this.textBoxSubnetMask.TabIndex = 1;
            // 
            // labelSubnetMask
            // 
            this.labelSubnetMask.Location = new System.Drawing.Point(3, 0);
            this.labelSubnetMask.Name = "labelSubnetMask";
            this.labelSubnetMask.Size = new System.Drawing.Size(282, 23);
            this.labelSubnetMask.TabIndex = 0;
            this.labelSubnetMask.Text = "Subnet mask:";
            this.labelSubnetMask.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(557, 527);
            this.Controls.Add(this.panelLocalInfo);
            this.Controls.Add(this.panelAddressUserActions);
            this.Controls.Add(this.dataGridPingRequests);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Location = new System.Drawing.Point(15, 15);
            this.Name = "Form1";
            this.Text = "LW 1";
            ((System.ComponentModel.ISupportInitialize) (this.dataGridPingRequests)).EndInit();
            this.panelFromAddress.ResumeLayout(false);
            this.panelFromAddress.PerformLayout();
            this.panelToAddress.ResumeLayout(false);
            this.panelToAddress.PerformLayout();
            this.panelAddressUserActions.ResumeLayout(false);
            this.panelLocalInfo.ResumeLayout(false);
            this.panelAddressMAC.ResumeLayout(false);
            this.panelAddressMAC.PerformLayout();
            this.panelNetworkAddress.ResumeLayout(false);
            this.panelNetworkAddress.PerformLayout();
            this.panelBroadcastAddress.ResumeLayout(false);
            this.panelBroadcastAddress.PerformLayout();
            this.panelSubnetMask.ResumeLayout(false);
            this.panelSubnetMask.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Panel panelAddressMAC;
        private System.Windows.Forms.TextBox textBoxAddressMAC;
        private System.Windows.Forms.Label labelAddressMac;

        private System.Windows.Forms.TextBox textBoxSubnetMask;
        private System.Windows.Forms.Panel panelBroadcastAddress;
        private System.Windows.Forms.TextBox textBoxBroadcastAddress;
        private System.Windows.Forms.Label labelBroadcastAddress;
        private System.Windows.Forms.Panel panelNetworkAddress;
        private System.Windows.Forms.TextBox textBoxNetworkAddress;
        private System.Windows.Forms.Label labelNetworkAddress;

        private System.Windows.Forms.Panel panelLocalInfo;
        private System.Windows.Forms.Panel panelSubnetMask;
        private System.Windows.Forms.Label labelSubnetMask;

        private System.Windows.Forms.Panel panelFromAddress;

        private System.Windows.Forms.TextBox textBoxFromAddress;
        private System.Windows.Forms.Panel panelAddressUserActions;
        private System.Windows.Forms.Label labelFromAddress;
        private System.Windows.Forms.Panel panelToAddress;
        private System.Windows.Forms.Label labelToAddress;
        private System.Windows.Forms.TextBox textBoxToAddress;

        private System.Windows.Forms.Button buttonScanRangeIP;

        private System.Windows.Forms.Button buttonClearPingRequests;

        private System.Windows.Forms.DataGridView dataGridPingRequests;

        #endregion
    }
}