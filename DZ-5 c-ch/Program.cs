namespace DZ_5_c_ch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //задание 1
            Book Bk1 = new Book("Стихи", "С.Есенин", 200, 1998);
            Book Bk2 = new Book("Рассказы", "Л.Н.Толстой", 120, 2004);
            Book Bk3 = new Book("Анна Каренина", "Л.Н.Толстой", 320, 2024);
            Book Bk4 = new Book("Басни", "Крылов", 50, 2002);

            list_of_books listOfBooks = new list_of_books(2);
            listOfBooks.AddBook(Bk1);
            listOfBooks.AddBook(Bk2);
            listOfBooks.AddBook(Bk3);
            listOfBooks.AddBook(Bk4);

            listOfBooks.RemoveBook(Bk3);

            //задание 2
            MyMatrix a = new MyMatrix(1, 4, 3, 2, 1, 5, 3, 2, 1);
            MyMatrix b = new MyMatrix(5, 2, 1, 4, 3, 2, 2, 1, 5);
           // MyMatrix c = a*2;
            //c.Info();
            Console.WriteLine();
            MyMatrix d = a * b;
            d.Info();
            Console.WriteLine();
            MyMatrix f = b * a;
            f.Info();
            Console.WriteLine();
            MyMatrix g = a + b;
            g.Info();
            Console.WriteLine();
            MyMatrix h = a - b;
            h.Info();


        }
    }

    //    1. Создайте приложение «Список книг для прочтения».
    //Приложение должно позволять добавлять книги в список, удалять книги из списка, проверять есть ли книга в
    //списке, и т.д.Используйте механизм свойств, перегрузки
    //операторов, индексаторов.
    //2. Ранее в одном из практических заданий вы создавали
    //класс «Матрица». Выполните перегрузку + (для сложения матриц), – (для вычитания матриц). * (умножение
    //матриц друг на друга, умножение матрицы на число), ==
    //(проверка матриц на равенство), != и Equals.Используйте
    //механизм свойств для полей класса.Также используйте
    //механизм индексаторов.

    //И если следует сравнивать два сложных объекта, как в данном случае,
    //то лучше использовать метод Equals, а не стандартную операцию ==.


}
