
int day;
string month;
Console.WriteLine("Please enter the day: ");
bool is_valid=Int32.TryParse(Console.ReadLine(),out day);
Console.WriteLine("Enter your month of birth: ");
month= Console.ReadLine().ToLower();

string[] months = {
            "january", "february", "march", "april", "may", "june",
            "july", "august", "september", "october", "november", "december"
        };


bool consistsMonth = Array.Exists(months, m => m.Equals(month));

if (is_valid && consistsMonth)
{
    if (month == "march" && day >= 21 || month == "april" && day <= 20)
    {
        Console.WriteLine("You are Aries");
    }
    else if (month == "april" && day >= 21 || month == "may" && day <= 20)
    {
        Console.WriteLine("You are Taurus");
    }
    else if (month == "may" && day >= 21 || month == "june" && day <= 20)
    {
        Console.WriteLine("You are Gemini");
    }
    else if (month == "june" && day >= 21 || month == "july" && day <= 22)
    {
        Console.WriteLine("You are Cancer");
    }
    else if (month == "july" && day >= 23 || month == "august" && day <= 22)
    {
        Console.WriteLine("You are Leo");
    }
    else if (month == "august" && day >= 23 || month == "september" && day <= 22)
    {
        Console.WriteLine("You are Virgo");
    }
    else if (month == "september" && day >= 23 || month == "october" && day <= 22)
    {
        Console.WriteLine("You are Libra");
    }
    else if (month == "october" && day >= 23 || month == "november" && day <= 22)
    {
        Console.WriteLine("You are Scorpio");
    }
    else if (month == "november" && day >= 23 || month == "december" && day <= 21)
    {
        Console.WriteLine("You are Sagittarius");
    }
    else if (month == "december" && day >= 22 || month == "january" && day <= 19)
    {
        Console.WriteLine("You are Capricorn");
    }
    else if (month == "january" && day >= 20 || month == "february" && day <= 19)
    {
        Console.WriteLine("You are Aquarius");
    }
    else if (month == "february" && day >= 20 || month == "march" && day <= 20)
    {
        Console.WriteLine("You are Pisces");
    }
    else {
        Console.WriteLine("Neither!");
    }
}
else {
    Console.WriteLine("not valid value!!!!!");
}


