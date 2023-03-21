// See https://aka.ms/new-console-template for more information
public class Penjumlahan
{
    public void JumlahTigaAngka<T>(T a, T b, T c)
    {
        dynamic penj1 = a;
        dynamic penj2 = b;
        dynamic penj3 = c;
        Console.WriteLine(penj1 + penj2 + penj3);

    }
}

public class main
{
    static void Main(string[] args)
    {
        Penjumlahan p = new Penjumlahan();
        float x = 13;
        float z = 02;
        float y = 21;
        p.JumlahTigaAngka(x, z, y);
    }
}


