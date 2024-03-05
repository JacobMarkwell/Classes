using System;

public class Customer
{
    private int cus_id;
    public string cus_name;
    public int cus_age;

    public Customer(int cus_id, string cus_name, int cus_age)
    {
        this.cus_id = cus_id;
        this.cus_name = cus_name;
        this.cus_age = cus_age;
    }

    public void ChangeID(int new_id)
    {
        this.cus_id = new_id;
    }

    public void PrintCusInfo()
    {
        Console.WriteLine($"Customer ID: {cus_id}");
        Console.WriteLine($"Customer Name: {cus_name}");
        Console.WriteLine($"Customer Age: {cus_age}");
    }

    public void CompareAge(Customer objCustomer)
    {
        if (this.cus_age > objCustomer.cus_age)
        {
            Console.WriteLine($"{this.cus_name} is older than {objCustomer.cus_name}");
        }
        else if (this.cus_age < objCustomer.cus_age)
        {
            Console.WriteLine($"{objCustomer.cus_name} is older than {this.cus_name}");
        }
        else
        {
            Console.WriteLine($"{this.cus_name} and {objCustomer.cus_name} are of the same age.");
        }
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Customer customer1 = new Customer(110, "Alice", 28);
        Customer customer2 = new Customer(111, "Bob", 30);

        Console.WriteLine("Customer 1 Information:");
        customer1.PrintCusInfo();
        Console.WriteLine();

        Console.WriteLine("Customer 2 Information:");
        customer2.PrintCusInfo();
        Console.WriteLine();

        customer1.ChangeID(220);
        customer2.ChangeID(221);

        Console.WriteLine("Customer 1 Updated Information:");
        customer1.PrintCusInfo();
        Console.WriteLine();

        Console.WriteLine("Customer 2 Updated Information:");
        customer2.PrintCusInfo();
        Console.WriteLine();

        Console.WriteLine("Comparing Ages:");
        customer1.CompareAge(customer2);
    }
}