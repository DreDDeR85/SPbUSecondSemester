namespace AdditionalTask
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            progressBar = new ProgressBar();
            startButton = new Button();
            importantLabel = new Label();
            SuspendLayout();
            // 
            // progressBar
            // 
            progressBar.BackColor = SystemColors.MenuHighlight;
            progressBar.Location = new Point(40, 207);
            progressBar.Name = "progressBar";
            progressBar.Size = new Size(736, 35);
            progressBar.TabIndex = 0;
            progressBar.Click += this.progressBar1_Click;
            // 
            // startButton
            // 
            startButton.BackColor = SystemColors.GradientActiveCaption;
            startButton.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            startButton.Location = new Point(337, 127);
            startButton.Name = "startButton";
            startButton.Size = new Size(128, 49);
            startButton.TabIndex = 1;
            startButton.Text = "Install";
            startButton.UseVisualStyleBackColor = false;
            startButton.Click += this.button1_Click;
            // 
            // importantLabel
            // 
            importantLabel.AutoSize = true;
            importantLabel.BackColor = Color.FromArgb(0, 192, 0);
            importantLabel.Font = new Font("Segoe UI Semibold", 24F, FontStyle.Bold, GraphicsUnit.Point);
            importantLabel.Location = new Point(143, 38);
            importantLabel.Name = "importantLabel";
            importantLabel.Size = new Size(505, 54);
            importantLabel.TabIndex = 2;
            importantLabel.Text = "Install the Amigo browser?";
            importantLabel.Click += label1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(800, 450);
            Controls.Add(importantLabel);
            Controls.Add(startButton);
            Controls.Add(progressBar);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ProgressBar progressBar;
        private Button startButton;
        private Label importantLabel;
    }
}