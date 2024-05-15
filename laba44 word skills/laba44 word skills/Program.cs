// using ReadersNamespace; - пространство имен для класса Reader
// using StudentsNamespace; - пространство имен для класса Student
// using System; - пространство имен для класса Console

// Пространство имен для студентов
using ReadersNamespace;
using StudentsNamespace;

namespace StudentsNamespace
{
    // Класс студентов
    public class Student
    {
        // Открытые поля - доступны из любого места в программе
        public string FullName; // Полное имя студента
        public string GroupNumber; // Номер группы студента

        // Закрытое поле - доступно только внутри класса Student
        private int Age; // Возраст студента

        // Метод для вывода информации о студенте
        public void DisplayInfo()
        {
            Console.WriteLine($"Student: {FullName}, Group: {GroupNumber}, Age: {Age}");
        }
    }
}

// Пространство имен для читателей
namespace ReadersNamespace
{
    // Класс читателей
    public class Reader
    {
        // Закрытые поля - доступны только внутри класса Reader
        private string FullName; // Полное имя читателя
        private DateTime DateOfBirth; // Дата рождения читателя

        // Открытые поля - доступны из любого места в программе
        public int LibraryCardNumber; // Номер читательского билета
        public string Faculty; // Факультет читателя
        public string PhoneNumber; // Телефонный номер читателя

        // Метод для взятия книги(книг)
        public void takeBook(int numberOfBooks)
        {
            Console.WriteLine($"{FullName} взял {numberOfBooks} книги(книгу).");
        }

        // Метод для взятия книги(книг) по названиям
        public void takeBook(params string[] bookNames)
        {
            Console.Write($"{FullName} взял книги: ");
            foreach (var book in bookNames)
            {
                Console.Write(book + ", ");
            }
            Console.WriteLine();
        }

        // Метод для возврата книги(книг)
        public void returnBook(int numberOfBooks)
        {
            Console.WriteLine($"{FullName} вернул {numberOfBooks} книги(книгу).");
        }

        // Метод для возврата книги(книг) по названиям
        public void returnBook(params string[] bookNames)
        {
            Console.Write($"{FullName} вернул книги: ");
            foreach (var book in bookNames)
            {
                Console.Write(book + ", ");
            }
            Console.WriteLine();
        }
    }
}

// Класс для главной функции
class Program
{
    static void Main(string[] args)
    {
        // Массив студентов
        Student[] students = new Student[3];

        // Инициализация студентов
        students[0] = new Student { FullName = "Иванов И. И.", GroupNumber = "101" };
        students[1] = new Student { FullName = "Петров П. П.", GroupNumber = "102" };
        students[2] = new Student { FullName = "Сидоров С. С.", GroupNumber = "103" };

        // Массив читателей
        Reader[] readers = new Reader[3];

        // Инициализация читателей
        readers[0] = new Reader { LibraryCardNumber = 12345, Faculty = "Информационные технологии" };
        readers[1] = new Reader { LibraryCardNumber = 54321, Faculty = "Экономика" };
        readers[2] = new Reader { LibraryCardNumber = 98765, Faculty = "Медицина" };

        // Взятие книг первыми двумя читателями
        readers[0].takeBook("Приключения", "Роман");
        readers[1].takeBook(2);
    }
}
