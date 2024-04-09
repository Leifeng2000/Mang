internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Nhap cac phan tu cua mang");
        int[,] myArray = new int[5,5];
        //Qua trinh nhap lieu
        for (int row = 0; row < myArray.GetLength(0); row++)
        {
            for (int colum = 0; colum < myArray.GetLength(1); colum++)
            {
                myArray[row,colum] = Convert.ToInt32(Console.ReadLine());
            }
        }
        //Qua trinh in ra man hinh
        for (int row = 0; row < myArray.GetLength(0); row++)
        {
            Console.WriteLine(" ");
            for (int colum = 0; colum < myArray.GetLength(1); colum++)
            {
                Console.Write(myArray[row,colum] + ",");
            }
        }
        //Qua trinh tinh gia tri lon nhat
        int maxValue = 0;
        int sum = 0;
        for (int row = 0; row < myArray.GetLength(0); row++)
        {
            for (int colum = 0; colum < myArray.GetLength(1); colum++)
            {
                sum += myArray[row,colum];
                if(maxValue<myArray[row,colum])
                {
                    maxValue = myArray[row,colum];
                }
            }
        }
        //in ra gia tri lon nhat
        Console.WriteLine($"Gia tri lon nhat cua mang la {maxValue}");
        Console.WriteLine($"gia tri cua mang la {sum}");

    }
}