using System;
using System.Windows.Forms;

namespace LABAA_6
{
    public partial class calc : Form
    {
        public calc()
        {
            InitializeComponent();
            one.Click += One_Click;
            two.Click += Two_Click;
            three.Click += Three_Click;
            four.Click += Four_Click;
            five.Click += Five_Click;
            six.Click += Six_Click;
            seven.Click += Seven_Click;
            eight.Click += Eight_Click;
            nine.Click += Nine_Click;
            zero.Click += Zero_Click;
            comma.Click += Comma_Click;
            equals.Click += Equals_Click;
            plus.Click += Plus_Click;
            minus.Click += Minus_Click;
            mult.Click += mult_Click;
            div.Click += Div_Click;
            pow.Click += Pow_Click;
            root.Click += Root_Click;
            reset.Click += Reset_Click;
            signChange.Click += SignChange_Click;
        }

        private void calc_Load(object sender, EventArgs e)
        {

        }
        double num1; double num2; double result; bool num1Entered = false; bool num2Entered = false; int operation;
        private void NumbersEntered(object sender, EventArgs e)
        {
            if (!num1Entered) num1 = double.Parse(line.Text);
            else
            {
                num2 = double.Parse(line.Text); num2Entered = true;
                zero.Cursor = Cursors.Default; zero.Enabled = true;
            }
        }
        private void Equals_Click(object sender, EventArgs e)
        {
            switch (operation)
            {
                case 1: result = num1 + num2; History.Text += $"{num1} + {num2} = {result}\n"; break;
                case 2: result = num1 - num2; History.Text += $"{num1} - {num2} = {result}\n"; break;
                case 3: result = num1 * num2; History.Text += $"{num1} * {num2} = {result}\n"; break;
                case 4: if (num2 == 0) { History.Text += "На 0 делить нельзя!\n"; } else { result = num1 / num2; History.Text += $"{num1} / {num2} = {result}\n"; } break;
                case 5: result = Math.Pow(num1, num2); History.Text += $"{num1} ^ {num2} = {result}\n"; break;
                default:
                    if (num2Entered) result = num2;
                    else result = num1; break;
            }
            if (History.Bottom > signChange.Bottom) History.Text = string.Empty;
            line.Text = result.ToString();
            num1 = result; num2 = 0; num1Entered = false; num2Entered = false; operation = 0;
            if (double.Parse(line.Text) < 0) root.Cursor = Cursors.No;
            else root.Cursor = Cursors.Default;
        }
        private void Reset_Click(object sender, EventArgs e)
        {
            line.Text = string.Empty;
            num1 = 0; num2 = 0; num1Entered = false; num2Entered = false;
        }
        private void SignChange_Click(object sender, EventArgs e)
        {
            if (num2Entered) { num2 = -num2; line.Text = num2.ToString(); }
            else { num1 = -num1; line.Text = num1.ToString(); }
            if (double.Parse(line.Text) < 0) root.Cursor = Cursors.No;
        }
        private void Root_Click(object sender, EventArgs e)
        {
            if (root.Cursor == Cursors.No) return; root.Cursor = Cursors.Default;
            History.Text += $"√{line.Text} = ";
            if (!num2Entered) {num1 = Math.Sqrt(num1); line.Text = num1.ToString(); }
            else { num2 = Math.Sqrt(num2); line.Text = num2.ToString();}
            History.Text += line.Text + "\n";
            if (History.Bottom > signChange.Bottom) History.Text = string.Empty;
            num1Entered = true;
        }

        private void Pow_Click(object sender, EventArgs e)
        {
            if (num2Entered) { Equals_Click(sender, e); }
            operation = 5;
            num1Entered = true;
        }

        private void Div_Click(object sender, EventArgs e)
        {
            if (num2Entered) { Equals_Click(sender, e); }
            operation = 4;
            num1Entered = true;
            if (line.Text == num1.ToString()) { zero.Cursor = Cursors.No; }
        }
        private void mult_Click(object sender, EventArgs e)
        {
            if (num2Entered) { Equals_Click(sender, e); }
            operation = 3;
            num1Entered = true;
        }

        private void Minus_Click(object sender, EventArgs e)
        {
            if (num2Entered) { Equals_Click(sender, e); }
            operation = 2;
            num1Entered = true;
        }
        private void Plus_Click(object sender, EventArgs e)
        {
            if (num2Entered) { Equals_Click(sender, e); }
            num1Entered = true;
            operation = 1;
        }

        private void Comma_Click(object sender, EventArgs e)
        {
            line.Text += ",";
        }

        private void Nine_Click(object sender, EventArgs e)
        {
            if (num1Entered && !num2Entered) line.Text = string.Empty;
            line.Text += 9.ToString();
            NumbersEntered(sender, e);
        }

        private void Eight_Click(object sender, EventArgs e)
        {
            if (num1Entered && !num2Entered) line.Text = string.Empty;
            line.Text += 8.ToString();
            NumbersEntered(sender, e);
        }

        private void Seven_Click(object sender, EventArgs e)
        {
            if (num1Entered && !num2Entered) line.Text = string.Empty;
            line.Text += 7.ToString();
            NumbersEntered(sender, e);
        }

        private void Six_Click(object sender, EventArgs e)
        {
            if (num1Entered && !num2Entered) line.Text = string.Empty;
            line.Text += 6.ToString();
            NumbersEntered(sender, e);
        }

        private void Five_Click(object sender, EventArgs e)
        {
            if (num1Entered && !num2Entered) line.Text = string.Empty;
            line.Text += 5.ToString();
            NumbersEntered(sender, e);
        }

        private void Four_Click(object sender, EventArgs e)
        {
            if (num1Entered && !num2Entered) line.Text = string.Empty;
            line.Text += 4.ToString();
            NumbersEntered(sender, e);
        }

        private void Three_Click(object sender, EventArgs e)
        {
            if (num1Entered && !num2Entered) line.Text = string.Empty;
            line.Text += 3.ToString();
            NumbersEntered(sender, e);
        }

        private void Two_Click(object sender, EventArgs e)
        {
            if (num1Entered && !num2Entered) line.Text = string.Empty;
            line.Text += 2.ToString();
            NumbersEntered(sender, e);
        }

        private void One_Click(object sender, EventArgs e)
        {
            if (num1Entered && !num2Entered) line.Text = string.Empty;
            line.Text += 1.ToString();
            NumbersEntered(sender, e);
        }

        private void Zero_Click(object sender, EventArgs e)
        {
            if (zero.Cursor == Cursors.No) {zero.Cursor = Cursors.Default; return; }
            if (num1Entered && !num2Entered) line.Text = string.Empty;
            line.Text += 0.ToString();
            NumbersEntered(sender, e);
        }
    }
}
