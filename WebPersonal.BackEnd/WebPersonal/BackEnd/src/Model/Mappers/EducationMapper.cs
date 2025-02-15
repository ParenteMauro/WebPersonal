using WebPersonal.BackEnd.src.Model.Entity;
using WebPersonal.Shared.SharedDTO;
namespace WebPersonal.BackEnd.src.Model.Mappers
{
    public static class EducationMapper
    {
        public static EducationDto Map(EducationEntity entity)
        {
            return new EducationDto()
            {
                Id = entity.Id,
                CourseName = entity.CourseName,
                EndDate = entity.EndDate,
                StartDate = entity.StartDate,
                UniversityName = entity.UniversityName
            };
        }
    }
}