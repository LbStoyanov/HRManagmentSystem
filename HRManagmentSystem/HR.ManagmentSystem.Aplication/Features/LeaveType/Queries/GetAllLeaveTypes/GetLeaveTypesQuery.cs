using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.ManagmentSystem.Aplication.Features.LeaveType.Queries.GetAllLeaveTypes
{
    public class GetLeaveTypesQuery : IRequest<List<LeaveTypeDto>>
    {
    }

    //Deference between class and record is that records are inmutable
    //public record GetLeavesTypesQuery : IRequest<List<LeaveTypeDto>>;
}
