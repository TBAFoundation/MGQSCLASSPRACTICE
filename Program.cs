Random rand = new();
decimal accountBalance = rand.Next(10001);
Console.WriteLine($"Available Balance: {accountBalance}");

while (accountBalance >= 500)
{
    decimal deduction = rand.Next(10, 101);
    accountBalance -= deduction;
    Console.WriteLine($"Deduction: {deduction}\nBalance After: {accountBalance}");
}

Console.WriteLine("\nEnd of WHILE LOOP\n\nBeginning of FOR LOOP\n");

for (; accountBalance < 500;)
{
    decimal inflow = rand.Next(10, 101);
    accountBalance += inflow;
    Console.WriteLine($"Credit: {inflow}\nBalance After: {accountBalance}");
}