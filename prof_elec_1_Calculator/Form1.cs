namespace prof_elec_1_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text.Length > 0)
            {
                double d ;
                if (!double.TryParse(txtDisplay.Text[txtDisplay.Text.Length - 1].ToString(), out d)) 
                {
                    previousOperation = Operation.None;
                }
                
                txtDisplay.Text = txtDisplay.Text.Remove(txtDisplay.Text.Length - 1, 1);
            }
        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            if (previousOperation != Operation.None)
            {
                PerformCalculation(previousOperation);
                
            }
            
    
             previousOperation = Operation.Add;
            
            txtDisplay.Text += (sender as Button).Text;
        }

        private void PerformCalculation(Operation previousOperation)
        {
            List<double> lstNums = new List<double>();
            switch (previousOperation)
            {
                case Operation.Add:
                    lstNums = txtDisplay.Text.Split('+').Select(double.Parse).ToList();
                    txtDisplay.Text = (lstNums[0] + lstNums[1]).ToString();
                    break;
                case Operation.Sub:
                    lstNums = txtDisplay.Text.Split('-').Select(double.Parse).ToList();
                    txtDisplay.Text = (lstNums[0] - lstNums[1]).ToString();
                    break;
                case Operation.Multi:
                    lstNums = txtDisplay.Text.Split('*').Select(double.Parse).ToList();
                    txtDisplay.Text = (lstNums[0] * lstNums[1]).ToString();
                    break;
                case Operation.Div:

                    try
                    {
                        lstNums = txtDisplay.Text.Split('/').Select(double.Parse).ToList();
                        txtDisplay.Text = (lstNums[0] / lstNums[1]).ToString();
                    }
                    catch (DivideByZeroException)
                    {
                        txtDisplay.Text = "EEEEEEEE";
                    }
                    break;
                case Operation.None: break;
                default: break;
            }
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            if (previousOperation != Operation.None)
            {
                PerformCalculation(previousOperation);

            }


            previousOperation = Operation.Sub;
            txtDisplay.Text += (sender as Button).Text;
        }

        private void btnMulti_Click(object sender, EventArgs e)
        {
            if (previousOperation != Operation.None)
            {
                PerformCalculation(previousOperation);

            }


            previousOperation = Operation.Multi;
            txtDisplay.Text += (sender as Button).Text;
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            if (previousOperation != Operation.None)
            {
                PerformCalculation(previousOperation);

            }


            previousOperation = Operation.Div;
            txtDisplay.Text += (sender as Button).Text;
        }

        private void btnNum_Click(object btn, EventArgs e)
        {
            txtDisplay.Text += (btn as Button).Text;
        }

        enum Operation
        {
            Add,
            Sub,
            Multi,
            Div,
            None
        }
        static Operation previousOperation = Operation.None;

        private void btnResult_Click_1(object sender, EventArgs e)
        {
            if (previousOperation == Operation.None)
            {
                return;
            }
            else
            {
                PerformCalculation(previousOperation);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            previousOperation = Operation.None;
            txtDisplay.Clear();
        }
    }
}
