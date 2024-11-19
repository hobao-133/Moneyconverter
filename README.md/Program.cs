using System;
class Program{
    static void Main(string[]args){
        const double USD_TO_VND = 23000;
        Console.WriteLine("Chào mừng đến ứng dụng chuyển đổi tiền tệ!");
        Console.WriteLine("Chuyển đổi từ USD sang VND");
        Console.WriteLine("Nhập số tiền cần đổi");
        double amount = double.Parse(Console.ReadLine());
        double result = 0;
        result = amount * USD_TO_VND;
        Console.WriteLine($"{amount} USD = {result} VND");
    }
}