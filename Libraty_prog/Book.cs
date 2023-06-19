namespace Libraty_prog
{
    public class Book
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
        public string Category { get; set; }
        public string Deseription { get; set; }
        public Guid? Reader { get; set; }
        public Book(string name, string description, string author)
        {
            Id = Guid.NewGuid();
            Name = name;
            Deseription = description;
            Author = author;
        }
    }
}
