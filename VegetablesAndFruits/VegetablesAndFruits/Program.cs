using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
//using System.Runtime.Intrinsics.Arm;

void DoCommand(SqlCommand selectcommand)
{
    SqlDataReader rdr = selectcommand.ExecuteReader();
    int count = 0;
    while (rdr.Read())
    {
        //Console.WriteLine(rdr[1] + " " + rdr[2]);
        //Console.WriteLine(rdr["FirstName"] + " " + rdr["LastName"]);
        if (count++ == 0)
        {
            for (int i = 0; i < rdr.FieldCount; i++)
            {
                Console.Write(rdr.GetName(i).ToString() + "\t");
            }
            Console.WriteLine();
        }



        for (int i = 0; i < rdr.FieldCount; i++)
        {
            Console.Write(rdr[i].ToString() + "\t");
        }
        Console.WriteLine();
    }
    if (rdr != null)
        rdr.Close();
}

Console.WriteLine("Connect to databases press Enter");
System.Console.OutputEncoding = System.Text.Encoding.UTF8;




if (Console.ReadKey().Key == ConsoleKey.Enter)
{
    //Console.WriteLine("ok");
   
    string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=FruitsAndVegetables;Integrated Security=True;Connect Timeout=30;";
    SqlConnection Connection = new SqlConnection(connectionString);

    try
    {
        // connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=FruitsAndVegetables;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";
       // Connection = new SqlConnection(connectionString);
        Connection.Open();
        Console.WriteLine("Connection successfully");

        int k = 0;
        Console.WriteLine("Відображення всієї інформації з таблиці овочів і фруктів ->1\nВідображення усіх назв овочів і фруктів ->2\nВідображення усіх кольорів ->3\nПоказати максимальну калорійність ->4\nПоказати мінімальну калорійність ->5\nПоказати середню калорійність ->6\nПоказати кількість овочів ->7\nПоказати кількість фруктів ->8\nПоказати кількість овочів і фруктів заданого кольору ->9\nПоказати кількість овочів і фруктів кожного кольору ->10\nПоказати овочі та фрукти з калорійністю нижче вказаної ->11\nПоказати овочі та фрукти з калорійністю вище вказаної ->12\nПоказати овочі та фрукти з калорійністю у вказаному діапазоні ->13\nПоказати усі овочі та фрукти жовтого або червоного кольору ->14\nВихід ->0");
        Console.Write("->");
        k=Convert.ToInt32(Console.ReadLine());
        Console.Clear();
       // SqlCommand selectcommand;
        while (k != 0)
        {
            switch (k)
            {
                case 1:
                    DoCommand(new SqlCommand("select * from Foods", Connection));
                    break; 
                    case 2:
                    DoCommand(new SqlCommand("select distinct Foods.name_object from Foods", Connection));
                    break;
                    case 3:                 
                    DoCommand(new SqlCommand("select distinct Foods.color_object from Foods", Connection));
                    break;
                    case 4:
                    DoCommand(new SqlCommand("select max(Foods.calorie) as 'Максимальна калорійність' from Foods", Connection));
                    break;
                case 5:
                    DoCommand(new SqlCommand("select min(Foods.calorie) as 'Мінімальна калорійність' from Foods", Connection));
                    break;
                case 6:
                    DoCommand(new SqlCommand("select avg(Foods.calorie) as 'Середня калорійність' from Foods", Connection));
                    break;
                case 7:
                    DoCommand(new SqlCommand("select count(Foods.Id) as 'Кількість овочів' from Foods where Foods.type_object = 0", Connection));
                    break;
                case 8:
                    DoCommand(new SqlCommand("select count(Foods.Id) as 'Кількість овочів' from Foods where Foods.type_object = 1", Connection));
                    break;
                case 9:
                    Console.Write("Введіть колір ->");
                    string color = Console.ReadLine();
                    DoCommand(new SqlCommand($"select count(Foods.Id) as 'Кількість овочів та фруктів' from Foods where Foods.color_object = '{color}'", Connection));
                    break;
                case 10:
                    DoCommand(new SqlCommand("select count(Foods.Id) as 'Кількість овочів та фруктів', Foods.color_object from Foods group by Foods.color_object", Connection));
                    break;
                case 11:
                    Console.Write("Введіть кількість калорій ->");
                    float cal = Convert.ToSingle(Console.ReadLine());
                    DoCommand(new SqlCommand($"select * from Foods where Foods.calorie < {cal}", Connection));
                    break;
                case 12:
                    Console.Write("Введіть кількість калорій ->");
                     cal = Convert.ToSingle(Console.ReadLine());
                    DoCommand(new SqlCommand($"select * from Foods where Foods.calorie > {cal}", Connection));
                    break;
                case 13:
                    Console.WriteLine("Діапазон від a до b");
                    int a, b;
                    Console.Write("a->");
                    a=Convert.ToInt32(Console.ReadLine());
                    Console.Write("b->");
                    b =Convert.ToInt32(Console.ReadLine());
                    DoCommand(new SqlCommand($"select * from Foods where Foods.calorie > {a} and Foods.calorie < {b}", Connection));
                    break;
                case 14:
                    DoCommand(new SqlCommand("select * from Foods where Foods.color_object = 'Yellow' or Foods.color_object = 'Red'", Connection));
                    break;

            }
            Console.WriteLine("Відображення всієї інформації з таблиці овочів і фруктів ->1\nВідображення усіх назв овочів і фруктів ->2\nВідображення усіх кольорів ->3\nПоказати максимальну калорійність ->4\nПоказати мінімальну калорійність ->5\nПоказати середню калорійність ->6\nПоказати кількість овочів ->7\nПоказати кількість фруктів ->8\nПоказати кількість овочів і фруктів заданого кольору ->9\nПоказати кількість овочів і фруктів кожного кольору ->10\nПоказати овочі та фрукти з калорійністю нижче вказаної ->11\nПоказати овочі та фрукти з калорійністю вище вказаної ->12\nПоказати овочі та фрукти з калорійністю у вказаному діапазоні ->13\nПоказати усі овочі та фрукти жовтого або червоного кольору ->14\nВихід ->0");
            Console.Write("->");
            k = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
        }
    }
    catch(Exception e)
    {
       
            Console.WriteLine("Connection error");
    }
    finally
    {
        if (Connection != null)
            Connection.Close();
        
    }
}
else
    Console.WriteLine("No");