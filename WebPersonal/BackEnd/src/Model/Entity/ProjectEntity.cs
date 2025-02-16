namespace WebPersonal.BackEnd.src.Model.Entity
{
    public class ProjectEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public ICollection<Skill> Skills {  get; set; }  
    }
}
