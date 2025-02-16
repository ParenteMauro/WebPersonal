namespace WebPersonal.BackEnd.src.Model.Mappers;
using WebPersonal.BackEnd.src.Model.Entity;
using WebPersonal.Shared.SharedDTO;

public static class PersonalProfileMapper
{
    public static ProfileDto Map(ProfileEntity entity)
    {
        return new ProfileDto()
        {
            Name = entity.Name,
            LastName = entity.LastName,
            BirthDay = entity.BirthDay,
            Description = entity.Description,
            Email = entity.Email,
            GitHub = entity.GitHub
        };
    }
}

