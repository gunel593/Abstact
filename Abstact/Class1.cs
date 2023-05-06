using ConsoleApp7;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ConsoleApp7
{
    public abstract class Tree
    {
        protected int pricePerTree;
        protected int countofFruit; public abstract int OverallPriceOfFruits();
        public Tree(int countOfFruit, int pricePerTree)
        {
            this.countofFruit = countOfFruit; this.pricePerTree = pricePerTree;
        }
    }
    public class AppleTree : Tree
    {
        public override int OverallPriceOfFruits()
        {
            return countofFruit * pricePerTree;
        }
        public AppleTree(int countOfFruit, int pricePerTree) : base(countOfFruit, pricePerTree)
        {
            this.countofFruit = countOfFruit; this.pricePerTree = pricePerTree;
        }
    }

    public class BananaTree : Tree
    {
        public override int OverallPriceOfFruits()
        {
            return countofFruit * pricePerTree;
        }
        public BananaTree(int countOfFruit, int pricePerTree) : base(countOfFruit, pricePerTree)
        {
            this.countofFruit = countOfFruit;
            this.pricePerTree = pricePerTree;
        }
    }
    public class LemonTree : Tree
    {
        public override int OverallPriceOfFruits()
        {
            return countofFruit * pricePerTree;
        }
        public LemonTree(int countOfFruit, int pricePerTree) : base(countOfFruit, pricePerTree)
        {
            this.countofFruit = countOfFruit;
            this.pricePerTree = pricePerTree;
        }
    }
}
