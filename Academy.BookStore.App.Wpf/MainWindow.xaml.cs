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
using Academy.BookStore.Entities.Models;
using Academy.BookStore.Services;

namespace Academy.BookStore.App.Wpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly IBookService _bookService;
        private ViewModel vm;
        public MainWindow(IBookService bookService)
        {
            InitializeComponent();
            _bookService = bookService ?? throw new ArgumentNullException(nameof(bookService));
            vm = new(_bookService);
            DataContext = vm;
        }

        private void insertBook(object sender, RoutedEventArgs e)
        {

        }

        private void updateBook(object sender, RoutedEventArgs e)
        {

        }

        private void cancelBook(object sender, RoutedEventArgs e)
        {

        }

        private void ComboBox_DropDownClosed(object sender, EventArgs e)
        {

        }

        private void BookList_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            var s = sender;
            
        }

        private void ComboBox_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            var s = sender as ComboBox;
            Store store = s.SelectedValue as Store;
            vm.ShowStore = store;

        }
    }
}