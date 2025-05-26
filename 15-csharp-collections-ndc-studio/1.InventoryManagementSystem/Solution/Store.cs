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

        public string LowCapacity()
        {
            foreach (var item in Articles)
            {
                if (item.Value < 10)
                {
                    return $"The quantity of {item.Key} is too low!\nQuantity = {item.Value}\n";
                }
            }
            return "";
        }
        public string Display()
        {
            foreach (var item in Articles)
            {
                return $"\n•{item.Key}: {item.Value}";
            }
            return "";
        }
    }
}