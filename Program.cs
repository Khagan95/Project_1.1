class Program
{
    static void Main(string[] args)
    {
        PhoneBook phoneBook = new PhoneBook();
        // Başlangıçta 5 kişi eklemek için:
        phoneBook.AddContact(new Person { FirstName = "Ahmet", LastName = "Yılmaz", PhoneNumber = "5551112233" });
        phoneBook.AddContact(new Person { FirstName = "Ayşe", LastName = "Kara", PhoneNumber = "5332223344" });
        phoneBook.AddContact(new Person { FirstName = "Mehmet", LastName = "Demir", PhoneNumber = "5423334455" });
        phoneBook.AddContact(new Person { FirstName = "Fatma", LastName = "Kaya", PhoneNumber = "5334445566" });
        phoneBook.AddContact(new Person { FirstName = "Ali", LastName = "Şahin", PhoneNumber = "5555556677" });

        Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz:");
        Console.WriteLine("(1) Yeni Numara Kaydetmek");
        Console.WriteLine("(2) Varolan Numarayı Silmek");
        Console.WriteLine("(3) Varolan Numarayı Güncelleme");
        Console.WriteLine("(4) Rehberi Listelemek");
        Console.WriteLine("(5) Rehberde Arama Yapmak");

        int choice = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case 1:
                // Yeni numara kaydetme işlemi
                break;
            case 2:
                // Numara silme işlemi
                break;
            case 3:
                // Numara güncelleme işlemi
                break;
            case 4:
                // Rehberi listeleme işlemi
                break;
            case 5:
                // Arama yapma işlemi
                break;
            default:
                Console.WriteLine("Geçersiz seçim!");
                break;
        }
    }
}