using AutoMapper;
using chat.Server.Data;
using chat.Shared.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chat.Server.Models
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<ApplicationUser, UserDto>();
            CreateMap<Channel, ChannelDto>();
            CreateMap<Group, GroupDto>();
            CreateMap<Message, MessageDto>();
            CreateMap<PrivateMessage, PrivateMessageDto>();
        }
    }
}
