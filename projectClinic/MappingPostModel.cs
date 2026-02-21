using AutoMapper;
using projectClinic.Models;
using Clinic.Core.Entities;

namespace projectClinic
{
    public class MappingPostModel:Profile
    {
        public MappingPostModel() { 
            CreateMap<ClientsPostModel,Clients>().ReverseMap();
            CreateMap<DoctorsPostModel,Doctors>().ReverseMap();
            CreateMap<QueuePostModel,Queues>().ReverseMap();
        }
    }
}
