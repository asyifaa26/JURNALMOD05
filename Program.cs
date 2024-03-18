using System;

public class SimpleDataBase<T>
{
    public List<T> storedData;
    public List<DateTime> inputDates;

    public SimpleDataBase() { 
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
        for (int i = 0; i < storedData.Count; i++)
        {
            Console.WriteLine($"Data {i+1} berisi: {storedData.ElementAt(i)}, yang disimpan pada waktu {inputDates.ElementAt(i)}");
        }
    }
}

class program
{ 
    static void Main(string[] args)
    {
        //NIM : 1302223029
        SimpleDataBase<long> data = new SimpleDataBase<long>();
        for (int i = 0; i < 4; i++)
        {
            data.AddNewData(i);
        }

        data.PrintAllData();
    }
}