using System;
using System.Diagnostics;
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
        Debug.Assert(title != null, "Judul tidak boleh null");
        Debug.Assert(title.Length <= 100, "Judul maksimal 100 karakter");
    }
    public void IncreasePlayCount(int count)
    {
        int tempCount = int.Parse(this.playCount);
        tempCount += count;
        this.playCount = tempCount.ToString();

        Debug.Assert(count <= 10000000, "Input penambahan maksimal 10.000.000");

        int currentCount = int.Parse(this.playCount);
        checked
        {
            currentCount += count;
        }
        this.playCount = currentCount.ToString();
    }

    public void PrintTrackDetails()
    {
        Console.WriteLine("Detail Music :");
        Console.WriteLine($"- ID         : {id}");
        Console.WriteLine($"- Judul      : {title}");
        Console.WriteLine($"- Play Count : {playCount}");
        Console.WriteLine($"ID: {id} | Title: {title} | Play Count: {playCount}");
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
        Console.WriteLine("\n--- Setelah penambahan ---\n");
        lagu.PrintTrackDetails();
        try
        {
            SayaMusicTrack lagu1 = new SayaMusicTrack("Surat Cinta Untuk Starla");
            lagu1.IncreasePlayCount(5000000);
            Console.WriteLine("\nSoal KE-2\n");
            lagu1.PrintTrackDetails();
            Console.WriteLine("\nTest Overflow...");
            for (int i = 0; i < 100; i++)
            {
                lagu1.IncreasePlayCount(10000000);
            }
        }
        catch (OverflowException ex)
        {
            Console.WriteLine($"\n[ERROR EXCEPTION] Terjadi Overflow: {ex.Message}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"\n[ERROR GENERAL]: {ex.Message}");
        }

        Console.WriteLine("\nProgram tetap berjalan.");
    }
}
