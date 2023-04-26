

int weekDay = Convert.ToInt32(DateTime.Now.DayOfWeek); // vahemik 0-6

switch (weekDay) // väärtus mida kontrollitkse
{
    case 0: //case 0: == if (weekdat == o)
        Console.WriteLine("pühapäev");
        break;    
    case 1:
        Console.WriteLine("esmaspäev");
        break;
    case 2:
        Console.WriteLine("teisipäev");
        break;
    case 3:
        Console.WriteLine("kolmapäev");
        break;  
    case 4:
        Console.WriteLine("neljapäev");
        break;
    case 5:
        Console.WriteLine("reede");
        break;  
    case 6:
        Console.WriteLine("laupäev");
        break;
    default:
        Console.WriteLine("viga kalendris");
        break;
}

Console.WriteLine("Ilust päeva jätku!");

