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
    /// Логика взаимодействия для MainPage.xaml
    /// </summary>
    public partial class MainPage : Page
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            MainTable.ItemsSource = dbContext.db.MainInfoTable.ToList();
        }

        private void ButtonAdd_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AddPage());
        }

        private void ButtonInfo_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                MainInfoTable MoreInfo = (MainInfoTable)MainTable.SelectedItem;
                if (MoreInfo != null)
                {
                    NavigationService.Navigate(new MoreInfoPage(MoreInfo));
                }
                else
                {
                    throw new Exception("Вы не выбрали не одного элемента");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }





        private void ButtonEdit_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                MainInfoTable EditWork = (MainInfoTable)MainTable.SelectedItem;
                if (EditWork != null)
                {
                    NavigationService.Navigate(new EditPage(EditWork));
                }
                else
                {
                    throw new Exception("Вы не выбрали не одного элменента!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void textboxSearch_TextChanged(object sender, TextChangedEventArgs e)
        {

            MainTable.ItemsSource = dbContext.db.MainInfoTable.Where(item => item.Teacher.FullName.Contains(textboxSearch.Text)
           || item.Classroom.Party.ToString().Contains(textboxSearch.Text)
           || item.Lesson.DisciplineName.ToString().Contains(textboxSearch.Text)
           || item.Classroom.TheDateOfThe.ToString().Contains(textboxSearch.Text)
           || item.HeadOfTheDepartament.NameManager.ToString().Contains(textboxSearch.Text)).ToList();

        }

        private void ButtonDelete_Click(object sender, RoutedEventArgs e)
        {

            try
            {
                MainInfoTable deleteWork = (MainInfoTable)MainTable.SelectedItem;
                if (MessageBox.Show(messageBoxText: "Вы действительно хотите удалить выбранную строку?", "Уведомление", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                {
                    if (deleteWork != null)
                    {
                        dbContext.db.MainInfoTable.Remove(deleteWork);
                        dbContext.db.SaveChanges();
                        Page_Loaded(sender: null, e: null);
                        MessageBox.Show("Вы удалили строку", "Оповещание", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                    else
                        throw new Exception(message: "Вы не выбрали строку которые хотите удалить!");
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
 