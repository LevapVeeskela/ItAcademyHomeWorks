namespace Common.Models
{
    public class PersonModel
    {
        public string Passport { get; set; }

        public bool IsHaveTickets { get; set; }

        public bool IsHaveBaggage { get; set; }

        public ushort WeightBags { get; set; }

        public string CountryDestination { get; set; }

        public bool IsHaveVisa { get; set; }
    }
}