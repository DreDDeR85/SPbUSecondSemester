using System.Runtime.CompilerServices;

namespace ProgressBarTask
{
    public partial class Form1 : Form
    {

        private Button StartButton;
        private Label veryImportantLabel;
        private ProgressBar progressBar;
        private Button closeButton;
        private void InitializeComponent()
        {
            StartButton = new Button();
            veryImportantLabel = new Label();
            progressBar = new ProgressBar();
            closeButton = new Button();
            SuspendLayout();
            // 
            // StartButton
            // 
            StartButton.BackColor = SystemColors.MenuBar;
            StartButton.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            StartButton.Location = new Point(302, 139);
            StartButton.Name = "StartButton";
            StartButton.Size = new Size(168, 55);
            StartButton.TabIndex = 0;
            StartButton.Text = "Install";
            StartButton.UseVisualStyleBackColor = false;
            StartButton.Click += button1_Click;
            // 
            // veryImportantLabel
            // 
            veryImportantLabel.AutoSize = true;
            veryImportantLabel.BackColor = Color.LightGreen;
            veryImportantLabel.Font = new Font("Segoe UI Semibold", 24F, FontStyle.Bold, GraphicsUnit.Point);
            veryImportantLabel.Location = new Point(135, 59);
            veryImportantLabel.Name = "veryImportantLabel";
            veryImportantLabel.Size = new Size(505, 54);
            veryImportantLabel.TabIndex = 1;
            veryImportantLabel.Text = "Install the Amigo browser?";
            // 
            // progressBar
            // 
            progressBar.Location = new Point(106, 255);
            progressBar.Name = "progressBar";
            progressBar.Size = new Size(569, 29);
            progressBar.TabIndex = 2;
            // 
            // closeButton
            // 
            closeButton.BackColor = SystemColors.MenuBar;
            closeButton.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            closeButton.Location = new Point(315, 344);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(139, 55);
            closeButton.TabIndex = 3;
            closeButton.Text = "Close";
            closeButton.UseVisualStyleBackColor = false;
            closeButton.Click += button1_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(closeButton);
            Controls.Add(progressBar);
            Controls.Add(veryImportantLabel);
            Controls.Add(StartButton);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }
        public Form1()
        {
            InitializeComponent();
            closeButton.Visible = false;
        }

        //startButtonClick
        private void button1_Click(object sender, EventArgs e)
        {
            StartButton.Enabled = false;
            StartButton.Text = "Installing...";
            progressBar.Value = 0;

            //starting separated stream for increasing the value
            //of progress's indicator

            Thread thread = new Thread(() =>
            {
                for (int i = 0; i <= 100; i++)
                {
                    //updating the value of progress's indicator
                    //in the main stream

                    Invoke(new Action(() => progressBar.Value = i));
                    Thread.Sleep(100);
                }

                //After reaching the 100% we show the closeButton

                Thread.Sleep(500);
                Invoke(new Action(() => closeButton.Visible = true));
                StartButton.Text = "Completed!";
            });

            thread.Start();
        }

        //closeButtonClick
        private void button1_Click_1(object sender, EventArgs e)
        {
            Close();
        }
    }
}