using System;
namespace PracticaMod2.model
{
    public class Operation
    {
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public double charge { get; set; }  

        public Operation(int id, string name, string description, double charge)
        {
            this.id = id;
            this.name = name;
            this.description = description;
            this.charge = charge;
        }
    }
}

