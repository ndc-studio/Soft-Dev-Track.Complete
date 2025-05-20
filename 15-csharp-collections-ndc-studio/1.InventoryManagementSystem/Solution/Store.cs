namespace ImsSpace
{
    public class Store
    {
        public SortedDictionary<string, int> Articles { get; set; }

        public Store()
        {
            Articles = new SortedDictionary<string, int>();
        }

        public void AddArticle(Article article)
        {
            if (Articles.ContainsKey(article.Name))
            {
                Articles[article.Name] += article.Quantity;
            }
            else
            {
                Articles.Add(article.Name, article.Quantity);
            }
        }

        public void RemoveArticle(string name)
        {
            if (Articles.ContainsKey(name))
            {
                Articles.Remove(name);
            }
        }

        public void LowCapacity()
        {
            Console.WriteLine("\n\n--------------------\n");
            foreach (var item in Articles)
            {
                if (item.Value < 10)
                {
                    Console.WriteLine($"The quantity of {item.Key} is too low!\nQuantity = {item.Value}\n");
                }
            }
            Console.WriteLine("--------------------\n");
        }
        public void Display()
        {
            Console.WriteLine("\n--------------------");
            Console.WriteLine("\n| Stock of store |");
            Console.WriteLine("\n--------------------");
            foreach (var item in Articles)
            {
                Console.WriteLine($"\n•{item.Key}: {item.Value}");
            }
            Console.WriteLine("\n--------------------");
        }
    }
}