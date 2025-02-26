public class Program
{
    public static void Main(string[] args)
    {
        
        Console.WriteLine("Введите число, содержащее не меньше 2 цифр, в противном случае программа выведет 0");
        int x = Convert.ToInt32(Console.ReadLine());  //ввод числа
        var result = sumLastNums(x);  //вызов метода(?)
        Console.WriteLine(result); 
    }

    public static int sumLastNums(int x)
    {
        if (x / 10 >= 1)  //если при делении на 10 результат больше 1, то в числе более 2 цифр
        {
            int y = x % 10;  //узнаем последнюю цифру вводимого числа
            int z = (x / 10) % 10;  // узнаем предпоследнюю цифру
            return y + z;

        }
        else
        {
            return 0;
        }
        
    }
}

