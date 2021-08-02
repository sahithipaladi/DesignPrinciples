using DesignPrinciples.Dependency_Inversion_Principle;
using DesignPrinciples.Open_Close_Principle;
using DesignPrinciples.Interface_Segregation_Principle;
using DesignPrinciples.Single_Responsibilty_Principle;
using DesignPrinciples.Liskov_Substitution_Principle;
using System;

namespace DesignPrinciples
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*********** DESIGN PRINCIPLES ***********");
            Console.WriteLine("1.Single Responsibilty Principle");
            Console.WriteLine("2.Open Closed Principle");
            Console.WriteLine("3.Liskov Substitution Principle");
            Console.WriteLine("4.Interface Segregation Principle");
            Console.WriteLine("5.Dependency Inversion Principle");
            Console.Write("\nEnter the option : ");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    var scheduler = new Scheduler();
                    scheduler.AddEntry(new ScheduleTask { TaskId = 1, Content = "Do something now.", ExecuteOn = DateTime.Now.AddDays(5) });
                    scheduler.AddEntry(new ScheduleTask { TaskId = 2, Content = "Update the task ", ExecuteOn = DateTime.Now.AddDays(2) });
                    scheduler.AddEntry(new ScheduleTask { TaskId = 3, Content = "Develop a Game", ExecuteOn = DateTime.Now.AddDays(3) });
                    Console.WriteLine(scheduler.ToString());
                    scheduler.RemoveEntryAt(2);
                    Console.WriteLine("\n Removed Successfully");
                    Console.WriteLine("\n After remvoing the data \n");
                    Console.WriteLine(scheduler.ToString());
                    break;
                case 2:
                    Shape shape = new Rectangle(10, 5);
                    Console.WriteLine(shape.Area());
                    break;
                case 3:
                    IFileWriter fileWriter = new AdminDataFile();
                    fileWriter.WriteFile(@"C:\Users\Admin\source\repos\DesignPrinciples\DesignPrinciples\Liskov Substitution Principle\AdminData.txt");

                    IFileReader fileReader = new AdminDataFile();
                    fileReader.ReadFile(@"C:\Users\Admin\source\repos\DesignPrinciples\DesignPrinciples\Liskov Substitution Principle\AdminData.txt");

                    IFileReader fileReaderR = new RegulaDataFile();
                    fileReaderR.ReadFile(@"C:\Users\Admin\source\repos\DesignPrinciples\DesignPrinciples\Liskov Substitution Principle\RegularData.txt");
                    break;
                case 4:
                    Console.WriteLine("\n-------Cannon------");
                    IPrintContent content1 = new Cannon();
                    content1.PrintContent();
                    IPhotoCopyContent copyContent = new Cannon();
                    copyContent.PhotoCopyContent();
                    Console.WriteLine("\n--------HPLaser------");
                    IPrintContent content = new HPLaser();
                    content.PrintContent();
                    IPrintDuplex printDuplex = new HPLaser();
                    printDuplex.PrintDuplexContent();

                    break;
                case 5:
                    var employeeDetailsModified = new EmployeeDetails(new SalaryCalculator());
                    employeeDetailsModified.HourlyRate = 50;
                    employeeDetailsModified.HoursWorked = 150;
                    Console.WriteLine($"\nThe Total Pay is {employeeDetailsModified.GetSalary()}");
                    break;
            }
        }
    }
}