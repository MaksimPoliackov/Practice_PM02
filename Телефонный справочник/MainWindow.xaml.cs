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
using System.IO;
using Microsoft.Win32;
using System.Data;



namespace Телефонный_справочник
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            try
            {
                using (var db = new СправочникEntities1())
                {
                    Контакт contacts = new Контакт();

                    DGrid.ItemsSource = db.Группа_контактов.ToList();
                    DGrid.ItemsSource = db.Контакт.ToList();

                }
            }
            catch
            {
                MessageBox.Show("Ошибка БД");
            }
        }
        private SolidColorBrush hb = new SolidColorBrush(Colors.Orange);
        private SolidColorBrush nb = new SolidColorBrush(Colors.White);
        private void SpisokBtn_Click(object sender, RoutedEventArgs e)
        {

            try
            {
                using (var db = new СправочникEntities1())
                {
                    Контакт contacts = new Контакт();

                    DGrid.ItemsSource = db.Группа_контактов.ToList();
                    DGrid.ItemsSource = db.Контакт.ToList();

                    var contacts1 = db.Контакт.FirstOrDefault(s => s.ID_Группа_контактов == 3);

                    if (contacts1 != null)
                    {
                        //DGrid.ItemsSource = listconst.ToList();
                        //DGrid.RowBackground = new SolidColorBrush(Colors.Green);
                    }


                }
            }
            catch
            {
                MessageBox.Show("Ошибка БД");
            }
            

        }

        private void visibleform(object sender, DependencyPropertyChangedEventArgs e)
        {

        }

        private void BtnEdit_Click(object sender, RoutedEventArgs e)
        {
            using (var db = new СправочникEntities1())
            {
                AddEdit edit = new AddEdit();

                edit.cont = ((Контакт)DGrid.SelectedItem).ID;
                edit.Show();

            }
        }

        private void DeleteBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                using (var db = new СправочникEntities1())
                {
                    try
                    {
                        if (MessageBox.Show("Удалить запись?", "Удаление", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
                        {
                            int id = ((Контакт)DGrid.SelectedItem).ID;

                            Контакт cont = db.Контакт.Find(id);
                            db.Контакт.Remove(cont);
                            db.SaveChanges();
                            MessageBox.Show("Запись удалена");

                        }
                        else
                        {
                            MessageBox.Show("Запись не удалена");
                        }
                    }
                    finally
                    {
                        DGrid.ItemsSource = db.Группа_контактов.ToList();
                        DGrid.ItemsSource = db.Контакт.ToList();
                    }
                }
            }
            catch
            {
                MessageBox.Show("Ошибка с БД");
            }
            
        }

        private void AddBtn_Click(object sender, RoutedEventArgs e)
        {
            var Add = new AddWindow();

            Add.Show();
        }

        private void poiskBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string posikovik = poiskTB.Text;

                using (var db = new СправочникEntities1())
                {
                    List<Контакт> listconst = new List<Контакт>();
                    var contact1 = db.Контакт.FirstOrDefault(s => s.Фамилия == posikovik);
                    listconst.Add(contact1);

                    if (contact1 != null)
                    {
                        DGrid.ItemsSource = listconst.ToList();

                    }
                    else
                    {
                        MessageBox.Show("Введите фамилю");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void Export_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.FileName = "ExportData";
            save.Filter = "ExportData (*.csv)|*.csv";
            if (save.ShowDialog() == true)
            {
                using (var db = new СправочникEntities1())
                {
                    using (StreamWriter sw = new StreamWriter(File.Open(save.FileName, FileMode.Create), Encoding.GetEncoding(437)))
                    {
                        sw.WriteLine(DGrid.Items);

                    }
                }

            }

        }

    }
}
