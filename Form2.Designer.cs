namespace DoggyPalour
{
    partial class Form2
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
            this.gbMainServices = new System.Windows.Forms.GroupBox();
            this.rbStyling = new System.Windows.Forms.RadioButton();
            this.rbGrooming = new System.Windows.Forms.RadioButton();
            this.rbBathing = new System.Windows.Forms.RadioButton();
            this.gbAdditionalServices = new System.Windows.Forms.GroupBox();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.btnProceed = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.gbMainServices.SuspendLayout();
            this.gbAdditionalServices.SuspendLayout();
            this.SuspendLayout();

            // lblTitle
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(20, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(300, 25);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Select Your Services";

            // lblStudentInfo
            this.lblStudentInfo.AutoSize = true;
            this.lblStudentInfo.Font = new System.Drawing.Font("Arial", 10F);
            this.lblStudentInfo.Location = new System.Drawing.Point(20, 50);
            this.lblStudentInfo.Name = "lblStudentInfo";
            this.lblStudentInfo.Size = new System.Drawing.Size(150, 16);
            this.lblStudentInfo.TabIndex = 1;
            this.lblStudentInfo.Text = "Student: 24865745";

            // gbMainServices
            this.gbMainServices.Controls.Add(this.rbStyling);
            this.gbMainServices.Controls.Add(this.rbGrooming);
            this.gbMainServices.Controls.Add(this.rbBathing);
            this.gbMainServices.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.gbMainServices.Location = new System.Drawing.Point(20, 80);
            this.gbMainServices.Name = "gbMainServices";
            this.gbMainServices.Size = new System.Drawing.Size(400, 130);
            this.gbMainServices.TabIndex = 2;
            this.gbMainServices.TabStop = false;
            this.gbMainServices.Text = "Main Services";

            // rbBathing
            this.rbBathing.AutoSize = true;
            this.rbBathing.Location = new System.Drawing.Point(20, 30);
            this.rbBathing.Name = "rbBathing";
            this.rbBathing.Size = new System.Drawing.Size(180, 22);
            this.rbBathing.TabIndex = 0;
            this.rbBathing.Text = "Dog Bathing - R150.00";
            this.rbBathing.UseVisualStyleBackColor = true;
            this.rbBathing.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);

            // rbGrooming
            this.rbGrooming.AutoSize = true;
            this.rbGrooming.Location = new System.Drawing.Point(20, 60);
            this.rbGrooming.Name = "rbGrooming";
            this.rbGrooming.Size = new System.Drawing.Size(180, 22);
            this.rbGrooming.TabIndex = 1;
            this.rbGrooming.Text = "Dog Grooming - R250.00";
            this.rbGrooming.UseVisualStyleBackColor = true;
            this.rbGrooming.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);

            // rbStyling
            this.rbStyling.AutoSize = true;
            this.rbStyling.Location = new System.Drawing.Point(20, 90);
            this.rbStyling.Name = "rbStyling";
            this.rbStyling.Size = new System.Drawing.Size(180, 22);
            this.rbStyling.TabIndex = 2;
            this.rbStyling.Text = "Dog Styling - R300.00";
            this.rbStyling.UseVisualStyleBackColor = true;
            this.rbStyling.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);

            // gbAdditionalServices
            this.gbAdditionalServices.Controls.Add(this.checkedListBox1);
            this.gbAdditionalServices.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.gbAdditionalServices.Location = new System.Drawing.Point(20, 230);
            this.gbAdditionalServices.Name = "gbAdditionalServices";
            this.gbAdditionalServices.Size = new System.Drawing.Size(400, 150);
            this.gbAdditionalServices.TabIndex = 3;
            this.gbAdditionalServices.TabStop = false;
            this.gbAdditionalServices.Text = "Additional Services";

            // checkedListBox1
            this.checkedListBox1.Font = new System.Drawing.Font("Arial", 10F);
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(20, 30);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(360, 100);
            this.checkedListBox1.TabIndex = 0;
            this.checkedListBox1.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.checkedListBox1_ItemChecked);
            this.checkedListBox1.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.checkedListBox1_ItemCheck);

            // lblTotal
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.lblTotal.Location = new System.Drawing.Point(20, 400);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(100, 18);
            this.lblTotal.TabIndex = 4;
            this.lblTotal.Text = "Total Price:";

            // txtTotal
            this.txtTotal.Font = new System.Drawing.Font("Arial", 11F);
            this.txtTotal.Location = new System.Drawing.Point(130, 398);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(150, 24);
            this.txtTotal.TabIndex = 5;

            // lblDate
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.lblDate.Location = new System.Drawing.Point(20, 435);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(110, 18);
            this.lblDate.TabIndex = 6;
            this.lblDate.Text = "Service Date:";

            // txtDate
            this.txtDate.Font = new System.Drawing.Font("Arial", 11F);
            this.txtDate.Location = new System.Drawing.Point(130, 433);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(150, 24);
            this.txtDate.TabIndex = 7;

            // btnProceed
            this.btnProceed.Font = new System.Drawing.Font("Arial", 11F);
            this.btnProceed.Location = new System.Drawing.Point(130, 475);
            this.btnProceed.Name = "btnProceed";
            this.btnProceed.Size = new System.Drawing.Size(150, 35);
            this.btnProceed.TabIndex = 8;
            this.btnProceed.Text = "Proceed to Details";
            this.btnProceed.UseVisualStyleBackColor = true;
            this.btnProceed.Click += new System.EventHandler(this.btnProceed_Click);

            // btnBack
            this.btnBack.Font = new System.Drawing.Font("Arial", 11F);
            this.btnBack.Location = new System.Drawing.Point(300, 475);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(120, 35);
            this.btnBack.TabIndex = 9;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);

            // Form2
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 530);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnProceed);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.gbAdditionalServices);
            this.Controls.Add(this.gbMainServices);
            this.Controls.Add(this.lblStudentInfo);
            this.Controls.Add(this.lblTitle);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Doggy Palour - Service Selection";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.gbMainServices.ResumeLayout(false);
            this.gbMainServices.PerformLayout();
            this.gbAdditionalServices.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblStudentInfo;
        private System.Windows.Forms.GroupBox gbMainServices;
        private System.Windows.Forms.RadioButton rbStyling;
        private System.Windows.Forms.RadioButton rbGrooming;
        private System.Windows.Forms.RadioButton rbBathing;
        private System.Windows.Forms.GroupBox gbAdditionalServices;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.Button btnProceed;
        private System.Windows.Forms.Button btnBack;
    }
}
