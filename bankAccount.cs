
public class BankAccount
{
    public int bankAmount;
    public string name;
    public string history;

    public BankAccount(int bankAmount, string name)
    {
        this.bankAmount = bankAmount;
        this.name = name;
    }

    public int getBankAmount()
    {
        return bankAmount;
    }

    public void setBankAmount(int bankAmount)
    {
        this.bankAmount = bankAmount;
    }

    public int getHistory()
    {
        return history;
    }

    public void setHistory(string history)
    {
        this.history = history;
    }
}

public class Operations
{
    public static void save(BankAccount bankAccount, int amount)
    {
        bankAccount.setBankAmount(bankAccount.getBankAmount() + amount);

        if (bankAccount.getHistory() == null)
        {
            bankAccount.getHistory() = "";
        }
        bankAccount.setHistory(bankAccount.getHistory() + "save succeed! you add " + amount + "on your account");
    }

    public static void retrieve(BankAccount bankAccount, int amount)
    {
        if (bankAccount.getBankAmount() >= amount)
        {
            bankAccount.setBankAmount(bankAccount.getBankAmount() - amount);
            if (bankAccount.getHistory() == null)
            {
                bankAccount.getHistory() = "";
            }
            bankAccount.setHistory(bankAccount.getHistory() + "retreive succeed! you retreive " + amount + "on your account");
        }
        else
        {
            throw new Exception("retreive failed : You don't have much money");
        }
    }

    public static string checkHistory(BankAccount bankAccount)
    {
        return BankAccount.getHistory();
    }
}