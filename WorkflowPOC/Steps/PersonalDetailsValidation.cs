using System;
using System.Collections.Generic;
using System.Text;
using WorkflowCore.Interface;
using WorkflowCore.Models;

namespace WorkflowPOC.Steps
{
   public  class PersonalDetailsValidation : StepBody
    {
        public override ExecutionResult Run(IStepExecutionContext context)
        {         
            
            //ExecutionResult results = new ExecutionResult() { OutcomeValue = result.IsCreditScoreValid };
            Console.WriteLine("Personal Details Validation Step was called..");
            return ExecutionResult.Next();
        }       
    }
}
