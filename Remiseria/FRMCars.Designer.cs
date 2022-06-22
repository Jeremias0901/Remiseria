
namespace Remiseria
{
    partial class FRMCars
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
            this.GRPAssignment = new System.Windows.Forms.GroupBox();
            this.LBLCar = new System.Windows.Forms.Label();
            this.LBLDriver = new System.Windows.Forms.Label();
            this.CMBCar = new System.Windows.Forms.ComboBox();
            this.CMBDriver = new System.Windows.Forms.ComboBox();
            this.BTNAssignment = new System.Windows.Forms.Button();
            this.GRPAddCar = new System.Windows.Forms.GroupBox();
            this.MTXPatent = new System.Windows.Forms.MaskedTextBox();
            this.BTNAdd = new System.Windows.Forms.Button();
            this.LBLPatent = new System.Windows.Forms.Label();
            this.TXTColor = new System.Windows.Forms.TextBox();
            this.LBLColor = new System.Windows.Forms.Label();
            this.TXTBland = new System.Windows.Forms.TextBox();
            this.LBLBland = new System.Windows.Forms.Label();
            this.TXTModel = new System.Windows.Forms.TextBox();
            this.LBLModel = new System.Windows.Forms.Label();
            this.BTNEnd = new System.Windows.Forms.Button();
            this.GRPAssignment.SuspendLayout();
            this.GRPAddCar.SuspendLayout();
            this.SuspendLayout();
            // 
            // GRPAssignment
            // 
            this.GRPAssignment.Controls.Add(this.LBLCar);
            this.GRPAssignment.Controls.Add(this.LBLDriver);
            this.GRPAssignment.Controls.Add(this.CMBCar);
            this.GRPAssignment.Controls.Add(this.CMBDriver);
            this.GRPAssignment.Controls.Add(this.BTNAssignment);
            this.GRPAssignment.Location = new System.Drawing.Point(12, 12);
            this.GRPAssignment.Name = "GRPAssignment";
            this.GRPAssignment.Size = new System.Drawing.Size(344, 119);
            this.GRPAssignment.TabIndex = 0;
            this.GRPAssignment.TabStop = false;
            this.GRPAssignment.Text = "Asignacion de Autos";
            // 
            // LBLCar
            // 
            this.LBLCar.AutoSize = true;
            this.LBLCar.Location = new System.Drawing.Point(250, 31);
            this.LBLCar.Name = "LBLCar";
            this.LBLCar.Size = new System.Drawing.Size(29, 13);
            this.LBLCar.TabIndex = 11;
            this.LBLCar.Text = "Auto";
            // 
            // LBLDriver
            // 
            this.LBLDriver.AutoSize = true;
            this.LBLDriver.Location = new System.Drawing.Point(51, 31);
            this.LBLDriver.Name = "LBLDriver";
            this.LBLDriver.Size = new System.Drawing.Size(38, 13);
            this.LBLDriver.TabIndex = 10;
            this.LBLDriver.Text = "Chofer";
            // 
            // CMBCar
            // 
            this.CMBCar.FormattingEnabled = true;
            this.CMBCar.Location = new System.Drawing.Point(205, 52);
            this.CMBCar.Name = "CMBCar";
            this.CMBCar.Size = new System.Drawing.Size(121, 21);
            this.CMBCar.TabIndex = 12;
            // 
            // CMBDriver
            // 
            this.CMBDriver.FormattingEnabled = true;
            this.CMBDriver.Location = new System.Drawing.Point(20, 52);
            this.CMBDriver.Name = "CMBDriver";
            this.CMBDriver.Size = new System.Drawing.Size(121, 21);
            this.CMBDriver.TabIndex = 11;
            // 
            // BTNAssignment
            // 
            this.BTNAssignment.Location = new System.Drawing.Point(135, 84);
            this.BTNAssignment.Name = "BTNAssignment";
            this.BTNAssignment.Size = new System.Drawing.Size(75, 23);
            this.BTNAssignment.TabIndex = 10;
            this.BTNAssignment.Text = "Asignar";
            this.BTNAssignment.UseVisualStyleBackColor = true;
            this.BTNAssignment.Click += new System.EventHandler(this.BTNAssignment_Click);
            // 
            // GRPAddCar
            // 
            this.GRPAddCar.Controls.Add(this.MTXPatent);
            this.GRPAddCar.Controls.Add(this.BTNAdd);
            this.GRPAddCar.Controls.Add(this.LBLPatent);
            this.GRPAddCar.Controls.Add(this.TXTColor);
            this.GRPAddCar.Controls.Add(this.LBLColor);
            this.GRPAddCar.Controls.Add(this.TXTBland);
            this.GRPAddCar.Controls.Add(this.LBLBland);
            this.GRPAddCar.Controls.Add(this.TXTModel);
            this.GRPAddCar.Controls.Add(this.LBLModel);
            this.GRPAddCar.Location = new System.Drawing.Point(12, 137);
            this.GRPAddCar.Name = "GRPAddCar";
            this.GRPAddCar.Size = new System.Drawing.Size(344, 115);
            this.GRPAddCar.TabIndex = 1;
            this.GRPAddCar.TabStop = false;
            this.GRPAddCar.Text = "Agregar Auto";
            // 
            // MTXPatent
            // 
            this.MTXPatent.Location = new System.Drawing.Point(226, 50);
            this.MTXPatent.Mask = "AAA-000";
            this.MTXPatent.Name = "MTXPatent";
            this.MTXPatent.Size = new System.Drawing.Size(100, 20);
            this.MTXPatent.TabIndex = 9;
            this.MTXPatent.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BTNAdd
            // 
            this.BTNAdd.Location = new System.Drawing.Point(135, 80);
            this.BTNAdd.Name = "BTNAdd";
            this.BTNAdd.Size = new System.Drawing.Size(75, 23);
            this.BTNAdd.TabIndex = 8;
            this.BTNAdd.Text = "Agregar";
            this.BTNAdd.UseVisualStyleBackColor = true;
            this.BTNAdd.Click += new System.EventHandler(this.BTNAdd_Click);
            // 
            // LBLPatent
            // 
            this.LBLPatent.AutoSize = true;
            this.LBLPatent.Location = new System.Drawing.Point(176, 53);
            this.LBLPatent.Name = "LBLPatent";
            this.LBLPatent.Size = new System.Drawing.Size(44, 13);
            this.LBLPatent.TabIndex = 6;
            this.LBLPatent.Text = "Patente";
            // 
            // TXTColor
            // 
            this.TXTColor.Location = new System.Drawing.Point(226, 24);
            this.TXTColor.Name = "TXTColor";
            this.TXTColor.Size = new System.Drawing.Size(100, 20);
            this.TXTColor.TabIndex = 5;
            // 
            // LBLColor
            // 
            this.LBLColor.AutoSize = true;
            this.LBLColor.Location = new System.Drawing.Point(189, 27);
            this.LBLColor.Name = "LBLColor";
            this.LBLColor.Size = new System.Drawing.Size(31, 13);
            this.LBLColor.TabIndex = 4;
            this.LBLColor.Text = "Color";
            // 
            // TXTBland
            // 
            this.TXTBland.Location = new System.Drawing.Point(63, 50);
            this.TXTBland.Name = "TXTBland";
            this.TXTBland.Size = new System.Drawing.Size(100, 20);
            this.TXTBland.TabIndex = 3;
            // 
            // LBLBland
            // 
            this.LBLBland.AutoSize = true;
            this.LBLBland.Location = new System.Drawing.Point(17, 53);
            this.LBLBland.Name = "LBLBland";
            this.LBLBland.Size = new System.Drawing.Size(37, 13);
            this.LBLBland.TabIndex = 2;
            this.LBLBland.Text = "Marca";
            // 
            // TXTModel
            // 
            this.TXTModel.Location = new System.Drawing.Point(63, 24);
            this.TXTModel.Name = "TXTModel";
            this.TXTModel.Size = new System.Drawing.Size(100, 20);
            this.TXTModel.TabIndex = 1;
            // 
            // LBLModel
            // 
            this.LBLModel.AutoSize = true;
            this.LBLModel.Location = new System.Drawing.Point(17, 27);
            this.LBLModel.Name = "LBLModel";
            this.LBLModel.Size = new System.Drawing.Size(42, 13);
            this.LBLModel.TabIndex = 0;
            this.LBLModel.Text = "Modelo";
            // 
            // BTNEnd
            // 
            this.BTNEnd.Location = new System.Drawing.Point(100, 263);
            this.BTNEnd.Name = "BTNEnd";
            this.BTNEnd.Size = new System.Drawing.Size(162, 23);
            this.BTNEnd.TabIndex = 13;
            this.BTNEnd.Text = "Finalizar y Abrir Recepcion";
            this.BTNEnd.UseVisualStyleBackColor = true;
            this.BTNEnd.Click += new System.EventHandler(this.BTNEnd_Click);
            // 
            // FRMCars
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 298);
            this.Controls.Add(this.BTNEnd);
            this.Controls.Add(this.GRPAddCar);
            this.Controls.Add(this.GRPAssignment);
            this.Name = "FRMCars";
            this.Text = "Cars";
            this.Load += new System.EventHandler(this.FRMCars_Load);
            this.GRPAssignment.ResumeLayout(false);
            this.GRPAssignment.PerformLayout();
            this.GRPAddCar.ResumeLayout(false);
            this.GRPAddCar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GRPAssignment;
        private System.Windows.Forms.GroupBox GRPAddCar;
        private System.Windows.Forms.TextBox TXTBland;
        private System.Windows.Forms.Label LBLBland;
        private System.Windows.Forms.TextBox TXTModel;
        private System.Windows.Forms.Label LBLModel;
        private System.Windows.Forms.Button BTNAdd;
        private System.Windows.Forms.Label LBLPatent;
        private System.Windows.Forms.TextBox TXTColor;
        private System.Windows.Forms.Label LBLColor;
        private System.Windows.Forms.Label LBLCar;
        private System.Windows.Forms.Label LBLDriver;
        private System.Windows.Forms.ComboBox CMBCar;
        private System.Windows.Forms.ComboBox CMBDriver;
        private System.Windows.Forms.Button BTNAssignment;
        private System.Windows.Forms.MaskedTextBox MTXPatent;
        private System.Windows.Forms.Button BTNEnd;
    }
}