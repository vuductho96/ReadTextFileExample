// See https://aka.ms/new-console-template for more information

using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Nhập đường dẫn tới file: ");
        string filePath = Console.ReadLine();

        try
        {
            int sum = 0;
            using (StreamReader sr = new StreamReader(filePath))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    if (int.TryParse(line, out int number))
                    {
                        sum += number;
                    }
                    else
                    {
                        Console.WriteLine("File chứa giá trị không phải số nguyên.");
                        return;
                    }
                }
            }

            Console.WriteLine("Tổng các số trong file: " + sum);
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("File không tồn tại.");
        }
        catch (IOException)
        {
            Console.WriteLine("Không thể đọc file.");
        }

        Console.ReadLine();
    }
}
