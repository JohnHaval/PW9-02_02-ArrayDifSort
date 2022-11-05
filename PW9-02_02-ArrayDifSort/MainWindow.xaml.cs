using CreatingArray;
using System;
using System.Windows;

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
                TableTab.Focus();
            }
            catch
            {
                MessageBox.Show("Некорректно введены значения строк или столбцов!", "Некорректность данных", MessageBoxButton.OK, MessageBoxImage.Error);
                ControlTab.Focus();
            }
        }

        private void FillArrayTable_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (VisualArrayTable.ItemsSource == null) throw new Exception();
                VisualArrayTable.ItemsSource = MainArrayTable.CreateTable(ArrayCreator.FillArray(MainArrayTable.GetArray(), new ArrayCreator.Range(Convert.ToInt32(FirstValue.Text), Convert.ToInt32(SecondValue.Text)))).DefaultView;
                TableTab.Focus();
            }
            catch
            {
                MessageBox.Show("Некорректно введены значения диапазона или массива не существует!", "Ошибка данных", MessageBoxButton.OK, MessageBoxImage.Error);
                ControlTab.Focus();
            }
        }

        private void ClearTable_Click(object sender, RoutedEventArgs e)
        {
            MainArrayTable.ClearTable();
            VisualArrayTable.ItemsSource = null;
            TableTab.Focus();
        }

        private void FirstWaySortToUpElements_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                VisualArrayTable.ItemsSource = MainArrayTable.CreateTable(ArraySorter.FirstWaySortToUpRowElements(MainArrayTable.GetArray())).DefaultView;
                TableTab.Focus();
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
                TableTab.Focus();
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
                TableTab.Focus();
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
                TableTab.Focus();
            }
            catch
            {
                ArrayIsEmpty();
            }
        }
        private void ArrayIsEmpty()
        {
            MessageBox.Show("Отсутствует массив для сортировки данных!", "Сортировка данных", MessageBoxButton.OK, MessageBoxImage.Error);
            ControlTab.Focus();
        }

        private void Help_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Разработчик: Лопаткин Сергей ИСП-41\n" +
                "GitHub.Name=HaproBishop\n" +
                "Задача. Задан двумерный массив размерности n x m. " +
                "Отсортировать элементы строк массива по возрастанию значений, а затем отсортировать строки массива по возрастанию среднего " +
                "арифметического элементов строк. " +
                "Реализовать сортировку разными способами и сравнить эффективность этих способов для разных исходных данных.", 
                "Справка", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}
