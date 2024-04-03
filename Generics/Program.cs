using System.ComponentModel.DataAnnotations;

namespace Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BoxCollection BoxList = new BoxCollection();


            BoxList.Add(new Box(10,10,10));
            BoxList.Add(new Box(50,50,50));
            BoxList.Add(new Box(10,15,25));
            BoxList.Add(new Box(18,13,11));
            BoxList.Add(new Box(18,18,17));
            
            
            BoxList.Add(new Box(18,18,17));
            Console.WriteLine("------------------------");
            Console.WriteLine("Some boxes from the list");
            Display(BoxList);
            Console.WriteLine("Amout of Boxes in the list: " + BoxList.Count);
            Console.WriteLine("------------------------");
            

            BoxList.Remove(new Box(10,10,10));
            Console.WriteLine("Boxes after removing a box");
            Display(BoxList);
            Console.WriteLine("Amout of Boxes in the list: " + BoxList.Count);


            var BoxContains = BoxList.Contains(new Box(10, 15, 25));
            Console.WriteLine($"\nDoes box (10, 15, 25) exist in the collection? {BoxContains}");
            Console.ReadKey();


            void Display(BoxCollection BoxList)
            {
                foreach (Box box in BoxList)
                {
                    Console.WriteLine($"Box Height:" +
                        $" {box.height}," +
                        $"Box Lenght: {box.lenght}," +
                        $" Box Width: {box.width}, " +
                        $"Box Volume: {box.volym}");
                }
            }
        }
    }
}