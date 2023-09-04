using System;
using System.Threading;
using System.Windows.Forms;
using System;
using System.Threading;
using System.Runtime.CompilerServices;

namespace AdditionalTask
{
    public partial class Form1 : Form
    {
        private Button startButton;
        private ProgressBar progressBar;
        private Button closeButton;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.startButton = new Button();
            this.progressBar = new ProgressBar();
            this.closeButton = new Button();
            this.SuspendLayout();
        }

        //startButton


        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}