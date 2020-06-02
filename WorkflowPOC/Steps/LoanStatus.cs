using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WorkflowCore.Interface;
using WorkflowCore.Models;

namespace WorkflowPOC.Steps
{
    public class LoanStatus : StepBody
    {       
        public bool IsLoanSanctioned { get; set; }      

        public override ExecutionResult Run(IStepExecutionContext context)
        {
           Console.WriteLine(IsLoanSanctioned ? "Your Loan is Sanctioned by ABC Bank" : "ABC Bank has rejected your Loan");            
            return ExecutionResult.Next();
        }
    }
}
