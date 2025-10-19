using System;

class BillingPlan
{
    public static BillingPlan Basic() => new BillingPlan("Basic Plan");
    public static BillingPlan Premium() => new BillingPlan("Premium Plan");

    public string Name { get; }
    public BillingPlan(string name) => Name = name;
}

class Customer
{
    private BillingPlan plan;
    public Customer(BillingPlan plan) => this.plan = plan;

    public BillingPlan GetPlan() => plan;
}

class Order
{
    public Customer Customer { get; set; }
}

class Program
{
    static void Main()
    {
        Order order1 = new Order { Customer = new Customer(BillingPlan.Premium()) };
        Order order2 = new Order { Customer = null };

        BillingPlan plan1, plan2;

        // Need to check for null every time
        if (order1.Customer == null)
            plan1 = BillingPlan.Basic();
        else
            plan1 = order1.Customer.GetPlan();

        if (order2.Customer == null)
            plan2 = BillingPlan.Basic();
        else
            plan2 = order2.Customer.GetPlan();

        Console.WriteLine($"Order 1 plan: {plan1.Name}");
        Console.WriteLine($"Order 2 plan: {plan2.Name}");
    }
}