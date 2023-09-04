using System;
using System.Drawing;
using System.Windows.Forms;

namespace ProgressBarTask
{
    public partial class Form1 : Form
    {
        private Button startButton;
        private Label veryImportantLabel;
        private ProgressBar progressBar;
        private Button closeButton;
        private System.Windows.Forms.Timer timer;

        public Form1()
        {
            InitializeComponent();
            closeButton.Visible = false;
        }

        private void InitializeComponent()
        {
            this.startButton = new Button();
            this.veryImportantLabel = new Label();
            this.progressBar = new ProgressBar();
            this.closeButton = new Button();
            this.timer = new System.Windows.Forms.Timer();
            this.SuspendLayout();

            // startButton
            this.startButton.BackColor = SystemColors.MenuBar;
            this.startButton.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            this.startButton.Location = new Point(302, 139);
            this.startButton.Name = "startButton";
            this.startButton.Size = new Size(168, 55);
            this.startButton.TabIndex = 0;
            this.startButton.Text = "Install";
            this.startButton.UseVisualStyleBackColor = false;
            this.startButton.Click += new EventHandler(this.startButton_Click);

            // veryImportantLabel
            this.veryImportantLabel.AutoSize = true;
            this.veryImportantLabel.BackColor = Color.LightGreen;
            this.veryImportantLabel.Font = new Font("Segoe UI Semibold", 24F, FontStyle.Bold, GraphicsUnit.Point);
            this.veryImportantLabel.Location = new Point(135, 59);
            this.veryImportantLabel.Name = "veryImportantLabel";
            this.veryImportantLabel.Size = new Size(505, 54);
            this.veryImportantLabel.TabIndex = 1;
            this.veryImportantLabel.Text = "Install the Amigo browser?";

            // progressBar
            this.progressBar.Location = new Point(106, 255);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new Size(569, 29);
            this.progressBar.TabIndex = 2;

            // closeButton
            this.closeButton.BackColor = SystemColors.MenuBar;
            this.closeButton.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            this.closeButton.Location = new Point(315, 344);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new Size(139, 55);
            this.closeButton.TabIndex = 3;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new EventHandler(this.closeButton_Click);

            // timer
            this.timer.Interval = 100;
            this.timer.Tick += new EventHandler(this.timer_Tick);

            // Form1
            this.AutoScaleDimensions = new SizeF(8F, 20F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(800, 450);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.veryImportantLabel);
            this.Controls.Add(this.startButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            startButton.Enabled = false;
            startButton.Text = "Installing...";
            progressBar.Value = 0;
            timer.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            progressBar.Value += 2;
            if (progressBar.Value >= 100)
            {
                timer.Stop();
                closeButton.Visible = true;
                startButton.Text = "Completed!";
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}