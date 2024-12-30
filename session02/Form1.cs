using session02.Utils;

namespace session02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonMiladiToJalali_Click(object sender, EventArgs e)
        {
            MessageBox.Show(DateUtil.MiladiToJalali(DateTime.Now));
        }
    }
    /*
     * class static
     * 
     *  global data
     *  utility
     */

}
