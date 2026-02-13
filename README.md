# Solid-Principle
This repo consists of Solid principle examples in c#

1.  **Single Responsibility Principle :** The class should have only one responsibility or talks about single entiity.

```nginx

    internal class Logger
    {
        public void Log(string message)
        {
            Console.WriteLine($"Log: {message}");
        }

        public void LogError(string errorMessage)
        {
            Console.WriteLine($"Error: {errorMessage}");
        }

        public void LogWarning(string message) 
        {
            Console.WriteLine($"Warning: {message}");
        }
    }

```
<br />
<br />
2.  **Open Closed Principle:** Open for Extension and Closed for Modification

```nginx

    internal class Employee
    {
        public string Name { get; set; }

        private int _salary;

        public Employee(string name, int salary)
        {
            this.Name = name;   
            this._salary = salary;
        }

        public virtual int GetSalary()
        {
            return _salary;
        }
    }

    internal class Manager : Employee
    {
        public Manager(string name, int salary) : base(name, salary)
        {

        }

        public override int GetSalary()
        {
            // Managers get a 20% bonus
            return base.GetSalary() + (int)(base.GetSalary() * 0.2);
        }
    }

```

<br />
<br />

3.  **Liskov Substitution Principle:** objects of Base class can be replaceable by objects of subclass with out breaking behavior.

```nginx

    internal abstract class Shape
    {
        public abstract int Area();
    }

    internal class Square(int SideLength) : Shape
    {
        public override int Area()
        {

            return SideLength * SideLength;
        }
    }

    internal class  Rectangle(int Width, int Height) : Shape
    {
        public override int Area()
        {
            return Width * Height;
        }
    }

    public class LiskovSubstitutionPrinciple
    {
        public void CalculateArea()
        {
            List<Shape> shapes = new List<Shape>
            {
                new Square(7),
                new Rectangle(4, 6)
            };

            foreach (var shape in shapes)
            {
                Console.WriteLine($"Area of {shape.GetType().Name}: {shape.Area()}");
            }
        }
    }

```

<br />
<br />

4.  **Interface Segregation Principle:** Clients should not be force to have methods that doesn't need.

```nginx

    internal interface IPrinter
    {
        void Print(string document);
    }

    internal interface IMail
    {
        void SendMail(string message);
    }

    internal class InterfaceSegregationPrinciple : IPrinter, IMail
    {
        public void Print(string document)
        {
            Console.WriteLine($"Printing: {document}");
        }

        public void SendMail(string message)
        {
            Console.WriteLine($"Sending mail: {message}");
        }
    }

```

<br />
<br />

5.  **Dependency inversion Principle:** Reduces tight coupling between the classes.

```nginx


    internal interface IMailService
    {
        void SendEmail(string recipient, string subject, string body);
    }

    internal class MailService : IMailService
    {
        public void SendEmail(string recipient, string subject, string body)
        {
            Console.WriteLine($"Mail is sending to {recipient}, with subject {subject},
                with body {body}");
        }
    }

    internal class DependencyInversionPrinciple
    {
        private readonly IMailService mailService;

        public DependencyInversionPrinciple(IMailService mailService)
        {
            this.mailService = mailService;
        }

        public void SendMessage(string message)
        {
            this.mailService.SendEmail("abc@gmail.com", "Hello", "Hi");
        }
    }

```


