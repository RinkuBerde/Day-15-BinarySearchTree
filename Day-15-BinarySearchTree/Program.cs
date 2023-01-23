namespace Day_15_BinarySearchTree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Binary Search Tree Practice problems!!!");
            Console.WriteLine("\n1. Create Binary Search Tree byadding 56 and then adding 30 & 70");
            Console.Write("Enter your choice : ");
            int option = Convert.ToInt32(Console.ReadLine());
            BinarySearchTree<int> binarySearch = new BinarySearchTree<int>(56);
            switch (option)
            {
                case 1:
                    binarySearch.Insert(30);
                    binarySearch.Insert(70);
                    binarySearch.Display();
                    break;
                default:
                    Console.WriteLine("Enter valid option!!!");
                    break;
            }
            Console.ReadLine();
        }
    }
}
    
