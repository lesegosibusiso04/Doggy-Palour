namespace DoggyPalour
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblStudentInfo = new System.Windows.Forms.Label();
            this.lblAbout = new System.Windows.Forms.Label();
            this.btnStartBooking = new System.Windows.Forms.Button();
            this.btnAbout = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // lblTitle
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(50, 30);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(300, 30);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Welcome to Doggy Palour";

            // lblStudentInfo
            this.lblStudentInfo.AutoSize = true;
            this.lblStudentInfo.Font = new System.Drawing.Font("Arial", 10F);
            this.lblStudentInfo.Location = new System.Drawing.Point(50, 80);
            this.lblStudentInfo.Name = "lblStudentInfo";
            this.lblStudentInfo.Size = new System.Drawing.Size(150, 16);
            this.lblStudentInfo.TabIndex = 1;
            this.lblStudentInfo.Text = "Student: 24865745";

            // lblAbout
            this.lblAbout.AutoSize = true;
            this.lblAbout.Font = new System.Drawing.Font("Arial", 12F);
            this.lblAbout.Location = new System.Drawing.Point(50, 130);
            this.lblAbout.Name = "lblAbout";
            this.lblAbout.Size = new System.Drawing.Size(300, 20);
            this.lblAbout.TabIndex = 2;
            this.lblAbout.Text = "Dog Grooming and Salon Services";

            // btnStartBooking
            this.btnStartBooking.Font = new System.Drawing.Font("Arial", 12F);
            this.btnStartBooking.Location = new System.Drawing.Point(50, 200);
            this.btnStartBooking.Name = "btnStartBooking";
            this.btnStartBooking.Size = new System.Drawing.Size(200, 40);
            this.btnStartBooking.TabIndex = 3;
            this.btnStartBooking.Text = "Start Booking";
            this.btnStartBooking.UseVisualStyleBackColor = true;
            this.btnStartBooking.Click += new System.EventHandler(this.btnStartBooking_Click);

            // btnAbout
            this.btnAbout.Font = new System.Drawing.Font("Arial", 12F);
            this.btnAbout.Location = new System.Drawing.Point(50, 260);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(200, 40);
            this.btnAbout.TabIndex = 4;
            this.btnAbout.Text = "About";
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);

            // btnExit
            this.btnExit.Font = new System.Drawing.Font("Arial", 12F);
            this.btnExit.Location = new System.Drawing.Point(50, 320);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(200, 40);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);

            // Form1
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 400);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnAbout);
            this.Controls.Add(this.btnStartBooking);
            this.Controls.Add(this.lblAbout);
            this.Controls.Add(this.lblStudentInfo);
            this.Controls.Add(this.lblTitle);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Doggy Palour - Main Menu";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblStudentInfo;
        private System.Windows.Forms.Label lblAbout;
        private System.Windows.Forms.Button btnStartBooking;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.Button btnExit;
    }
}
