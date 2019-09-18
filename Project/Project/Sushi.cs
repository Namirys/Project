namespace Project
{
    public class Sushi : ISushi
    {
        public int Id { get; set; }
        public string Name { get; set; }        
        public float Cost { get; set; }
        public int Piece { get; set; }        
        public Sushi(string name,float cost, int piece)
        {
            Name = name;            
            Cost = cost;
            Piece = piece;            
        }
    }
}
