namespace CSC240_01_02_TestsInteractiveGUI_LDM
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
            this.txtTest1 = new System.Windows.Forms.TextBox();
            this.txtTest2 = new System.Windows.Forms.TextBox();
            this.txtTest3 = new System.Windows.Forms.TextBox();
            this.txtTest4 = new System.Windows.Forms.TextBox();
            this.txtTest5 = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.lblTest1 = new System.Windows.Forms.Label();
            this.lblTest2 = new System.Windows.Forms.Label();
            this.lblTest3 = new System.Windows.Forms.Label();
            this.lblTest4 = new System.Windows.Forms.Label();
            this.lblTest5 = new System.Windows.Forms.Label();
            this.lblAverage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTest1
            // 
            this.lblTest1.AutoSize = true;
            this.lblTest1.Location = new System.Drawing.Point(20, 20);
            this.lblTest1.Name = "lblTest1";
            this.lblTest1.Size = new System.Drawing.Size(45, 15);
            this.lblTest1.TabIndex = 0;
            this.lblTest1.Text = "Test 1:";
            // 
            // txtTest1
            // 
            this.txtTest1.Location = new System.Drawing.Point(90, 17);
            this.txtTest1.Name = "txtTest1";
            this.txtTest1.Size = new System.Drawing.Size(100, 23);
            this.txtTest1.TabIndex = 1;
            // 
            // lblTest2
            // 
            this.lblTest2.AutoSize = true;
            this.lblTest2.Location = new System.Drawing.Point(20, 50);
            this.lblTest2.Name = "lblTest2";
            this.lblTest2.Size = new System.Drawing.Size(45, 15);
            this.lblTest2.TabIndex = 2;
            this.lblTest2.Text = "Test 2:";
            // 
            // txtTest2
            // 
            this.txtTest2.Location = new System.Drawing.Point(90, 47);
            this.txtTest2.Name = "txtTest2";
            this.txtTest2.Size = new System.Drawing.Size(100, 23);
            this.txtTest2.TabIndex = 3;
            // 
            // lblTest3
            // 
            this.lblTest3.AutoSize = true;
            this.lblTest3.Location = new System.Drawing.Point(20, 80);
            this.lblTest3.Name = "lblTest3";
            this.lblTest3.Size = new System.Drawing.Size(45, 15);
            this.lblTest3.TabIndex = 4;
            this.lblTest3.Text = "Test 3:";
            // 
            // txtTest3
            // 
            this.txtTest3.Location = new System.Drawing.Point(90, 77);
            this.txtTest3.Name = "txtTest3";
            this.txtTest3.Size = new System.Drawing.Size(100, 23);
            this.txtTest3.TabIndex = 5;
            // 
            // lblTest4
            // 
            this.lblTest4.AutoSize = true;
            this.lblTest4.Location = new System.Drawing.Point(20, 110);
            this.lblTest4.Name = "lblTest4";
            this.lblTest4.Size = new System.Drawing.Size(45, 15);
            this.lblTest4.TabIndex = 6;
            this.lblTest4.Text = "Test 4:";
            // 
            // txtTest4
            // 
            this.txtTest4.Location = new System.Drawing.Point(90, 107);
            this.txtTest4.Name = "txtTest4";
            this.txtTest4.Size = new System.Drawing.Size(100, 23);
            this.txtTest4.TabIndex = 7;
            // 
            // lblTest5
            // 
            this.lblTest5.AutoSize = true;
            this.lblTest5.Location = new System.Drawing.Point(20, 140);
            this.lblTest5.Name = "lblTest5";
            this.lblTest5.Size = new System.Drawing.Size(45, 15);
            this.lblTest5.TabIndex = 8;
            this.lblTest5.Text = "Test 5:";
            // 
            // txtTest5
            // 
            this.txtTest5.Location = new System.Drawing.Point(90, 137);
            this.txtTest5.Name = "txtTest5";
            this.txtTest5.Size = new System.Drawing.Size(100, 23);
            this.txtTest5.TabIndex = 9;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(90, 175);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(100, 30);
            this.btnCalculate.TabIndex = 10;
            this.btnCalculate.Text = "Calculate Average";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lblAverage
            // 
            this.lblAverage.AutoSize = true;
            this.lblAverage.Location = new System.Drawing.Point(20, 220);
            this.lblAverage.Name = "lblAverage";
            this.lblAverage.Size = new System.Drawing.Size(55, 15);
            this.lblAverage.TabIndex = 11;
            this.lblAverage.Text = "Average:";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblResult.Location = new System.Drawing.Point(90, 220);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 15);
            this.lblResult.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(220, 260);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblAverage);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtTest5);
            this.Controls.Add(this.lblTest5);
            this.Controls.Add(this.txtTest4);
            this.Controls.Add(this.lblTest4);
            this.Controls.Add(this.txtTest3);
            this.Controls.Add(this.lblTest3);
            this.Controls.Add(this.txtTest2);
            this.Controls.Add(this.lblTest2);
            this.Controls.Add(this.txtTest1);
            this.Controls.Add(this.lblTest1);
            this.Name = "Form1";
            this.Text = "Test Score Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txtTest1;
        private System.Windows.Forms.TextBox txtTest2;
        private System.Windows.Forms.TextBox txtTest3;
        private System.Windows.Forms.TextBox txtTest4;
        private System.Windows.Forms.TextBox txtTest5;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label lblTest1;
        private System.Windows.Forms.Label lblTest2;
        private System.Windows.Forms.Label lblTest3;
        private System.Windows.Forms.Label lblTest4;
        private System.Windows.Forms.Label lblTest5;
        private System.Windows.Forms.Label lblAverage;
    }
}

