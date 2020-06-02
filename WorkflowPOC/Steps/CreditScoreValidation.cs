using System;
using System.Collections.Generic;
using System.Text;
using WorkflowCore.Interface;
using WorkflowCore.Models;

namespace WorkflowPOC.Steps
{
   public class CreditScoreValidation : StepBody
    {
        public bool IsCreditScoreValid { get; set; }
         public override ExecutionResult Run(IStepExecutionContext context)
        {            
            Console.WriteLine("ABC Bank Step Result is " + IsCreditScoreValid.ToString());
            Console.WriteLine("Credit Score Validation Step was called..");           
            return ExecutionResult.Next();
        }
    }
}
