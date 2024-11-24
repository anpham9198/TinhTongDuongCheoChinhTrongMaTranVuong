internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Nhap kich thuoc cua man tran vuong");
        int n = Convert.ToInt32(Console.ReadLine());
        int[,] arr = new int[n, n];
        for (var i = 0; i < n; i++)
        {
            for (var j = 0; j < n; j++)
            {
                arr[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }

        //hien thi mang ra man hinh
        for (var i = 0; i < n; i++)
        {
            Console.Write("\n");
            for (var j = 0; j < n; j++)
            {
                Console.Write(arr[i, j] + "\t");
            }
        }

        //tinh tong duong cheo chinh
        int sum = 0;
        for (var i = 0; i < n; i++)
        {
            for (var j = 0; j < n; j++)
            {
                if (i == j) sum += arr[i, j];
            }
        }

        Console.WriteLine("Tong duong cheo chinh la{0}", sum); 
    }
}