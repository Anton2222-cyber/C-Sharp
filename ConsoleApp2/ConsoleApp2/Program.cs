

using System.Data.Common;
using System.Data.SqlClient;

string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=library;Integrated Security=True;Connect Timeout=30;";
SqlConnection Connection = null;
Connection = new SqlConnection(connectionString);
string insertstring = @"insert into Authors(FirstName,LastName) values ('Taras','Shevchenko')";

//try
//{
//    Connection.Open();

//    SqlCommand insertcommand = new SqlCommand(insertstring, Connection);
//    insertcommand.ExecuteNonQuery();
//}
//finally
//{
//    if(Connection != null)
//      Connection.Close();
//}

SqlDataReader rdr = null;
try
{
    Connection.Open();
    SqlCommand selectcommand = new SqlCommand("select * from Foods",Connection);
    rdr = selectcommand.ExecuteReader();
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
    Console.WriteLine();
    Console.WriteLine("Number of records: "+ count.ToString());
}
finally
{
    if (rdr != null)
        rdr.Close();
    if(Connection != null) 
        Connection.Close();
}