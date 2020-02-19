using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP212_MidtermPracticeTest_CompositeControl
{
    public partial class Form1 : Form
    {

        public string name;
        public int age;
        bool convertingAgetoInteger;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDiscount_Click(object sender, EventArgs e)
        {
            name = txtName.Text;
            convertingAgetoInteger = int.TryParse(txtAge.Text, out age);

            if (userCompositeControl1.Male.Checked==true)
            {
             if (age==18 || age<=25)
                {
                    MessageBox.Show("Hi " + name + "You are " + age + " years old " + userCompositeControl1.Male.Text + " and therefore, your discount rate is 20%");
                }
             else if (age >=26)
                {
                    MessageBox.Show("Hi " + name + "You are  " + age + " years old " + userCompositeControl1.Male.Text + " and therefore, your discount rate is 22% ");
                }
            }
            
            else if(userCompositeControl1.Female.Checked==true)
            {
                lblshow.Text = userCompositeControl1.Female.Text;
            }

            
        }
    }
}
