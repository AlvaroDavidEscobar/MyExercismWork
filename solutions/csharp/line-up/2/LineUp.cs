public static class LineUp
{
    public static string Format(string name, int number)
    {
        string numFormat;
        if (number % 10 == 1 && number % 100 != 11) {numFormat = number + "st";}
        else if (number % 10 == 2 && number % 100 != 12) {numFormat = number + "nd";}
        else if (number % 10 == 3 && number % 100 != 13) {numFormat = number + "rd";}
        else {numFormat = number + "th";}

        return $"{name}, you are the {numFormat} customer we serve today. Thank you!";
    }
}
