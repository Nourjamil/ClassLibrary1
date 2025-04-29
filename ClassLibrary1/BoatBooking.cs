using Microsoft.VisualBasic;

namespace ClassLibrary1
{
    public class BoatBooking : Boat
    {


        public int BookingID { get; set; }
        public int BådID { get; set; }
        public int MedlemsID { get; set; }
        public DateTime SejlTid { get; set; }
        public string Mødested { get; set; }


        public BoatBooking(int BookingID, int BådID, int MeldemsID, DateAndTime Sejltid, string mødested) { }

        public void BookBåd(int bådID, int medlemsID, DateTime sejlTid, string mødested)
        {
            Booking nyBooking = new Booking
            {
                BookingID = GenerateBookingID(), // funktion til at generere ID
                BådID = bådID,
                MedlemsID = medlemsID,
                SejlTid = sejlTid,
                Mødested = mødested
            };

            // Her kan du tilføje booking til en database eller liste
            bookings.Add(nyBooking);

            Console.WriteLine("Båd er blevet booket til den ønskede tid.");
        }

    }
}
