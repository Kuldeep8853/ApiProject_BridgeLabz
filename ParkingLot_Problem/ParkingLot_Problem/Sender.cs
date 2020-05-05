using Experimental.System.Messaging;
using System;

namespace ParkingLot_Problem
{
    public class Sender
    {
        public void Send(double value)
        {
            try
            {
                MessageQueue Msmq = null;
                if (MessageQueue.Exists(@".\Private$\Msmq"))
                {
                    Msmq = new MessageQueue(@".\Private$\Msmq");
                }
                else
                {
                    Msmq = MessageQueue.Create(@".\Private$\Msmq");
                }
                Msmq.Send(value.ToString(), "Message send");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}