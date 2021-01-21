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
using University.Context;
using University.SQL;

namespace University.Pages
{
    /// <summary>
    /// Логика взаимодействия для MoreInfoPage.xaml
    /// </summary>
    public partial class MoreInfoPage : Page
    {

        private MainInfoTable selecteditem;
        public MoreInfoPage (MainInfoTable selecteditem)
        
        {
            InitializeComponent();
            this.selecteditem = selecteditem;
        }

    

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            MainTableMoreInfo.ItemsSource = dbContext.db.MainInfoTable.Where(item => item.idLesson == selecteditem.Lesson.ID && item.idClassroom == selecteditem.Classroom.ID && item.idHeadOfTheDepartament == selecteditem.HeadOfTheDepartament.ID && item.idTeacher == selecteditem.Teacher.ID).ToList();
        }



        private void ButtonBack_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

    }
}
