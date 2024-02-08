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

    string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Student_Evaluations;Integrated Security=True;Connect Timeout=30;";
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
           Відображати всієї інформації з таблиці зі студентами та оцінками ->1
           Відображати ПІБ усіх студентів ->2
           Відображати усіх середніх оцінок ->3
           Показати ПІБ усіх студентів з середньою оцінкою, більшою, ніж зазначена ->4
           Показати назви усіх предметів із мінімальними середніми оцінками. Назви предметів мають бути унікальними ->5
           Показати мінімальну середню оцінку ->6
           Показати максимальну середню оцінку ->7
           Показати кількість студентів з мінімальною середньою оцінкою з математики ->8
           Показати кількість студентів, в яких максимальна середня оцінка з математики ->9
           Показати кількість студентів у кожній групі ->10
           Показати середню оцінку групи ->11
           ->
           """
            );
        k = Convert.ToInt32(Console.ReadLine());
        Console.Clear();
        // SqlCommand selectcommand;
        while (k != 0)
        {
            switch (k)
            {
                case 1:
                    DoCommand(new SqlCommand("select * from MarksOfStudents", Connection));
                    break;
                case 2:
                    DoCommand(new SqlCommand("select FIO from MarksOfStudents", Connection));
                    break;
                case 3:
                    DoCommand(new SqlCommand("select avg_of_subjects from MarksOfStudents", Connection));
                    break;
                case 4:
                    Console.Write("Введіть оцінку ->");
                    float mark = Convert.ToInt32(Console.ReadLine());
                    DoCommand(new SqlCommand($"select FIO from MarksOfStudents where avg_of_subjects > {mark}", Connection));
                    break;
                case 5:
                    DoCommand(new SqlCommand("select distinct name_of_subject_with_min_mark from MarksOfStudents ", Connection));
                    break;
                case 6:
                    DoCommand(new SqlCommand("select min(avg_of_subjects)as 'Мінімальна середня оцінка' from MarksOfStudents ", Connection));
                    break;
                case 7:
                    DoCommand(new SqlCommand("select max(avg_of_subjects)as 'Максимальна середня оцінка' from MarksOfStudents ", Connection));
                    break;
                case 8:
                    DoCommand(new SqlCommand("select count(id) as 'Кількість студентів з мінімальною середньою оцінкою з математики' from MarksOfStudents where name_of_subject_with_min_mark = 'Math'", Connection));
                    break;
                case 9:
                    DoCommand(new SqlCommand("select count(id) as 'Кількість студентів, в яких максимальна середня оцінка з математики' from MarksOfStudents where name_of_subject_with_max_mark = 'Math'", Connection));
                    break;
                case 10:
                    DoCommand(new SqlCommand("select count(id) as 'Кількість', name_group from MarksOfStudents group by name_group", Connection));
                    break;
                case 11:
                    DoCommand(new SqlCommand("select name_group, avg(avg_of_subjects) as 'Середня оцінка' from MarksOfStudents group by name_group", Connection));
                    break;


            }
            Console.Write(
             """
           Відображати всієї інформації з таблиці зі студентами та оцінками ->1
           Відображати ПІБ усіх студентів ->2
           Відображати усіх середніх оцінок ->3
           Показати ПІБ усіх студентів з середньою оцінкою, більшою, ніж зазначена ->4
           Показати назви усіх предметів із мінімальними середніми оцінками. Назви предметів мають бути унікальними ->5
           Показати мінімальну середню оцінку ->6
           Показати максимальну середню оцінку ->7
           Показати кількість студентів з мінімальною середньою оцінкою з математики ->8
           Показати кількість студентів, в яких максимальна середня оцінка з математики ->9
           Показати кількість студентів у кожній групі ->10
           Показати середню оцінку групи ->11
           ->
           """
             );
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
