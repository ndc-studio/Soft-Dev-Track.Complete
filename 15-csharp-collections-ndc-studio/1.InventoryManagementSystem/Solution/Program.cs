using System;

namespace ImsSpace
{
    public class Program
    {
        public static void Main(string[] args)
        {
            /* Create a store */
            var store = new Store();

            /* Create items for the store */
            var kiwis = new Article("Kiwi", 15);
            var oranges = new Article("Orange", 9);
            var fraises = new Article("Fraises", 6);
            var framboises = new Article("Framboise", 60);
            var raisins = new Article("Raisin", 35);

            /* Add all items in the store */
            store.AddArticle(kiwis);
            store.AddArticle(oranges);
            store.AddArticle(fraises);
            store.AddArticle(framboises);
            store.AddArticle(raisins);

            /* Display all items of the store */
            store.Display();

            /* Display the items are low quantity (> 10) */
            store.LowCapacity();

            /* Exit system */
            Console.WriteLine("\n\n |    EXIT    | \n");
            Console.WriteLine("Press any key...");
            Console.ReadKey();
        }
    }
}