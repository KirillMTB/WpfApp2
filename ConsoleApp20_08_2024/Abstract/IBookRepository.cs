using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp2.ConsoleApp20_08_2024.Enities;

namespace WpfApp2.ConsoleApp20_08_2024.Abstract
{
    public interface IBookRepository
    {
        Book GetBookByName(string name);
        (int curPage, int allPage, Book[] books) GetBooksByAuthor(Author author, int page = 1);
        bool CreateBook(Book book);
        bool EditBook(Book book);
        bool DeleteBook(Book book);
    }
}
