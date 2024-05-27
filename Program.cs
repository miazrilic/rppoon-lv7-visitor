namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
        
                IItem DVDItemM =new DVD("The Matrix", DVDType.MOVIE, 15.0);
            IItem DVDItemS = new DVD("IDFASHFH", DVDType.SOFTWARE, 18.0);
            IItem VHSItem = new VHS("The Godfather", 12.0);
            IItem BookItem = new Book("C# Programming", 30.0);  
        
            List<IItem> items = new List<IItem>();
            items.Add(DVDItemM);
            items.Add(DVDItemS);
            items.Add(VHSItem);
            items.Add(BookItem);
            items.Add(VHSItem);
            IVisitor buyVisitor = new BuyVisitor();
            double totalPrice = 0;
            foreach (IItem item in items)
            {
                Console.WriteLine(item.ToString());
                Console.WriteLine("Price with tax: " + item.Accept(buyVisitor));
                totalPrice = totalPrice + item.Accept(buyVisitor);
            }
            Console.WriteLine("Total price: " + totalPrice);
        }
    }
}