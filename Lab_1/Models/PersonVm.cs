namespace Lab_1.Models
{
    public class PersonVm
    {
        public string FirstName;
        public string SecondName;
        public string PhoneNumber;
        public string Address;

        public PersonVm() { }
        public PersonVm(string first_name, string second_name, string phone_number, string address)
        {
            FirstName = first_name;
            SecondName = second_name;
            PhoneNumber = phone_number;
            Address = address;
        }
    }
}
