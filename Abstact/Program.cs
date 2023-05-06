namespace ConsoleApp7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AppleTree AppleTree = new AppleTree(8, 6); AppleTree.OverallPriceOfFruits();
            Console.WriteLine(AppleTree.OverallPriceOfFruits()); BananaTree BananaTree = new BananaTree(7, 9);
            BananaTree.OverallPriceOfFruits(); Console.WriteLine(BananaTree.OverallPriceOfFruits());
            LemonTree LemonTree = new LemonTree(9, 6); LemonTree.OverallPriceOfFruits();
            Console.WriteLine(LemonTree.OverallPriceOfFruits());
        }
    }
}
