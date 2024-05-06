
namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        bool check = false;
        double rezult = 0;
        string what = "none";

        private void n1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "1";
                check = false;
            }
            else
            {
                if (check == false) { textBox1.Text = textBox1.Text + "1"; }
                else { textBox1.Text = "1"; check = false; }
            }
            label2.Text = Convert.ToString(check);
            label3.Text = Convert.ToString(what);
            label4.Text = Convert.ToString(rezult);
        }

        private void n2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "2";
                check = false;
            }
            else
            {
                if (check == false) { textBox1.Text = textBox1.Text + "2"; }
                else { textBox1.Text = "2"; check = false; }
            }
            label2.Text = Convert.ToString(check);
            label3.Text = Convert.ToString(what);
            label4.Text = Convert.ToString(rezult);
        }

        private void n3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "3";
                check = false;
            }
            else
            {
                if (check == false) { textBox1.Text = textBox1.Text + "3"; }
                else { textBox1.Text = "3"; check = false; }
            }
            label2.Text = Convert.ToString(check);
            label3.Text = Convert.ToString(what);
            label4.Text = Convert.ToString(rezult);
        }

        private void n4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "4";
                check = false;
            }
            else
            {
                if (check == false) { textBox1.Text = textBox1.Text + "4"; }
                else { textBox1.Text = "4"; check = false; }
            }
            label2.Text = Convert.ToString(check);
            label3.Text = Convert.ToString(what);
            label4.Text = Convert.ToString(rezult);
        }

        private void n5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "5";
                check = false;
            }
            else
            {
                if (check == false) { textBox1.Text = textBox1.Text + "5"; }
                else { textBox1.Text = "5"; check = false; }
            }
            label2.Text = Convert.ToString(check);
            label3.Text = Convert.ToString(what);
            label4.Text = Convert.ToString(rezult);
        }

        private void n6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "6";
                check = false;
            }
            else
            {
                if (check == false) { textBox1.Text = textBox1.Text + "6"; }
                else { textBox1.Text = "6"; check = false; }
            }
            label2.Text = Convert.ToString(check);
            label3.Text = Convert.ToString(what);
            label4.Text = Convert.ToString(rezult);
        }

        private void n7_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "7";
                check = false;
            }
            else
            {
                if (check == false) { textBox1.Text = textBox1.Text + "7"; }
                else { textBox1.Text = "7"; check = false; }
            }
            label2.Text = Convert.ToString(check);
            label3.Text = Convert.ToString(what);
            label4.Text = Convert.ToString(rezult);
        }

        private void n8_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "8";
                check = false;
            }
            else
            {
                if (check == false) { textBox1.Text = textBox1.Text + "8"; }
                else { textBox1.Text = "8"; check = false; }
            }
            label2.Text = Convert.ToString(check);
            label3.Text = Convert.ToString(what);
            label4.Text = Convert.ToString(rezult);
        }

        private void n9_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "9";
                check = false;
            }
            else
            {
                if (check == false) { textBox1.Text = textBox1.Text + "9"; }
                else { textBox1.Text = "9"; check = false; }
            }
            label2.Text = Convert.ToString(check);
            label3.Text = Convert.ToString(what);
            label4.Text = Convert.ToString(rezult);
        }

        private void n0_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "0";
                check = false;
            }
            else
            {
                if (check == false) { textBox1.Text = textBox1.Text + "0"; }
                else { textBox1.Text = "0"; check = false; }
            }
            label2.Text = Convert.ToString(check);
            label3.Text = Convert.ToString(what);
            label4.Text = Convert.ToString(rezult);
        }

        private void nplus_Click(object sender, EventArgs e)
        {
            if (what == "none") { rezult += Convert.ToDouble(textBox1.Text); }
            if (what == "plus") { rezult += Convert.ToDouble(textBox1.Text); textBox1.Text = Convert.ToString(rezult); }
            if (what == "minus") { rezult -= Convert.ToDouble(textBox1.Text); textBox1.Text = Convert.ToString(rezult); }
            if (what == "on") { rezult *= Convert.ToDouble(textBox1.Text); textBox1.Text = Convert.ToString(rezult); }
            if (what == "drob") { rezult /= Convert.ToDouble(textBox1.Text); textBox1.Text = Convert.ToString(rezult); }
            if (what == "up") { rezult = Math.Pow(rezult, Convert.ToDouble(textBox1.Text)); textBox1.Text = Convert.ToString(rezult); }
            check = true;
            what = "plus";
            label2.Text = Convert.ToString(check);
            label3.Text = Convert.ToString(what);
            label4.Text = Convert.ToString(rezult);
        }

        private void nminus_Click(object sender, EventArgs e)
        {
            if (what == "none") { rezult += Convert.ToDouble(textBox1.Text); }
            if (what == "plus") { rezult += Convert.ToDouble(textBox1.Text); textBox1.Text = Convert.ToString(rezult); }
            if (what == "minus") { rezult -= Convert.ToDouble(textBox1.Text); textBox1.Text = Convert.ToString(rezult); }
            if (what == "on") { rezult *= Convert.ToDouble(textBox1.Text); textBox1.Text = Convert.ToString(rezult); }
            if (what == "drob") { rezult /= Convert.ToDouble(textBox1.Text); textBox1.Text = Convert.ToString(rezult); }
            if (what == "up") { rezult = Math.Pow(rezult, Convert.ToDouble(textBox1.Text)); textBox1.Text = Convert.ToString(rezult); }
            check = true;
            what = "minus";
            label2.Text = Convert.ToString(check);
            label3.Text = Convert.ToString(what);
            label4.Text = Convert.ToString(rezult);

        }

        private void non_Click(object sender, EventArgs e)
        {
            if (what == "none") { rezult += Convert.ToDouble(textBox1.Text); }
            if (what == "plus") { rezult += Convert.ToDouble(textBox1.Text); textBox1.Text = Convert.ToString(rezult); }
            if (what == "minus") { rezult -= Convert.ToDouble(textBox1.Text); textBox1.Text = Convert.ToString(rezult); }
            if (what == "on") { rezult *= Convert.ToDouble(textBox1.Text); textBox1.Text = Convert.ToString(rezult); }
            if (what == "drob") { rezult /= Convert.ToDouble(textBox1.Text); textBox1.Text = Convert.ToString(rezult); }
            if (what == "up") { rezult = Math.Pow(rezult, Convert.ToDouble(textBox1.Text)); textBox1.Text = Convert.ToString(rezult); }
            check = true;
            what = "on";
            label2.Text = Convert.ToString(check);
            label3.Text = Convert.ToString(what);
            label4.Text = Convert.ToString(rezult);
        }

        private void ndrod_Click(object sender, EventArgs e)
        {
            if (what == "none") { rezult += Convert.ToDouble(textBox1.Text); }
            if (what == "plus") { rezult += Convert.ToDouble(textBox1.Text); textBox1.Text = Convert.ToString(rezult); }
            if (what == "minus") { rezult -= Convert.ToDouble(textBox1.Text); textBox1.Text = Convert.ToString(rezult); }
            if (what == "on") { rezult *= Convert.ToDouble(textBox1.Text); textBox1.Text = Convert.ToString(rezult); }
            if (what == "drob") { rezult /= Convert.ToDouble(textBox1.Text); textBox1.Text = Convert.ToString(rezult); }
            if (what == "up") { rezult = Math.Pow(rezult, Convert.ToDouble(textBox1.Text)); textBox1.Text = Convert.ToString(rezult); }
            check = true;
            what = "drob";
            label2.Text = Convert.ToString(check);
            label3.Text = Convert.ToString(what);
            label4.Text = Convert.ToString(rezult);
        }

        private void nup_Click(object sender, EventArgs e)
        {
            if (what == "none") { rezult += Convert.ToDouble(textBox1.Text); }
            if (what == "plus") { rezult += Convert.ToDouble(textBox1.Text); textBox1.Text = Convert.ToString(rezult); }
            if (what == "minus") { rezult -= Convert.ToDouble(textBox1.Text); textBox1.Text = Convert.ToString(rezult); }
            if (what == "on") { rezult *= Convert.ToDouble(textBox1.Text); textBox1.Text = Convert.ToString(rezult); }
            if (what == "drob") { rezult /= Convert.ToDouble(textBox1.Text); textBox1.Text = Convert.ToString(rezult); }
            if (what == "up") { rezult = Math.Pow(rezult, Convert.ToDouble(textBox1.Text)); textBox1.Text = Convert.ToString(rezult); }
            check = true;
            what = "up";
            label2.Text = Convert.ToString(check);
            label3.Text = Convert.ToString(what);
            label4.Text = Convert.ToString(rezult);
        }

        private void ndown_Click(object sender, EventArgs e)
        {
            if (what == "none") { rezult += Convert.ToDouble(textBox1.Text); }
            if (what == "plus") { rezult += Convert.ToDouble(textBox1.Text); textBox1.Text = Convert.ToString(rezult); }
            if (what == "minus") { rezult -= Convert.ToDouble(textBox1.Text); textBox1.Text = Convert.ToString(rezult); }
            if (what == "on") { rezult *= Convert.ToDouble(textBox1.Text); textBox1.Text = Convert.ToString(rezult); }
            if (what == "drob") { rezult /= Convert.ToDouble(textBox1.Text); textBox1.Text = Convert.ToString(rezult); }
            if (what == "up") { rezult = Math.Pow(rezult, Convert.ToDouble(textBox1.Text)); textBox1.Text = Convert.ToString(rezult); }

            what = "sqrt";
            if (what == "sqrt") { rezult = Math.Sqrt(rezult); textBox1.Text = Convert.ToString(rezult); }
            check = false;

            label2.Text = Convert.ToString(check);
            label3.Text = Convert.ToString(what);
            label4.Text = Convert.ToString(rezult);
        }
        private void ntochka_Click(object sender, EventArgs e)
        {
            if (Convert.ToDouble(textBox1.Text) % 1 == 0)
            {
                if (textBox1.Text == "0" && textBox1.Text != null)
                {
                    textBox1.Text = "0.";
                    check = false;
                }
                else
                {
                    if (check == false) { textBox1.Text = textBox1.Text + "."; }
                }
            }
            
            label2.Text = Convert.ToString(check);
            label3.Text = Convert.ToString(what);
            label4.Text = Convert.ToString(rezult);
        }

        private void npercent_Click(object sender, EventArgs e)
        {
            if (what == "none") { rezult += Convert.ToDouble(textBox1.Text); }
            if (what == "plus") { rezult += Convert.ToDouble(textBox1.Text); textBox1.Text = Convert.ToString(rezult); }
            if (what == "minus") { rezult -= Convert.ToDouble(textBox1.Text); textBox1.Text = Convert.ToString(rezult); }
            if (what == "on") { rezult *= Convert.ToDouble(textBox1.Text); textBox1.Text = Convert.ToString(rezult); }
            if (what == "drob") { rezult /= Convert.ToDouble(textBox1.Text); textBox1.Text = Convert.ToString(rezult); }
            if (what == "up") { rezult = Math.Pow(rezult, Convert.ToDouble(textBox1.Text)); textBox1.Text = Convert.ToString(rezult); }
            
            check = false;
            what = "percent";
            if (what == "percent") { rezult /= 100; textBox1.Text = Convert.ToString(rezult); }

            label2.Text = Convert.ToString(check);
            label3.Text = Convert.ToString(what);
            label4.Text = Convert.ToString(rezult);
        }

        private void nis_Click(object sender, EventArgs e)
        {
            if (what == "none") { rezult += Convert.ToDouble(textBox1.Text); }
            if (what == "plus") { rezult += Convert.ToDouble(textBox1.Text); textBox1.Text = Convert.ToString(rezult); }
            if (what == "minus") { rezult -= Convert.ToDouble(textBox1.Text); textBox1.Text = Convert.ToString(rezult); }
            if (what == "on") { rezult *= Convert.ToDouble(textBox1.Text); textBox1.Text = Convert.ToString(rezult); }
            if (what == "drob") { rezult /= Convert.ToDouble(textBox1.Text); textBox1.Text = Convert.ToString(rezult); }
            if (what == "up") { rezult = Math.Pow(rezult, Convert.ToDouble(textBox1.Text)); textBox1.Text = Convert.ToString(rezult); }
            if (what == "percent") {textBox1.Text = Convert.ToString(rezult); }
            if (what == "sqrt") { textBox1.Text = Convert.ToString(rezult); }
            check = false;
            what = "none";
            label2.Text = Convert.ToString(check);
            label3.Text = Convert.ToString(what);
            label4.Text = Convert.ToString(rezult);
        }

        private void nclean_Click(object sender, EventArgs e)
        {
            check = false;
            what = "none";
            rezult = 0;
            textBox1.Text = "0";
            label2.Text = Convert.ToString(check);
            label3.Text = Convert.ToString(what);
            label4.Text = Convert.ToString(rezult);
        }

        
    }
}
