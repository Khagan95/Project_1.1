class PhoneBook
{
    private List<Person> contacts = new List<Person>();

    public void AddContact(Person person)
    {
        contacts.Add(person);
    }

    public bool RemoveContact(string nameOrLastName)
    {
        // Silme işlemi burada yapılır
        return ;
    }

    public bool UpdateContact(string nameOrLastName)
    {
        // Güncelleme işlemi burada yapılır
        return ;
    }

    public void ListContacts()
    {
        // Listeleme işlemi burada yapılır
    }

    public void SearchContacts()
    {
        // Arama işlemi burada yapılır
    }
}