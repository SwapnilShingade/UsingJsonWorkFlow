using System;
using System.Collections.Generic;
using System.Text;
using WorkflowCore.Interface;
using WorkflowCore.Models;

namespace WorkflowPOC.Steps
{
   public  class SalaryValidation: StepBody
    {
        public override ExecutionResult Run(IStepExecutionContext context)
        {
            BankValidationResults result = new BankValidationResults()
            { IsCreditScoreValid = true };
            //ExecutionResult results = new ExecutionResult() { OutcomeValue = result.IsCreditScoreValid };
            Console.WriteLine("Salary Validation Step was called..");
            return ExecutionResult.Next();
        }
    }
}
