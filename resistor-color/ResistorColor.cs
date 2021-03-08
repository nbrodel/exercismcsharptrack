using System;

public static class ResistorColor
{
    public static int ColorCode(string color)
    {
        return Array.IndexOf(_colors, color);
    }

    private static readonly string[] _colors = new { "black", "brown", "red", "orange", "yellow", "green", "blue", "violet", "grey", "white" };

}