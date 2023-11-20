﻿using BusinessApp.Application.Model;

namespace BusinessApp.WebAPI.DTO
{
    public record GeraetDTO(int Id, string art, string name, LocalPersonDTO? person, LocalRaumDTO? raum);
    public record LocalGeraetDTO(int Id, string art, string name);
}
