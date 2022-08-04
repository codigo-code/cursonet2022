using System;
using System.Collections;
using System.Collections.Generic;

namespace PracticaMod2.model
{
    public abstract class Client
    {
        public string name { get; set; }
        public string cuil { get; set; }
        protected List<Operation> listOperation { get; set; }


        public Client()
        {
            this.listOperation = new List<Operation>();
        }


        public abstract void saveOperation(Operation operation);

        public IList<Operation> getOperations()
        {
            return this.listOperation;
        }

        public Operation getOperationById(int index)
        {
            if (this.listOperation[index] != null)
                return this.listOperation[index];
            else {
                throw new NullReferenceException("not found element");
            }
        }
    }
}

