using System.Data.Common;
using System.Data.SqlClient;

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

    string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Warhouse;Integrated Security=True;Connect Timeout=30;";
    SqlConnection Connection = new SqlConnection(connectionString);

    try
    {
        //connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Student_Evaluations;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";
        //Connection = new SqlConnection(connectionString);
        Connection.Open();
        Console.WriteLine("Connection successfully");

        int k = 0;
        Console.Write(
            """
           Відображення всієї інформації про товар ->1
           Відображення всіх типів товарів ->2
           Відображення всіх постачальників ->3
           Показати товар з максимальною кількістю ->4
           Показати товар з мінімальною кількістю ->5
           Показати товар з мінімальною собівартістю ->6
           Показати товар з максимальною собівартістю ->7
           Показати товари заданої категорії ->8
           Показати товари заданого постачальника ->9
           Показати товар, який знаходиться на складі найдовше з усіх ->10
           Показати середню кількість товарів за кожним типом товару ->11   
           Вставка нових товарів ->12
           Вставка нових типів товарів ->13
           Вставка нових постачальників ->14
           Оновлення інформації про існуючі товари ->15
           Оновлення інформації про існуючих постачальників ->16
           Оновлення інформації про існуючі типи товари ->17
           Видалення товарів ->18
           Видалення постачальників ->19
           Видалення типів товарів ->20
           Показати інформацію про постачальника, в якого кількість товарів на складі найбільша ->21
           Показати інформацію про постачальника, в якого кількість товарів на складі найменша ->22
           Показати інформацію про тип товару з найбільшою кількістю одиниць на складі ->23
           Показати інформацію про тип товарів з найменшою кількістю товарів на складі ->24
           Показати товари, з постачання яких минула задана кількість днів ->25
           Вихід ->0  
           """
            );
        Console.WriteLine();
        Console.Write("->");
        k = Convert.ToInt32(Console.ReadLine());
        Console.Clear();
        // SqlCommand selectcommand;
        SqlCommand insertcommand;
        while (k != 0)
        {
            switch (k)
            {
                case 1:
                    DoCommand(new SqlCommand(
                        """
                        select products.id, products.name as 'product_name', product_types.name as 'type', suppliers.name as 'suppliers', products.quantity, products.cost_price, products.last_delivery_date
                        from products 
                        join product_types on product_types.id = products.type_id
                        join suppliers on suppliers.id = products.supplier_id
                        """, Connection));
                    break;
                case 2:
                    DoCommand(new SqlCommand(
                        """
                        select product_types.name, id
                        from product_types
                        """, Connection));
                    break;
                case 3:
                    DoCommand(new SqlCommand(
                        """
                        select suppliers.name, id
                        from suppliers
                        """, Connection));
                    break;
                case 4:
                    DoCommand(new SqlCommand(
                        """
                        select top 1  products.name
                        from products
                        order by products.quantity desc 
                        """, Connection));
                    break;
                case 5:
                    DoCommand(new SqlCommand(
                        """
                        select top 1  products.name
                        from products
                        order by products.quantity  
                        """, Connection));
                    break;
                case 6:
                    DoCommand(new SqlCommand(
                       """
                        select top  1 products.name
                        from products
                        order by products.cost_price
                        """, Connection));
                    break;
                case 7:
                    DoCommand(new SqlCommand(
                       """
                        select top 1  products.name
                        from products
                        order by products.cost_price desc
                        """, Connection));
                    break;
                case 8:
                    Console.Write("Введіть категорію ->");
                    string category = Console.ReadLine();
                    SqlCommand command = new SqlCommand("""
                        select products.name, products.cost_price, products.quantity
                        from products
                        join product_types on product_types.id = products.type_id
                        where product_types.name = @p1
                        """, Connection);
                    command.Parameters.AddWithValue("@p1", category);
                    DoCommand(command);
                    break;
                case 9:
                    Console.Write("Введіть постачальника ->");
                    string suplier = Console.ReadLine();
                    SqlCommand command2 = new SqlCommand("""
                        select products.name, products.cost_price, products.quantity
                        from suppliers
                        join products on products.supplier_id = suppliers.id
                        where suppliers.name = @p1
                        """, Connection);
                    command2.Parameters.AddWithValue("@p1", suplier);
                    DoCommand(command2);
                    break;
                case 10:
                    DoCommand(new SqlCommand(
                       """
                        select top 1 products.name
                        from products
                        order by products.last_delivery_date
                        """, Connection));
                    break;
                case 11:
                    DoCommand(new SqlCommand(
                       """
                        select sum(products.quantity)/count(products.name) as 'avg quantity', product_types.name
                        from products
                        join product_types on product_types.id = products.type_id
                        group by product_types.name
                        """, Connection));
                    break;
                case 12:
                    insertcommand = new SqlCommand(
                        """
                        insert into products values(@name,@type_id,@supplier_id,@quantity,@cost_price,@last_delivery_date)
                        """, Connection);
                    Console.Write("Введіть назву товару ->");
                    string name = Console.ReadLine();
                    insertcommand.Parameters.AddWithValue("@name", name);

                    Console.Write("Введіть id типу товару ->");
                    int type_id = Convert.ToInt32(Console.ReadLine());
                    insertcommand.Parameters.AddWithValue("@type_id", type_id);

                    Console.Write("Введіть id поставщика товару ->");
                    int supplier_id = Convert.ToInt32(Console.ReadLine());
                    insertcommand.Parameters.AddWithValue("@supplier_id", supplier_id);

                    Console.Write("Введіть кількість товару ->");
                    int quantity = Convert.ToInt32(Console.ReadLine());
                    insertcommand.Parameters.AddWithValue("@quantity", quantity);

                    Console.Write("Введіть ціну товару за штуку ->");
                    float cost_price = Convert.ToSingle(Console.ReadLine());
                    insertcommand.Parameters.AddWithValue("@cost_price", cost_price);

                    Console.Write("Введіть дату поставки у форматі рік-місяць-день наприклад 2022-01-20 ->");
                    string last_delivery_date = Console.ReadLine();
                    insertcommand.Parameters.AddWithValue("@last_delivery_date", last_delivery_date);

                    insertcommand.ExecuteNonQuery();
                    break;
                case 13:
                    insertcommand = new SqlCommand(
                        """
                        insert into product_types values(@name_t)
                        """, Connection);
                    Console.Write("Введіть назву типу товару ->");
                    string name_t = Console.ReadLine();
                    insertcommand.Parameters.AddWithValue("@name_t", name_t);               
                    insertcommand.ExecuteNonQuery();
                    break;
                case 14:
                    insertcommand = new SqlCommand(
                        """
                        insert into suppliers values(@name_s)
                        """, Connection);
                    Console.Write("Введіть назву типу товару ->");
                    string name_s = Console.ReadLine();
                    insertcommand.Parameters.AddWithValue("@name_s", name_s);
                    insertcommand.ExecuteNonQuery();
                    break;
                case 15:
                    int k2=0;

                    Console.WriteLine
                        ("""
                        Виберіть операцію:
                        Змінити назву->1
                        Змінити тип->2
                        Змінити постачальника->3
                        Змінити кількість->4
                        Змінити ціну->5
                        Змінити дату поставки->6
                        Вихід->0
                        """);
                    Console.Write("->");
                    k2 =Convert.ToInt32(Console.ReadLine());
                    Console.Clear();
                    while(k2!=0)
                    {
                        Console.Write("Введіть id товару ->");
                        int id = Convert.ToInt32(Console.ReadLine());                     
                        switch (k2)
                        {
                            case 1:
                                insertcommand = new SqlCommand(
                        """
                        update products
                        set name = @n
                        where id = @id
                        """, Connection);

                                Console.Write("Введіть нову назву товару ->");
                                string n = Console.ReadLine();
                                insertcommand.Parameters.AddWithValue("@n", n);
                                insertcommand.Parameters.AddWithValue("@id", id);
                                insertcommand.ExecuteNonQuery();
                                break;
                            case 2:
                                insertcommand = new SqlCommand(
                        """
                        update products
                        set type_id = @typeid
                        where id = @id
                        """, Connection);

                                Console.Write("Введіть новий id типу товару ->");
                                int typeid = Convert.ToInt32(Console.ReadLine());
                                insertcommand.Parameters.AddWithValue("@typeid", typeid);
                                insertcommand.Parameters.AddWithValue("@id", id);
                                insertcommand.ExecuteNonQuery();
                                break;
                            case 3:
                                insertcommand = new SqlCommand(
                        """
                        update products
                        set supplier_id = @supplierid
                        where id = @id
                        """, Connection);

                                Console.Write("Введіть новий id поставщика товару ->");
                                int supplierid = Convert.ToInt32(Console.ReadLine());
                                insertcommand.Parameters.AddWithValue("@supplierid", supplierid);
                                insertcommand.Parameters.AddWithValue("@id", id);
                                insertcommand.ExecuteNonQuery();
                                break;
                            case 4:
                                insertcommand = new SqlCommand(
                        """
                        update products
                        set quantity = @q_uantity
                        where id = @id
                        """, Connection);

                                Console.Write("Введіть кількість товару ->");
                                int q_uantity = Convert.ToInt32(Console.ReadLine());
                                insertcommand.Parameters.AddWithValue("@q_uantity", q_uantity);
                                insertcommand.Parameters.AddWithValue("@id", id);
                                insertcommand.ExecuteNonQuery();
                                break;
                            case 5:
                                insertcommand = new SqlCommand(
                        """
                        update products
                        set cost_price = @costprice
                        where id = @id
                        """, Connection);

                                Console.Write("Введіть ціну товару за штуку ->");
                                float costprice = Convert.ToSingle(Console.ReadLine());
                                insertcommand.Parameters.AddWithValue("@costprice", costprice);
                                insertcommand.Parameters.AddWithValue("@id", id);
                                insertcommand.ExecuteNonQuery();
                                break;
                            case 6:
                                insertcommand = new SqlCommand(
                        """
                        update products
                        set last_delivery_date = @lastdelivery_date
                        where id = @id
                        """, Connection);

                                Console.Write("Введіть дату поставки у форматі рік-місяць-день наприклад 2022-01-20 ->");
                                string lastdelivery_date = Console.ReadLine();
                                insertcommand.Parameters.AddWithValue("@lastdelivery_date", lastdelivery_date);
                                insertcommand.Parameters.AddWithValue("@id", id);
                                insertcommand.ExecuteNonQuery();
                                break;
                        }
                        Console.WriteLine
                     ("""
                        Виберіть операцію:
                        Змінити назву->1
                        Змінити тип->2
                        Змінити постачальника->3
                        Змінити кількість->4
                        Змінити ціну->5
                        Змінити дату поставки->6
                        Вихід->0
                        """);
                        Console.Write("->");
                        k2 = Convert.ToInt32(Console.ReadLine());
                        Console.Clear();
                    }

                   
                    break;
                case 16:
                    Console.Write("Введіть id постачальника ->");
                    int ID = Convert.ToInt32(Console.ReadLine());
                    insertcommand = new SqlCommand(
                        """
                        update suppliers
                        set name = @n
                        where id = @id
                        """, Connection);

                    Console.Write("Введіть нову назву постачальника ->");
                    string n2 = Console.ReadLine();
                    insertcommand.Parameters.AddWithValue("@n", n2);
                    insertcommand.Parameters.AddWithValue("@id", ID);
                    insertcommand.ExecuteNonQuery();
                    break;
                case 17:
                    Console.Write("Введіть id типу товару ->");
                    int Id = Convert.ToInt32(Console.ReadLine());
                    insertcommand = new SqlCommand(
                        """
                        update product_types
                        set name = @n
                        where id = @id
                        """, Connection);

                    Console.Write("Введіть нову назву типу товару ->");
                    string n3 = Console.ReadLine();
                    insertcommand.Parameters.AddWithValue("@n", n3);
                    insertcommand.Parameters.AddWithValue("@id", Id);
                    insertcommand.ExecuteNonQuery();
                    break;
                case 18:
                    Console.Write("Введіть id товару ->");
                    int Id1 = Convert.ToInt32(Console.ReadLine());
                    insertcommand = new SqlCommand(
                        """
                        delete from products
                        where id = @id
                        """, Connection);                 
                    insertcommand.Parameters.AddWithValue("@id", Id1);
                    insertcommand.ExecuteNonQuery();
                    break;
                case 19:
                    Console.Write("Введіть id товару ->");
                    int Id2 = Convert.ToInt32(Console.ReadLine());
                    insertcommand = new SqlCommand(
                        """
                        delete from suppliers
                        where id = @id
                        """, Connection);
                    insertcommand.Parameters.AddWithValue("@id", Id2);
                    insertcommand.ExecuteNonQuery();
                    break;
                case 20:
                    Console.Write("Введіть id товару ->");
                    int Id3 = Convert.ToInt32(Console.ReadLine());
                    insertcommand = new SqlCommand(
                        """
                        delete from product_types
                        where id = @id
                        """, Connection);
                    insertcommand.Parameters.AddWithValue("@id", Id3);
                    insertcommand.ExecuteNonQuery();
                    break;
                    case 21:
                    DoCommand(new SqlCommand(
                       """
                        select top 1 suppliers.name
                        from suppliers
                        join products on products.supplier_id = suppliers.id
                        group by suppliers.name
                        order by sum(products.quantity) desc
                        """, Connection));
                    break;
                case 22:
                    DoCommand(new SqlCommand(
                       """
                        select top 1 suppliers.name
                        from suppliers
                        join products on products.supplier_id = suppliers.id
                        group by suppliers.name
                        order by sum(products.quantity)
                        """, Connection));
                    break;
                case 23:
                    DoCommand(new SqlCommand(
                       """
                        select top 1 product_types.name
                        from products
                        join product_types on product_types.id = products.type_id
                        group by product_types.name
                        order by sum(products.quantity) desc
                        """, Connection));
                    break;
                case 24:
                    DoCommand(new SqlCommand(
                       """
                        select top 1 product_types.name
                        from products
                        join product_types on product_types.id = products.type_id
                        group by product_types.name
                        order by sum(products.quantity) 
                        """, Connection));
                    break;
                case 25:
                    Console.Write("Введіть кількість днів ->");
                    int days  = Convert.ToInt32(Console.ReadLine())*(-1);
                    SqlCommand command5 = new SqlCommand("""
                        select products.name, product_types.name as 'type'
                        						  from products 
                                                join product_types on product_types.id = products.type_id
                        						where day(products.last_delivery_date) = day(DATEADD(DAY, @p1, GETDATE())) and 
                        						month(products.last_delivery_date) = month(DATEADD(DAY, @p1, GETDATE())) and
                        						year(products.last_delivery_date) = year(DATEADD(DAY, @p1, GETDATE()))
                        """, Connection);
                    command5.Parameters.AddWithValue("@p1", days);
                    DoCommand(command5);
                    break;
            }
            Console.Write(
           """
           Відображення всієї інформації про товар ->1
           Відображення всіх типів товарів ->2
           Відображення всіх постачальників ->3
           Показати товар з максимальною кількістю ->4
           Показати товар з мінімальною кількістю ->5
           Показати товар з мінімальною собівартістю ->6
           Показати товар з максимальною собівартістю ->7
           Показати товари заданої категорії ->8
           Показати товари заданого постачальника ->9
           Показати товар, який знаходиться на складі найдовше з усіх ->10
           Показати середню кількість товарів за кожним типом товару ->11   
           Вставка нових товарів ->12
           Вставка нових типів товарів ->13
           Вставка нових постачальників ->14
           Оновлення інформації про існуючі товари ->15
           Оновлення інформації про існуючих постачальників ->16
           Оновлення інформації про існуючі типи товари ->17
           Видалення товарів ->18
           Видалення постачальників ->19
           Видалення типів товарів ->20
           Показати інформацію про постачальника, в якого кількість товарів на складі найбільша ->21
           Показати інформацію про постачальника, в якого кількість товарів на складі найменша ->22
           Показати інформацію про тип товару з найбільшою кількістю одиниць на складі ->23
           Показати інформацію про тип товарів з найменшою кількістю товарів на складі ->24
           Показати товари, з постачання яких минула задана кількість днів ->25
           Вихід ->0  
           """
           );
            Console.WriteLine();
            Console.Write("->");
            k = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
        }
    }
    catch (Exception e)
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
