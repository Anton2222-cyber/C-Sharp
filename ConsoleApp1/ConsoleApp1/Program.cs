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

        HttpWebRequest myHttwebrequest = (HttpWebRequest)HttpWebRequest.Create("https://minfin.com.ua/currency/");
        HttpWebResponse myHttpWebresponse = (HttpWebResponse)myHttwebrequest.GetResponse();
        StreamReader strm = new StreamReader(myHttpWebresponse.GetResponseStream());
        HtmlText = strm.ReadToEnd();
        //Console.WriteLine(HtmlText);
        string pattern = "[\"\"]@type[\"\"]: [\"\"]ItemList[\"\"],\n.*[\"\"]name[\"\"]: [\"\"]Курс валют в Украине[\"\"],\n.*[\"\"]itemListElement[\"\"]: [[]\n.*{\n.*[\"\"]@type[\"\"]: [\"\"]ExchangeRateSpecification[\"\"],\n.*[\"\"]currency[\"\"]:[\"\"](USD)[\"\"],\n.*[\"\"]name[\"\"]:[\"\"]Средний курс валюты в банках[\"\"],\n.*[\"\"]description[\"\"]:[\"\"](Курс покупки)[\"\"],\n.*[\"\"]currentExchangeRate[\"\"]:{\n.*[\"\"]@type[\"\"]: [\"\"]UnitPriceSpecification[\"\"],\n.*[\"\"]price[\"\"]: [\"\"](\\d\\d,\\d\\d)\\d[\"\"],\n.*[\"\"]priceCurrency[\"\"]: [\"\"](UAH)[\"\"]\n.*}\n.*},";
        //Console.WriteLine(pattern);
        Regex r = new Regex(pattern);
        Match m = r.Match(HtmlText);

        Console.WriteLine(m.Groups[1]);
        Console.WriteLine(m.Groups[2]);
        Console.WriteLine(m.Groups[3].ToString() + m.Groups[4].ToString());
        Console.WriteLine("---------------------------------------");
        pattern = "[\"\"](\\d\\d[,]\\d\d)\d";
        r = new Regex(pattern);
        MatchCollection mc = r.Matches(HtmlText);
        Console.WriteLine(m.Groups[1]);
        Console.WriteLine(m.Groups[2]);
        Console.WriteLine(m.Groups[3].ToString() + m.Groups[4].ToString());
        Console.WriteLine("---------------------------------------");
    }
}