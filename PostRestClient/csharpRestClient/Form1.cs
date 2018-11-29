using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace csharpRestClient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void requestURI_Click(object sender, EventArgs e)
        {

        }

        #region UI Event Handler
        private void cmdGo_Click(object sender, EventArgs e)
        {

            RestClient rClient = new RestClient();
            rClient.endPoint = txtRestURI.Text;

            switch (cboVerb.Text)
            {
                case "POST":
                    rClient.httpMethod = httpVerb.POST;
                    rClient.postJSON = txtPOSTData.Text;
                    break;

                default:
                    rClient.httpMethod = httpVerb.GET;
                    break;


            }


            rClient.userName = txtUsername.Text;
            rClient.userPassword = txtPassword.Text;

            debugOutput("Rest Client Created");

            String strResponse = string.Empty;
            strResponse = rClient.makeRequest();

            debugOutput(strResponse);

        }
        #endregion

        private void debugOutput(string strDebugText)
        {
            try
            {
                System.Diagnostics.Debug.Write(strDebugText + Environment.NewLine);
                txtResponse.Text = txtResponse.Text + strDebugText + Environment.NewLine;
                txtResponse.SelectionStart = txtResponse.TextLength;
                txtResponse.ScrollToCaret();
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.Write(ex.Message, ToString() + Environment.NewLine);
            }
        }

        private void txtResponse_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
