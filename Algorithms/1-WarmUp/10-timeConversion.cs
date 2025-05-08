public static string timeConversion(string s)
{
    string meridian = s.Substring(s.Length - 2); 
    string[] parts = s.Substring(0, 8).Split(':');

    int hour = int.Parse(parts[0]);

    if (meridian == "AM")
    {
        if (hour == 12)
            hour = 0; 
    }
    else 
    {
        if (hour != 12)
            hour += 12;
    }
    return $"{hour:D2}:{parts[1]}:{parts[2]}";
}
