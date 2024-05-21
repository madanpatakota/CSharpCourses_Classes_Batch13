

using System;

/// <summary>
///Class: A class in C# is a fundamental construct in object-oriented programming (OOP). 
///It serves as a blueprint for creating objects, and it encapsulates data and behavior related to that data. 
///
/// Object: An object is an instance of a class. 
/// It represents a real-world entity and has its own unique data and behavior.
/// 
/// while non-static classes can contain both static and instance members.
/// 
/// 
/// member is nothing but a field(s) , method(s)  , properties(s)  and constructor(s)
/// </summary>
class File
{
    string fileName;  // field which can hold the data directly;
    string filelocation;// field
    string fileSize;// field
    string createdDate;// field


    static string companyName = "Misard";


    //non-static method(member) method
    void ShowMessage(string filename , string filelocation)
    {
        // Console.WriteLine("Show Message");
        Console.WriteLine($"Hello !!! File name is {filename} and filelocation is {filelocation}");
    }

    static void ShowPDFFileHistory(string filename, string createdDate)
    {
        Console.WriteLine($"Hello !!! File name is {filename} " +
            $"and filelocation is {createdDate}");
    }

    static void ShowWordFileSize(string name, string filesize)
    {
        Console.WriteLine($"Hello, File name is {name} and filelocation is {filesize}");
    }

    void ShowAnotherWordFileSize(string name, string filesize)
    {
        Console.WriteLine($"Hello, File name is {name} and filelocation is {filesize}");
    }

    //static - method
    static void Main()
    {
        //string str = "";
        Console.WriteLine("------------Start----------");
        File file = new File();//object ref
                               //file here is referece which holds the object reference.

        file.ShowMessage("Resume.docx", "D:/Resumes");//browse in UI

        File.ShowPDFFileHistory("CreditCardStatement-March", "01-Mar-2024");

        File.ShowWordFileSize("Resume.docx", "D:/Resumes");

        File file1 = new File();

        file.ShowAnotherWordFileSize("VisualStudioInstallization.docx", "D:/Downloads");
        file1.ShowAnotherWordFileSize("VisualStudioInstallizationFile1.docx", "D:/Documents");


        File file3 = new File();
        file3.fileName = "Resume.docx";
        file3.fileSize = "10kb";
        file3.filelocation = @"D:/Education/Resumes";
        file3.createdDate = "May-01-2024";
        file3.ShowAnotherWordFileSize(file3.fileName,file3.fileSize);


        File file5 = new File()
        {
            fileName = "Resume.docx",
            createdDate = "Jan-30-2024",
            filelocation = @"D:/Education/Resumes",
            fileSize = "10kb"
        };
        file3.ShowAnotherWordFileSize(file5.fileName, file5.fileSize);


        Console.WriteLine(file3.createdDate);//"10kb";
        Console.WriteLine(file5.createdDate);//D:/Education/Resumes


        Console.WriteLine(file3.fileSize);//"10kb";
        Console.WriteLine(file3.filelocation);

        Console.WriteLine(File.companyName);

        //new File().ShowMessage("fadfa" , "adasda");

        File file4 = new File();
        file4.fileName = "VisualStudioInstallizationFile1.docx";
        file4.fileSize = "10kb";
       



        Console.ReadLine();
    }




}
