using CustomList.Models;

namespace CustomList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Item item = new Item()
            {
                Name = "Tist",
            };
            Item item2 = new Item()
            {
                Name = "Teit",
            };
            GenericList<Item> genericList=new GenericList<Item>();
            genericList.Add(item);
            //Console.WriteLine(genericList.FindItem(item => item.Name.Contains("i")));
            genericList.FindAllItems(item => item.Name.Contains('i')).ForEach(item => Console.WriteLine(item));
        }
    }
}
