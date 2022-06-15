namespace Remiseria
{
    partial class FRMRecepcion
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.GRPAuthenticate = new System.Windows.Forms.GroupBox();
            this.LBLEstado = new System.Windows.Forms.Label();
            this.MTXCode = new System.Windows.Forms.MaskedTextBox();
            this.BTNGenerate = new System.Windows.Forms.Button();
            this.BTNFind = new System.Windows.Forms.Button();
            this.LBLCode = new System.Windows.Forms.Label();
            this.GRPCustomer = new System.Windows.Forms.GroupBox();
            this.NUDTelephone = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.DTPBirthDay = new System.Windows.Forms.DateTimePicker();
            this.LBLBirthDay = new System.Windows.Forms.Label();
            this.BTNRegister = new System.Windows.Forms.Button();
            this.LBLCode_Content = new System.Windows.Forms.Label();
            this.LBLCode_Tag = new System.Windows.Forms.Label();
            this.TXTSurname = new System.Windows.Forms.TextBox();
            this.LBLSurname = new System.Windows.Forms.Label();
            this.TXTName = new System.Windows.Forms.TextBox();
            this.LBLName = new System.Windows.Forms.Label();
            this.GRPTravel = new System.Windows.Forms.GroupBox();
            this.BTNOrderTravel = new System.Windows.Forms.Button();
            this.DTPDuration = new System.Windows.Forms.DateTimePicker();
            this.LBLDuration = new System.Windows.Forms.Label();
            this.LBLDelay_Content = new System.Windows.Forms.Label();
            this.LBLDelay_Tag = new System.Windows.Forms.Label();
            this.TXTDestiny = new System.Windows.Forms.TextBox();
            this.LBLDestiny = new System.Windows.Forms.Label();
            this.TXTDeparture = new System.Windows.Forms.TextBox();
            this.LBLDeparture = new System.Windows.Forms.Label();
            this.BTNViewCar = new System.Windows.Forms.Button();
            this.BTNCancelTravel = new System.Windows.Forms.Button();
            this.BTNArrived = new System.Windows.Forms.Button();
            this.DGVTravels = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.GRPAuthenticate.SuspendLayout();
            this.GRPCustomer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUDTelephone)).BeginInit();
            this.GRPTravel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVTravels)).BeginInit();
            this.SuspendLayout();
            // 
            // GRPAuthenticate
            // 
            this.GRPAuthenticate.Controls.Add(this.LBLEstado);
            this.GRPAuthenticate.Controls.Add(this.MTXCode);
            this.GRPAuthenticate.Controls.Add(this.BTNGenerate);
            this.GRPAuthenticate.Controls.Add(this.BTNFind);
            this.GRPAuthenticate.Controls.Add(this.LBLCode);
            this.GRPAuthenticate.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.GRPAuthenticate.Location = new System.Drawing.Point(12, 12);
            this.GRPAuthenticate.Name = "GRPAuthenticate";
            this.GRPAuthenticate.Size = new System.Drawing.Size(213, 112);
            this.GRPAuthenticate.TabIndex = 0;
            this.GRPAuthenticate.TabStop = false;
            this.GRPAuthenticate.Text = "Autenticar";
            // 
            // LBLEstado
            // 
            this.LBLEstado.AutoSize = true;
            this.LBLEstado.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.LBLEstado.Location = new System.Drawing.Point(56, 85);
            this.LBLEstado.Name = "LBLEstado";
            this.LBLEstado.Size = new System.Drawing.Size(51, 17);
            this.LBLEstado.TabIndex = 9;
            this.LBLEstado.Text = "Cliente";
            // 
            // MTXCode
            // 
            this.MTXCode.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.MTXCode.Location = new System.Drawing.Point(83, 26);
            this.MTXCode.Mask = "000000";
            this.MTXCode.Name = "MTXCode";
            this.MTXCode.Size = new System.Drawing.Size(100, 23);
            this.MTXCode.TabIndex = 8;
            this.MTXCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BTNGenerate
            // 
            this.BTNGenerate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BTNGenerate.Location = new System.Drawing.Point(108, 55);
            this.BTNGenerate.Name = "BTNGenerate";
            this.BTNGenerate.Size = new System.Drawing.Size(75, 23);
            this.BTNGenerate.TabIndex = 2;
            this.BTNGenerate.Text = "Generar";
            this.BTNGenerate.UseVisualStyleBackColor = true;
            this.BTNGenerate.Click += new System.EventHandler(this.BTNGenerate_Click);
            // 
            // BTNFind
            // 
            this.BTNFind.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BTNFind.Location = new System.Drawing.Point(27, 55);
            this.BTNFind.Name = "BTNFind";
            this.BTNFind.Size = new System.Drawing.Size(75, 23);
            this.BTNFind.TabIndex = 1;
            this.BTNFind.Text = "Buscar";
            this.BTNFind.UseVisualStyleBackColor = true;
            this.BTNFind.Click += new System.EventHandler(this.BTNFind_Click);
            // 
            // LBLCode
            // 
            this.LBLCode.AutoSize = true;
            this.LBLCode.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LBLCode.Location = new System.Drawing.Point(26, 29);
            this.LBLCode.Name = "LBLCode";
            this.LBLCode.Size = new System.Drawing.Size(46, 15);
            this.LBLCode.TabIndex = 0;
            this.LBLCode.Text = "Código";
            // 
            // GRPCustomer
            // 
            this.GRPCustomer.Controls.Add(this.NUDTelephone);
            this.GRPCustomer.Controls.Add(this.label1);
            this.GRPCustomer.Controls.Add(this.DTPBirthDay);
            this.GRPCustomer.Controls.Add(this.LBLBirthDay);
            this.GRPCustomer.Controls.Add(this.BTNRegister);
            this.GRPCustomer.Controls.Add(this.LBLCode_Content);
            this.GRPCustomer.Controls.Add(this.LBLCode_Tag);
            this.GRPCustomer.Controls.Add(this.TXTSurname);
            this.GRPCustomer.Controls.Add(this.LBLSurname);
            this.GRPCustomer.Controls.Add(this.TXTName);
            this.GRPCustomer.Controls.Add(this.LBLName);
            this.GRPCustomer.Enabled = false;
            this.GRPCustomer.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.GRPCustomer.Location = new System.Drawing.Point(12, 132);
            this.GRPCustomer.Name = "GRPCustomer";
            this.GRPCustomer.Size = new System.Drawing.Size(213, 220);
            this.GRPCustomer.TabIndex = 3;
            this.GRPCustomer.TabStop = false;
            this.GRPCustomer.Text = "Cliente";
            // 
            // NUDTelephone
            // 
            this.NUDTelephone.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.NUDTelephone.Location = new System.Drawing.Point(86, 128);
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
            this.NUDTelephone.Size = new System.Drawing.Size(100, 23);
            this.NUDTelephone.TabIndex = 11;
            this.NUDTelephone.Value = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label1.Location = new System.Drawing.Point(24, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "Telefono";
            // 
            // DTPBirthDay
            // 
            this.DTPBirthDay.CustomFormat = "dd/MM/yyyy";
            this.DTPBirthDay.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DTPBirthDay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DTPBirthDay.Location = new System.Drawing.Point(86, 95);
            this.DTPBirthDay.MaxDate = new System.DateTime(2060, 12, 31, 0, 0, 0, 0);
            this.DTPBirthDay.Name = "DTPBirthDay";
            this.DTPBirthDay.Size = new System.Drawing.Size(100, 23);
            this.DTPBirthDay.TabIndex = 9;
            this.DTPBirthDay.Value = new System.DateTime(2001, 1, 1, 0, 0, 0, 0);
            // 
            // LBLBirthDay
            // 
            this.LBLBirthDay.AutoSize = true;
            this.LBLBirthDay.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LBLBirthDay.Location = new System.Drawing.Point(6, 97);
            this.LBLBirthDay.Name = "LBLBirthDay";
            this.LBLBirthDay.Size = new System.Drawing.Size(74, 15);
            this.LBLBirthDay.TabIndex = 9;
            this.LBLBirthDay.Text = "Cumpleaños";
            // 
            // BTNRegister
            // 
            this.BTNRegister.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BTNRegister.Location = new System.Drawing.Point(63, 191);
            this.BTNRegister.Name = "BTNRegister";
            this.BTNRegister.Size = new System.Drawing.Size(75, 23);
            this.BTNRegister.TabIndex = 8;
            this.BTNRegister.Text = "Registrar";
            this.BTNRegister.UseVisualStyleBackColor = true;
            this.BTNRegister.Click += new System.EventHandler(this.BTNRegister_Click);
            // 
            // LBLCode_Content
            // 
            this.LBLCode_Content.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LBLCode_Content.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold);
            this.LBLCode_Content.Location = new System.Drawing.Point(86, 159);
            this.LBLCode_Content.Name = "LBLCode_Content";
            this.LBLCode_Content.Size = new System.Drawing.Size(100, 23);
            this.LBLCode_Content.TabIndex = 7;
            this.LBLCode_Content.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LBLCode_Tag
            // 
            this.LBLCode_Tag.AutoSize = true;
            this.LBLCode_Tag.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LBLCode_Tag.Location = new System.Drawing.Point(34, 159);
            this.LBLCode_Tag.Name = "LBLCode_Tag";
            this.LBLCode_Tag.Size = new System.Drawing.Size(46, 15);
            this.LBLCode_Tag.TabIndex = 6;
            this.LBLCode_Tag.Text = "Código";
            // 
            // TXTSurname
            // 
            this.TXTSurname.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TXTSurname.Location = new System.Drawing.Point(86, 62);
            this.TXTSurname.Name = "TXTSurname";
            this.TXTSurname.Size = new System.Drawing.Size(100, 23);
            this.TXTSurname.TabIndex = 3;
            // 
            // LBLSurname
            // 
            this.LBLSurname.AutoSize = true;
            this.LBLSurname.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LBLSurname.Location = new System.Drawing.Point(29, 65);
            this.LBLSurname.Name = "LBLSurname";
            this.LBLSurname.Size = new System.Drawing.Size(51, 15);
            this.LBLSurname.TabIndex = 2;
            this.LBLSurname.Text = "Apellido";
            // 
            // TXTName
            // 
            this.TXTName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TXTName.Location = new System.Drawing.Point(86, 33);
            this.TXTName.Name = "TXTName";
            this.TXTName.Size = new System.Drawing.Size(100, 23);
            this.TXTName.TabIndex = 1;
            // 
            // LBLName
            // 
            this.LBLName.AutoSize = true;
            this.LBLName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LBLName.Location = new System.Drawing.Point(29, 36);
            this.LBLName.Name = "LBLName";
            this.LBLName.Size = new System.Drawing.Size(51, 15);
            this.LBLName.TabIndex = 0;
            this.LBLName.Text = "Nombre";
            // 
            // GRPTravel
            // 
            this.GRPTravel.Controls.Add(this.BTNOrderTravel);
            this.GRPTravel.Controls.Add(this.DTPDuration);
            this.GRPTravel.Controls.Add(this.LBLDuration);
            this.GRPTravel.Controls.Add(this.LBLDelay_Content);
            this.GRPTravel.Controls.Add(this.LBLDelay_Tag);
            this.GRPTravel.Controls.Add(this.TXTDestiny);
            this.GRPTravel.Controls.Add(this.LBLDestiny);
            this.GRPTravel.Controls.Add(this.TXTDeparture);
            this.GRPTravel.Controls.Add(this.LBLDeparture);
            this.GRPTravel.Enabled = false;
            this.GRPTravel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.GRPTravel.Location = new System.Drawing.Point(12, 358);
            this.GRPTravel.Name = "GRPTravel";
            this.GRPTravel.Size = new System.Drawing.Size(213, 196);
            this.GRPTravel.TabIndex = 8;
            this.GRPTravel.TabStop = false;
            this.GRPTravel.Text = "Viaje";
            // 
            // BTNOrderTravel
            // 
            this.BTNOrderTravel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BTNOrderTravel.Location = new System.Drawing.Point(47, 125);
            this.BTNOrderTravel.Name = "BTNOrderTravel";
            this.BTNOrderTravel.Size = new System.Drawing.Size(107, 23);
            this.BTNOrderTravel.TabIndex = 11;
            this.BTNOrderTravel.Text = "Pedir";
            this.BTNOrderTravel.UseVisualStyleBackColor = true;
            this.BTNOrderTravel.Click += new System.EventHandler(this.BTNOrderTravel_Click);
            // 
            // DTPDuration
            // 
            this.DTPDuration.CustomFormat = "hh:mm";
            this.DTPDuration.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.DTPDuration.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.DTPDuration.Location = new System.Drawing.Point(121, 87);
            this.DTPDuration.Name = "DTPDuration";
            this.DTPDuration.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DTPDuration.ShowUpDown = true;
            this.DTPDuration.Size = new System.Drawing.Size(74, 25);
            this.DTPDuration.TabIndex = 10;
            this.DTPDuration.Value = new System.DateTime(2022, 1, 1, 0, 0, 0, 0);
            // 
            // LBLDuration
            // 
            this.LBLDuration.AutoSize = true;
            this.LBLDuration.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LBLDuration.Location = new System.Drawing.Point(6, 92);
            this.LBLDuration.Name = "LBLDuration";
            this.LBLDuration.Size = new System.Drawing.Size(109, 15);
            this.LBLDuration.TabIndex = 8;
            this.LBLDuration.Text = "Duración al destino";
            // 
            // LBLDelay_Content
            // 
            this.LBLDelay_Content.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold);
            this.LBLDelay_Content.Location = new System.Drawing.Point(58, 159);
            this.LBLDelay_Content.Name = "LBLDelay_Content";
            this.LBLDelay_Content.Size = new System.Drawing.Size(76, 23);
            this.LBLDelay_Content.TabIndex = 7;
            this.LBLDelay_Content.Text = "00:00:00";
            this.LBLDelay_Content.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LBLDelay_Tag
            // 
            this.LBLDelay_Tag.AutoSize = true;
            this.LBLDelay_Tag.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LBLDelay_Tag.Location = new System.Drawing.Point(8, 163);
            this.LBLDelay_Tag.Name = "LBLDelay_Tag";
            this.LBLDelay_Tag.Size = new System.Drawing.Size(49, 15);
            this.LBLDelay_Tag.TabIndex = 6;
            this.LBLDelay_Tag.Text = "Demora";
            // 
            // TXTDestiny
            // 
            this.TXTDestiny.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TXTDestiny.Location = new System.Drawing.Point(58, 57);
            this.TXTDestiny.Name = "TXTDestiny";
            this.TXTDestiny.Size = new System.Drawing.Size(146, 23);
            this.TXTDestiny.TabIndex = 3;
            // 
            // LBLDestiny
            // 
            this.LBLDestiny.AutoSize = true;
            this.LBLDestiny.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LBLDestiny.Location = new System.Drawing.Point(5, 60);
            this.LBLDestiny.Name = "LBLDestiny";
            this.LBLDestiny.Size = new System.Drawing.Size(47, 15);
            this.LBLDestiny.TabIndex = 2;
            this.LBLDestiny.Text = "Destino";
            // 
            // TXTDeparture
            // 
            this.TXTDeparture.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TXTDeparture.Location = new System.Drawing.Point(58, 28);
            this.TXTDeparture.Name = "TXTDeparture";
            this.TXTDeparture.Size = new System.Drawing.Size(146, 23);
            this.TXTDeparture.TabIndex = 1;
            // 
            // LBLDeparture
            // 
            this.LBLDeparture.AutoSize = true;
            this.LBLDeparture.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LBLDeparture.Location = new System.Drawing.Point(8, 31);
            this.LBLDeparture.Name = "LBLDeparture";
            this.LBLDeparture.Size = new System.Drawing.Size(44, 15);
            this.LBLDeparture.TabIndex = 0;
            this.LBLDeparture.Text = "Partida";
            // 
            // BTNViewCar
            // 
            this.BTNViewCar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BTNViewCar.Location = new System.Drawing.Point(259, 360);
            this.BTNViewCar.Name = "BTNViewCar";
            this.BTNViewCar.Size = new System.Drawing.Size(137, 23);
            this.BTNViewCar.TabIndex = 10;
            this.BTNViewCar.Text = "VER AUTO";
            this.BTNViewCar.UseVisualStyleBackColor = true;
            this.BTNViewCar.Click += new System.EventHandler(this.BTNViewCar_Click);
            // 
            // BTNCancelTravel
            // 
            this.BTNCancelTravel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BTNCancelTravel.Location = new System.Drawing.Point(413, 360);
            this.BTNCancelTravel.Name = "BTNCancelTravel";
            this.BTNCancelTravel.Size = new System.Drawing.Size(137, 23);
            this.BTNCancelTravel.TabIndex = 12;
            this.BTNCancelTravel.Text = "CANCELAR";
            this.BTNCancelTravel.UseVisualStyleBackColor = true;
            this.BTNCancelTravel.Click += new System.EventHandler(this.BTNCancelTravel_Click);
            // 
            // BTNArrived
            // 
            this.BTNArrived.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BTNArrived.Location = new System.Drawing.Point(566, 360);
            this.BTNArrived.Name = "BTNArrived";
            this.BTNArrived.Size = new System.Drawing.Size(137, 23);
            this.BTNArrived.TabIndex = 13;
            this.BTNArrived.Text = "LLEGO AL DESTINO";
            this.BTNArrived.UseVisualStyleBackColor = true;
            this.BTNArrived.Click += new System.EventHandler(this.BTNArrived_Click);
            // 
            // DGVTravels
            // 
            this.DGVTravels.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVTravels.Location = new System.Drawing.Point(247, 78);
            this.DGVTravels.Name = "DGVTravels";
            this.DGVTravels.Size = new System.Drawing.Size(469, 276);
            this.DGVTravels.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(243, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 24);
            this.label2.TabIndex = 15;
            this.label2.Text = "Viajes";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(243, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(469, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "──────────────────────────────────────────────────";
            // 
            // FRMRecepcion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 570);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BTNCancelTravel);
            this.Controls.Add(this.BTNViewCar);
            this.Controls.Add(this.DGVTravels);
            this.Controls.Add(this.BTNArrived);
            this.Controls.Add(this.GRPTravel);
            this.Controls.Add(this.GRPCustomer);
            this.Controls.Add(this.GRPAuthenticate);
            this.Name = "FRMRecepcion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Recepcion";
            this.Load += new System.EventHandler(this.FRMRecepcion_Load);
            this.GRPAuthenticate.ResumeLayout(false);
            this.GRPAuthenticate.PerformLayout();
            this.GRPCustomer.ResumeLayout(false);
            this.GRPCustomer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUDTelephone)).EndInit();
            this.GRPTravel.ResumeLayout(false);
            this.GRPTravel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVTravels)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox GRPAuthenticate;
        private System.Windows.Forms.Button BTNGenerate;
        private System.Windows.Forms.Button BTNFind;
        private System.Windows.Forms.Label LBLCode;
        private System.Windows.Forms.GroupBox GRPCustomer;
        private System.Windows.Forms.Label LBLCode_Content;
        private System.Windows.Forms.Label LBLCode_Tag;
        private System.Windows.Forms.TextBox TXTSurname;
        private System.Windows.Forms.Label LBLSurname;
        private System.Windows.Forms.TextBox TXTName;
        private System.Windows.Forms.Label LBLName;
        private System.Windows.Forms.GroupBox GRPTravel;
        private System.Windows.Forms.Label LBLDelay_Content;
        private System.Windows.Forms.Label LBLDelay_Tag;
        private System.Windows.Forms.TextBox TXTDestiny;
        private System.Windows.Forms.Label LBLDestiny;
        private System.Windows.Forms.TextBox TXTDeparture;
        private System.Windows.Forms.Label LBLDeparture;
        private System.Windows.Forms.MaskedTextBox MTXCode;
        private System.Windows.Forms.Button BTNRegister;
        private System.Windows.Forms.Label LBLDuration;
        private System.Windows.Forms.Label LBLEstado;
        private System.Windows.Forms.Button BTNViewCar;
        private System.Windows.Forms.Label LBLBirthDay;
        private System.Windows.Forms.DateTimePicker DTPBirthDay;
        private System.Windows.Forms.DateTimePicker DTPDuration;
        private System.Windows.Forms.Button BTNCancelTravel;
        private System.Windows.Forms.Button BTNOrderTravel;
        private System.Windows.Forms.Button BTNArrived;
        private System.Windows.Forms.DataGridView DGVTravels;
        private System.Windows.Forms.NumericUpDown NUDTelephone;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

