using System;

public class LogLine
{
    private static string[] SplitOnChunks(string text) => text.Split(':');

    public static string Message(string text) => SplitOnChunks(text)[1].Trim();

    public static string LogLevel(string text)
    {
        return SplitOnChunks(text)[0].Trim('[', ']').ToLower();
    }

    //Assert.Equal("Segmentation fault (error)", LogLine.Reformat("[ERROR]: Segmentation fault"));
    public static string Reformat(string text)
    {
        string result = $"{Message(text)} ({LogLevel(text)})";
        return result;
    }

}