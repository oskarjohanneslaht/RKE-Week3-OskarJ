

int weekDay = Convert.ToInt32(DateTime.Now.DayOfWeek);

Console.WriteLine(weekDay);


if (weekDay == 0)
{
    Console.WriteLine("pühapäev");
}
else if (weekDay == 1)
{
    Console.WriteLine("esmaspäev");
}
else if (weekDay == 2)
{
    Console.WriteLine("teisipäev");
}
else if (weekDay == 3)
{
    Console.WriteLine("kolmapäev");
}
else if (weekDay == 4)
{
    Console.WriteLine("neljapäev");
}
else if (weekDay == 5)
{
    Console.WriteLine("reede");
}
else if (weekDay == 6)
{
    Console.WriteLine("laupäev");
}




