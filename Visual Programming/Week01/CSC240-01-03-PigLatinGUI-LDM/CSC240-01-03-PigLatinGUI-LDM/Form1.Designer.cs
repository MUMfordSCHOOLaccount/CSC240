namespace CSC240_01_03_PigLatinGUI_LDM
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
            this.lblPrompt = new System.Windows.Forms.Label();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.btnConvert = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.lblOutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblPrompt
            // 
            this.lblPrompt.AutoSize = true;
            this.lblPrompt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrompt.Location = new System.Drawing.Point(30, 30);
            this.lblPrompt.Name = "lblPrompt";
            this.lblPrompt.Size = new System.Drawing.Size(143, 17);
            this.lblPrompt.TabIndex = 0;
            this.lblPrompt.Text = "Enter a word:";
            // 
            // txtInput
            // 
            this.txtInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInput.Location = new System.Drawing.Point(33, 60);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(250, 23);
            this.txtInput.TabIndex = 1;
            // 
            // btnConvert
            // 
            this.btnConvert.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConvert.Location = new System.Drawing.Point(33, 100);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(150, 35);
            this.btnConvert.TabIndex = 2;
            this.btnConvert.Text = "Convert to Pig Latin";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.Location = new System.Drawing.Point(30, 160);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(114, 17);
            this.lblResult.TabIndex = 3;
            this.lblResult.Text = "Pig Latin version:";
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutput.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblOutput.Location = new System.Drawing.Point(33, 190);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(0, 20);
            this.lblOutput.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 280);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.lblPrompt);
            this.Name = "Form1";
            this.Text = "Pig Latin Converter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPrompt;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label lblOutput;
    }
}

