using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibilityImpl
{
    public interface ILeaveRequestHandler
    {
        ILeaveRequestHandler NextHandler { get; }

        void HandleRequest(LeaveRequest leaveRequest);
    }
}