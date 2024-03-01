using Lesson5excercise4lab;

namespace Lesson5excercise4lab
{


    abstract class Machines
    {
        // Property
        public abstract string Name { get; set; }
        public abstract string Description { get; set; }
        public abstract string Manufacturer { get; set; }
       


        // Methods
        public abstract double Calculate();

        public string Heading()
        {
            return "Machine: ";
        }
            
    }
    
 

    class InjectionMoldingMachines : Machines
    {
        // override the aspect property

        public override string Name { get; set; }
        public override string Description { get; set; }
        public override string Manufacturer { get; set; }
        public virtual double Size { get; set; }
        public virtual double TimeCost {  get; set; }
       
        


        
        public InjectionMoldingMachines()
        {
            Name = string.Empty;
            Description = string.Empty;
            Manufacturer = string.Empty;
            Size = 0;
            TimeCost = 0;

        }

        public InjectionMoldingMachines(string name, string description, string manufacturer, double size, double timecost)
            {
            Name = name;
            Description = description;
            Manufacturer = manufacturer;
            Size = size;
            TimeCost = timecost;
        }

        public override double Calculate()
        {
            Console.WriteLine("Please enter size tonnage of machine:");
            Size = double.Parse(Console.ReadLine());
            Console.WriteLine("Please enter TimeCost parts per hour: ");
            TimeCost = double.Parse( Console.ReadLine());
            return (TimeCost / Size);

        }
        public virtual string Template()
        {
            
            return $"{Heading()}" +
            "\nName: " + Name + 
            "\nDescription: " + Description + 
            "\nManufacturer: " + Manufacturer +
            "\nSize: " + Size +
            "\nTimeCost: " + TimeCost +
            "\n\nCalculated ratio for the original entry per hour: " + Calculate();

        }

    }


    }




internal class Program
{
    static void Main(string[] args)
    {

        InjectionMoldingMachines Mach1 = new InjectionMoldingMachines();
        Mach1.Name = "1";
        Mach1.Description = "Toggle";
        Mach1.Manufacturer = "Cincinatti";
        Mach1.Size = 100;
        Mach1.TimeCost = 500;
    
        Console.WriteLine(Mach1.Template());
        

    } 
    }

