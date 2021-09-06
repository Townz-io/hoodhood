namespace Domain.Users
{
    public class Household
    {
        public Guid Id { get; set; }
        public List<User> Users { get; set; }
        public Guid HouseId { get; set; }
        public List<Chore> Chores { get; set; }
        public List<PayBill> Bills { get; set; } 
        public PayRent Rent { get; set; }
    }
}