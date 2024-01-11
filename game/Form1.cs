using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace game
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnK_Click(object sender, EventArgs e)
        {
            string k = "K";
            string o = "O";
            string t = "T";
            string l = "L";
            string i = "I";
            string n = "N";
            lblAnsK.Text = k;
            if (lblAnsK.Text == k)
            {
                btnK.Visible = false;
                int scr = 10;
                int cou = Convert.ToInt32(lblScoreAmount.Text);
                int result = cou + scr;
                lblScoreAmount.Text = Convert.ToString(result);

                if (lblAnsK.Text == k && lblAnsO.Text == o && lblAnsT.Text == t && lblAnsL.Text == l && lblAnsI.Text == i && lblAnsN.Text == n)
                {
                    lblWonmessage.Visible = true;
                }
                else
                {
                    lblWonmessage.Visible = false;
                }
            }

            
        }

        private void btnO_Click(object sender, EventArgs e)
        {
            string k = "K";
            string o = "O";
            string t = "T";
            string l = "L";
            string i = "I";
            string n = "N";
            lblAnsO.Text = o;
            if (lblAnsO.Text == o)
            {
                btnO.Visible = false;
                int scr = 10;
                int cou = Convert.ToInt32(lblScoreAmount.Text);
                int result = cou + scr;
                lblScoreAmount.Text = Convert.ToString(result);

                if (lblAnsK.Text == k && lblAnsO.Text == o && lblAnsT.Text == t && lblAnsL.Text == l && lblAnsI.Text == i && lblAnsN.Text == n)
                {
                    lblWonmessage.Visible = true;
                }
                else
                {
                    lblWonmessage.Visible = false;
                }
            }
        }

        private void btnT_Click(object sender, EventArgs e)
        {
            string k = "K";
            string o = "O";
            string t = "T";
            string l = "L";
            string i = "I";
            string n = "N";
            lblAnsT.Text = t;
            if (lblAnsT.Text == t)
            {
                btnT.Visible = false;
                int scr = 10;
                int cou = Convert.ToInt32(lblScoreAmount.Text);
                int result = cou + scr;
                lblScoreAmount.Text = Convert.ToString(result);

                if (lblAnsK.Text == k && lblAnsO.Text == o && lblAnsT.Text == t && lblAnsL.Text == l && lblAnsI.Text == i && lblAnsN.Text == n)
                {
                    lblWonmessage.Visible = true;
                }
                else
                {
                    lblWonmessage.Visible = false;
                }
            }
        }

        private void btnL_Click(object sender, EventArgs e)
        {
            string k = "K";
            string o = "O";
            string t = "T";
            string l = "L";
            string i = "I";
            string n = "N";
            lblAnsL.Text = l;
            if (lblAnsL.Text == l)
            {
                btnL.Visible = false;
                int scr = 10;
                int cou = Convert.ToInt32(lblScoreAmount.Text);
                int result = cou + scr;
                lblScoreAmount.Text = Convert.ToString(result);

                if (lblAnsK.Text == k && lblAnsO.Text == o && lblAnsT.Text == t && lblAnsL.Text == l && lblAnsI.Text == i && lblAnsN.Text == n)
                {
                    lblWonmessage.Visible = true;
                }
                else
                {
                    lblWonmessage.Visible = false;
                }
            }
        }

        private void btnI_Click(object sender, EventArgs e)
        {
            string k = "K";
            string o = "O";
            string t = "T";
            string l = "L";
            string i = "I";
            string n = "N";
            lblAnsI.Text = i;
            if (lblAnsI.Text == i)
            {
                btnI.Visible = false;
                int scr = 10;
                int cou = Convert.ToInt32(lblScoreAmount.Text);
                int result = cou + scr;
                lblScoreAmount.Text = Convert.ToString(result);

                if (lblAnsK.Text == k && lblAnsO.Text == o && lblAnsT.Text == t && lblAnsL.Text == l && lblAnsI.Text == i && lblAnsN.Text == n)
                {
                    lblWonmessage.Visible = true;
                }
                else
                {
                    lblWonmessage.Visible = false;
                }
            }
        }

        private void btnN_Click(object sender, EventArgs e)
        {
            string k = "K";
            string o = "O";
            string t = "T";
            string l = "L";
            string i = "I";
            string n = "N";
            lblAnsN.Text = n;
            if (lblAnsN.Text == n)
            {
                btnN.Visible = false;
                int scr = 10;
                int cou = Convert.ToInt32(lblScoreAmount.Text);
                int result = cou + scr;
                lblScoreAmount.Text = Convert.ToString(result);

                if (lblAnsK.Text == k && lblAnsO.Text == o && lblAnsT.Text == t && lblAnsL.Text == l && lblAnsI.Text == i && lblAnsN.Text == n)
                {
                    lblWonmessage.Visible = true;
                }
                else
                {
                    lblWonmessage.Visible = false;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblWonmessage.Visible = false;
            lblFailmessage.Visible = false;
            lblResultanswer.Visible = false;
        }

        private void btnA_Click(object sender, EventArgs e)
        {
            btnA.Visible = false;
            if (btnA.Visible == false)
            {
                int scr = 1;
                int cou = Convert.ToInt32(lblWrongAmount.Text);
                int result = cou + scr;
                lblWrongAmount.Text = Convert.ToString(result);

                int core = 9;
                if (cou == core)
                {
                    lblFailmessage.Visible = true;
                    lblResultanswer.Visible = true;
                }
            }
        }

        private void btnB_Click(object sender, EventArgs e)
        {
            btnB.Visible = false;
            if (btnB.Visible == false)
            {
                int scr = 1;
                int cou = Convert.ToInt32(lblWrongAmount.Text);
                int result = cou + scr;
                lblWrongAmount.Text = Convert.ToString(result);

                int core = 9;
                if (cou == core)
                {
                    lblFailmessage.Visible = true;
                    lblResultanswer.Visible = true;

                }

            }
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            btnC.Visible = false;
            if (btnC.Visible == false)
            {
                int scr = 1;
                int cou = Convert.ToInt32(lblWrongAmount.Text);
                int result = cou + scr;
                lblWrongAmount.Text = Convert.ToString(result);

                int core = 9;
                if (cou == core)
                {
                    lblFailmessage.Visible = true;
                    lblResultanswer.Visible = true;
                }

            }
        }

        private void btnD_Click(object sender, EventArgs e)
        {
            btnD.Visible = false;
            if (btnD.Visible == false)
            {
                int scr = 1;
                int cou = Convert.ToInt32(lblWrongAmount.Text);
                int result = cou + scr;
                lblWrongAmount.Text = Convert.ToString(result);


                int core = 9;
                if (cou == core)
                {
                    lblFailmessage.Visible = true;
                    lblResultanswer.Visible = true;
                }
            }
        }

        private void btnE_Click(object sender, EventArgs e)
        {
            btnE.Visible = false;
            if (btnE.Visible == false)
            {
                int scr = 1;
                int cou = Convert.ToInt32(lblWrongAmount.Text);
                int result = cou + scr;
                lblWrongAmount.Text = Convert.ToString(result);

                int core = 9;
                if (cou == core)
                {
                    lblFailmessage.Visible = true;
                    lblResultanswer.Visible = true;
                }

            }
        }

        private void btnF_Click(object sender, EventArgs e)
        {
            btnF.Visible = false;
            if (btnF.Visible == false)
            {
                int scr = 1;
                int cou = Convert.ToInt32(lblWrongAmount.Text);
                int result = cou + scr;
                lblWrongAmount.Text = Convert.ToString(result);

                int core = 9;
                if (cou == core)
                {
                    lblFailmessage.Visible = true;
                    lblResultanswer.Visible = true;
                }

            }
        }

        private void btnG_Click(object sender, EventArgs e)
        {
            btnG.Visible = false;
            if (btnG.Visible == false)
            {
                int scr = 1;
                int cou = Convert.ToInt32(lblWrongAmount.Text);
                int result = cou + scr;
                lblWrongAmount.Text = Convert.ToString(result);

                int core = 9;
                if (cou == core)
                {
                    lblFailmessage.Visible = true;
                    lblResultanswer.Visible = true;
                }

            }
        }

        private void btnH_Click(object sender, EventArgs e)
        {
            btnH.Visible = false;
            if (btnH.Visible == false)
            {
                int scr = 1;
                int cou = Convert.ToInt32(lblWrongAmount.Text);
                int result = cou + scr;
                lblWrongAmount.Text = Convert.ToString(result);

                int core = 9;
                if (cou == core)
                {
                    lblFailmessage.Visible = true;
                    lblResultanswer.Visible = true;
                }

            }
        }

        private void btnJ_Click(object sender, EventArgs e)
        {
            btnJ.Visible = false;
            if (btnJ.Visible == false)
            {
                int scr = 1;
                int cou = Convert.ToInt32(lblWrongAmount.Text);
                int result = cou + scr;
                lblWrongAmount.Text = Convert.ToString(result);

                int core = 9;
                if (cou == core)
                {
                    lblFailmessage.Visible = true;
                    lblResultanswer.Visible = true;
                }

            }
        }

        private void btnM_Click(object sender, EventArgs e)
        {
            btnM.Visible = false;
            if (btnM.Visible == false)
            {
                int scr = 1;
                int cou = Convert.ToInt32(lblWrongAmount.Text);
                int result = cou + scr;
                lblWrongAmount.Text = Convert.ToString(result);

                int core = 9;
                if (cou == core)
                {
                    lblFailmessage.Visible = true;
                    lblResultanswer.Visible = true;
                }

            }
        }

        private void btnP_Click(object sender, EventArgs e)
        {
            btnP.Visible = false;
            if (btnP.Visible == false)
            {
                int scr = 1;
                int cou = Convert.ToInt32(lblWrongAmount.Text);
                int result = cou + scr;
                lblWrongAmount.Text = Convert.ToString(result);

                int core = 9;
                if (cou == core)
                {
                    lblFailmessage.Visible = true;
                    lblResultanswer.Visible = true;
                }

            }
        }

        private void btnQ_Click(object sender, EventArgs e)
        {
            btnQ.Visible = false;
            if (btnQ.Visible == false)
            {
                int scr = 1;
                int cou = Convert.ToInt32(lblWrongAmount.Text);
                int result = cou + scr;
                lblWrongAmount.Text = Convert.ToString(result);

                int core = 9;
                if (cou == core)
                {
                    lblFailmessage.Visible = true;
                    lblResultanswer.Visible = true;
                }

            }
        }

        private void btnR_Click(object sender, EventArgs e)
        {
            btnR.Visible = false;
            if (btnR.Visible == false)
            {
                int scr = 1;
                int cou = Convert.ToInt32(lblWrongAmount.Text);
                int result = cou + scr;
                lblWrongAmount.Text = Convert.ToString(result);

                int core = 9;
                if (cou == core)
                {
                    lblFailmessage.Visible = true;
                    lblResultanswer.Visible = true;
                }

            }
        }

        private void btnS_Click(object sender, EventArgs e)
        {
            btnS.Visible = false;
            if (btnS.Visible == false)
            {
                int scr = 1;
                int cou = Convert.ToInt32(lblWrongAmount.Text);
                int result = cou + scr;
                lblWrongAmount.Text = Convert.ToString(result);

                int core = 9;
                if (cou == core)
                {
                    lblFailmessage.Visible = true;
                    lblResultanswer.Visible = true;
                }

            }
        }

        private void btnU_Click(object sender, EventArgs e)
        {
            btnU.Visible = false;
            if (btnU.Visible == false)
            {
                int scr = 1;
                int cou = Convert.ToInt32(lblWrongAmount.Text);
                int result = cou + scr;
                lblWrongAmount.Text = Convert.ToString(result);

                int core = 9;
                if (cou == core)
                {
                    lblFailmessage.Visible = true;
                    lblResultanswer.Visible = true;
                }

            }
        }

        private void btnV_Click(object sender, EventArgs e)
        {
            btnV.Visible = false;
            if (btnV.Visible == false)
            {
                int scr = 1;
                int cou = Convert.ToInt32(lblWrongAmount.Text);
                int result = cou + scr;
                lblWrongAmount.Text = Convert.ToString(result);

                int core = 9;
                if (cou == core)
                {
                    lblFailmessage.Visible = true;
                    lblResultanswer.Visible = true;
                }

            }
        }

        private void btnW_Click(object sender, EventArgs e)
        {
            btnW.Visible = false;
            if (btnW.Visible == false)
            {
                int scr = 1;
                int cou = Convert.ToInt32(lblWrongAmount.Text);
                int result = cou + scr;
                lblWrongAmount.Text = Convert.ToString(result);

                int core = 9;
                if (cou == core)
                {
                    lblFailmessage.Visible = true;
                    lblResultanswer.Visible = true;
                    
                }

            }
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            btnX.Visible = false;
            if (btnX.Visible == false)
            {
                int scr = 1;
                int cou = Convert.ToInt32(lblWrongAmount.Text);
                int result = cou + scr;
                lblWrongAmount.Text = Convert.ToString(result);

                int core = 9;
                if (cou == core)
                {
                    lblFailmessage.Visible = true;
                    lblResultanswer.Visible = true;
                }

            }
        }

        private void btnY_Click(object sender, EventArgs e)
        {
            btnY.Visible = false;
            if (btnY.Visible == false)
            {
                int scr = 1;
                int cou = Convert.ToInt32(lblWrongAmount.Text);
                int result = cou + scr;
                lblWrongAmount.Text = Convert.ToString(result);

                int core = 9;
                if (cou == core)
                {
                    lblFailmessage.Visible = true;
                    lblResultanswer.Visible = true;
                }

            }
        }

        private void btnZ_Click(object sender, EventArgs e)
        {
            btnZ.Visible = false;
            if (btnZ.Visible == false)
            {
                int scr = 1;
                int cou = Convert.ToInt32(lblWrongAmount.Text);
                int result = cou + scr;
                lblWrongAmount.Text = Convert.ToString(result);

                int core = 9;
                if (cou == core)
                {
                    lblFailmessage.Visible = true;
                    lblResultanswer.Visible = true;
                }

            }
        }
        private void btnREPLAY_Click(object sender, EventArgs e)
        {
            lblResultanswer.Visible = false;
            lblFailmessage.Visible = false;
            lblWonmessage.Visible = false;
            btnA.Visible = true;
            btnB.Visible = true;
            btnC.Visible = true;
            btnD.Visible = true;
            btnE.Visible = true;
            btnF.Visible = true;
            btnG.Visible = true;
            btnH.Visible = true;
            btnI.Visible = true;
            btnJ.Visible = true;
            btnK.Visible = true;
            btnL.Visible = true;
            btnM.Visible = true;
            btnN.Visible = true;
            btnO.Visible = true;
            btnP.Visible = true;
            btnQ.Visible = true;
            btnR.Visible = true;
            btnS.Visible = true;
            btnT.Visible = true;
            btnU.Visible = true;
            btnV.Visible = true;
            btnW.Visible = true;
            btnX.Visible = true;
            btnY.Visible = true;
            btnZ.Visible = true;
            lblAnsK.Text = "";
            lblAnsO.Text = "";
            lblAnsT.Text = "";
            lblAnsL.Text = "";
            lblAnsI.Text = "";
            lblAnsN.Text = "";
            lblScoreAmount.Text = "00";
            lblWrongAmount.Text = "00";


        }
        private void btnQUIT_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
