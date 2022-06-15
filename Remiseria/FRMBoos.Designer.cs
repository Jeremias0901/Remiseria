namespace Remiseria
{
    partial class FRMBoos
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
            this.BTNFinish = new System.Windows.Forms.Button();
            this.BTNContinue = new System.Windows.Forms.Button();
            this.BTNPresentDrivers = new System.Windows.Forms.Button();
            this.BTNArrived = new System.Windows.Forms.Button();
            this.DGVDrivers = new System.Windows.Forms.DataGridView();
            this.DGVDriversLate = new System.Windows.Forms.DataGridView();
            this.LBLReloj = new System.Windows.Forms.Label();
            this.TMRReloj = new System.Windows.Forms.Timer(this.components);
            this.GRPDrivers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVDrivers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVDriversLate)).BeginInit();
            this.SuspendLayout();
            // 
            // GRPDrivers
            // 
            this.GRPDrivers.Controls.Add(this.BTNFinish);
            this.GRPDrivers.Controls.Add(this.BTNContinue);
            this.GRPDrivers.Controls.Add(this.BTNPresentDrivers);
            this.GRPDrivers.Controls.Add(this.BTNArrived);
            this.GRPDrivers.Controls.Add(this.DGVDrivers);
            this.GRPDrivers.Controls.Add(this.DGVDriversLate);
            this.GRPDrivers.Location = new System.Drawing.Point(12, 29);
            this.GRPDrivers.Name = "GRPDrivers";
            this.GRPDrivers.Size = new System.Drawing.Size(531, 432);
            this.GRPDrivers.TabIndex = 0;
            this.GRPDrivers.TabStop = false;
            this.GRPDrivers.Text = "Choferes";
            // 
            // BTNFinish
            // 
            this.BTNFinish.Location = new System.Drawing.Point(409, 401);
            this.BTNFinish.Name = "BTNFinish";
            this.BTNFinish.Size = new System.Drawing.Size(109, 20);
            this.BTNFinish.TabIndex = 2;
            this.BTNFinish.Text = "&Finalizar";
            this.BTNFinish.UseVisualStyleBackColor = true;
            this.BTNFinish.Click += new System.EventHandler(this.BTNFinish_Click);
            // 
            // BTNContinue
            // 
            this.BTNContinue.Location = new System.Drawing.Point(409, 244);
            this.BTNContinue.Name = "BTNContinue";
            this.BTNContinue.Size = new System.Drawing.Size(109, 20);
            this.BTNContinue.TabIndex = 2;
            this.BTNContinue.Text = "&Continuar";
            this.BTNContinue.UseVisualStyleBackColor = true;
            // 
            // BTNPresentDrivers
            // 
            this.BTNPresentDrivers.Location = new System.Drawing.Point(15, 218);
            this.BTNPresentDrivers.Name = "BTNPresentDrivers";
            this.BTNPresentDrivers.Size = new System.Drawing.Size(503, 20);
            this.BTNPresentDrivers.TabIndex = 1;
            this.BTNPresentDrivers.Text = "&Presente";
            this.BTNPresentDrivers.UseVisualStyleBackColor = true;
            // 
            // BTNArrived
            // 
            this.BTNArrived.Location = new System.Drawing.Point(15, 376);
            this.BTNArrived.Name = "BTNArrived";
            this.BTNArrived.Size = new System.Drawing.Size(503, 20);
            this.BTNArrived.TabIndex = 1;
            this.BTNArrived.Text = "&Llegó";
            this.BTNArrived.UseVisualStyleBackColor = true;
            // 
            // DGVDrivers
            // 
            this.DGVDrivers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVDrivers.Location = new System.Drawing.Point(15, 21);
            this.DGVDrivers.Name = "DGVDrivers";
            this.DGVDrivers.RowTemplate.Height = 25;
            this.DGVDrivers.Size = new System.Drawing.Size(503, 192);
            this.DGVDrivers.TabIndex = 0;
            // 
            // DGVDriversLate
            // 
            this.DGVDriversLate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVDriversLate.Location = new System.Drawing.Point(15, 269);
            this.DGVDriversLate.Name = "DGVDriversLate";
            this.DGVDriversLate.RowTemplate.Height = 25;
            this.DGVDriversLate.Size = new System.Drawing.Size(503, 101);
            this.DGVDriversLate.TabIndex = 0;
            // 
            // LBLReloj
            // 
            this.LBLReloj.AutoSize = true;
            this.LBLReloj.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LBLReloj.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.LBLReloj.Location = new System.Drawing.Point(248, 7);
            this.LBLReloj.Name = "LBLReloj";
            this.LBLReloj.Size = new System.Drawing.Size(82, 27);
            this.LBLReloj.TabIndex = 3;
            this.LBLReloj.Text = "00:00:00";
            // 
            // TMRReloj
            // 
            this.TMRReloj.Enabled = true;
            this.TMRReloj.Interval = 1000;
            this.TMRReloj.Tick += new System.EventHandler(this.TMRReloj_Tick);
            // 
            // FRMJefe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 465);
            this.Controls.Add(this.LBLReloj);
            this.Controls.Add(this.GRPDrivers);
            this.Name = "FRMJefe";
            this.Text = "FRMJefe";
            this.GRPDrivers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVDrivers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVDriversLate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox GRPDrivers;
        private System.Windows.Forms.Button BTNFinish;
        private System.Windows.Forms.Button BTNContinue;
        private System.Windows.Forms.Button BTNPresentDrivers;
        private System.Windows.Forms.Button BTNArrived;
        private System.Windows.Forms.DataGridView DGVDrivers;
        private System.Windows.Forms.DataGridView DGVDriversLate;
        private System.Windows.Forms.Label LBLReloj;
        private System.Windows.Forms.Timer TMRReloj;
    }
}