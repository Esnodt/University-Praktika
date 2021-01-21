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
    /// Логика взаимодействия для AddPage.xaml
    /// </summary>
    public partial class AddPage : Page
    {
        public AddPage()
        {
            InitializeComponent();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new MainPage());
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            MainInfoTable newMainInfoTable = new MainInfoTable();
            HeadOfTheDepartament newHeadOfTheDepartament = new HeadOfTheDepartament();
            Lesson newLesson = new Lesson();
            Teacher newTeacher = new Teacher();
            Classroom newClassroom = new Classroom();

            newHeadOfTheDepartament.NumberManager = Convert.ToInt32(tbNumberManager.Text);
            newHeadOfTheDepartament.NameManager = tbNameManager.Text;

            newTeacher.NumberTeacher = Convert.ToInt32(tbNumberTeacher.Text);
            newTeacher.FullName = tbFullnameTeacher.Text;
            newTeacher.TheAddress = tbAdress.Text;
            newTeacher.Position = comboPosition.Text;
            newTeacher.AcademicDegree = ComboAcademDegree.Text;

            newClassroom.NumberClassrom = Convert.ToInt32(tbNumberClassrom.Text);
            newClassroom.Party = (tbParty.Text);
            newClassroom.TheDateOfThe = (DateTime)tbTheDateOfThe.SelectedDate;
            newClassroom.LectureStartTime = (tbLectureStartTime.Text);
            newClassroom.LectureEndTime = tbLectureEndTime.Text;

            newLesson.NumberDiscipline = Convert.ToInt32(tbNumberDiscipline.Text);
            newLesson.DisciplineName = tbDisciplineName.Text;
            newLesson.NumberOfHours = Convert.ToInt32(tbNumberOfHours.Text);
            newLesson.ControlType = comboControlType.Text;
            newLesson.DisciplineSection = comboDisciplineSection.Text;

            dbContext.db.Teacher.Add(newTeacher);
            dbContext.db.Classroom.Add(newClassroom);
            dbContext.db.Lesson.Add(newLesson);
            dbContext.db.HeadOfTheDepartament.Add(newHeadOfTheDepartament);
            dbContext.db.MainInfoTable.Add(newMainInfoTable);

            newMainInfoTable.idTeacher = newHeadOfTheDepartament.ID;
            newMainInfoTable.idClassroom = newHeadOfTheDepartament.ID;
            newMainInfoTable.idLesson = newHeadOfTheDepartament.ID;
            newMainInfoTable.idHeadOfTheDepartament = newHeadOfTheDepartament.ID;



            dbContext.db.SaveChanges();

            MessageBox.Show("Вы добавили данные", "Уведомление");
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

    }
}
