using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Задание 2
Создайте приложение «Список книг для прочтения» (поля: название, автор, количество страниц).
Приложение должно позволять добавлять книги в список, удалять книги из списка, проверять есть ли книга в списке, и т. д. 
Используйте механизм свойств, перегрузки операторов, индексаторов.*/

namespace Task2_HomeWork19_20
{
    class Program
    {
        public class Book //Книга
        {
            public string Author { get;  set; } //Название автора
            public int PageCount { get;  set; } //Количество страниц
            public Book(string Author, int PageCount)
            {
                this.Author = Author;
                this.PageCount = PageCount;
            }
            public static int operator +(Book book, int pageCount) //Перегрузка оператора +
            {
                book.PageCount += pageCount;
                return book.PageCount;
            }
            public override string ToString() => $"{Author}\t {PageCount} страниц";
        }

        public class Library //Библиотека
        {
            private readonly List<Book> books;
            private int FindAuthor(string author) //Проверка, есть ли книга с указанным автором в списке
            {
                for (int i = 0; i < books.Count; i++)
                {
                    if (books[i].Author == author)
                    {
                        return i;
                    }
                }
                return -1;
            }
            public Library(int size)
            {
                books = new List<Book>(size);
            }
            public int CountBooks
            {
                get { return books.Count; }
            }
            public Book this[int index]
            {
                get
                {
                    if (index >= 0 && index < books.Count)
                    {
                        return books[index];
                    }
                    throw new IndexOutOfRangeException("Выход за пределы массива");
                }
                set
                {
                    books.Add(value);
                }
            }
            public Book this[string author]
            {
                get
                {
                    if (FindAuthor(author) >= 0)
                        return this[FindAuthor(author)];
                    throw new Exception("Автора в списке нет");
                }
            }
            public void AddNewBook(Book newBook) //Добавление новой книги в список
            {
                if (FindAuthor(newBook.Author) >= 0)
                    Console.WriteLine("Автор уже есть в списке");
                else
                    books.Add(newBook);
            }
            public void RemoveBook(string author)
            {
                if (FindAuthor(author) >= 0)
                    books.Remove(books[FindAuthor(author)]);
                else
                    Console.WriteLine("Указанного автора в списке нет");
            }

        }
        static void Main(string[] args)
        {
            Library library = new Library(3);
            library[0] = new Book("Пушкин А.С.", 100);
            library[1] = new Book("Грибоедов А.С.", 200);
            library[2] = new Book("Толстой Л.Н.", 1000);
            Console.WriteLine("Библиотека");
            for (int i = 0; i < library.CountBooks; i++)
                Console.WriteLine(library[i]);
            Console.WriteLine("===============================================================");
            Console.WriteLine("Поиск автора Пушкин А.С.");
            Console.WriteLine(library["Пушкин А.С."]);
            Console.WriteLine("===============================================================");
            Console.WriteLine("Добавляем нового автора Маяковский В.В. 2000 страниц");
            library.AddNewBook(new Book("Маяковский В.В.", 2000));
            Console.WriteLine("Обновленная библиотека");
            for (int i = 0; i < library.CountBooks; i++)
                Console.WriteLine(library[i]);
            Console.WriteLine("===============================================================");
            Console.WriteLine("Удаляем автора Грибоедов А.С.");
            library.RemoveBook("Грибоедов А.С.");
            Console.WriteLine("Обновленная библиотека");
            for (int i = 0; i < library.CountBooks; i++)
                Console.WriteLine(library[i]);
            Console.WriteLine("===============================================================");
            Console.WriteLine("Увеличим количество страниц у автора книги Пушкин А.С. на 5000");
            Console.WriteLine($"Итоговое количество у данной книги будет  {library["Пушкин А.С."] + 5000}"); 
            Console.WriteLine("Обновленная библиотека");
            for (int i = 0; i < library.CountBooks; i++)
                Console.WriteLine(library[i]);
            Console.ReadKey();
        }
    }
}
