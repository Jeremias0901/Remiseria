namespace Remiseria
{
    partial class FRMBoss
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
            this.components = new System.ComponentModel.Container();
            this.GRPDrivers = new System.Windows.Forms.GroupBox();
            this.DGVDrivers = new System.Windows.Forms.DataGridView();
            this.BTNFinish = new System.Windows.Forms.Button();
            this.BTNContinue = new System.Windows.Forms.Button();
            this.BTNPresentDrivers = new System.Windows.Forms.Button();
            this.BTNArrived = new System.Windows.Forms.Button();
            this.DGVDriversLate = new System.Windows.Forms.DataGridView();
            this.LBLReloj = new System.Windows.Forms.Label();
            this.TMRReloj = new System.Windows.Forms.Timer(this.components);
            this.GRPAddDriver = new System.Windows.Forms.GroupBox();
            this.NUDTelephone = new System.Windows.Forms.NumericUpDown();
            this.BTNAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TXTSurname = new System.Windows.Forms.TextBox();
            this.DTPBirthDay = new System.Windows.Forms.DateTimePicker();
            this.LBLBirthDay = new System.Windows.Forms.Label();
            this.LBLSurname = new System.Windows.Forms.Label();
            this.TXTName = new System.Windows.Forms.TextBox();
            this.LBLName = new System.Windows.Forms.Label();
            this.GRPDrivers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVDrivers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVDriversLate)).BeginInit();
            this.GRPAddDriver.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUDTelephone)).BeginInit();
            this.SuspendLayout();
            // 
            // GRPDrivers
            // 
            this.GRPDrivers.Controls.Add(this.DGVDrivers);
            this.GRPDrivers.Controls.Add(this.BTNFinish);
            this.GRPDrivers.Controls.Add(this.BTNContinue);
            this.GRPDrivers.Controls.Add(this.BTNPresentDrivers);
            this.GRPDrivers.Controls.Add(this.BTNArrived);
            this.GRPDrivers.Controls.Add(this.DGVDriversLate);
            this.GRPDrivers.Location = new System.Drawing.Point(12, 7);
            this.GRPDrivers.Name = "GRPDrivers";
            this.GRPDrivers.Size = new System.Drawing.Size(535, 492);
            this.GRPDrivers.TabIndex = 0;
            this.GRPDrivers.TabStop = false;
            this.GRPDrivers.Text = "Choferes";
            // 
            // DGVDrivers
            // 
            this.DGVDrivers.AllowDrop = true;
            this.DGVDrivers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVDrivers.Location = new System.Drawing.Point(15, 29);
            this.DGVDrivers.Name = "DGVDrivers";
            this.DGVDrivers.ReadOnly = true;
            this.DGVDrivers.RowTemplate.ReadOnly = true;
            this.DGVDrivers.Size = new System.Drawing.Size(503, 213);
            this.DGVDrivers.TabIndex = 0;
            // 
            // BTNFinish
            // 
            this.BTNFinish.Enabled = false;
            this.BTNFinish.Location = new System.Drawing.Point(409, 460);
            this.BTNFinish.Name = "BTNFinish";
            this.BTNFinish.Size = new System.Drawing.Size(109, 26);
            this.BTNFinish.TabIndex = 2;
            this.BTNFinish.Text = "&Finalizar";
            this.BTNFinish.UseVisualStyleBackColor = true;
            this.BTNFinish.Click += new System.EventHandler(this.BTNFinish_Click);
            // 
            // BTNContinue
            // 
            this.BTNContinue.Location = new System.Drawing.Point(409, 248);
            this.BTNContinue.Name = "BTNContinue";
            this.BTNContinue.Size = new System.Drawing.Size(109, 28);
            this.BTNContinue.TabIndex = 2;
            this.BTNContinue.Text = "&Continuar";
            this.BTNContinue.UseVisualStyleBackColor = true;
            this.BTNContinue.Click += new System.EventHandler(this.BTNContinue_Click);
            // 
            // BTNPresentDrivers
            // 
            this.BTNPresentDrivers.Location = new System.Drawing.Point(15, 248);
            this.BTNPresentDrivers.Name = "BTNPresentDrivers";
            this.BTNPresentDrivers.Size = new System.Drawing.Size(384, 28);
            this.BTNPresentDrivers.TabIndex = 1;
            this.BTNPresentDrivers.Text = "&Presente";
            this.BTNPresentDrivers.UseVisualStyleBackColor = true;
            this.BTNPresentDrivers.Click += new System.EventHandler(this.BTNPresentDrivers_Click);
            // 
            // BTNArrived
            // 
            this.BTNArrived.Enabled = false;
            this.BTNArrived.Location = new System.Drawing.Point(15, 459);
            this.BTNArrived.Name = "BTNArrived";
            this.BTNArrived.Size = new System.Drawing.Size(384, 27);
            this.BTNArrived.TabIndex = 1;
            this.BTNArrived.Text = "&Llegó";
            this.BTNArrived.UseVisualStyleBackColor = true;
            this.BTNArrived.Click += new System.EventHandler(this.BTNArrived_Click);
            // 
            // DGVDriversLate
            // 
            this.DGVDriversLate.AllowDrop = true;
            this.DGVDriversLate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVDriversLate.Enabled = false;
            this.DGVDriversLate.Location = new System.Drawing.Point(15, 282);
            this.DGVDriversLate.Name = "DGVDriversLate";
            this.DGVDriversLate.ReadOnly = true;
            this.DGVDriversLate.RowTemplate.Height = 25;
            this.DGVDriversLate.Size = new System.Drawing.Size(503, 171);
            this.DGVDriversLate.TabIndex = 0;
            // 
            // LBLReloj
            // 
            this.LBLReloj.AutoSize = true;
            this.LBLReloj.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LBLReloj.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.LBLReloj.Location = new System.Drawing.Point(567, 15);
            this.LBLReloj.Name = "LBLReloj";
            this.LBLReloj.Size = new System.Drawing.Size(191, 27);
            this.LBLReloj.TabIndex = 3;
            this.LBLReloj.Text = "01/01/0001   00:00:00";
            // 
            // TMRReloj
            // 
            this.TMRReloj.Enabled = true;
            this.TMRReloj.Interval = 1000;
            this.TMRReloj.Tick += new System.EventHandler(this.TMRReloj_Tick);
            // 
            // GRPAddDriver
            // 
            this.GRPAddDriver.Controls.Add(this.NUDTelephone);
            this.GRPAddDriver.Controls.Add(this.BTNAdd);
            this.GRPAddDriver.Controls.Add(this.label1);
            this.GRPAddDriver.Controls.Add(this.TXTSurname);
            this.GRPAddDriver.Controls.Add(this.DTPBirthDay);
            this.GRPAddDriver.Controls.Add(this.LBLBirthDay);
            this.GRPAddDriver.Controls.Add(this.LBLSurname);
            this.GRPAddDriver.Controls.Add(this.TXTName);
            this.GRPAddDriver.Controls.Add(this.LBLName);
            this.GRPAddDriver.Location = new System.Drawing.Point(562, 56);
            this.GRPAddDriver.Name = "GRPAddDriver";
            this.GRPAddDriver.Size = new System.Drawing.Size(199, 170);
            this.GRPAddDriver.TabIndex = 4;
            this.GRPAddDriver.TabStop = false;
            this.GRPAddDriver.Text = "Agregar Chofer";
            // 
            // NUDTelephone
            // 
            this.NUDTelephone.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.NUDTelephone.Location = new System.Drawing.Point(89, 103);
            this.NUDTelephone.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.NUDTelephone.Minimum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.NUDTelephone.Name = "NUDTelephone";
            this.NUDTelephone.Size = new System.Drawing.Size(100, 20);
            this.NUDTelephone.TabIndex = 12;
            this.NUDTelephone.Value = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            // 
            // BTNAdd
            // 
            this.BTNAdd.Location = new System.Drawing.Point(62, 136);
            this.BTNAdd.Name = "BTNAdd";
            this.BTNAdd.Size = new System.Drawing.Size(75, 23);
            this.BTNAdd.TabIndex = 8;
            this.BTNAdd.Text = "Agregar";
            this.BTNAdd.UseVisualStyleBackColor = true;
            this.BTNAdd.Click += new System.EventHandler(this.BTNAdd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label1.Location = new System.Drawing.Point(31, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Telefono";
            // 
            // TXTSurname
            // 
            this.TXTSurname.Location = new System.Drawing.Point(89, 48);
            this.TXTSurname.Name = "TXTSurname";
            this.TXTSurname.Size = new System.Drawing.Size(100, 20);
            this.TXTSurname.TabIndex = 3;
            // 
            // DTPBirthDay
            // 
            this.DTPBirthDay.CustomFormat = "dd/MM/yyyy";
            this.DTPBirthDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.DTPBirthDay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DTPBirthDay.Location = new System.Drawing.Point(89, 74);
            this.DTPBirthDay.MaxDate = new System.DateTime(2060, 12, 31, 0, 0, 0, 0);
            this.DTPBirthDay.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.DTPBirthDay.Name = "DTPBirthDay";
            this.DTPBirthDay.Size = new System.Drawing.Size(100, 20);
            this.DTPBirthDay.TabIndex = 11;
            this.DTPBirthDay.Value = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            // 
            // LBLBirthDay
            // 
            this.LBLBirthDay.AutoSize = true;
            this.LBLBirthDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.LBLBirthDay.Location = new System.Drawing.Point(9, 76);
            this.LBLBirthDay.Name = "LBLBirthDay";
            this.LBLBirthDay.Size = new System.Drawing.Size(65, 13);
            this.LBLBirthDay.TabIndex = 13;
            this.LBLBirthDay.Text = "Cumpleaños";
            // 
            // LBLSurname
            // 
            this.LBLSurname.AutoSize = true;
            this.LBLSurname.Location = new System.Drawing.Point(43, 51);
            this.LBLSurname.Name = "LBLSurname";
            this.LBLSurname.Size = new System.Drawing.Size(44, 13);
            this.LBLSurname.TabIndex = 2;
            this.LBLSurname.Text = "Apellido";
            // 
            // TXTName
            // 
            this.TXTName.Location = new System.Drawing.Point(89, 22);
            this.TXTName.Name = "TXTName";
            this.TXTName.Size = new System.Drawing.Size(100, 20);
            this.TXTName.TabIndex = 1;
            // 
            // LBLName
            // 
            this.LBLName.AutoSize = true;
            this.LBLName.Location = new System.Drawing.Point(43, 25);
            this.LBLName.Name = "LBLName";
            this.LBLName.Size = new System.Drawing.Size(44, 13);
            this.LBLName.TabIndex = 0;
            this.LBLName.Text = "Nombre";
            // 
            // FRMBoss
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 511);
            this.Controls.Add(this.GRPAddDriver);
            this.Controls.Add(this.LBLReloj);
            this.Controls.Add(this.GRPDrivers);
            this.Name = "FRMBoss";
            this.Text = "Jefe";
            this.Load += new System.EventHandler(this.FRMBoos_Load);
            this.GRPDrivers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVDrivers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVDriversLate)).EndInit();
            this.GRPAddDriver.ResumeLayout(false);
            this.GRPAddDriver.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUDTelephone)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox GRPDrivers;
        private System.Windows.Forms.Button BTNFinish;
        private System.Windows.Forms.Button BTNContinue;
        private System.Windows.Forms.Button BTNPresentDrivers;
        private System.Windows.Forms.Button BTNArrived;
        private System.Windows.Forms.DataGridView DGVDriversLate;
        private System.Windows.Forms.Label LBLReloj;
        private System.Windows.Forms.Timer TMRReloj;
        private System.Windows.Forms.GroupBox GRPAddDriver;
        private System.Windows.Forms.Button BTNAdd;
        private System.Windows.Forms.TextBox TXTSurname;
        private System.Windows.Forms.Label LBLSurname;
        private System.Windows.Forms.TextBox TXTName;
        private System.Windows.Forms.Label LBLName;
        private System.Windows.Forms.NumericUpDown NUDTelephone;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker DTPBirthDay;
        private System.Windows.Forms.Label LBLBirthDay;
        private System.Windows.Forms.DataGridView DGVDrivers;
    }
}