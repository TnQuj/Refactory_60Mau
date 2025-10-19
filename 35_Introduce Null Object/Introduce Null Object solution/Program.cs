using System;

class BillingPlan
{
    public static BillingPlan Basic() => new BillingPlan("Basic Plan");
    public static BillingPlan Premium() => new BillingPlan("Premium Plan");

    public string Name { get; }
    public BillingPlan(string name) => Name = name;
}

abstract class Customer
{
    public abstract BillingPlan GetPlan();
    public abstract bool IsNull();
}

class RealCustomer : Customer
{
    private BillingPlan plan;
    public RealCustomer(BillingPlan plan) => this.plan = plan;

    public override BillingPlan GetPlan() => plan;
    public override bool IsNull() => false;
}

class NullCustomer : Customer
{
    public override BillingPlan GetPlan() => BillingPlan.Basic();
    public override bool IsNull() => true;
}

class Order
{
    public Customer Customer { get; set; }
}

class Program
{
    static void Main()
    {
        Order order1 = new Order { Customer = new RealCustomer(BillingPlan.Premium()) };
        Order order2 = new Order { Customer = null };

        // Replace null with Null Object
        Customer customer1 = order1.Customer ?? new NullCustomer();
        Customer customer2 = order2.Customer ?? new NullCustomer();

        BillingPlan plan1 = customer1.GetPlan();
        BillingPlan plan2 = customer2.GetPlan();

        Console.WriteLine($"Order 1 plan: {plan1.Name}");
        Console.WriteLine($"Order 2 plan: {plan2.Name}");
    }
}
