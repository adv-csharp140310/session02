using MD.PersianDateTime;
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
            var persianDateTime = new PersianDateTime(DateTime.Now);
            PersianDateTime.Parse(persianDateTime.ToString());

            MessageBox.Show(DateUtil.MiladiToJalali(DateTime.Now));
        }

        private void buttonJalaliMonth_Click(object sender, EventArgs e)
        {
            MessageBox.Show(DateUtil.GetJalaliMonthName(DateTime.Now));
        }

        private void buttonJalaliSeason_Click(object sender, EventArgs e)
        {
            MessageBox.Show(DateUtil.GetJalaliSeason(DateTime.Now));
        }

        private void buttonJalaliToMiladi_Click(object sender, EventArgs e)
        {
            string date = DateUtil.MiladiToJalali(DateTime.Now);
            MessageBox.Show(DateUtil.JalaliToMiladi(date).ToLongDateString());
        }
    }
    /*
     * class static
     * 
     *  global data
     *  utility
     */

}
