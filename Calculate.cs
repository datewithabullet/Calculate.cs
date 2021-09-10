public static double Calculate(string userInput)
{
    var parts = userInput.Split();
    return double.Parse(parts[0]) * Math.Pow(1 + double.Parse(parts[1]) / (12 * 100), double.Parse(parts[2]));
}
