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
using CreatingArray;

namespace PW9_02_02_ArrayDifSort
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        VisualArray MainArrayTable = new VisualArray();
        private void CreateArrayTable_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                VisualArrayTable.ItemsSource = MainArrayTable.CreateTable(ArrayCreator.CreateArray(Convert.ToInt32(RowCount.Text), Convert.ToInt32(ColumnCount.Text))).DefaultView;
            }
            catch
            {
                MessageBox.Show("Некорректно введены значения строк или столбцов!", "Некорректность данных", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void FillArrayTable_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                VisualArrayTable.ItemsSource = MainArrayTable.CreateTable(ArrayCreator.FillArray(MainArrayTable.GetArray(), new ArrayCreator.Range(Convert.ToInt32(RowCount.Text), Convert.ToInt32(ColumnCount.Text)))).DefaultView;
            }
            catch
            {
                MessageBox.Show("Некорректно введены значения строк или столбцов!", "Некорректность данных", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void ClearTable_Click(object sender, RoutedEventArgs e)
        {
            VisualArrayTable.ItemsSource = MainArrayTable.ClearTable().DefaultView;
        }

        private void FirstWaySortToUpElements_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                VisualArrayTable.ItemsSource = MainArrayTable.CreateTable(ArraySorter.FirstWaySortToUpRowElements(MainArrayTable.GetArray())).DefaultView;
            }
            catch
            {
                ArrayIsEmpty();
            }
        }

        private void SecondWaySortToUpElements_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                VisualArrayTable.ItemsSource = MainArrayTable.CreateTable(ArraySorter.SecondWaySortToUpRowElements(MainArrayTable.GetArray())).DefaultView;
            }
            catch
            {
                ArrayIsEmpty();
            }
        }

        private void FirstWaySortToUpRowsOnAvg_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                VisualArrayTable.ItemsSource = MainArrayTable.CreateTable(ArraySorter.FirstWaySortToUpRowsOnAvgElements(MainArrayTable.GetArray())).DefaultView;
            }
            catch
            {
                ArrayIsEmpty();
            }
        }

        private void SecondWaySortToUpRowsOnAvg_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                VisualArrayTable.ItemsSource = MainArrayTable.CreateTable(ArraySorter.SecondWaySortToUpRowsOnAvgElements(MainArrayTable.GetArray())).DefaultView;
            }
            catch
            {
                ArrayIsEmpty();
            }
        }
        private void ArrayIsEmpty()
        {
            MessageBox.Show("Отсутствует массив для сортировки данных!", "Сортировка данных", MessageBoxButton.OK, MessageBoxImage.Error);
        }
    }
}
