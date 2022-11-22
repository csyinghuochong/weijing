using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{
    [Event]
    public class Task_OnTaskNpcDialog : AEventClass<EventType.TaskNpcDialog>
    {

        protected override void Run(object numerice)
        {
            EventType.TaskNpcDialog args = numerice as EventType.TaskNpcDialog;
            if (args.ErrorCode == 0)
            {

            }
        }
    }
}
