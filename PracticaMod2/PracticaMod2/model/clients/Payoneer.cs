using System;
namespace PracticaMod2.model.clients
{
    public class Payoneer : Client
    {
        

        public override void saveOperation(Operation operation)
        {
            operation.charge -= (operation.charge * 0.025);
            base.listOperation.Add(operation);
        }
    }
}

