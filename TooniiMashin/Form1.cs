using System;
using System.Globalization;
using System.Windows.Forms;

namespace TooniiMashin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            btnAdd.Click += (sender, e) => Calculate("+");
            btnSubtract.Click += (sender, e) => Calculate("-");
            btnMultiply.Click += (sender, e) => Calculate("*");
            btnDivide.Click += (sender, e) => Calculate("/");
        }

        private void Calculate(string operation)
        {
            // Өмнөх хариуг цэвэрлэнэ.
            lblResult.Text = "Хариу:";

            // Бутархай тоог 2.5 эсвэл 2,5 гэж оруулж болно.
            string firstText = txtFirst.Text.Trim().Replace(',', '.');
            string secondText = txtSecond.Text.Trim().Replace(',', '.');

            if (!decimal.TryParse(
                firstText,
                NumberStyles.AllowLeadingSign |
                NumberStyles.AllowDecimalPoint,
                CultureInfo.InvariantCulture,
                out decimal first))
            {
                MessageBox.Show("Эхний тоог зөв оруулна уу.");
                txtFirst.Focus();
                return;
            }

            if (!decimal.TryParse(
                secondText,
                NumberStyles.AllowLeadingSign |
                NumberStyles.AllowDecimalPoint,
                CultureInfo.InvariantCulture,
                out decimal second))
            {
                MessageBox.Show("Хоёр дахь тоог зөв оруулна уу.");
                txtSecond.Focus();
                return;
            }

            decimal result;

            try
            {
                switch (operation)
                {
                    case "+":
                        result = first + second;
                        break;

                    case "-":
                        result = first - second;
                        break;

                    case "*":
                        result = first * second;
                        break;

                    case "/":
                        if (second == 0)
                        {
                            MessageBox.Show("Тэгээр хувааж болохгүй.");
                            txtSecond.Focus();
                            return;
                        }

                        result = first / second;
                        break;

                    default:
                        return;
                }

                lblResult.Text = "Хариу: " +
                    result.ToString(CultureInfo.InvariantCulture);
            }
            catch (OverflowException)
            {
                MessageBox.Show(
                    "Үр дүн хэт том байна. Бага тоогоор туршина уу.");
            }
        }
    }
}