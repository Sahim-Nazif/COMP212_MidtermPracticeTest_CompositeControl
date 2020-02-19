using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP212_MidtermPracticeTest_CompositeControl
{
    public partial class UserCompositeControl : UserControl
    {

        public RadioButton Male
        {
            get => rdbtnMale;
        }
        public RadioButton Female
        {
            get => rdbtnFemale;
        }

        public UserCompositeControl()
        {
            InitializeComponent();
        }
    }
}
