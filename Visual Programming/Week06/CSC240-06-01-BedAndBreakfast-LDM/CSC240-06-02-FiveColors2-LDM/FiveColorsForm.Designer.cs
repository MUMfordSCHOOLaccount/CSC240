namespace CSC240_06_02_FiveColors2_LDM
{
    partial class FiveColorsForm
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
n        private System.Windows.Forms.RadioButton redRadio;
        private System.Windows.Forms.RadioButton greenRadio;
        private System.Windows.Forms.RadioButton blueRadio;
        private System.Windows.Forms.RadioButton yellowRadio;
        private System.Windows.Forms.RadioButton purpleRadio;
        private System.Windows.Forms.Button resetButton;
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.redRadio = new System.Windows.Forms.RadioButton();
            this.greenRadio = new System.Windows.Forms.RadioButton();
            this.blueRadio = new System.Windows.Forms.RadioButton();
            this.yellowRadio = new System.Windows.Forms.RadioButton();
            this.purpleRadio = new System.Windows.Forms.RadioButton();
            this.resetButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // redRadio
            // 
            this.redRadio.AutoSize = true;
            this.redRadio.Location = new System.Drawing.Point(24, 24);
            this.redRadio.Name = "redRadio";
            this.redRadio.Size = new System.Drawing.Size(54, 24);
            this.redRadio.TabIndex = 0;
            this.redRadio.TabStop = true;
            this.redRadio.Text = "Red";
            this.redRadio.UseVisualStyleBackColor = true;
            this.redRadio.CheckedChanged += new System.EventHandler(this.colorRadio_CheckedChanged);
            // 
            // greenRadio
            // 
            this.greenRadio.AutoSize = true;
            this.greenRadio.Location = new System.Drawing.Point(24, 56);
            this.greenRadio.Name = "greenRadio";
            this.greenRadio.Size = new System.Drawing.Size(67, 24);
            this.greenRadio.TabIndex = 1;
            this.greenRadio.TabStop = true;
            this.greenRadio.Text = "Green";
            this.greenRadio.UseVisualStyleBackColor = true;
            this.greenRadio.CheckedChanged += new System.EventHandler(this.colorRadio_CheckedChanged);
            // 
            // blueRadio
            // 
            this.blueRadio.AutoSize = true;
            this.blueRadio.Location = new System.Drawing.Point(24, 88);
            this.blueRadio.Name = "blueRadio";
            this.blueRadio.Size = new System.Drawing.Size(58, 24);
            this.blueRadio.TabIndex = 2;
            this.blueRadio.TabStop = true;
            this.blueRadio.Text = "Blue";
            this.blueRadio.UseVisualStyleBackColor = true;
            this.blueRadio.CheckedChanged += new System.EventHandler(this.colorRadio_CheckedChanged);
            // 
            // yellowRadio
            // 
            this.yellowRadio.AutoSize = true;
            this.yellowRadio.Location = new System.Drawing.Point(24, 120);
            this.yellowRadio.Name = "yellowRadio";
            this.yellowRadio.Size = new System.Drawing.Size(72, 24);
            this.yellowRadio.TabIndex = 3;
            this.yellowRadio.TabStop = true;
            this.yellowRadio.Text = "Yellow";
            this.yellowRadio.UseVisualStyleBackColor = true;
            this.yellowRadio.CheckedChanged += new System.EventHandler(this.colorRadio_CheckedChanged);
            // 
            // purpleRadio
            // 
            this.purpleRadio.AutoSize = true;
            this.purpleRadio.Location = new System.Drawing.Point(24, 152);
            this.purpleRadio.Name = "purpleRadio";
            this.purpleRadio.Size = new System.Drawing.Size(68, 24);
            this.purpleRadio.TabIndex = 4;
            this.purpleRadio.TabStop = true;
            this.purpleRadio.Text = "Purple";
            this.purpleRadio.UseVisualStyleBackColor = true;
            this.purpleRadio.CheckedChanged += new System.EventHandler(this.colorRadio_CheckedChanged);
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(24, 192);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(94, 29);
            this.resetButton.TabIndex = 5;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // FiveColorsForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 250);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.purpleRadio);
            this.Controls.Add(this.yellowRadio);
            this.Controls.Add(this.blueRadio);
            this.Controls.Add(this.greenRadio);
            this.Controls.Add(this.redRadio);
            this.Name = "FiveColorsForm";
            this.Text = "Five Colors 2";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
    }
}