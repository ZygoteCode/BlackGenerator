using BlackGenerator_XS.Forms;
using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlackGenerator_XS
{
    public partial class LauncherForm : Form
    {
        public LauncherForm()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }

        private void guna2HtmlLabel2_Click(object sender, EventArgs e)
        {

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            Task.Run(() =>
            {
                guna2HtmlLabel2.Hide();
                Thread.Sleep(400);
                guna2HtmlLabel2.Show();
                guna2HtmlLabel2.Text = "Loading.";
                Thread.Sleep(400);
                guna2HtmlLabel2.Refresh();
                guna2HtmlLabel2.Text = "Loading..";
                Thread.Sleep(400);
                guna2HtmlLabel2.Refresh();
                guna2HtmlLabel2.Text = "Loading...";
                Thread.Sleep(400);
                guna2HtmlLabel2.Refresh();
                Thread.Sleep(400);
                guna2HtmlLabel2.Text = "Retrieving certificates..";
                this.Hide();
                new LoginForm().ShowDialog();

            });



        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            Process.GetCurrentProcess().Kill();
        }
    }
}
