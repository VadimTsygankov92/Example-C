Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if (username.ToLower() == "вадим") 
  {
    Console.WriteLine("Урааа, это же ВАДИМ!!!");
  }
  else
  {
    Console.Write("Привет, ");
    Console.WriteLine(username);
  }
