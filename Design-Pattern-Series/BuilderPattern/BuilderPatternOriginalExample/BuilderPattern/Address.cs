namespace BuilderPattern
{
    public class Address
    {
        public Address()
        {

        }

        public Address(string addressLine1, string addressLine2, string addressLine3, string town, string postcode)
        {
            AddressLine1 = addressLine1;
            AddressLine2 = addressLine2;
            AddressLine3 = addressLine3;
            Town = town;
            Postcode = postcode;
        }

        public string AddressLine1 { get; }

        public string AddressLine2 { get; }

        public string AddressLine3 { get; }

        public string Town { get; }

        public string Postcode { get; }
    }
}
