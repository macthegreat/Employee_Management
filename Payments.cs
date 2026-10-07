using System.Globalization;

namespace Payments;

abstract class Payment
{
    public int Id{get; set;}
    public decimal Amount{get; set;}
    public string CustomerName {get; set;}

    public Payment(int id, decimal amount, string name)
    {
        Id=id;
        Amount=amount;
        CustomerName=name;
    }

   public void DisplayInfo()
    {
        Console.WriteLine($"Id: {Id}");
        Console.WriteLine($"Amount: {Amount}");
        Console.WriteLine($"Customer Name: {CustomerName}");
    }
    public abstract string ProcessPayment();
}
class CreditCardPayment : Payment
{
    public decimal CreditCardNumber {get;set;}

    public CreditCardPayment(int id, decimal amount,string name, decimal creditcard) : base(id, amount, name)
    {
        CreditCardNumber=creditcard;
    }

    public override string ProcessPayment()
    {
        return ($"credit card number of {Amount} processed successfully");
    }
}

class BankTransferpayment : Payment
{
    public string BankName {get; set;}
    public BankTransferpayment(int id, decimal amount,string name, string bankName) : base(id, amount, name)
    {
        BankName=bankName;
    }
    public override string ProcessPayment()
    {
        return ($"Bank Transfer payment of {Amount} processed successfully through {BankName}.");
    }
}
class MobileMoneyPayment : Payment
{
    public string PhoneNumber{get; set;}

    public MobileMoneyPayment(int id,  decimal amount, string name, string phone) : base(id, amount, name)
    {
        PhoneNumber = phone;
    }

    public override string ProcessPayment()
    {
        return ($"Mobile Money payment of {Amount} processed successfully.");
    }

}