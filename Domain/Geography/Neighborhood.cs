namespace Domain.Geography
{
    public class Neighborhood
    {
        public String Name { get; set; }
        public String City { get; set; }
        public String County { get; set; }
        public String State { get; set; }
        public String Country { get; set; }
        public List GeoJSON { get; set; }
        public String NeighborhoodType { get; set; }
        public Vector2 Center { get; set; }
        public Vector4 Bbox { get; set; }
    }
}