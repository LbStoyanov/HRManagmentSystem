using AutoMapper;
using HR.ManagmentSystem.Aplication.Features.LeaveType.Queries.GetAllLeaveTypes;
using HR.ManagmentSystem.Aplication.Features.LeaveType.Queries.GetLeaveTypeDetails;
using HR.ManagmentSystem.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.ManagmentSystem.Aplication.MappingProfiles
{
    public class LeaveTypeProfile : Profile
    {
        public LeaveTypeProfile()
        {
            CreateMap<LeaveTypeDto, LeaveType>().ReverseMap();

            CreateMap<LeaveType, LeaveTypeDetailsDto >();
        }
    }
}
