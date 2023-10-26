// See https://aka.ms/new-console-template for more information

using HtmlToPdfMaster;
//For HTML context
//string htmlContenet = File.ReadAllText("C:\\Users\\MD FAISAL\\Desktop\\HtmlFile\\demohtml.txt");
//var pdfFile= HtmlConverter.FromHtmlString(htmlContenet, 220, 335);

//For URL
var pdfFile = HtmlConverter.FromUrl("https://www.w3schools.com/html/", 220,335);

string fileName=Guid.NewGuid().ToString()+".pdf";
File.WriteAllBytes("C:\\Users\\MD FAISAL\\Desktop\\HtmlFile\\"+fileName, pdfFile);
Console.WriteLine("Hello, World!");
