using DesignPatternsAndSolid.SOLID;


Console.WriteLine($"{Environment.NewLine}** Single Responsibility Principle **");
SingleResponsibilityPrinciple singleResponsibilityPrinciple = new SingleResponsibilityPrinciple();
singleResponsibilityPrinciple.PerformTask();


Console.WriteLine($"{Environment.NewLine}** Open/Closed Principle **");
OpenClosedPrinciple openClosedPrinciple = new OpenClosedPrinciple();
openClosedPrinciple.DisplaySalaries();


Console.WriteLine($"{Environment.NewLine}** Liskov Substitution Principle **");
LiskovSubstitutionPrinciple liskovSubstitutionPrinciple = new LiskovSubstitutionPrinciple();
liskovSubstitutionPrinciple.CalculateArea();


Console.WriteLine($"{Environment.NewLine}** Interface Segregation Principle **");
InterfaceSegregationPrinciple interfaceSegregationPrinciple = new InterfaceSegregationPrinciple();  
interfaceSegregationPrinciple.Print("Hello, World!");
interfaceSegregationPrinciple.SendMail("This is a test email.");


Console.WriteLine($"{Environment.NewLine}** Dependency Inversion Principle **");
DependencyInversionPrinciple dependencyInversionPrinciple = new DependencyInversionPrinciple(new MailService());
dependencyInversionPrinciple.SendMessage("This is a message sent using the Dependency Inversion Principle.");

Console.ReadLine();