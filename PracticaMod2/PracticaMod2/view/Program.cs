using System;
using PracticaMod2.controler;
using PracticaMod2.model;
using PracticaMod2.model.clients;

namespace PracticaMod2
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1 o N clientes --_> crear el obj ---> crear las operaciones para ese objeto
            Client c1 = new Payoneer();


            c1.name = "pepito";
            c1.cuil = "123";
            /*
             * ejemplo
             *  int  id =  (int) Console.ReadLine();  ---> ReadLine ---> siempre retorna un string --> recuerden castear
            */
            c1.saveOperation(new Operation(123,"peppa pig","bank-transfer",100.0));
            c1.saveOperation(new Operation(3423, "dora la explodora", "debit-transfer", 500.0));
            c1.saveOperation(new Operation(123, "lisa simpson", "manual-transfer", 4500.0));


            // Controller -> instanciamos el obj

            ClientController cc = new ClientController();

            cc.listOperationsByClient(c1);


        }
    }
}

