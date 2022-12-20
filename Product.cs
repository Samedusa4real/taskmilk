class Product
{
    public string Name
    {
        get
        {
            return Name;
        }
        set
        {
            if (string.IsNullOrWhiteSpace(value) || value.Length == 0)
            {
                Console.WriteLine("WRONG PRODUCT");
            }
            else
            {
                Name = value;
            }
        }
    }

    public int Price = 30;

    private int Count
    {
        get { return Price; }

        set
        {
            if (value > 0)
            {
                Count = value;
            }
            else
            {
                Console.WriteLine("COUNT CANT BE LESS THAN '0'");
            }
        }
    }

    private int TotalIncome = 0;

    public void Sell()
    {
        if (Count > 0)
        {
            Count -= 1;
            TotalIncome += Price;
        }
        else
        {
            Console.WriteLine("OUT OF STOCK!");
        }
    }
}