using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using Academy.BookStore.Entities.Models;
using Academy.BookStore.Services;

namespace Academy.BookStore.App.Wpf
{
    public class ViewModel : INotifyPropertyChanged
    {

        public List<Book> books;
        public ViewModel(IBookService bs)
        {
            books = (List<Book>)bs.GetAll();
        }

        public List<Book> Books
        {
            get { return books; }
            set { books = value; }
        }

        private string book_Title;
        public string Book_Title
        {
            get { return book_Title; }
            set
            {
                book_Title = value;
                OnPropertyChanged(nameof(Book_Title));
            }
        }


        private string bookPublishingYear;
        public string BookPublishingYear
        {
            get { return bookPublishingYear; }
            set
            {
                bookPublishingYear = value;
                OnPropertyChanged(nameof(BookPublishingYear));
            }
        }

        private string pagesCount;
        public string PagesCount
        {
            get { return pagesCount; }
            set
            {
                pagesCount = value;
                OnPropertyChanged(nameof(PagesCount));
            }
        }

        private string authorsFirstName;
        public string AuthorsFirstName
        {
            get { return authorsFirstName; }
            set { authorsFirstName = value; OnPropertyChanged(nameof(AuthorsFirstName)); }
        }

        private string authorsLastName;
        public string AuthorsLastName
        {
            get { return authorsLastName; }
            set { authorsLastName = value; OnPropertyChanged(nameof(AuthorsLastName)); }
        }

        private string storeName;
        public string StoreName
        {
            get { return storeName; }
            set { storeName = value; OnPropertyChanged(nameof(StoreName)); }
        }

        private string addressName;
        public string AddressName
        {
            get { return addressName; }
            set { addressName = value; OnPropertyChanged(nameof(AddressName)); }
        }




        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
