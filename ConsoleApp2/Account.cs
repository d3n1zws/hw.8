class Account
{
    public string username; 
    public string password;
    public void login(string Username, string Password)
    {
        if (Username == username && Password == password)
        {
            Console.WriteLine("giris ugurlu oldu");
        }    
        else
        {
            Console.WriteLine("email ve password sehvdir");
        }
    }
}