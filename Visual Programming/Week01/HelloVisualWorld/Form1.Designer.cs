namespace HelloVisualWorld
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

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            displayOutputButton = new Button();
            helloLabel = new Label();
            changeOutputButton = new Button();
            SuspendLayout();
            // 
            // displayOutputButton
            // 
            displayOutputButton.Location = new Point(80, 50);
            displayOutputButton.Name = "displayOutputButton";
            displayOutputButton.Size = new Size(150, 40);
            displayOutputButton.TabIndex = 0;
            displayOutputButton.Text = "Click here";
            displayOutputButton.UseVisualStyleBackColor = true;
            displayOutputButton.Click += DisplayOutputButtonClick;
            // 
            // helloLabel
            // 
            helloLabel.AutoSize = true;
            helloLabel.Location = new Point(80, 140);
            helloLabel.Name = "helloLabel";
            helloLabel.Size = new Size(172, 25);
            helloLabel.TabIndex = 1;
            helloLabel.Text = "Hello, Visual World!";
            helloLabel.Visible = false;
            // 
            // changeOutputButton
            // 
            changeOutputButton.Enabled = false;
            changeOutputButton.Location = new Point(80, 195);
            changeOutputButton.Name = "changeOutputButton";
            changeOutputButton.Size = new Size(150, 40);
            changeOutputButton.TabIndex = 2;
            changeOutputButton.Text = "Click me last";
            changeOutputButton.UseVisualStyleBackColor = true;
            changeOutputButton.Click += ChangeOutputButtonClick;
            // 
            // Form1
            // 
            AccessibleName = "Hello Visual World";
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(changeOutputButton);
            Controls.Add(helloLabel);
            Controls.Add(displayOutputButton);
            Name = "Form1";
            Text = "Hello Visual World";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button displayOutputButton;
        private Label helloLabel;
        private Button changeOutputButton;
    }
}
