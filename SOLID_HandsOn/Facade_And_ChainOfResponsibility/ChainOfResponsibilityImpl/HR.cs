using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibilityImpl
{
    public class HR : ILeaveRequestHandler
    {
        public ILeaveRequestHandler NextHandler => null;

        public void HandleRequest(LeaveRequest leaveRequest)
        {
            if (leaveRequest.LeaveDays > 5)
            {
                Console.WriteLine("HR Accepts");
            }
        }
    }
}