using System;

public class SayaMusicTrack
{
    private int id;
    private string playCount;
    private string title;
    public SayaMusicTrack(string title)
    {
        this.title = title;
        Random random = new Random();
        this.id = random.Next(10000, 100000);
        this.playCount = "0";
    }
    public void IncreasePlayCount(int count)
    {
        int tempCount = int.Parse(this.playCount);
        tempCount += count;
        this.playCount = tempCount.ToString();
    }

    public void PrintTrackDetails()
    {
        Console.WriteLine("Detail Music :");
        Console.WriteLine($"- ID         : {id}");
        Console.WriteLine($"- Judul      : {title}");
        Console.WriteLine($"- Play Count : {playCount}");
    }
}
class Program
{
    static void Main(string[] args)
    {
        SayaMusicTrack lagu = new SayaMusicTrack("Surat Cinta Untuk Starla");
        lagu.IncreasePlayCount(125);
        lagu.PrintTrackDetails();
        lagu.IncreasePlayCount(75);
        Console.WriteLine("\n--- Setelah penambahan ---");
        lagu.PrintTrackDetails();
    }
}