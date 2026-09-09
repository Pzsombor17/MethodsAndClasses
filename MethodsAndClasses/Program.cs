namespace MethodsAndClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book("Bogyó és Babóca", "nincs infó ", 300);
            Book book2 = new Book("Harry Potter", "nincs infóm", -200);
            Console.WriteLine(book1.Title,book2.Title);

            book1.Describe();
            book2.Describe();
            book1.IsLong();
            book2.IsLong();

            Book book3 = new Book("A kis herceg", "nincs infó");
            book2.Borrow();

        }
    }
}
