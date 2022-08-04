using System;
using System.Collections.Generic;
using PracticaMod2.model;

namespace PracticaMod2.controler
{
    public class ClientController
    {
      
        public void listOperationsByClient(Client client)
        {
            // wise , payoneer o binance ...

            // logica extra
            Console.WriteLine("client " + client.name);
            double sum = 0;
            foreach(var item in client.getOperations()){
                Console.WriteLine("operation name " + item.description + ", charge= " + item.charge);
                sum += item.charge;
            }

            Console.WriteLine("total amount= " + sum);
        }


    }
}

