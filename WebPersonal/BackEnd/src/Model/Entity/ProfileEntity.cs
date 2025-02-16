namespace WebPersonal.BackEnd.src.Model.Entity
{
    public class ProfileEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string LastName { get; set; }
        public string Description { get; set; }

        public DateTime BirthDay { get; set; }
        public string Email { get; set; }

        public string GitHub { get; set; }

        public ICollection<ProjectEntity> Projects { get; set; }
        public ICollection<Skill> Skills { get; set; }
    }
}
