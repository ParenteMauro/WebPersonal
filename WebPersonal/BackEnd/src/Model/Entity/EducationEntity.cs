namespace WebPersonal.BackEnd.src.Model.Entity
{
    public enum EducationType
    {
        UNIVERSITY = 0,
        COURSE = 1,
    }
    public class EducationEntity
    {
        public  int Id { get; set; }
        public  DateTime StartDate { get; set; }
        public  DateTime? EndDate { get; set; }
        public  string CourseName { get; set; }
        public string? UniversityName { get; set; }
        
        public EducationType EducationType { get; set; }
        public byte[]? CertificatePdf { get; set; }

    }
}
