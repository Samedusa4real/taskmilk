class Product
{
    private string _name;
    public string Name 
    { 
        get
        {
            return _name;
        } 
        
        set
        {
            if(string.IsNullOrWhiteSpace(value) || value.Length > 30)
            {
                Console.WriteLine("WRONG INPUT!");
            }
            else
            {
                value = _name;
            }
        } 
    }

    private double _price;
    public double Price
    {
        get
        {
            return _price;
        }
        set
        {
            if (value > 0)
            {
                _price = value;
            }
            else
            {
                Console.WriteLine("WRONG PRICE!");
            }
        }
    }
    private int _count;
    public int Count
    {
        get
        {
            return _count;
        }
        set
        {
            if (value > 0)
            {
                _count = value;
            }
            else if(value == 0)
            {
                Console.WriteLine("OUT OF STOCK!");
            }
            else
            {
                Console.WriteLine("SOMETHING WENT WRONG!");
            }
        }
    }

    private double TotalIncome;

    public Product(string name)
    {
        this.Name = name;
    }

    public void Sell()
    {
        if(Count>0)
        {
            Count--;
            TotalIncome += Price;
        }
        else
        {
            Console.WriteLine("OUT OF STOCK!");
        }
    }
}