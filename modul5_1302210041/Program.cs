// See https://aka.ms/new-console-template for more information

public class SimpleDataBase<T>
{
    private List<T> storedData;
    private List<DateTime> inputDates;

    public SimpleDataBase()
    {
        storedData = new List<T>();
        inputDates = new List<DateTime>();
    }

    public void AddNewData(T data)
    {
        storedData.Add(data);
        inputDates.Add(DateTime.Now);
    }

    public void PrintAllData()
    {
        for(int  i = 0; i < storedData.Count; i++)
        {
            Console.WriteLine("Data" + (i + 1) + " berisi: " + storedData[i] + ", yang disimpan pada waktu UTC: " + inputDates[i]);
        }
    }
}

public class main
{
    static void Main(string[] args)
    {
        string[] arr = { "13", "02", "21" };
        SimpleDataBase<string> x = new SimpleDataBase<string>();
        for(int i = 0; i < arr.Length;i++)
        {
            x.AddNewData(arr[i]);
        }
        x.PrintAllData();
    }
}
