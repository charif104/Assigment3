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
            this.pricePerLiter = new System.Windows.Forms.TextBox();
            this.fuelAmount = new System.Windows.Forms.TextBox();
            this.prevRead = new System.Windows.Forms.TextBox();
            this.CurRead = new System.Windows.Forms.TextBox();
            this.calFuel = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.costPerKm = new System.Windows.Forms.Label();
            this.litPerSweMil = new System.Windows.Forms.Label();
            this.litPerMetMile = new System.Windows.Forms.Label();
            this.litPerKm = new System.Windows.Forms.Label();
            this.kmPerLiter = new System.Windows.Forms.Label();
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
            this.groupBox1.Controls.Add(this.pricePerLiter);
            this.groupBox1.Controls.Add(this.fuelAmount);
            this.groupBox1.Controls.Add(this.prevRead);
            this.groupBox1.Controls.Add(this.CurRead);
            this.groupBox1.Controls.Add(this.calFuel);
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
            // pricePerLiter
            // 
            this.pricePerLiter.Location = new System.Drawing.Point(222, 113);
            this.pricePerLiter.Name = "pricePerLiter";
            this.pricePerLiter.Size = new System.Drawing.Size(100, 20);
            this.pricePerLiter.TabIndex = 8;
            // 
            // fuelAmount
            // 
            this.fuelAmount.Location = new System.Drawing.Point(222, 81);
            this.fuelAmount.Name = "fuelAmount";
            this.fuelAmount.Size = new System.Drawing.Size(100, 20);
            this.fuelAmount.TabIndex = 7;
            // 
            // prevRead
            // 
            this.prevRead.Location = new System.Drawing.Point(222, 55);
            this.prevRead.Name = "prevRead";
            this.prevRead.Size = new System.Drawing.Size(100, 20);
            this.prevRead.TabIndex = 6;
            // 
            // CurRead
            // 
            this.CurRead.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.CurRead.Location = new System.Drawing.Point(222, 29);
            this.CurRead.Name = "CurRead";
            this.CurRead.Size = new System.Drawing.Size(100, 20);
            this.CurRead.TabIndex = 5;
            // 
            // calFuel
            // 
            this.calFuel.Location = new System.Drawing.Point(50, 147);
            this.calFuel.Name = "calFuel";
            this.calFuel.Size = new System.Drawing.Size(114, 23);
            this.calFuel.TabIndex = 4;
            this.calFuel.Text = "Calculate";
            this.calFuel.UseVisualStyleBackColor = true;
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
            this.groupBox2.Controls.Add(this.costPerKm);
            this.groupBox2.Controls.Add(this.litPerSweMil);
            this.groupBox2.Controls.Add(this.litPerMetMile);
            this.groupBox2.Controls.Add(this.litPerKm);
            this.groupBox2.Controls.Add(this.kmPerLiter);
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
            // costPerKm
            // 
            this.costPerKm.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.costPerKm.Location = new System.Drawing.Point(223, 170);
            this.costPerKm.Name = "costPerKm";
            this.costPerKm.Size = new System.Drawing.Size(100, 27);
            this.costPerKm.TabIndex = 9;
            // 
            // litPerSweMil
            // 
            this.litPerSweMil.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.litPerSweMil.Location = new System.Drawing.Point(223, 129);
            this.litPerSweMil.Name = "litPerSweMil";
            this.litPerSweMil.Size = new System.Drawing.Size(100, 23);
            this.litPerSweMil.TabIndex = 8;
            // 
            // litPerMetMile
            // 
            this.litPerMetMile.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.litPerMetMile.Location = new System.Drawing.Point(223, 92);
            this.litPerMetMile.Name = "litPerMetMile";
            this.litPerMetMile.Size = new System.Drawing.Size(100, 26);
            this.litPerMetMile.TabIndex = 7;
            // 
            // litPerKm
            // 
            this.litPerKm.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.litPerKm.Location = new System.Drawing.Point(223, 61);
            this.litPerKm.Name = "litPerKm";
            this.litPerKm.Size = new System.Drawing.Size(100, 23);
            this.litPerKm.TabIndex = 6;
            // 
            // kmPerLiter
            // 
            this.kmPerLiter.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.kmPerLiter.Location = new System.Drawing.Point(223, 32);
            this.kmPerLiter.Name = "kmPerLiter";
            this.kmPerLiter.Size = new System.Drawing.Size(100, 23);
            this.kmPerLiter.TabIndex = 5;
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
        private System.Windows.Forms.Button calFuel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox pricePerLiter;
        private System.Windows.Forms.TextBox fuelAmount;
        private System.Windows.Forms.TextBox prevRead;
        private System.Windows.Forms.TextBox CurRead;
        private System.Windows.Forms.Label costPerKm;
        private System.Windows.Forms.Label litPerSweMil;
        private System.Windows.Forms.Label litPerMetMile;
        private System.Windows.Forms.Label litPerKm;
        private System.Windows.Forms.Label kmPerLiter;
    }
}

