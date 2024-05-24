using System;

class ExcelFile
{
    public string fileName;  // field which can hold the data directly;
    public string filelocation;// field
    public string fileSize;// field
    public string createdDate;// field

    // int[] ints = { 1, 2, 3, 4, 5, 6};
    //string[] strings = { "one", "two" };
    //string str = "Excelfile.xlsx";
}
class ExcelFileSystem
{
    void ShowExcelFileNamesLength(string[] fileNames)
    {
        Console.WriteLine($"Files List Length{fileNames.Length} ");  //3
        //fileNames.Length;
    }


    void ShowEveryExcelFileName(string[] fileNames)
    {
        //implementation.. i want to print every file name in console...
        //foreach(string file in fileNames)
        //{
        //    Console.WriteLine($"File name is  {file}");
        //}

        ////implementation.. i want to print only if file name is "ExcelFile2.xlsx"
        foreach (string file in fileNames)
        {
            if (file == "ExcelFile2.xlsx")
            {
                Console.WriteLine($"File name is  {file}");
            }
        }

    }


    //VVVVIMP argument is the very imp in method.
    void ShowExcelFileDetails(ExcelFile excelFile)
    {
        Console.WriteLine($"Excel file details : File Name is {excelFile.fileName} ");
        Console.WriteLine($"Excel file details : File Size is {excelFile.fileSize} ");
        Console.WriteLine($"Excel file details : File Location is {excelFile.filelocation} ");
        Console.WriteLine($"Excel file details : File created date is {excelFile.createdDate} ");
    }

    //string[] str =_________
    //foreach(string s in str){

    //int[] intssadfa = __________`
    //foreach(int asda in intssadfa)

    //bool[] adfasdada = { };
    //foreach(bool adfa in adfasdada)

    //ExcelFile[] asdfasdfaf = { }
    //foreach(ExcelFile adaffda in asdfasdfaf)


    void ShowEveryExcelFileDetails(ExcelFile[] excelFiles)
    {
        foreach (ExcelFile excelFile in excelFiles)
        {
            Console.WriteLine($"Excel file details : File Name is {excelFile.fileName} ");
            Console.WriteLine($"Excel file details : File Size is {excelFile.fileSize} ");
            Console.WriteLine($"Excel file details : File Location is {excelFile.filelocation} ");
            Console.WriteLine($"Excel file details : File created date is {excelFile.createdDate} ");
            Console.WriteLine("****************************************"); 
        }
           
    }

    static void Main()
    {
        ExcelFileSystem excelFileSystem = new ExcelFileSystem();

        string[] fileNames =
            { "ExcelFile1.xlsx", "ExcelFile2.xlsx", "ExcelFile3.xlsx" };

        excelFileSystem.ShowExcelFileNamesLength(fileNames);

        excelFileSystem.ShowEveryExcelFileName(fileNames);


        ExcelFile excelFile = new ExcelFile()
        {
            fileName = "Creditcardstatment.pdf",
            createdDate = "Mar-01-2024",
            fileSize = "5kb",
            filelocation = @"C:/Downloads"
        };

        excelFileSystem.ShowExcelFileDetails(excelFile);

        ExcelFile[] excelFiles = new ExcelFile[]
        {
            new ExcelFile()
            {
                fileName = "CreditcardstatmentMar.pdf",
                createdDate = "Mar-01-2024",
                fileSize = "5kb",
                filelocation = @"C:/Downloads"
            },
            new ExcelFile {
                fileName = "CreditcardstatmentApril.pdf",
                createdDate = "April-01-2024",
                fileSize = "3kb",
                filelocation = @"C:/Downloads" },
            new ExcelFile {
                fileName = "CreditcardstatmentMay.pdf",
                createdDate = "May-01-2024",
                fileSize = "2kb",
                filelocation = @"C:/Downloads"
            }
        };

        excelFileSystem.ShowEveryExcelFileDetails(excelFiles);

        Console.ReadLine();

    }

}

