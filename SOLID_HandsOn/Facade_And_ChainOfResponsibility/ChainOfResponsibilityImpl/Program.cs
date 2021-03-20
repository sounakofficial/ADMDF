using System;

namespace ChainOfResponsibilityImpl
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            ILeaveRequestHandler supervisor = new Supervisor();
            //ILeaveRequestHandler projectManager = new ProjectManager();
            //ILeaveRequestHandler hr = new HR();

            //supervisor.NextHandlerSet(projectManager);
            //projectManager.NextHandlerSet(hr);

            LeaveRequest lr = new LeaveRequest
            {
                Employee = "john",
                LeaveDays = 7
            };

            supervisor.HandleRequest(lr);
        }
    }
}