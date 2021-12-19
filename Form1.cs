namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
       
        double FirstNumber;
        string Operation;
        public void setButtonStyle(Button button, Color c, Color d)
        {
            button.BackColor = c;
            button.FlatAppearance.MouseDownBackColor = c;
            button.FlatAppearance.MouseOverBackColor = d;
            button.FlatStyle = FlatStyle.Flat;
        }
        public void setButtonsColor(Color c)
        {
            foreach (Control control in this.Controls)
            {
                if (typeof(Button).IsInstanceOfType(control))
                {
                    Button button = (Button)control;
                    this.setButtonForeColor(button, c);
                }
            }
        }
        public void setButtonForeColor(Button button, Color c)
        {
            button.ForeColor = c;
        }        
        public Form1()
        {
            InitializeComponent();
            comboBox1.SelectionLength = 0;
            comboBox1.SelectedText = String.Empty;
            Color c = Color.FromArgb(150, 0, 0, 0);
            Color d = Color.FromArgb(220, 0, 0, 0);
            foreach (Control control in this.Controls)
            {
                if (typeof(Button).IsInstanceOfType(control))
                {
                    Button button = (Button)control;
                    this.setButtonStyle(button, c, d);
                }
            }
            this.textBox1.AutoSize = false;
            this.textBox1.Size = new Size(550, 60);
            this.textBox1.ReadOnly = true;
            this.textBox1.Enabled = false;          
            this.textBox1.BackColor = Color.FromArgb(150, 0, 0, 0);
            this.MaximizeBox = false;
            comboBox1.SelectionLength = 0;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
        }
        public void textBox1_TextChanged(object sender, EventArgs e)
        {
        }
        private void button40_Click(object sender, EventArgs e)
        {
            textBox1.CueText = " ";
        }
        private void label1_Click(object sender, EventArgs e)
        {
        }
        public void button6_Click(object sender, EventArgs e)
        {
            textBox1.CueText += button6.Text;
        }
        public void button1_Click_1(object sender, EventArgs e)
        {
            textBox1.CueText += button1.Text;
        }
        public void button2_Click(object sender, EventArgs e)
        {
            textBox1.CueText += button2.Text;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.CueText += button3.Text;
        }
        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.CueText += button4.Text;
        }
        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.CueText += button5.Text;
        }
        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.CueText += button7.Text;
        }
        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.CueText += button8.Text;
        }
        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.CueText += button9.Text;
        }
        private void button10_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBox1.CueText))
            {
                textBox1.CueText = "";
                return;
            }
            double SecondNumber;
            try
            {
                SecondNumber = Convert.ToDouble(textBox1.CueText.Replace(".", ","));
            }
            catch (Exception ex)
            {
                textBox1.CueText = "";
                return;
            }
            FirstNumber = Convert.ToDouble(textBox1.CueText.Replace(".", ","));
            textBox1.CueText = " ";
            Operation = "+";
        }
        private void button11_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBox1.CueText))
            {
                textBox1.CueText = "";
                return;
            }
            double SecondNumber;
            try
            {
                SecondNumber = Convert.ToDouble(textBox1.CueText.Replace(".", ","));
            }
            catch (Exception ex)
            {
                textBox1.CueText = "";
                return;
            }

            FirstNumber = Convert.ToDouble(textBox1.CueText.Replace(".", ","));
            textBox1.CueText = " ";
            Operation = "-";
        }
        private void button12_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBox1.CueText))
            {
                textBox1.CueText = "";
                return;
            }
            double SecondNumber;
            try
            {
                SecondNumber = Convert.ToDouble(textBox1.CueText.Replace(".", ","));
            }
            catch (Exception ex)
            {
                textBox1.CueText = "";
                return;
            }
            FirstNumber = Convert.ToDouble(textBox1.CueText.Replace(".", ","));
            textBox1.CueText = " ";
            Operation = "*";
        }
        private void button13_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBox1.CueText))
            {
                textBox1.CueText = "";
                return;
            }
            double SecondNumber;
            try
            {
                SecondNumber = Convert.ToDouble(textBox1.CueText.Replace(".", ","));
            }
            catch (Exception ex)
            {
                textBox1.CueText = "";
                return;
            }
            FirstNumber = Convert.ToDouble(textBox1.CueText.Replace(".", ","));
            textBox1.CueText = " ";
            Operation = "/";
        }
        private void button15_Click(object sender, EventArgs e)
        {
            textBox1.CueText += ".";
        }
        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.CueText += button16.Text;
        }
        private void button14_Click_1(object sender, EventArgs e)
        {
            textBox1.CueText += button14.Text;
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.Hand;
            if (comboBox1.SelectedIndex == 0)
            {
                setButtonsColor(Color.DarkViolet);   
                textBox1.ForeColor = Color.DarkViolet;
                comboBox1.BackColor = Color.Violet;
                comboBox1.ForeColor = Color.DarkViolet;
                this.BackgroundImage = Properties.Resources.raiden;
            }
            if (comboBox1.SelectedIndex == 1)
            {
                setButtonsColor(Color.DarkRed);
                textBox1.ForeColor = Color.DarkRed;
                comboBox1.BackColor = Color.Red;
                comboBox1.ForeColor = Color.DarkRed;
                this.BackgroundImage = Properties.Resources.alucard;
            }
            if (comboBox1.SelectedIndex == 2)
            {
                setButtonsColor(Color.DarkViolet);             
                textBox1.ForeColor = Color.DarkViolet;
                comboBox1.BackColor = Color.Violet;
                comboBox1.ForeColor = Color.DarkViolet;
                this.BackgroundImage = Properties.Resources.dzodzo;
            }
            if (comboBox1.SelectedIndex == 3)
            {
                setButtonsColor(Color.DarkRed);
                textBox1.ForeColor = Color.DarkRed;
                comboBox1.BackColor = Color.Red;
                comboBox1.ForeColor = Color.DarkRed;
                this.BackgroundImage = Properties.Resources.hutao;
            }
            if (comboBox1.SelectedIndex == 4)
            {
                setButtonsColor(Color.DarkGray);
                textBox1.ForeColor = Color.Black;
                comboBox1.BackColor = Color.Gray;
                comboBox1.ForeColor = Color.DarkGray;
                this.BackgroundImage = Properties.Resources.sasuke;
            }
            if (comboBox1.SelectedIndex == 5)
            {
                setButtonsColor(Color.DarkBlue);
                textBox1.ForeColor = Color.DarkBlue;
                comboBox1.BackColor = Color.Blue;
                comboBox1.ForeColor = Color.DarkBlue;
                this.BackgroundImage = Properties.Resources.targtalia;
            }
            if (comboBox1.SelectedIndex == 6)
            {
                setButtonsColor(Color.Yellow);
                textBox1.ForeColor = Color.Yellow;
                comboBox1.BackColor = Color.Orange;
                comboBox1.ForeColor = Color.Yellow;
                this.BackgroundImage = Properties.Resources.animeart1;
            }
            if (comboBox1.SelectedIndex == 7)
            {
                setButtonsColor(Color.Aqua);
                textBox1.ForeColor = Color.Aqua;
                comboBox1.BackColor = Color.Gray;
                comboBox1.ForeColor = Color.Aqua;
                this.BackgroundImage = Properties.Resources.animeart2;
            }
        }
        private void C_Click(object sender, EventArgs e)
        {
            textBox1.CueText = "";
        }
        private void gg_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBox1.CueText))
            {
                textBox1.CueText = "";
                return;
            }
            double SecondNumber;
            double Result;
            int a = 0;
            try
            {
                SecondNumber = Convert.ToDouble(textBox1.CueText.Replace(".", ","));
            }
            catch (Exception ex)
            {
                textBox1.CueText = "";
                return;
            }
            if (Operation == "+")
            {
                textBox1.CueText = Convert.ToString(a);
                Result = (a + FirstNumber + SecondNumber);
                textBox1.CueText = Convert.ToString(Result);
                FirstNumber = Result;
            }
            else if (Operation == "-")
            {
                Result = (FirstNumber - SecondNumber);
                textBox1.CueText = Convert.ToString(Result);
                FirstNumber = Result;
            }
            else if (Operation == "*")
            {
                Result = (FirstNumber * SecondNumber);
                textBox1.CueText = Convert.ToString(Result);
                FirstNumber = Result;
            }
            else if (Operation == "/")
            {
                if (SecondNumber == 0)
                {
                    textBox1.CueText = "0";
                }
                else
                {
                    Result = (FirstNumber / SecondNumber);
                    textBox1.CueText = Convert.ToString(Result);
                    FirstNumber = Result;
                }
            }
            else
            {
                textBox1.CueText = Convert.ToString(a);
                textBox1.CueText = "0";
            }
        }
        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
        }
    }
}

