Console.WriteLine("Введите имя пользователя"!);
string Username = Console.ReadLine();
if (Username.ToLower() == "маша")
{
    Console.Write("Ура, это же ");
    Console.WriteLine(Username);
}
else 
{
    Console.Write("Привет, ");
    Console.WriteLine(Username);
}