
public class BankAccount
{
    public int bankAmount;
    public string name;
    public string history;

    public Bank(int bankAmount, string name)
    {
        bankAmount = bankAmount;
        name = name;
    }

    public int getBankAmount()
    {
        return bankAmount;
    }

    public void setBankAmount(int age)
    {
        bankAmount = bankAmount;
    }

    public int getHistory()
    {
        return history;
    }

    public void setHistory(int age)
    {
        history = history;
    }
}

public save(BankAccount bankAccount, int amount)
{
    bankAccount.setBankAmount(bankAccount.getBankAmount() + amount);

    if (bankAccount.getHistory() == null)
    {
        bankAccount.getHistory() = "";
    }
    bankAccount.setHistory(bankAccount.getHistory() + "save succeed! you add " + amount + "on your account");
}

public retrieve(BankAccount bankAccount, int amount)
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
        throw new Exception("retreive failed : You don't have much money")
    }
}

public string checkAccount(BankAccount bankAccount)
{
    return BankAccount.getHistory();
}