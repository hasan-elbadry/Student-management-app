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
    /// Interaction logic for SearchPage.xaml
    /// </summary>
    public partial class SearchPage : Page
    {
        UniveristyEntities1 db=new UniveristyEntities1();
        public SearchPage()
        {
            InitializeComponent();
            combo.ItemsSource = db.student_table.Select(x=>x.stu_department).Distinct().ToList();
            
        }

        private void combo_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            datagridd.ItemsSource =7null;
        }

        private void search_btn_Click(object sender, object e)
        {
            var dep = combo.SelectedItem;
            if (dep==null) {
                dep = "";

            }      
                datagridd.ItemsSource = db.student_table.Where(x => x.stu_name.Contains(search_txt.Text)).ToList();
        }
    }
}
