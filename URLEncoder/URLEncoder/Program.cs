using System;

namespace URLEncoder
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("What is the project name of this:");
            string ProjectName = Console.ReadLine();

            System.Web.HttpUtility.UrlEncode(ProjectName);

            Console.WriteLine("Okay, {0} it is", ProjectName);

            Console.WriteLine("What is the name of this activity:");
            string ActivityName = Console.ReadLine();

            Console.WriteLine("Okay, {0} it is", ActivityName);

            String FinalURL = ("https://companyserver.com/content/" + ProjectName + "/files/" + ActivityName + "/" + ActivityName + "Report.pdf");

            Console.WriteLine(FinalURL.Replace(" ", "%20"));

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
