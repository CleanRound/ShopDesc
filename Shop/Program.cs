class Shop
{
    private string storeName;
    private string address;
    private string storeDescription;
    private string contactPhoneNumber;
    private string email;

    public void InputData()
    {
        Console.Write("Enter the store name: ");
        storeName = Console.ReadLine();

        Console.Write("Enter the address: ");
        address = Console.ReadLine();

        Console.Write("Enter the store profile description: ");
        storeDescription = Console.ReadLine();

        Console.Write("Enter the contact phone number: ");
        contactPhoneNumber = Console.ReadLine();

        Console.Write("Enter the email: ");
        email = Console.ReadLine();
    }

    public void OutputData()
    {
        Console.WriteLine($"Store Name: {storeName}");
        Console.WriteLine($"Address: {address}");
        Console.WriteLine($"Store Profile Description: {storeDescription}");
        Console.WriteLine($"Contact Phone Number: {contactPhoneNumber}");
        Console.WriteLine($"Email: {email}");
    }

    public string GetStoreName()
    {
        return storeName;
    }


    public void SetStoreName(string name)
    {
        storeName = name;
    }

    public string GetAddress()
    {
        return address;
    }

    public void SetAddress(string addr)
    {
        address = addr;
    }

    public string GetStoreDescription()
    {
        return storeDescription;
    }

    public void SetStoreDescription(string description)
    {
        storeDescription = description;
    }

    public string GetContactPhoneNumber()
    {
        return contactPhoneNumber;
    }

    public void SetContactPhoneNumber(string phoneNumber)
    {
        contactPhoneNumber = phoneNumber;
    }

    public string GetEmail()
    {
        return email;
    }

    public void SetEmail(string emailAddress)
    {
        email = emailAddress;
    }
}

internal class Program
{
    private static void Main(string[] args)
    {
        Shop myShop = new Shop();

        myShop.InputData();

        myShop.OutputData();
    }
}