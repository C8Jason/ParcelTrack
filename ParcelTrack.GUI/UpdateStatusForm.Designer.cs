namespace ParcelTrack.GUI
{
    partial class UpdateStatusForm
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
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlSideBar = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnD0ashBoard = new System.Windows.Forms.Button();
            this.pnlUpdateParcelStatus = new System.Windows.Forms.Panel();
            this.lblUpdateParcelStatus = new System.Windows.Forms.Label();
            this.pnlUnderUpdateParcelStatus = new System.Windows.Forms.Panel();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.lblLocation = new System.Windows.Forms.Label();
            this.btnClearUpdate = new System.Windows.Forms.Button();
            this.btnUpdateStatus = new System.Windows.Forms.Button();
            this.txtRemarks = new System.Windows.Forms.TextBox();
            this.lblRemarks = new System.Windows.Forms.Label();
            this.cmbUpdateStatus = new System.Windows.Forms.ComboBox();
            this.lblUpdateStatus = new System.Windows.Forms.Label();
            this.btnSearchUpdate = new System.Windows.Forms.Button();
            this.txtCurrentStatus = new System.Windows.Forms.TextBox();
            this.lblCurrentStatus = new System.Windows.Forms.Label();
            this.txtTrackingNumber = new System.Windows.Forms.TextBox();
            this.lblTrackingNumber = new System.Windows.Forms.Label();
            this.pnlParcelDetails = new System.Windows.Forms.Panel();
            this.lblParcelDetails = new System.Windows.Forms.Label();
            this.pnlUnderParcelDetails = new System.Windows.Forms.Panel();
            this.lblRegisteredDateValue = new System.Windows.Forms.Label();
            this.lblDeliveryServiceValue = new System.Windows.Forms.Label();
            this.lblWeightValue = new System.Windows.Forms.Label();
            this.lblRecipientNameValue = new System.Windows.Forms.Label();
            this.lblSenderNameValue = new System.Windows.Forms.Label();
            this.lblRegisteredDate = new System.Windows.Forms.Label();
            this.lblDeliveryService = new System.Windows.Forms.Label();
            this.lblWeight = new System.Windows.Forms.Label();
            this.lblRecipientName = new System.Windows.Forms.Label();
            this.lblSenderName = new System.Windows.Forms.Label();
            this.pnlStatusUpdateHistory = new System.Windows.Forms.Panel();
            this.lblStatusUpdateHistory = new System.Windows.Forms.Label();
            this.pnlUnderStatusUpdateHistory = new System.Windows.Forms.Panel();
            this.dgvStatusUpdateHistory = new System.Windows.Forms.DataGridView();
            this.colDateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLocation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblRecipientAddress = new System.Windows.Forms.Label();
            this.lblSenderAddress = new System.Windows.Forms.Label();
            this.lblCurrentLocation = new System.Windows.Forms.Label();
            this.lblSenderAddressValue = new System.Windows.Forms.Label();
            this.lblRecipientAddressValue = new System.Windows.Forms.Label();
            this.lblCurrentLocationValue = new System.Windows.Forms.Label();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlSideBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.pnlUpdateParcelStatus.SuspendLayout();
            this.pnlUnderUpdateParcelStatus.SuspendLayout();
            this.pnlParcelDetails.SuspendLayout();
            this.pnlUnderParcelDetails.SuspendLayout();
            this.pnlStatusUpdateHistory.SuspendLayout();
            this.pnlUnderStatusUpdateHistory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStatusUpdateHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.AutoSize = true;
            this.pnlHeader.BackColor = System.Drawing.Color.LightCyan;
            this.pnlHeader.Controls.Add(this.pictureBox1);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(250, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1494, 112);
            this.pnlHeader.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ParcelTrack.GUI.Properties.Resources.ParcelTrack_Delivery_Tracking_Logo;
            this.pictureBox1.Location = new System.Drawing.Point(26, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(425, 109);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // pnlSideBar
            // 
            this.pnlSideBar.AccessibleName = "";
            this.pnlSideBar.BackColor = System.Drawing.Color.MidnightBlue;
            this.pnlSideBar.Controls.Add(this.pictureBox3);
            this.pnlSideBar.Controls.Add(this.pictureBox2);
            this.pnlSideBar.Controls.Add(this.btnUpdate);
            this.pnlSideBar.Controls.Add(this.btnRegister);
            this.pnlSideBar.Controls.Add(this.btnD0ashBoard);
            this.pnlSideBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSideBar.Location = new System.Drawing.Point(0, 0);
            this.pnlSideBar.Name = "pnlSideBar";
            this.pnlSideBar.Size = new System.Drawing.Size(250, 861);
            this.pnlSideBar.TabIndex = 4;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::ParcelTrack.GUI.Properties.Resources.Blue_Location_Pin_with_Shipping_Boxes;
            this.pictureBox3.Location = new System.Drawing.Point(-47, 670);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(335, 190);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::ParcelTrack.GUI.Properties.Resources.ParcelTrack_Logo;
            this.pictureBox2.Location = new System.Drawing.Point(20, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(210, 97);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.SteelBlue;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(20, 272);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(210, 50);
            this.btnUpdate.TabIndex = 8;
            this.btnUpdate.Text = " Update Status";
            this.btnUpdate.UseVisualStyleBackColor = false;
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.SteelBlue;
            this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegister.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.ForeColor = System.Drawing.Color.White;
            this.btnRegister.Location = new System.Drawing.Point(20, 195);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(210, 50);
            this.btnRegister.TabIndex = 7;
            this.btnRegister.Text = "Register Parcel";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnD0ashBoard
            // 
            this.btnD0ashBoard.BackColor = System.Drawing.Color.SteelBlue;
            this.btnD0ashBoard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnD0ashBoard.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnD0ashBoard.ForeColor = System.Drawing.Color.White;
            this.btnD0ashBoard.Location = new System.Drawing.Point(20, 130);
            this.btnD0ashBoard.Name = "btnD0ashBoard";
            this.btnD0ashBoard.Size = new System.Drawing.Size(210, 50);
            this.btnD0ashBoard.TabIndex = 1;
            this.btnD0ashBoard.Text = "Dashboard";
            this.btnD0ashBoard.UseVisualStyleBackColor = false;
            // 
            // pnlUpdateParcelStatus
            // 
            this.pnlUpdateParcelStatus.BackColor = System.Drawing.Color.Blue;
            this.pnlUpdateParcelStatus.Controls.Add(this.lblUpdateParcelStatus);
            this.pnlUpdateParcelStatus.Location = new System.Drawing.Point(276, 130);
            this.pnlUpdateParcelStatus.Name = "pnlUpdateParcelStatus";
            this.pnlUpdateParcelStatus.Size = new System.Drawing.Size(613, 192);
            this.pnlUpdateParcelStatus.TabIndex = 10;
            // 
            // lblUpdateParcelStatus
            // 
            this.lblUpdateParcelStatus.AutoSize = true;
            this.lblUpdateParcelStatus.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdateParcelStatus.ForeColor = System.Drawing.Color.White;
            this.lblUpdateParcelStatus.Location = new System.Drawing.Point(124, 17);
            this.lblUpdateParcelStatus.Name = "lblUpdateParcelStatus";
            this.lblUpdateParcelStatus.Size = new System.Drawing.Size(328, 45);
            this.lblUpdateParcelStatus.TabIndex = 4;
            this.lblUpdateParcelStatus.Text = "Update Parcel Status";
            this.lblUpdateParcelStatus.Click += new System.EventHandler(this.label1_Click);
            // 
            // pnlUnderUpdateParcelStatus
            // 
            this.pnlUnderUpdateParcelStatus.BackColor = System.Drawing.Color.CornflowerBlue;
            this.pnlUnderUpdateParcelStatus.Controls.Add(this.txtLocation);
            this.pnlUnderUpdateParcelStatus.Controls.Add(this.lblLocation);
            this.pnlUnderUpdateParcelStatus.Controls.Add(this.btnClearUpdate);
            this.pnlUnderUpdateParcelStatus.Controls.Add(this.btnUpdateStatus);
            this.pnlUnderUpdateParcelStatus.Controls.Add(this.txtRemarks);
            this.pnlUnderUpdateParcelStatus.Controls.Add(this.lblRemarks);
            this.pnlUnderUpdateParcelStatus.Controls.Add(this.cmbUpdateStatus);
            this.pnlUnderUpdateParcelStatus.Controls.Add(this.lblUpdateStatus);
            this.pnlUnderUpdateParcelStatus.Controls.Add(this.btnSearchUpdate);
            this.pnlUnderUpdateParcelStatus.Controls.Add(this.txtCurrentStatus);
            this.pnlUnderUpdateParcelStatus.Controls.Add(this.lblCurrentStatus);
            this.pnlUnderUpdateParcelStatus.Controls.Add(this.txtTrackingNumber);
            this.pnlUnderUpdateParcelStatus.Controls.Add(this.lblTrackingNumber);
            this.pnlUnderUpdateParcelStatus.Location = new System.Drawing.Point(276, 212);
            this.pnlUnderUpdateParcelStatus.Name = "pnlUnderUpdateParcelStatus";
            this.pnlUnderUpdateParcelStatus.Size = new System.Drawing.Size(613, 611);
            this.pnlUnderUpdateParcelStatus.TabIndex = 11;
            // 
            // txtLocation
            // 
            this.txtLocation.Location = new System.Drawing.Point(7, 252);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(575, 20);
            this.txtLocation.TabIndex = 25;
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocation.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblLocation.Location = new System.Drawing.Point(9, 224);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(89, 25);
            this.lblLocation.TabIndex = 24;
            this.lblLocation.Text = "Location";
            // 
            // btnClearUpdate
            // 
            this.btnClearUpdate.BackColor = System.Drawing.Color.SlateGray;
            this.btnClearUpdate.DialogResult = System.Windows.Forms.DialogResult.Ignore;
            this.btnClearUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearUpdate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearUpdate.ForeColor = System.Drawing.Color.White;
            this.btnClearUpdate.Location = new System.Drawing.Point(390, 520);
            this.btnClearUpdate.Name = "btnClearUpdate";
            this.btnClearUpdate.Size = new System.Drawing.Size(208, 43);
            this.btnClearUpdate.TabIndex = 23;
            this.btnClearUpdate.Text = "Clear";
            this.btnClearUpdate.UseVisualStyleBackColor = false;
            this.btnClearUpdate.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnUpdateStatus
            // 
            this.btnUpdateStatus.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnUpdateStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateStatus.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateStatus.ForeColor = System.Drawing.Color.White;
            this.btnUpdateStatus.Location = new System.Drawing.Point(18, 497);
            this.btnUpdateStatus.Name = "btnUpdateStatus";
            this.btnUpdateStatus.Size = new System.Drawing.Size(366, 85);
            this.btnUpdateStatus.TabIndex = 12;
            this.btnUpdateStatus.Text = "Update Status";
            this.btnUpdateStatus.UseVisualStyleBackColor = false;
            this.btnUpdateStatus.Click += new System.EventHandler(this.btnUpdateStatus_Click);
            // 
            // txtRemarks
            // 
            this.txtRemarks.Location = new System.Drawing.Point(7, 344);
            this.txtRemarks.Multiline = true;
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.Size = new System.Drawing.Size(575, 136);
            this.txtRemarks.TabIndex = 22;
            this.txtRemarks.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // lblRemarks
            // 
            this.lblRemarks.AutoSize = true;
            this.lblRemarks.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRemarks.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblRemarks.Location = new System.Drawing.Point(9, 315);
            this.lblRemarks.Name = "lblRemarks";
            this.lblRemarks.Size = new System.Drawing.Size(194, 25);
            this.lblRemarks.TabIndex = 21;
            this.lblRemarks.Text = "Remarks ( Optional )";
            this.lblRemarks.Click += new System.EventHandler(this.label4_Click);
            // 
            // cmbUpdateStatus
            // 
            this.cmbUpdateStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUpdateStatus.FormattingEnabled = true;
            this.cmbUpdateStatus.Items.AddRange(new object[] {
            "Registered",
            "",
            "PickedUp",
            "",
            "InTransit",
            "",
            "OutForDelivery",
            "",
            "Delivered",
            "",
            "Cancelled"});
            this.cmbUpdateStatus.Location = new System.Drawing.Point(7, 184);
            this.cmbUpdateStatus.Name = "cmbUpdateStatus";
            this.cmbUpdateStatus.Size = new System.Drawing.Size(430, 21);
            this.cmbUpdateStatus.TabIndex = 20;
            // 
            // lblUpdateStatus
            // 
            this.lblUpdateStatus.AutoSize = true;
            this.lblUpdateStatus.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdateStatus.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblUpdateStatus.Location = new System.Drawing.Point(9, 156);
            this.lblUpdateStatus.Name = "lblUpdateStatus";
            this.lblUpdateStatus.Size = new System.Drawing.Size(163, 25);
            this.lblUpdateStatus.TabIndex = 10;
            this.lblUpdateStatus.Text = "Update To Status";
            this.lblUpdateStatus.Click += new System.EventHandler(this.label3_Click);
            // 
            // btnSearchUpdate
            // 
            this.btnSearchUpdate.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchUpdate.Location = new System.Drawing.Point(448, 37);
            this.btnSearchUpdate.Name = "btnSearchUpdate";
            this.btnSearchUpdate.Size = new System.Drawing.Size(107, 35);
            this.btnSearchUpdate.TabIndex = 9;
            this.btnSearchUpdate.Text = "Search";
            this.btnSearchUpdate.UseVisualStyleBackColor = true;
            // 
            // txtCurrentStatus
            // 
            this.txtCurrentStatus.Location = new System.Drawing.Point(7, 114);
            this.txtCurrentStatus.Name = "txtCurrentStatus";
            this.txtCurrentStatus.ReadOnly = true;
            this.txtCurrentStatus.Size = new System.Drawing.Size(430, 20);
            this.txtCurrentStatus.TabIndex = 8;
            this.txtCurrentStatus.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblCurrentStatus
            // 
            this.lblCurrentStatus.AutoSize = true;
            this.lblCurrentStatus.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentStatus.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblCurrentStatus.Location = new System.Drawing.Point(9, 86);
            this.lblCurrentStatus.Name = "lblCurrentStatus";
            this.lblCurrentStatus.Size = new System.Drawing.Size(141, 25);
            this.lblCurrentStatus.TabIndex = 7;
            this.lblCurrentStatus.Text = "Current Status";
            this.lblCurrentStatus.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtTrackingNumber
            // 
            this.txtTrackingNumber.Location = new System.Drawing.Point(7, 47);
            this.txtTrackingNumber.Name = "txtTrackingNumber";
            this.txtTrackingNumber.Size = new System.Drawing.Size(430, 20);
            this.txtTrackingNumber.TabIndex = 6;
            // 
            // lblTrackingNumber
            // 
            this.lblTrackingNumber.AutoSize = true;
            this.lblTrackingNumber.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrackingNumber.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblTrackingNumber.Location = new System.Drawing.Point(9, 19);
            this.lblTrackingNumber.Name = "lblTrackingNumber";
            this.lblTrackingNumber.Size = new System.Drawing.Size(168, 25);
            this.lblTrackingNumber.TabIndex = 5;
            this.lblTrackingNumber.Text = "Tracking Number";
            // 
            // pnlParcelDetails
            // 
            this.pnlParcelDetails.BackColor = System.Drawing.Color.Orange;
            this.pnlParcelDetails.Controls.Add(this.lblParcelDetails);
            this.pnlParcelDetails.Location = new System.Drawing.Point(942, 130);
            this.pnlParcelDetails.Name = "pnlParcelDetails";
            this.pnlParcelDetails.Size = new System.Drawing.Size(758, 175);
            this.pnlParcelDetails.TabIndex = 11;
            // 
            // lblParcelDetails
            // 
            this.lblParcelDetails.AutoSize = true;
            this.lblParcelDetails.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblParcelDetails.ForeColor = System.Drawing.Color.White;
            this.lblParcelDetails.Location = new System.Drawing.Point(278, 17);
            this.lblParcelDetails.Name = "lblParcelDetails";
            this.lblParcelDetails.Size = new System.Drawing.Size(221, 45);
            this.lblParcelDetails.TabIndex = 4;
            this.lblParcelDetails.Text = "Parcel Details";
            // 
            // pnlUnderParcelDetails
            // 
            this.pnlUnderParcelDetails.BackColor = System.Drawing.Color.PeachPuff;
            this.pnlUnderParcelDetails.Controls.Add(this.lblCurrentLocationValue);
            this.pnlUnderParcelDetails.Controls.Add(this.lblRecipientAddressValue);
            this.pnlUnderParcelDetails.Controls.Add(this.lblSenderAddressValue);
            this.pnlUnderParcelDetails.Controls.Add(this.lblCurrentLocation);
            this.pnlUnderParcelDetails.Controls.Add(this.lblSenderAddress);
            this.pnlUnderParcelDetails.Controls.Add(this.lblRecipientAddress);
            this.pnlUnderParcelDetails.Controls.Add(this.lblRegisteredDateValue);
            this.pnlUnderParcelDetails.Controls.Add(this.lblDeliveryServiceValue);
            this.pnlUnderParcelDetails.Controls.Add(this.lblWeightValue);
            this.pnlUnderParcelDetails.Controls.Add(this.lblRecipientNameValue);
            this.pnlUnderParcelDetails.Controls.Add(this.lblSenderNameValue);
            this.pnlUnderParcelDetails.Controls.Add(this.lblRegisteredDate);
            this.pnlUnderParcelDetails.Controls.Add(this.lblDeliveryService);
            this.pnlUnderParcelDetails.Controls.Add(this.lblWeight);
            this.pnlUnderParcelDetails.Controls.Add(this.lblRecipientName);
            this.pnlUnderParcelDetails.Controls.Add(this.lblSenderName);
            this.pnlUnderParcelDetails.Location = new System.Drawing.Point(942, 195);
            this.pnlUnderParcelDetails.Name = "pnlUnderParcelDetails";
            this.pnlUnderParcelDetails.Size = new System.Drawing.Size(758, 326);
            this.pnlUnderParcelDetails.TabIndex = 12;
            // 
            // lblRegisteredDateValue
            // 
            this.lblRegisteredDateValue.AutoSize = true;
            this.lblRegisteredDateValue.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegisteredDateValue.Location = new System.Drawing.Point(202, 280);
            this.lblRegisteredDateValue.Name = "lblRegisteredDateValue";
            this.lblRegisteredDateValue.Size = new System.Drawing.Size(20, 25);
            this.lblRegisteredDateValue.TabIndex = 9;
            this.lblRegisteredDateValue.Text = "-";
            // 
            // lblDeliveryServiceValue
            // 
            this.lblDeliveryServiceValue.AutoSize = true;
            this.lblDeliveryServiceValue.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeliveryServiceValue.Location = new System.Drawing.Point(202, 241);
            this.lblDeliveryServiceValue.Name = "lblDeliveryServiceValue";
            this.lblDeliveryServiceValue.Size = new System.Drawing.Size(20, 25);
            this.lblDeliveryServiceValue.TabIndex = 8;
            this.lblDeliveryServiceValue.Text = "-";
            // 
            // lblWeightValue
            // 
            this.lblWeightValue.AutoSize = true;
            this.lblWeightValue.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWeightValue.Location = new System.Drawing.Point(202, 201);
            this.lblWeightValue.Name = "lblWeightValue";
            this.lblWeightValue.Size = new System.Drawing.Size(20, 25);
            this.lblWeightValue.TabIndex = 7;
            this.lblWeightValue.Text = "-";
            // 
            // lblRecipientNameValue
            // 
            this.lblRecipientNameValue.AutoSize = true;
            this.lblRecipientNameValue.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecipientNameValue.Location = new System.Drawing.Point(202, 89);
            this.lblRecipientNameValue.Name = "lblRecipientNameValue";
            this.lblRecipientNameValue.Size = new System.Drawing.Size(20, 25);
            this.lblRecipientNameValue.TabIndex = 6;
            this.lblRecipientNameValue.Text = "-";
            // 
            // lblSenderNameValue
            // 
            this.lblSenderNameValue.AutoSize = true;
            this.lblSenderNameValue.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenderNameValue.Location = new System.Drawing.Point(202, 17);
            this.lblSenderNameValue.Name = "lblSenderNameValue";
            this.lblSenderNameValue.Size = new System.Drawing.Size(20, 25);
            this.lblSenderNameValue.TabIndex = 5;
            this.lblSenderNameValue.Text = "-";
            this.lblSenderNameValue.Click += new System.EventHandler(this.lblSenderNameValue_Click);
            // 
            // lblRegisteredDate
            // 
            this.lblRegisteredDate.AutoSize = true;
            this.lblRegisteredDate.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegisteredDate.Location = new System.Drawing.Point(12, 280);
            this.lblRegisteredDate.Name = "lblRegisteredDate";
            this.lblRegisteredDate.Size = new System.Drawing.Size(150, 25);
            this.lblRegisteredDate.TabIndex = 4;
            this.lblRegisteredDate.Text = "Registered Date";
            // 
            // lblDeliveryService
            // 
            this.lblDeliveryService.AutoSize = true;
            this.lblDeliveryService.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeliveryService.Location = new System.Drawing.Point(12, 241);
            this.lblDeliveryService.Name = "lblDeliveryService";
            this.lblDeliveryService.Size = new System.Drawing.Size(149, 25);
            this.lblDeliveryService.TabIndex = 3;
            this.lblDeliveryService.Text = "Delivery Service";
            // 
            // lblWeight
            // 
            this.lblWeight.AutoSize = true;
            this.lblWeight.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWeight.Location = new System.Drawing.Point(12, 201);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(112, 25);
            this.lblWeight.TabIndex = 2;
            this.lblWeight.Text = "Weight (kg)";
            // 
            // lblRecipientName
            // 
            this.lblRecipientName.AutoSize = true;
            this.lblRecipientName.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecipientName.Location = new System.Drawing.Point(13, 89);
            this.lblRecipientName.Name = "lblRecipientName";
            this.lblRecipientName.Size = new System.Drawing.Size(150, 25);
            this.lblRecipientName.TabIndex = 1;
            this.lblRecipientName.Text = "Recipient Name";
            // 
            // lblSenderName
            // 
            this.lblSenderName.AutoSize = true;
            this.lblSenderName.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenderName.Location = new System.Drawing.Point(13, 16);
            this.lblSenderName.Name = "lblSenderName";
            this.lblSenderName.Size = new System.Drawing.Size(129, 25);
            this.lblSenderName.TabIndex = 0;
            this.lblSenderName.Text = "Sender Name";
            // 
            // pnlStatusUpdateHistory
            // 
            this.pnlStatusUpdateHistory.BackColor = System.Drawing.Color.Crimson;
            this.pnlStatusUpdateHistory.Controls.Add(this.lblStatusUpdateHistory);
            this.pnlStatusUpdateHistory.Location = new System.Drawing.Point(942, 527);
            this.pnlStatusUpdateHistory.Name = "pnlStatusUpdateHistory";
            this.pnlStatusUpdateHistory.Size = new System.Drawing.Size(758, 88);
            this.pnlStatusUpdateHistory.TabIndex = 12;
            this.pnlStatusUpdateHistory.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlStatusUpdateHistory_Paint);
            // 
            // lblStatusUpdateHistory
            // 
            this.lblStatusUpdateHistory.AutoSize = true;
            this.lblStatusUpdateHistory.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatusUpdateHistory.ForeColor = System.Drawing.Color.White;
            this.lblStatusUpdateHistory.Location = new System.Drawing.Point(199, 18);
            this.lblStatusUpdateHistory.Name = "lblStatusUpdateHistory";
            this.lblStatusUpdateHistory.Size = new System.Drawing.Size(349, 45);
            this.lblStatusUpdateHistory.TabIndex = 5;
            this.lblStatusUpdateHistory.Text = "Status Update History";
            // 
            // pnlUnderStatusUpdateHistory
            // 
            this.pnlUnderStatusUpdateHistory.BackColor = System.Drawing.Color.Pink;
            this.pnlUnderStatusUpdateHistory.Controls.Add(this.dgvStatusUpdateHistory);
            this.pnlUnderStatusUpdateHistory.Location = new System.Drawing.Point(942, 593);
            this.pnlUnderStatusUpdateHistory.Name = "pnlUnderStatusUpdateHistory";
            this.pnlUnderStatusUpdateHistory.Size = new System.Drawing.Size(758, 230);
            this.pnlUnderStatusUpdateHistory.TabIndex = 13;
            // 
            // dgvStatusUpdateHistory
            // 
            this.dgvStatusUpdateHistory.AllowUserToAddRows = false;
            this.dgvStatusUpdateHistory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvStatusUpdateHistory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStatusUpdateHistory.BackgroundColor = System.Drawing.Color.White;
            this.dgvStatusUpdateHistory.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvStatusUpdateHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStatusUpdateHistory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colDateTime,
            this.dataGridViewTextBoxColumn1,
            this.colLocation,
            this.colDescription});
            this.dgvStatusUpdateHistory.Location = new System.Drawing.Point(18, 18);
            this.dgvStatusUpdateHistory.Name = "dgvStatusUpdateHistory";
            this.dgvStatusUpdateHistory.ReadOnly = true;
            this.dgvStatusUpdateHistory.RowHeadersVisible = false;
            this.dgvStatusUpdateHistory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStatusUpdateHistory.Size = new System.Drawing.Size(730, 198);
            this.dgvStatusUpdateHistory.TabIndex = 14;
            this.dgvStatusUpdateHistory.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTrackingHistory_CellContentClick);
            // 
            // colDateTime
            // 
            this.colDateTime.HeaderText = "Date & Time";
            this.colDateTime.Name = "colDateTime";
            this.colDateTime.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Status";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // colLocation
            // 
            this.colLocation.HeaderText = "Location";
            this.colLocation.Name = "colLocation";
            this.colLocation.ReadOnly = true;
            // 
            // colDescription
            // 
            this.colDescription.HeaderText = "Description";
            this.colDescription.Name = "colDescription";
            this.colDescription.ReadOnly = true;
            // 
            // lblRecipientAddress
            // 
            this.lblRecipientAddress.AutoSize = true;
            this.lblRecipientAddress.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecipientAddress.Location = new System.Drawing.Point(13, 126);
            this.lblRecipientAddress.Name = "lblRecipientAddress";
            this.lblRecipientAddress.Size = new System.Drawing.Size(165, 25);
            this.lblRecipientAddress.TabIndex = 10;
            this.lblRecipientAddress.Text = "Recipient Address";
            // 
            // lblSenderAddress
            // 
            this.lblSenderAddress.AutoSize = true;
            this.lblSenderAddress.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenderAddress.Location = new System.Drawing.Point(12, 54);
            this.lblSenderAddress.Name = "lblSenderAddress";
            this.lblSenderAddress.Size = new System.Drawing.Size(144, 25);
            this.lblSenderAddress.TabIndex = 11;
            this.lblSenderAddress.Text = "Sender Address";
            // 
            // lblCurrentLocation
            // 
            this.lblCurrentLocation.AutoSize = true;
            this.lblCurrentLocation.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentLocation.Location = new System.Drawing.Point(12, 162);
            this.lblCurrentLocation.Name = "lblCurrentLocation";
            this.lblCurrentLocation.Size = new System.Drawing.Size(161, 25);
            this.lblCurrentLocation.TabIndex = 12;
            this.lblCurrentLocation.Text = "Current  Location";
            // 
            // lblSenderAddressValue
            // 
            this.lblSenderAddressValue.AutoSize = true;
            this.lblSenderAddressValue.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenderAddressValue.Location = new System.Drawing.Point(202, 54);
            this.lblSenderAddressValue.Name = "lblSenderAddressValue";
            this.lblSenderAddressValue.Size = new System.Drawing.Size(20, 25);
            this.lblSenderAddressValue.TabIndex = 13;
            this.lblSenderAddressValue.Text = "-";
            // 
            // lblRecipientAddressValue
            // 
            this.lblRecipientAddressValue.AutoSize = true;
            this.lblRecipientAddressValue.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecipientAddressValue.Location = new System.Drawing.Point(202, 125);
            this.lblRecipientAddressValue.Name = "lblRecipientAddressValue";
            this.lblRecipientAddressValue.Size = new System.Drawing.Size(20, 25);
            this.lblRecipientAddressValue.TabIndex = 14;
            this.lblRecipientAddressValue.Text = "-";
            // 
            // lblCurrentLocationValue
            // 
            this.lblCurrentLocationValue.AutoSize = true;
            this.lblCurrentLocationValue.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentLocationValue.Location = new System.Drawing.Point(202, 162);
            this.lblCurrentLocationValue.Name = "lblCurrentLocationValue";
            this.lblCurrentLocationValue.Size = new System.Drawing.Size(20, 25);
            this.lblCurrentLocationValue.TabIndex = 15;
            this.lblCurrentLocationValue.Text = "-";
            // 
            // UpdateStatusForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(1744, 861);
            this.Controls.Add(this.pnlUnderStatusUpdateHistory);
            this.Controls.Add(this.pnlStatusUpdateHistory);
            this.Controls.Add(this.pnlUnderParcelDetails);
            this.Controls.Add(this.pnlParcelDetails);
            this.Controls.Add(this.pnlUnderUpdateParcelStatus);
            this.Controls.Add(this.pnlUpdateParcelStatus);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.pnlSideBar);
            this.MaximizeBox = false;
            this.Name = "UpdateStatusForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ParcelTrack - Update Parcel Status";
            this.Load += new System.EventHandler(this.UpdateStatusForm_Load);
            this.pnlHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlSideBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.pnlUpdateParcelStatus.ResumeLayout(false);
            this.pnlUpdateParcelStatus.PerformLayout();
            this.pnlUnderUpdateParcelStatus.ResumeLayout(false);
            this.pnlUnderUpdateParcelStatus.PerformLayout();
            this.pnlParcelDetails.ResumeLayout(false);
            this.pnlParcelDetails.PerformLayout();
            this.pnlUnderParcelDetails.ResumeLayout(false);
            this.pnlUnderParcelDetails.PerformLayout();
            this.pnlStatusUpdateHistory.ResumeLayout(false);
            this.pnlStatusUpdateHistory.PerformLayout();
            this.pnlUnderStatusUpdateHistory.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStatusUpdateHistory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pnlSideBar;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnD0ashBoard;
        private System.Windows.Forms.Panel pnlUpdateParcelStatus;
        private System.Windows.Forms.Panel pnlUnderUpdateParcelStatus;
        private System.Windows.Forms.Label lblUpdateParcelStatus;
        private System.Windows.Forms.TextBox txtCurrentStatus;
        private System.Windows.Forms.Label lblCurrentStatus;
        private System.Windows.Forms.TextBox txtTrackingNumber;
        private System.Windows.Forms.Label lblTrackingNumber;
        private System.Windows.Forms.Button btnSearchUpdate;
        private System.Windows.Forms.Label lblUpdateStatus;
        private System.Windows.Forms.Button btnUpdateStatus;
        private System.Windows.Forms.TextBox txtRemarks;
        private System.Windows.Forms.Label lblRemarks;
        private System.Windows.Forms.ComboBox cmbUpdateStatus;
        private System.Windows.Forms.Button btnClearUpdate;
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.Panel pnlParcelDetails;
        private System.Windows.Forms.Label lblParcelDetails;
        private System.Windows.Forms.Panel pnlUnderParcelDetails;
        private System.Windows.Forms.Label lblRegisteredDateValue;
        private System.Windows.Forms.Label lblDeliveryServiceValue;
        private System.Windows.Forms.Label lblWeightValue;
        private System.Windows.Forms.Label lblRecipientNameValue;
        private System.Windows.Forms.Label lblSenderNameValue;
        private System.Windows.Forms.Label lblRegisteredDate;
        private System.Windows.Forms.Label lblDeliveryService;
        private System.Windows.Forms.Label lblWeight;
        private System.Windows.Forms.Label lblRecipientName;
        private System.Windows.Forms.Label lblSenderName;
        private System.Windows.Forms.Panel pnlStatusUpdateHistory;
        private System.Windows.Forms.Label lblStatusUpdateHistory;
        private System.Windows.Forms.Panel pnlUnderStatusUpdateHistory;
        private System.Windows.Forms.DataGridView dgvStatusUpdateHistory;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDateTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLocation;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDescription;
        private System.Windows.Forms.Label lblCurrentLocationValue;
        private System.Windows.Forms.Label lblRecipientAddressValue;
        private System.Windows.Forms.Label lblSenderAddressValue;
        private System.Windows.Forms.Label lblCurrentLocation;
        private System.Windows.Forms.Label lblSenderAddress;
        private System.Windows.Forms.Label lblRecipientAddress;
    }
}