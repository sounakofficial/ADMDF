using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibilityImpl
{
    public class Supervisor : ILeaveRequestHandler
    {
        public ILeaveRequestHandler NextHandler => new ProjectManager();

        public void HandleRequest(LeaveRequest leaveRequest)
        {
            if (leaveRequest.LeaveDays <= 3)
            {
                Console.WriteLine("Superviser Accept");
            }
            else
            {
                Console.WriteLine("Superviser Rejects");
                NextHandler.HandleRequest(leaveRequest);
            }
        }
    }
}