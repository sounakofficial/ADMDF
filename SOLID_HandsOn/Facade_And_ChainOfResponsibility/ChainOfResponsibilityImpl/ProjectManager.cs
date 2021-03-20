using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibilityImpl
{
    public class ProjectManager : ILeaveRequestHandler
    {
        public ILeaveRequestHandler NextHandler => new HR();

        public void HandleRequest(LeaveRequest leaveRequest)
        {
            if (leaveRequest.LeaveDays <= 5)
            {
                Console.WriteLine("ProjectManager Accept");
            }
            else
            {
                Console.WriteLine("ProjectManager Rejects");
                NextHandler.HandleRequest(leaveRequest);
            }
        }
    }
}