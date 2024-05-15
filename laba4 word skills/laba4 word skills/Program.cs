namespace student
{
    class Student
    {
        public string name = "Untitled";
        public string group = "Untitled";
        private int age = 0;
        public Student(string name, string group, int age)
        {
            this.name = name;
            this.group = group;
            this.age = age;
        }
        public void Print()
        {
            Console.WriteLine($"{name}, Группа: {group},Возраст{age}");
        }
    }
}

namespace reader
{
    class Reader
    {
        public string name = "Untitled";
        public int number_library_card = 0;
        public string faculty = "Untitled";
        private DateTime date_of_birth;
        public string telephone = "Untitled";
        public Reader(string name, int number_library_card, string faculty, DateTime date_of_birth, string telephone)
        {
            this.name = name;
            this.number_library_card = number_library_card;
            this.faculty = faculty;
            this.date_of_birth = date_of_birth;
            this.telephone = telephone;
        }
        public void takeBook(string name, int number_book)
        {
            Console.WriteLine($"{name}, взял {number_book} книг");
        }
        public void takeBook(params string[] books)
        {
            Console.Write($"{name}, взял книги:");
            foreach (string book in books)
            {
                Console.Write(book + ",");
            }
            Console.WriteLine();
        }
        public void returnBook(string name, int number_book)
        {
            Console.WriteLine($"{name}, вернул {number_book} книг");
        }
        public void returnBook(params string[] books)
        {
            Console.Write($"{name}, вернул книги:");
            foreach (string book in books)
            {
                Console.Write(book + ",");
            }
            Console.WriteLine();
        }
    }
}