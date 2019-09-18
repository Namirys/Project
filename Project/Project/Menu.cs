namespace Project
{
    public class Menu
    {
        public static SushiBase MenuCreate(SushiBase sushiBase)
        {
            Sushi Xoco = new Sushi("Хосомаки", 250.0f,8);
            sushiBase.CreateSushi(Xoco);

            Sushi Futo = new Sushi("Футомаки", 210.0f,8);
            sushiBase.CreateSushi(Futo);

            Sushi Yro = new Sushi("Урамаки", 80.0f,2);
            sushiBase.CreateSushi(Yro);

            Sushi Osi = new Sushi("Осидзуси", 80.0f,2);
            sushiBase.CreateSushi(Osi);

            Sushi Ina = new Sushi("Инари", 300.0f,2);
            sushiBase.CreateSushi(Ina);

            Sushi Tira = new Sushi("Тираси-дзуси", 550.0f,1);
            sushiBase.CreateSushi(Tira);

            Sushi Nar = new Sushi("Нарэдзуси", 280.0f,8);
            sushiBase.CreateSushi(Nar);

            Sushi Tem = new Sushi("Темаки", 100.0f,2);
            sushiBase.CreateSushi(Tem);

            return sushiBase;
        }
    }
}
