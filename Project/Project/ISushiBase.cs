namespace Project
{
    interface ISushiBase
    {
        void CreateSushi(Sushi sushi);
        Sushi GetSushiById(int id);
        void GetSushis();
        void UpdateSushi(Sushi sushi);        
    }
}
