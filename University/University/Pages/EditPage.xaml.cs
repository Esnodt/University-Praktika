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
    /// Логика взаимодействия для EditPage.xaml
    /// </summary>
    public partial class EditPage : Page
    {

        private MainInfoTable selecteditems;
        public EditPage(MainPage editWork)
        {
            InitializeComponent();
            
        }

        public EditPage(MainInfoTable selecteditems)
        {
        InitializeComponent();
            this.selecteditems = selecteditems;
            tbNumberManager.Text = Convert.ToString(selecteditems.HeadOfTheDepartament.NumberManager);
            tbNameManager.Text = selecteditems.HeadOfTheDepartament.NameManager;

            tbNumberTeacher.Text = Convert.ToString(selecteditems.Teacher.NumberTeacher);
            tbFullnameTeacher.Text = selecteditems.Teacher.FullName;
            tbAdress.Text = selecteditems.Teacher.TheAddress;
            comboPosition.Text = selecteditems.Teacher.Position;
            ComboAcademDegree.Text = selecteditems.Teacher.AcademicDegree;

            tbNumberClassrom.Text = Convert.ToString(selecteditems.Classroom.NumberClassrom);
            tbParty.Text = Convert.ToString(selecteditems.Classroom.Party);
            tbTheDateOfThe.Text = Convert.ToString(selecteditems.Classroom.TheDateOfThe);
            tbLectureStartTime.Text = selecteditems.Classroom.LectureStartTime;
            tbLectureEndTime.Text = selecteditems.Classroom.LectureEndTime;

            tbNumberDiscipline.Text = Convert.ToString(selecteditems.Lesson.NumberDiscipline);
            tbDisciplineName.Text = selecteditems.Lesson.DisciplineName;
            tbNumberOfHours.Text = Convert.ToString(selecteditems.Lesson.NumberOfHours);
            comboControlType.Text = selecteditems.Lesson.ControlType;
            comboDisciplineSection.Text = selecteditems.Lesson.DisciplineSection;
        }


        private void EditButton_Click(object sender, RoutedEventArgs e)
        {
            MainInfoTable Save = dbContext.db.MainInfoTable.FirstOrDefault(Item => Item.ID == selecteditems.ID);

            Save.HeadOfTheDepartament.NumberManager = Convert.ToInt32(tbNumberManager.Text);
            Save.HeadOfTheDepartament.NameManager = tbNameManager.Text;

            Save.Teacher.NumberTeacher = Convert.ToInt32(tbNumberTeacher.Text);
            Save.Teacher.FullName = (tbFullnameTeacher.Text);
            Save.Teacher.TheAddress = (tbAdress.Text);
            Save.Teacher.Position = (comboPosition.Text);
            Save.Teacher.AcademicDegree = (ComboAcademDegree.Text);

            Save.Classroom.NumberClassrom = Convert.ToInt32(tbNumberClassrom.Text);
            Save.Classroom.Party = (tbParty.Text);
            Save.Classroom.TheDateOfThe = (DateTime)tbTheDateOfThe.SelectedDate;
            Save.Classroom.LectureStartTime = tbLectureStartTime.Text;
            Save.Classroom.LectureEndTime = tbLectureEndTime.Text;

            Save.Lesson.NumberDiscipline = Convert.ToInt32(tbNumberDiscipline.Text);
            Save.Lesson.DisciplineName = (tbDisciplineName.Text);
            Save.Lesson.NumberOfHours = Convert.ToInt32(tbNumberOfHours.Text);
            Save.Lesson.ControlType = (comboControlType.Text);
            Save.Lesson.DisciplineSection = (comboDisciplineSection.Text);

            dbContext.db.SaveChanges();
            MessageBox.Show("Вы изменили данные!", "Изменение", MessageBoxButton.OK, MessageBoxImage.Information);
            NavigationService.GoBack();
        }

        private void ClearButton_Click(object sender, RoutedEventArgs e)
        {
            tbNumberManager.Text = "";
            tbNameManager.Text = "";
            tbNumberTeacher.Text = "";
            tbFullnameTeacher.Text = "";
            tbAdress.Text = "";
            comboPosition.Text = "";
            ComboAcademDegree.Text = "";
            tbNumberClassrom.Text = "";
            tbParty.Text = "";
            tbTheDateOfThe.Text = "";
            tbLectureStartTime.Text = "";
            tbLectureEndTime.Text = "";
            tbNumberDiscipline.Text = "";
            tbDisciplineName.Text = "";
            tbNumberOfHours.Text = "";
            comboControlType.Text = "";
            comboDisciplineSection.Text = "";
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
    }
}
