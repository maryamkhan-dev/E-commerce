using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace my_project
{
    public partial class FirstScreen : Form
    {
        
        public FirstScreen()
        {
            InitializeComponent();
        }

        private void FirstScreen_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(progressBar1.Value<100)
            {
                progressBar1.Value += 1;
                loadingpercentage.Text = progressBar1.Value.ToString(); 
            }
            else
            {
                timer1.Stop();
                loadingpercentage.Visible = false;  
                progressBar1.Visible = false;   
                continueBtn.Visible = true;
            }
        }

        private void continueBtn_Click(object sender, EventArgs e)
        {
            ChooseUser cform = new ChooseUser();
            cform.ShowDialog();
            this.Close();
        }
    }
}
