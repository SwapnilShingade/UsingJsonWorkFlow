using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WorkflowCore.Interface;
using WorkflowCore.Models;

namespace WorkflowPOC.Steps
{
    public class ABCBank : StepBody
    {
        public bool IsBankSuccess { get; set; }
        public override ExecutionResult Run(IStepExecutionContext context)
        {
            IsBankSuccess = true;
            Console.WriteLine("This is ABC Bank Home Loan Department!!");
            return ExecutionResult.Next();
        }
    }
}
