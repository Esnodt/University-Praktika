   M S B A M L   `   `   `  ����E  AUniversity, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:University.PagesUniversity.Pages  5          University.Pages.MainPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      0localclr-namespace:University.Pages     5      -   5          N� Title$4  .База данных университета��5	      .��5      � .+�5   
   �� $��/back/fon.png��6   $
��Fill=�6'   � 5   
    � RowDefinitions 5      �� 5      $��60 �6    6.   �� 5      $	��500 �6    6/   .+�5      �� $
��Left=�5      $��Center=�5       �� Orientation$ 
Horizontal=�5      .+�5      �� -   5         ��Name$ 	ButtonAdd��5   ,   $��Добавить��6   6?   �� 5      -   5        $ 
ButtonEdit��5   1   $ ��Редактировать��6   6E   �� 5!      -   5        $ 
ButtonInfo��5!   -   $��Подробнее��6   6\   �� 5#      $��Поиск:��6   $��	20 10 0 0q�6*   $��14(�6=   �� 5$      -   5         ��Name$ textboxSearch��5$      $��0 0 20 0q�61   $	��200��6C   6O   �� 5&      -   5        $ ButtonDelete��5&   +   $��Удалить��6   
���  ��6S   5(      &   System.Windows.Controls.DataGrid  5*      -   5          Name$ 	MainTable��5*   $   $��1��6      AutoGenerateColumns .  
�������
���   �   Columns 5,      0  *System.Windows.Controls.DataGridTextColumn  5.      ,  &System.Windows.Controls.DataGridColumn   Header$ Номер группы��5/      	   Width5  /System.Windows.Controls.DataGridLengthConverter$	 * 50      1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 51      �� *Classroom.Party+52        55      $' !ФИО преподавателя��56      $	 * 57      
 58      �� *Teacher.FullName+59        5;      $3 -Должность преподавателя��5<      $	 * 5=   %   
 5>      �� *Teacher.Position+5?        5A      $	 * 5B   #   $+ %Название дисциплины��5C      
 5D      �� *Lesson.DisciplineName+5E        5G      $	 * 5H       $# Номер аудитории��5I      
 5J      �� *Classroom.NumberClassrom+5K        5M      $	 * 5N      $! Тип дисциплины��5O      
 5P      �� *Lesson.DisciplineSection+5Q        5S      $0 *Дата проведения лекции��5T      $	 * 5U      
 5V      �� *Classroom.TheDateOfThe+ �� StringFormat$ {0:dd MMMM yyyy}��5W        5Y      $	 * 5Z      $* $Время начала лекции��5[      
 5\      �� *Classroom.LectureStartTime+5]        5_      $	 * 5`   !   $0 *Время окончания лекции��5a      
 5b      �� *Classroom.LectureEndTime+5c      5f      5h      5j      5k      