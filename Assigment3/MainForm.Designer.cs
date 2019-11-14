namespace Assigment3
{
    partial class MainForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtpricePerLiter = new System.Windows.Forms.TextBox();
            this.txtfuelAmount = new System.Windows.Forms.TextBox();
            this.txtprevRead = new System.Windows.Forms.TextBox();
            this.txtCurRead = new System.Windows.Forms.TextBox();
            this.btnCalculateFuel = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblcostPerKm = new System.Windows.Forms.Label();
            this.lbllitPerSweMil = new System.Windows.Forms.Label();
            this.lbllitPerMetMile = new System.Windows.Forms.Label();
            this.lbllitPerKm = new System.Windows.Forms.Label();
            this.lblkmPerLiter = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtpricePerLiter);
            this.groupBox1.Controls.Add(this.txtfuelAmount);
            this.groupBox1.Controls.Add(this.txtprevRead);
            this.groupBox1.Controls.Add(this.txtCurRead);
            this.groupBox1.Controls.Add(this.btnCalculateFuel);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(328, 187);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Fuel";
            // 
            // txtpricePerLiter
            // 
            this.txtpricePerLiter.Location = new System.Drawing.Point(222, 113);
            this.txtpricePerLiter.Name = "txtpricePerLiter";
            this.txtpricePerLiter.Size = new System.Drawing.Size(100, 20);
            this.txtpricePerLiter.TabIndex = 8;
            // 
            // txtfuelAmount
            // 
            this.txtfuelAmount.Location = new System.Drawing.Point(222, 81);
            this.txtfuelAmount.Name = "txtfuelAmount";
            this.txtfuelAmount.Size = new System.Drawing.Size(100, 20);
            this.txtfuelAmount.TabIndex = 7;
            // 
            // txtprevRead
            // 
            this.txtprevRead.Location = new System.Drawing.Point(222, 55);
            this.txtprevRead.Name = "txtprevRead";
            this.txtprevRead.Size = new System.Drawing.Size(100, 20);
            this.txtprevRead.TabIndex = 6;
            this.txtprevRead.Validated += new System.EventHandler(this.txtprevRead_Validated);
            // 
            // txtCurRead
            // 
            this.txtCurRead.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.txtCurRead.Location = new System.Drawing.Point(222, 29);
            this.txtCurRead.Name = "txtCurRead";
            this.txtCurRead.Size = new System.Drawing.Size(100, 20);
            this.txtCurRead.TabIndex = 5;
            this.txtCurRead.Validating += new System.ComponentModel.CancelEventHandler(this.txtCurRead_Validating);
            // 
            // btnCalculateFuel
            // 
            this.btnCalculateFuel.Location = new System.Drawing.Point(50, 147);
            this.btnCalculateFuel.Name = "btnCalculateFuel";
            this.btnCalculateFuel.Size = new System.Drawing.Size(114, 23);
            this.btnCalculateFuel.TabIndex = 4;
            this.btnCalculateFuel.Text = "Calculate";
            this.btnCalculateFuel.UseVisualStyleBackColor = true;
            this.btnCalculateFuel.Click += new System.EventHandler(this.btnCalculateFuel_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Price Per liter";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(175, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Amount of fuel tanked tankat(Liters)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Previous odometer reading (Km)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Current odometer reading (Km)";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblcostPerKm);
            this.groupBox2.Controls.Add(this.lbllitPerSweMil);
            this.groupBox2.Controls.Add(this.lbllitPerMetMile);
            this.groupBox2.Controls.Add(this.lbllitPerKm);
            this.groupBox2.Controls.Add(this.lblkmPerLiter);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(12, 206);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(329, 223);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Results";
            // 
            // lblcostPerKm
            // 
            this.lblcostPerKm.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblcostPerKm.Location = new System.Drawing.Point(223, 170);
            this.lblcostPerKm.Name = "lblcostPerKm";
            this.lblcostPerKm.Size = new System.Drawing.Size(100, 27);
            this.lblcostPerKm.TabIndex = 9;
            // 
            // lbllitPerSweMil
            // 
            this.lbllitPerSweMil.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbllitPerSweMil.Location = new System.Drawing.Point(223, 129);
            this.lbllitPerSweMil.Name = "lbllitPerSweMil";
            this.lbllitPerSweMil.Size = new System.Drawing.Size(100, 23);
            this.lbllitPerSweMil.TabIndex = 8;
            // 
            // lbllitPerMetMile
            // 
            this.lbllitPerMetMile.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbllitPerMetMile.Location = new System.Drawing.Point(223, 92);
            this.lbllitPerMetMile.Name = "lbllitPerMetMile";
            this.lbllitPerMetMile.Size = new System.Drawing.Size(100, 26);
            this.lbllitPerMetMile.TabIndex = 7;
            // 
            // lbllitPerKm
            // 
            this.lbllitPerKm.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbllitPerKm.Location = new System.Drawing.Point(223, 61);
            this.lbllitPerKm.Name = "lbllitPerKm";
            this.lbllitPerKm.Size = new System.Drawing.Size(100, 23);
            this.lbllitPerKm.TabIndex = 6;
            // 
            // lblkmPerLiter
            // 
            this.lblkmPerLiter.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblkmPerLiter.Location = new System.Drawing.Point(223, 32);
            this.lblkmPerLiter.Name = "lblkmPerLiter";
            this.lblkmPerLiter.Size = new System.Drawing.Size(100, 23);
            this.lblkmPerLiter.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 170);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "Cost per Kilometer";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 129);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(145, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Fuel Consumption(lit/Swe mil)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 92);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(158, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Fuel Consumption(lit/metric mile)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Fuel Consumption(lit/km)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Fuel Consumption(km/lit)";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 441);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnCalculateFuel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtpricePerLiter;
        private System.Windows.Forms.TextBox txtfuelAmount;
        private System.Windows.Forms.TextBox txtprevRead;
        private System.Windows.Forms.TextBox txtCurRead;
        private System.Windows.Forms.Label lblcostPerKm;
        private System.Windows.Forms.Label lbllitPerSweMil;
        private System.Windows.Forms.Label lbllitPerMetMile;
        private System.Windows.Forms.Label lbllitPerKm;
        private System.Windows.Forms.Label lblkmPerLiter;
    }
}

