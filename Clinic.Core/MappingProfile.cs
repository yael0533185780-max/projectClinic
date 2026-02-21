using AutoMapper;
using Clinic.Core.DTOs;
using Clinic.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Clinic.Core
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Clients, ClientDTO>().ReverseMap();
            CreateMap<Doctors, DoctorDTO>().ReverseMap();
            CreateMap<Queues, QueueDTO>().ReverseMap();

          
        }
    }

}
