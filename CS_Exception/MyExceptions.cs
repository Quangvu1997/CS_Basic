namespace MyExceptions
{
    public class NameEmptyException : Exception
    {
        public NameEmptyException() : base("Ten khac rong")
        {

        }
    }
    public class AgeException : Exception
    {
        public int age { get; set; }
        public AgeException(int _age) : base("Tuoi khong hop le")
        {
            age = _age;
        }
        public void Detail()
        {
            Console.WriteLine($"Tuoi = {age} khong nam trong khoang tu 18 den 100");
        }
    }
}