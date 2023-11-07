using DAL.Interfaces;

namespace DAL.Entities
{
    public abstract class User : IEntity
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public DateTime Birthdate { get; set; }
        public string Password { get; set; }
        public virtual ICollection<Appointment> Appointments { get; set; }
    }
}