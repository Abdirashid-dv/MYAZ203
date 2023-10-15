using System.Diagnostics;
using System.Net.NetworkInformation;

class Bank
{
    public string FirstName { get; set; } = string.Empty;

    public string LastName { get; set; } = string.Empty;

    public string FullName
    {
        get
        {
            return FirstName + " " + LastName;
        }
        set { }
    }

    private List<string> accountActivities { get; }

    public string AccountDate = DateTime.Now.ToString();

    private double _balance;
    public double Balance
    {
        get { return _balance; }
        set { _balance = value; }
    }

    public float CheckAccount()
    {
        Console.WriteLine("");
    }

    public void Withdraw(float Amount)
    {
        if (Amount > 10000 && Amount < 50)
        {
            throw new Exception("Çekilecek para 50den küçük ve 10000den büyük olamaz");
        }
        else
        {
            if (_balance >= Amount)
            {
                _balance -= Amount;
                accountActivities.Add($"Cekilmis Para{Amount} Tarih {DateTime.Now}");
            }
        }
    }


    public void Deposit(float Amount)
    {
        _balance += Amount;
    }

    public void AccountActivities()
    {
        foreach (var activity in accountActivities)
        {
            Console.WriteLine(activity);
        }
    }

    public Account()
    {
        accountActivities = new List<string>();
    }



}