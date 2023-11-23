using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ficality
{
    /// <summary>
    /// Interaction logic for HomePage.xaml
    /// </summary>
    public partial class HomePage : Page
    {
        public HomePage()
        {
            InitializeComponent();
        }
        UniveristyEntities1 db=new UniveristyEntities1();
        private void opendata_btn_Click(object sender, RoutedEventArgs e)
        {
            SearchPage searchPage = new SearchPage();
            this.NavigationService.Navigate(searchPage);
        }

        private void savedata_btn_Click(object sender, RoutedEventArgs e)
        {
            student_table student= new student_table();
            if (name_txt.Text != "")
            {
                student.stu_name = name_txt.Text;
                student.stu_age = age_txt.Text;
                student.stu_address = adress_txt.Text;
                student.stu_department = department_txt.Text;
                db.student_table.Add(student);
                db.SaveChanges();
                MessageBox.Show("successful add");
            }
            else
            {
                MessageBox.Show("please enter data");
            }
        }
    }
}
