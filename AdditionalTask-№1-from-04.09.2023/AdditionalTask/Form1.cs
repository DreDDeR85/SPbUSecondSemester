using System;
using System.Drawing;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace progressBarTask
{
    public partial class Form1 : Form
    {
        private System.Windows.Forms.Button _startButton;
        private System.Windows.Forms.Label _veryImportantLabel;
        private System.Windows.Forms.ProgressBar _progressBar;
        private System.Windows.Forms.Button _closeButton;
        private System.Windows.Forms.Timer _timer;

        public Form1()
        {
            InitializeComponent();
            _closeButton.Visible = false;
        }

        private void InitializeComponent()
        {
            _startButton = new System.Windows.Forms.Button();
            _veryImportantLabel = new System.Windows.Forms.Label();
            _progressBar = new System.Windows.Forms.ProgressBar();
            _closeButton = new System.Windows.Forms.Button();
            _timer = new System.Windows.Forms.Timer();
            SuspendLayout();

            // _startButton
            _startButton.BackColor = SystemColors.MenuBar;
            _startButton.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            _startButton.Location = new Point(302, 139);
            _startButton.Name = "_startButton";
            _startButton.Size = new Size(168, 55);
            _startButton.TabIndex = 0;
            _startButton.Text = "Install";
            _startButton.UseVisualStyleBackColor = false;
            _startButton.Click += new EventHandler(_startButton_Click);

            // _veryImportantLabel
            _veryImportantLabel.AutoSize = true;
            _veryImportantLabel.BackColor = Color.LightGreen;
            _veryImportantLabel.Font = new Font("Segoe UI Semibold", 24F, FontStyle.Bold, GraphicsUnit.Point);
            _veryImportantLabel.Location = new Point(135, 59);
            _veryImportantLabel.Name = "_veryImportantLabel";
            _veryImportantLabel.Size = new Size(505, 54);
            _veryImportantLabel.TabIndex = 1;
            _veryImportantLabel.Text = "Install the Amigo browser?";

            // _progressBar
            _progressBar.Location = new Point(106, 255);
            _progressBar.Name = "_progressBar";
            _progressBar.Size = new Size(569, 29);
            _progressBar.TabIndex = 2;

            // _closeButton
            _closeButton.BackColor = SystemColors.MenuBar;
            _closeButton.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            _closeButton.Location = new Point(315, 344);
            _closeButton.Name = "_closeButton";
            _closeButton.Size = new Size(139, 55);
            _closeButton.TabIndex = 3;
            _closeButton.Text = "Close";
            _closeButton.UseVisualStyleBackColor = false;
            _closeButton.Click += new EventHandler(_closeButton_Click);

            // _timer
            _timer.Interval = 100;
            _timer.Tick += new EventHandler(timer_Tick);

            // Form1
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(_closeButton);
            Controls.Add(_progressBar);
            Controls.Add(_veryImportantLabel);
            Controls.Add(_startButton);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        private void _startButton_Click(object sender, EventArgs e)
        {
            _startButton.Enabled = false;
            _startButton.Text = "Installing...";
            _progressBar.Value = 0;
            _timer.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            _progressBar.Value += 2;
            if (_progressBar.Value >= 100)
            {
                _timer.Stop();
                _closeButton.Visible = true;
                _startButton.Text = "Completed!";
            }
        }

        private void _closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }


    }
}