//1. get the directory
//2. append the folder name into the directory
//3. make the folder
//4. append the file name into the folder
//5. create file
//6. append the file with the data
//7. figure out how to capture the data
//8. close yay :)



using System;
using System.IO;

namespace MonitorBus;

public class FileLogs
{
    //1. get the directory
    string currentPath = Directory.GetCurrentDirectory();

    //2. append the folder name into the directory
    public FileLogs(string folderPath) //defines constructor taking folderpath parameter
    {
        FolderPath = folderPath; //initializes property with the argument 
        string folderPath = Path.Combine(currentPath, "Logs"):   //combines folder path into the directory
   
    //3. make the folder
    if (!Directory.Exists(folderPath))
        {
            Directory.CreateDirectory(folderPath); //if the folder  does not exist create it in the directory
        }
    }

    //4. append the file name into the folder
    FileName = fileName;
    string fileName = Path.Combine(folderPath, "Komodo-file");

    //5. create file
    public string CreateFilename() //defines method signature wrapped code with {}
    {
    string timestamp = DateTime.Now.ToString("yyyy-MM-dd_HH-mm-ss"); //gets current dat eand time in specific formatting
    string fileName = $"log_{timestamp}.txt"; //returns filename string
    return fileName;
    }

    //6. append the file with the data
if (File.Exists(folderPath))
    {
    using StreamWriter sw = File.AppendText(FileSystemName)
    {
    
    //method to write data to file
    public void WriteToFile(string filename, string data) //defines public method of two parameters
{
    string filePath = Path.Combine(FolderPath, filename); //combines and creates full file path
    File.WriteAllText(filePath, data); //writes data to filepath
}

//method to log message
public void LogMessage(string message) //defines method one parameter returning void
{
    string filename = CreateFilename(); //calls createfilename method to generate a unique filename
    WriteToFile(filename, message); //calls writetofile method to write the message 
}

//7. figure out how to capture the data
private static string CaptureCANData() //defines private static mehtod returing string only accesible withing program class call with no instance
{
    //repalce with can capturing data
    return "sample can data 123 456 789 :)"; //just for simulation purposes
}

}