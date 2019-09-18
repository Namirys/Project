namespace Project
{
    interface IOrderCreate
    {
        void AddSushiInOrder(Sushi sushi);

        void GetSushisInOrder();

        void UpdateSushiInOrder(int id, SushiBase sushis);
    }
}
