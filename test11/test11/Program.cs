using System;
using System.Text.RegularExpressions;
using System.IO;
using System.Text;
using System.Net;

public class Example
{
    public static void Main()
    {

        string HtmlText = string.Empty;

        string pattern = "\"\"@type\"\": \"\"ExchangeRateSpecification\"\",
            \"\"currency\"\":\"\"EUR\"\",
            \"\"name\"\":\"\"Курс на черном рынке\"\",
            \"\"description\"\":\"\"Курс продажи\"\",
            \"\"currentExchangeRate\"\":{
            \"\"@type\"\": \"\"UnitPriceSpecification\"\",
              \"\"price\"\": \"\"39,450\"\",
              \"\"priceCurrency\"\": \"\"UAH\"\"
              }
        \"    }
}