namespace Domain.Housing
{
    public class Property
    {
        public int StreetNumber { get; set; }
        public String StreetName { get; set; }
        public int CondoNumber { get; set; }
        public int SquareFootage { get; set; }
        public int Stories { get; set; }
        public int Rooms { get; set; }
        public int Bathrooms { get; set; }
        public int LotSquareFootage { get; set; }
        public int YardSquareFootage { get; set; }
        public int PatioSquareFootage { get; set; }
        public String PropertyType { get; set; }
        public Boolean Rented { get; set; }
        public Boolean OwnerOccupied { get; set; }
        public Boolean ForRent { get; set; }
        public List<ServiceProvider> ServiceProviders { get; set; }
        public List<UtilitiyProvider> UtilityProviders { get; set; }
        public List<IotDevices> IotDevices { get; set; }
        public List<Camera> Cameras { get; set; }
        public SmokeDetector SmokeDetector { get; set; }
        public Vector2 Coordinates { get; set; }
        public String Neighborhood { get; set; }
    }
}