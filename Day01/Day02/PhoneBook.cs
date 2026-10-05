namespace Day02;

public class PhoneBook
{
    public void Run(string name)
    {
        Dictionary<string, string> phonebook = new Dictionary<string, string>();
        phonebook.Add("Anu", "+3598888888");
        phonebook.Add("Ana", "+3598888889");
        phonebook.Add("Eme", "+3598888880");
        phonebook.Add("Manju", "+3598888886");
        if (phonebook.TryGetValue(name, out string value))
        {
            Console.WriteLine($"{name}  and the number is {value}");
        }
        else
        {
            Console.WriteLine("No name found");
        }
    }
}