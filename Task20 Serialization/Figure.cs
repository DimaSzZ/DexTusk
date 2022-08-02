namespace Task20_Serialization
{
    [Serializable]
    public class Figure
    {
        public Figure(string name,int square)
        {
            Name = name;
            Square = square;
        }
        public Figure() {}
        public string? Name { get; set; }
        public int Square { get; set; }
        public ListFigure? lstFigure { get; set; }
    }
}
