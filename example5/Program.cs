Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if (username.ToLower() == "тамара")
{
    Console.WriteLine("Ура! Это же ТАМАРА");
}  
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}