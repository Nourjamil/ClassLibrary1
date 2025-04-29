namespace ClassLibrary1
{


    public class Member
    {
        public int MemberId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public bool IsActive { get; set; }

        public List<BoatBooking> Bookings { get; set; } = new();
        public List<EventRegistration> Registrations { get; set; } = new();
    }

    //public class Motor : Motor
    //{
    //    public int _antelHorse;

    //    public int AntelHorse { get => _antelHorse; set => _antelHorse = value; }

    //    public Motor(int antelHorses)
    //    {
    //        _antelHorse = AntelHorse;
    //    }

    //}

    //public class Member : Boats
    //{
    //    // our private fields
    //    private string _name;
    //    private string _email;
    //    private string _phoneNumber;
    //    private string _address;
    //    private string _city;


    //    // our public properties 
    //    public string Name { get => _name; set => _name = value; }

    //    public string Email { get => _email; set => _email = value; }

    //    public string PhoneNr { get => _phoneNumber; set => _phoneNumber = value; }

    //    public string Address { get => _address; set => _address = value; }

    //    public string City { get => _city; set => _city = value; }

    //    // our constructor


    //    public Member(string name, string email, string phoneNumber, string address, string city)
    //    {
    //        _name = name;
    //        _email = email;
    //        _phoneNumber = phoneNumber;
    //        _address = address;
    //        _city = city;
    //    }


}
