using ExcelFileSytem;
using PDFFileSystem;
using WordFileSystem;
using System;

namespace MainProgramSystem
{
    class MainProgram
    {
        static void Main()
        {
          ExcelFiles excelFiles = new ExcelFiles();
          string fileName= excelFiles.fileName;
          Console.WriteLine($"File Name is {fileName}");

          AnotherExcelFiles anotherExcelFiles = new AnotherExcelFiles();

          Pdffiles pdffiles = new Pdffiles();
          string pdfFileName = pdffiles.fileName;
            Console.WriteLine($"File Name is {pdfFileName}");

          Wordfiles wordFiles = new Wordfiles();
          string wordFileName = wordFiles.fileName;
          Console.WriteLine($"File Name is {wordFileName}");


            Console.ReadLine();




        }
    }
}
