using System;

namespace Task_2
{
    // Singleton Pattern for Printer Class
    // TODO#1: Convert to use singleton pattern 
    public class Printer
    {
        private static Printer? Instance;
        private Printer() { }
        public static Printer GetInstance() 
        {
          if (Instance == null) 
            {
                Instance = new Printer();
            }
          return Instance;
        }
        public void Print(string message) 
        {
            Console.WriteLine($"Printing: {message}");
        }
    }
    // Class template for Exam classes
    // TODO#2: Convert to use Abstract Factory pattern
    // Create an Exam interface and an Abstract Factory to manage the creation of different exam types
    public interface IExamFactory 
    {
        IExam CreateExam();
    }
    public interface IExam 
    {
        void Conduct();
        void Evaluate();
        void PublishResults();
    }

    public class MathExam : IExam
    {
        public void Conduct() 
        {
            // Output: "Conducting Math Exam", should use Printer class to print the message
            Console.WriteLine("Conducting Math Exam");
            Printer.GetInstance().Print("Conducting MAth Exam");
        }
        public void Evaluate() 
        {
            // Output: "Evaluating Math Exam", should use Printer class to print the message
            Console.WriteLine("Evaluating Math Exam");
            Printer.GetInstance().Print("Evaluating Math Exam");
        }
        public void PublishResults() 
        {
            // Output: "Publishing Math Exam Results", should use Printer class to print the message
            Console.WriteLine("Publishing Math Exam Results");
            Printer.GetInstance().Print("Publishing Math Exam Results");
        }
    }

    // TODO#5: Add new ScienceExam class
    public class ScienceExam : IExam 
    {
         public void Conduct() 
         {
            Console.WriteLine("Conducting Science Exam");
            Printer.GetInstance().Print("Conducting Science Exam");
         }
        public void Evaluate()
        {
            Console.WriteLine("Evaluating Science Exam");
            Printer.GetInstance().Print("Evaluating Science Exam");
        }
        public void PublishResults() 
        {
            Console.WriteLine("Publishing Science Exam");
            Printer.GetInstance().Print("Publishing Science Exam");
        }
    }
    // TODO#6: Add another ProgrammingExam class
    public class ProgrammingExam : IExam 
    {
        public void Conduct() 
        {
            Console.WriteLine("Conducting Programming Exam");
            Printer.GetInstance().Print("Conducting Programming Exam");
        }
        public void Evaluate() 
        {
            Console.WriteLine("Evaluating Programming Exam");
            Printer.GetInstance().Print("Evaluating Programming Exam");
        }
        public void PublishResults() 
        {
            Console.WriteLine("Publishing Programming Exam");
            Printer.GetInstance().Print("Publishing Programming Exam");
        }
    }
    // Adding a Factory
    public class MathExamFactory : IExamFactory
    { 
        public IExam CreateExam() 
        {
        return new MathExam();
        }
    }

    public class ScienceExamFactory : IExamFactory
    {
        public IExam CreateExam()
        {
            return new ScienceExam();
        }
    }
    
    public class ProgrammingExamFactory : IExamFactory
    {
        public IExam CreateExam()
        {
            return new ProgrammingExam();
        }
    }
    // Main Program
    class Program
    {
        static void Main(string[] args) 
        {
            // TODO#7: Initialize Printer that uses Singleton pattern
            Printer printer = Printer.GetInstance();
            // TODO#8: Test that the created Printer works, by calling the Print method
            printer.Print("Testing the print");
            // TODO#9: Ensure that only one Printer instance is used throughout the application.
            //         Try to create new Printer object and compare the two objects to check,
            //         that the new printer object is the same instance
            Printer anotherPrinter = Printer.GetInstance();
            if (printer== anotherPrinter) 
            {
                Console.WriteLine("Both printer objects are in the same instance");
            }

            // TODO#10: Use Abstract Factory to create different types of exams.
            IExamFactory mathExamFactory = new MathExamFactory();
            IExam mathExam = mathExamFactory.CreateExam();
            mathExam.Conduct();
            mathExam.Evaluate();
            mathExam.PublishResults();

            IExamFactory scienceExamFactory = new ScienceExamFactory();
            IExam scienceExam = scienceExamFactory.CreateExam();
            scienceExam.Conduct();
            scienceExam.Evaluate();
            scienceExam.PublishResults();

            IExamFactory programmingExamFactory = new ProgrammingExamFactory();
            IExam programmingExam = programmingExamFactory.CreateExam();
            programmingExam.Conduct();
            programmingExam.Evaluate();
            programmingExam.PublishResults();


        }
    }
}