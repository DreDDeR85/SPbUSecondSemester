namespace Midtern1._0._0
{
    public partial class Form1 : Form
    {

        private int player;
        public Form1()
        {
            InitializeComponent();
            this.Height = 768;
            this.Width = 1188;
            player = 1;
            label2.Text = "Current move: \nThe first player";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            bool isThisTheEnd = false;
            switch (player)
            {
                case 1:
                    sender.GetType().GetProperty("Text").SetValue(sender, "X");
                    player = 2;
                    label2.Text = "Current move: \nThe second player";
                    label2.BackColor = Color.CornflowerBlue;
                    break;
                case 2:
                    sender.GetType().GetProperty("Text").SetValue(sender, "O");
                    player = 1;
                    label2.Text = "Current move: \nThe first player";
                    label2.BackColor = Color.OrangeRed;
                    break;
            }
            sender.GetType().GetProperty("Enabled").SetValue(sender, false);
            isThisTheEnd = checkWin(player);
            if (isThisTheEnd)
            {
                label2.Text = "Restart me!";
                label2.BackColor = Color.WhiteSmoke;
                restrictUntilRestart();
            }

        }

        private void restrictUntilRestart()
        {
            button1.GetType().GetProperty("Enabled").SetValue(button1, false);
            button2.GetType().GetProperty("Enabled").SetValue(button2, false);
            button3.GetType().GetProperty("Enabled").SetValue(button3, false);
            button4.GetType().GetProperty("Enabled").SetValue(button4, false);
            button5.GetType().GetProperty("Enabled").SetValue(button5, false);
            button6.GetType().GetProperty("Enabled").SetValue(button6, false);
            button7.GetType().GetProperty("Enabled").SetValue(button7, false);
            button8.GetType().GetProperty("Enabled").SetValue(button8, false);
            button9.GetType().GetProperty("Enabled").SetValue(button9, false);
        }

        private void winWindow(int player)
        {
            switch (player)
            {
                case 0:
                    MessageBox.Show("This is a draw! No one won!");
                    break;
                case 1:
                    MessageBox.Show("The second player won!");
                    break;
                case 2:
                    MessageBox.Show("The first player won!");
                    break;
            }
        }

        private bool isThisASymbol(string symbol)
        {
            if (symbol == "X" || symbol == "O")
            {
                return true;
            }
            return false;
        }
        private int isThisAWin()
        { 
            if ((button1.Text == button2.Text && button2.Text == button3.Text && isThisASymbol(button1.Text)) || // the first line
                (button4.Text == button5.Text && button5.Text == button6.Text && isThisASymbol(button4.Text)) || // the second line
                (button7.Text == button8.Text && button8.Text == button9.Text && isThisASymbol(button7.Text)) || // the third line
                (button1.Text == button5.Text && button5.Text == button9.Text && isThisASymbol(button1.Text)) || // the main diagonal
                (button3.Text == button5.Text && button5.Text == button7.Text && isThisASymbol(button3.Text)) || // the sub diagonal
                (button1.Text == button4.Text && button4.Text == button7.Text && isThisASymbol(button1.Text)) || // the first column
                (button2.Text == button5.Text && button5.Text == button8.Text && isThisASymbol(button2.Text)) || // the second column
                (button3.Text == button6.Text && button6.Text == button9.Text && isThisASymbol(button3.Text)))   // the third column
            {
                return 1;
            }

            if (isThisASymbol(button1.Text) && isThisASymbol(button2.Text) && isThisASymbol(button3.Text) &&
                isThisASymbol(button4.Text) && isThisASymbol(button5.Text) && isThisASymbol(button6.Text) &&
                isThisASymbol(button7.Text) && isThisASymbol(button8.Text) && isThisASymbol(button9.Text))
            {
                return -1;
            }

            return 0;
        }
        private bool checkWin(int player)
        {
            if (isThisAWin() == 1)
            {
                winWindow(player);
                return true;
            }
            else if (isThisAWin() == -1)
            {
                player = 0;
                winWindow(player);
                return true;
            }
            return false;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}