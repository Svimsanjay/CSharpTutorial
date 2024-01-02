public class ValueType
{
    public int display(out int num)
    {
        num = 50;
        return num+5;
        
    }
        
}
public class Program
{
    public static void Main(String[] args)
    {
        int num;
        ValueType rep = new ValueType();
        num = rep.display(out num);
        Console.WriteLine(num);
        Console.ReadLine();
    }
}