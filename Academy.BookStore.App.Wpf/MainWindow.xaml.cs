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
using Academy.BookStore.Services;

namespace Academy.BookStore.App.Wpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly IBookService _bookService;
        public MainWindow(IBookService bookService)
        {
            InitializeComponent();
            _bookService = bookService ?? throw new ArgumentNullException(nameof(bookService));
            ViewModel vm = new(_bookService);

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


    }
}