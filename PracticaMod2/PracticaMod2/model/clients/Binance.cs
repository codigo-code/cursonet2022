using System;
namespace PracticaMod2.model.clients
{
    public class Binance : Client
    {
      
        public override void saveOperation(Operation operation)
        {
            base.listOperation.Add(operation);
        }
    }
}

