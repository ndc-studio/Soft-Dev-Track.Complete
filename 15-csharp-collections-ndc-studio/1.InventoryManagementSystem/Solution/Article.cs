namespace ImsSpace
{
    public struct Article
    {
        public string Name { get; set; }
        public int Quantity { get; set; }

        public Article(string name, int quantity)
        {
            Name = name;
            Quantity = quantity;
        }
    }
}