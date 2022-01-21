using System.IO;
namespace ConsoleApplication1
{
    class Files
    {
        static void Main()
        {
            var adress = File.Create(@"D:\Primer.txt");//создание файла
            adress.Close();//закрытии файла и освобождение системных ресурсов
            File.Move(@"D:\Primer.txt", "D:\\Primer.txt");//переместить файл в указанную папку
            var adress2 = File.Create("Primer2.txt");//Помещается в директорию Debug
            adress2.Close();
            File.Delete("D:\\Primer.txt");//удаление файла
            if (File.Exists("Primer2.txt"))//если файл2 существует
            { File.Copy("Primer2.txt", "D:\\Primer2.txt", true); }//скопировать в указанную папку
        }
    }
}
