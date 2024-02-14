// Shaxmat doskasi
char [,] chess = new char [8,8];
for(int i = 0; i < 8; i++)
{
    for(int j = 0; j < 8; j++)
    {
        chess[i, j] = 'o';
    }
}
Console.WriteLine("Shaxmat o'yingiga xush kelibsiz");
Console.WriteLine("Quyidagilardan birini tanlang : ");
Console.WriteLine("1. Shoh");
Console.WriteLine("2. Farzin");
Console.WriteLine("3. Fil");
Console.WriteLine("4. Ot");
Console.WriteLine("5. Ruh");
Console.WriteLine("6. Piyoda");
string figure = Console.ReadLine();

Console.Write($"{figure} koordinatasini kiriting : ");
string coordinate = Console.ReadLine();
int x = Convert.ToInt32(coordinate[0]) - 65;
int y = Convert.ToInt32(coordinate[1]) - 48;

switch(figure)
{
    case "1":
        {
            for(int i = 0; i < 8; i++)
            {
                for(int j = 0; j < 8; j++)
                {
                    if(Math.Abs(i - x) + Math.Abs(j - y) <= 2)
                    {
                        chess[i, j] = '1';
                    }
                }
            }
        }
    break;
    case "2":
        {
            for(int i = 0; i < 8; i++)
            {
                for(int j = 0; j < 8; j++)
                {
                    if(Math.Abs(i - x) == Math.Abs(j - y) || i == x || j == y)
                    {
                        chess[i, j] = '1';
                    }
                }
            }
        }
    break;
    case "3":
        {
            for(int i = 0; i < 8; i++)
            {
                for(int j = 0; j < 8; j++)
                {
                    if(Math.Abs(i - x) == Math.Abs(j - y))
                    {
                        chess[i, j] = '1';
                    }
                }
            }
        }
    break;
    case "4":
        {
            for(int i = 0; i < 8; i++)
            {
                for(int j = 0; j < 8; j++)
                {
                    if((i - x) * (i - x) + (j - y) * (j - y) == 5)
                    {
                        chess[i, j] = '1';
                    }
                }
            }
        }
    break;
}
chess[x, y] = 'F';