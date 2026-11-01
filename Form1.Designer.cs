namespace Program1Spring2025
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
            this.ReceiverTxt = new System.Windows.Forms.TextBox();
            this.HoursWrkTxt = new System.Windows.Forms.TextBox();
            this.StaffAssignedTxt = new System.Windows.Forms.TextBox();
            this.StuDiscountTxt = new System.Windows.Forms.TextBox();
            this.LocationTxt = new System.Windows.Forms.TextBox();
            this.ClientNameTxt = new System.Windows.Forms.TextBox();
            this.CalcBttn = new System.Windows.Forms.Button();
            this.ClientNameLbl = new System.Windows.Forms.Label();
            this.LocationLbl = new System.Windows.Forms.Label();
            this.OutputClientNameLbl = new System.Windows.Forms.Label();
            this.OutputLocationLbl = new System.Windows.Forms.Label();
            this.OutputTotalCostLbl = new System.Windows.Forms.Label();
            this.ClientNameRepeatLbl = new System.Windows.Forms.Label();
            this.LocationRepeatLbl = new System.Windows.Forms.Label();
            this.TotalCostLbl = new System.Windows.Forms.Label();
            this.NameCompanyLbl = new System.Windows.Forms.Label();
            this.NumReceiversLbl = new System.Windows.Forms.Label();
            this.HoursWorkedLbl = new System.Windows.Forms.Label();
            this.StaffLbl = new System.Windows.Forms.Label();
            this.StuDiscountLbl = new System.Windows.Forms.Label();
            this.YourQuoteLbl = new System.Windows.Forms.Label();
            this.ClearBttn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ReceiverTxt
            // 
            this.ReceiverTxt.Location = new System.Drawing.Point(423, 131);
            this.ReceiverTxt.Name = "ReceiverTxt";
            this.ReceiverTxt.Size = new System.Drawing.Size(100, 22);
            this.ReceiverTxt.TabIndex = 2;
            // 
            // HoursWrkTxt
            // 
            this.HoursWrkTxt.Location = new System.Drawing.Point(423, 159);
            this.HoursWrkTxt.Name = "HoursWrkTxt";
            this.HoursWrkTxt.Size = new System.Drawing.Size(100, 22);
            this.HoursWrkTxt.TabIndex = 3;
            // 
            // StaffAssignedTxt
            // 
            this.StaffAssignedTxt.Location = new System.Drawing.Point(423, 187);
            this.StaffAssignedTxt.Name = "StaffAssignedTxt";
            this.StaffAssignedTxt.Size = new System.Drawing.Size(100, 22);
            this.StaffAssignedTxt.TabIndex = 4;
            // 
            // StuDiscountTxt
            // 
            this.StuDiscountTxt.Location = new System.Drawing.Point(423, 215);
            this.StuDiscountTxt.Name = "StuDiscountTxt";
            this.StuDiscountTxt.Size = new System.Drawing.Size(100, 22);
            this.StuDiscountTxt.TabIndex = 5;
            // 
            // LocationTxt
            // 
            this.LocationTxt.Location = new System.Drawing.Point(423, 104);
            this.LocationTxt.Name = "LocationTxt";
            this.LocationTxt.Size = new System.Drawing.Size(100, 22);
            this.LocationTxt.TabIndex = 1;
            // 
            // ClientNameTxt
            // 
            this.ClientNameTxt.Location = new System.Drawing.Point(423, 76);
            this.ClientNameTxt.Name = "ClientNameTxt";
            this.ClientNameTxt.Size = new System.Drawing.Size(100, 22);
            this.ClientNameTxt.TabIndex = 0;
            this.ClientNameTxt.TextChanged += new System.EventHandler(this.ClientNameTxt_TextChanged);
            // 
            // CalcBttn
            // 
            this.CalcBttn.Location = new System.Drawing.Point(398, 271);
            this.CalcBttn.Name = "CalcBttn";
            this.CalcBttn.Size = new System.Drawing.Size(94, 23);
            this.CalcBttn.TabIndex = 6;
            this.CalcBttn.Text = "Calculate";
            this.CalcBttn.UseVisualStyleBackColor = true;
            this.CalcBttn.Click += new System.EventHandler(this.CalcBttn_Click);
            // 
            // ClientNameLbl
            // 
            this.ClientNameLbl.AutoSize = true;
            this.ClientNameLbl.Location = new System.Drawing.Point(313, 81);
            this.ClientNameLbl.Name = "ClientNameLbl";
            this.ClientNameLbl.Size = new System.Drawing.Size(83, 16);
            this.ClientNameLbl.TabIndex = 7;
            this.ClientNameLbl.Text = "Client Name:";
            // 
            // LocationLbl
            // 
            this.LocationLbl.AutoSize = true;
            this.LocationLbl.Location = new System.Drawing.Point(335, 106);
            this.LocationLbl.Name = "LocationLbl";
            this.LocationLbl.Size = new System.Drawing.Size(61, 16);
            this.LocationLbl.TabIndex = 8;
            this.LocationLbl.Text = "Location:";
            // 
            // OutputClientNameLbl
            // 
            this.OutputClientNameLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.OutputClientNameLbl.Location = new System.Drawing.Point(441, 316);
            this.OutputClientNameLbl.Name = "OutputClientNameLbl";
            this.OutputClientNameLbl.Size = new System.Drawing.Size(100, 25);
            this.OutputClientNameLbl.TabIndex = 9;
            // 
            // OutputLocationLbl
            // 
            this.OutputLocationLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.OutputLocationLbl.Location = new System.Drawing.Point(441, 358);
            this.OutputLocationLbl.Name = "OutputLocationLbl";
            this.OutputLocationLbl.Size = new System.Drawing.Size(100, 26);
            this.OutputLocationLbl.TabIndex = 10;
            // 
            // OutputTotalCostLbl
            // 
            this.OutputTotalCostLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.OutputTotalCostLbl.Location = new System.Drawing.Point(441, 400);
            this.OutputTotalCostLbl.Name = "OutputTotalCostLbl";
            this.OutputTotalCostLbl.Size = new System.Drawing.Size(100, 24);
            this.OutputTotalCostLbl.TabIndex = 11;
            // 
            // ClientNameRepeatLbl
            // 
            this.ClientNameRepeatLbl.AutoSize = true;
            this.ClientNameRepeatLbl.Location = new System.Drawing.Point(313, 317);
            this.ClientNameRepeatLbl.Name = "ClientNameRepeatLbl";
            this.ClientNameRepeatLbl.Size = new System.Drawing.Size(83, 16);
            this.ClientNameRepeatLbl.TabIndex = 12;
            this.ClientNameRepeatLbl.Text = "Client Name:";
            // 
            // LocationRepeatLbl
            // 
            this.LocationRepeatLbl.AutoSize = true;
            this.LocationRepeatLbl.Location = new System.Drawing.Point(335, 359);
            this.LocationRepeatLbl.Name = "LocationRepeatLbl";
            this.LocationRepeatLbl.Size = new System.Drawing.Size(61, 16);
            this.LocationRepeatLbl.TabIndex = 13;
            this.LocationRepeatLbl.Text = "Location:";
            // 
            // TotalCostLbl
            // 
            this.TotalCostLbl.AutoSize = true;
            this.TotalCostLbl.Location = new System.Drawing.Point(325, 400);
            this.TotalCostLbl.Name = "TotalCostLbl";
            this.TotalCostLbl.Size = new System.Drawing.Size(71, 16);
            this.TotalCostLbl.TabIndex = 14;
            this.TotalCostLbl.Text = "Total Cost:";
            // 
            // NameCompanyLbl
            // 
            this.NameCompanyLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameCompanyLbl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.NameCompanyLbl.Location = new System.Drawing.Point(163, 21);
            this.NameCompanyLbl.Name = "NameCompanyLbl";
            this.NameCompanyLbl.Size = new System.Drawing.Size(301, 50);
            this.NameCompanyLbl.TabIndex = 15;
            this.NameCompanyLbl.Text = "Plugged in Cable";
            // 
            // NumReceiversLbl
            // 
            this.NumReceiversLbl.AutoSize = true;
            this.NumReceiversLbl.Location = new System.Drawing.Point(259, 131);
            this.NumReceiversLbl.Name = "NumReceiversLbl";
            this.NumReceiversLbl.Size = new System.Drawing.Size(137, 16);
            this.NumReceiversLbl.TabIndex = 16;
            this.NumReceiversLbl.Text = "Number of Receivers:";
            // 
            // HoursWorkedLbl
            // 
            this.HoursWorkedLbl.AutoSize = true;
            this.HoursWorkedLbl.Location = new System.Drawing.Point(299, 159);
            this.HoursWorkedLbl.Name = "HoursWorkedLbl";
            this.HoursWorkedLbl.Size = new System.Drawing.Size(97, 16);
            this.HoursWorkedLbl.TabIndex = 17;
            this.HoursWorkedLbl.Text = "Hours Worked:";
            // 
            // StaffLbl
            // 
            this.StaffLbl.AutoSize = true;
            this.StaffLbl.Location = new System.Drawing.Point(300, 187);
            this.StaffLbl.Name = "StaffLbl";
            this.StaffLbl.Size = new System.Drawing.Size(96, 16);
            this.StaffLbl.TabIndex = 18;
            this.StaffLbl.Text = "Staff Assigned:";
            // 
            // StuDiscountLbl
            // 
            this.StuDiscountLbl.AutoSize = true;
            this.StuDiscountLbl.Location = new System.Drawing.Point(243, 221);
            this.StuDiscountLbl.Name = "StuDiscountLbl";
            this.StuDiscountLbl.Size = new System.Drawing.Size(153, 16);
            this.StuDiscountLbl.TabIndex = 19;
            this.StuDiscountLbl.Text = "Student Discount (0 or 1):";
            // 
            // YourQuoteLbl
            // 
            this.YourQuoteLbl.AutoSize = true;
            this.YourQuoteLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YourQuoteLbl.Location = new System.Drawing.Point(163, 265);
            this.YourQuoteLbl.Name = "YourQuoteLbl";
            this.YourQuoteLbl.Size = new System.Drawing.Size(146, 29);
            this.YourQuoteLbl.TabIndex = 20;
            this.YourQuoteLbl.Text = "Your Quote";
            // 
            // ClearBttn
            // 
            this.ClearBttn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClearBttn.Location = new System.Drawing.Point(399, 466);
            this.ClearBttn.Name = "ClearBttn";
            this.ClearBttn.Size = new System.Drawing.Size(94, 23);
            this.ClearBttn.TabIndex = 7;
            this.ClearBttn.Text = "Clear";
            this.ClearBttn.UseVisualStyleBackColor = true;
            this.ClearBttn.Click += new System.EventHandler(this.ClearBttn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 501);
            this.Controls.Add(this.ClearBttn);
            this.Controls.Add(this.YourQuoteLbl);
            this.Controls.Add(this.StuDiscountLbl);
            this.Controls.Add(this.StaffLbl);
            this.Controls.Add(this.HoursWorkedLbl);
            this.Controls.Add(this.NumReceiversLbl);
            this.Controls.Add(this.NameCompanyLbl);
            this.Controls.Add(this.TotalCostLbl);
            this.Controls.Add(this.LocationRepeatLbl);
            this.Controls.Add(this.ClientNameRepeatLbl);
            this.Controls.Add(this.OutputTotalCostLbl);
            this.Controls.Add(this.OutputLocationLbl);
            this.Controls.Add(this.OutputClientNameLbl);
            this.Controls.Add(this.LocationLbl);
            this.Controls.Add(this.ClientNameLbl);
            this.Controls.Add(this.CalcBttn);
            this.Controls.Add(this.ClientNameTxt);
            this.Controls.Add(this.LocationTxt);
            this.Controls.Add(this.StuDiscountTxt);
            this.Controls.Add(this.StaffAssignedTxt);
            this.Controls.Add(this.HoursWrkTxt);
            this.Controls.Add(this.ReceiverTxt);
            this.Name = "Form1";
            this.Text = "Quote Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ReceiverTxt;
        private System.Windows.Forms.TextBox HoursWrkTxt;
        private System.Windows.Forms.TextBox StaffAssignedTxt;
        private System.Windows.Forms.TextBox StuDiscountTxt;
        private System.Windows.Forms.TextBox LocationTxt;
        private System.Windows.Forms.TextBox ClientNameTxt;
        private System.Windows.Forms.Button CalcBttn;
        private System.Windows.Forms.Label ClientNameLbl;
        private System.Windows.Forms.Label LocationLbl;
        private System.Windows.Forms.Label OutputClientNameLbl;
        private System.Windows.Forms.Label OutputLocationLbl;
        private System.Windows.Forms.Label OutputTotalCostLbl;
        private System.Windows.Forms.Label ClientNameRepeatLbl;
        private System.Windows.Forms.Label LocationRepeatLbl;
        private System.Windows.Forms.Label TotalCostLbl;
        private System.Windows.Forms.Label NameCompanyLbl;
        private System.Windows.Forms.Label NumReceiversLbl;
        private System.Windows.Forms.Label HoursWorkedLbl;
        private System.Windows.Forms.Label StaffLbl;
        private System.Windows.Forms.Label StuDiscountLbl;
        private System.Windows.Forms.Label YourQuoteLbl;
        private System.Windows.Forms.Button ClearBttn;
    }
}

