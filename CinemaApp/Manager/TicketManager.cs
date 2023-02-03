using System;
namespace TaetrProjekt
{
    internal class TicketManager : ICrudService, IPrintService
    {
        private Ticket[] tickets = new Ticket[150];
        private int ticketCount;

        public void Add(Entity entity)
        {
            if (ticketCount > 149)
                Console.WriteLine("Bilet sayi 150-dir!");

            tickets[ticketCount++]=(Ticket)entity;
        }

        public void Delete(int id)
        {
            bool found = false;
            for (int i = 0; i < tickets.Length; i++)
            {
                if (tickets[i] == null)
                    continue;
                if (id == tickets[i].Id)

                {
                    found = true;

                    for (int j = 0; j < tickets.Length - 1; j++)
                    {
                        tickets[j] = tickets[j + 1];
                    }
                    ticketCount--;
                    Console.WriteLine($"{id}-li ticket silindi");
                    return;
                }
            }
            if (!found)
                Console.WriteLine($"{id}-li ticket not found!");
        }

        public Entity Get(int id)
        {
            for (int i = 0; i < tickets.Length; i++)
            {
                if (tickets[i] == null)
                    continue;
                if (tickets[i].Id == id)
                {

                    return tickets[i];
                }

            }
            Console.WriteLine("Not found!");

            return null;
        }

        public void Print()
        {
            foreach (var item in tickets)
            {
                if (item == null)
                    continue;
                Console.WriteLine(item.ToString());
            }
        }

        public void Update(int id, Entity entity)
        {
            for (int i = 0; i < tickets.Length; i++)
            {
                if (tickets[i] == null)
                    continue;
                if (tickets[i].Id == id)
                {
                    tickets[i] = (Ticket)entity;
                    Console.WriteLine("ugurla deyisdirildi!");
                    return;
                }
            }
            Console.WriteLine("not found!");
        }
    }
}

