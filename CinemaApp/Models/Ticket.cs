using System;
namespace TaetrProjekt
{
	internal class Ticket:Entity
	{
       // public SessionManager CurrentSession { get; set; }

		//internal Session[] sessions = Array.Empty<Session>();

		internal decimal Price { get; set; }

		internal int Count { get; set; }
        
        internal decimal BuyTicket(int sessionId , int sessionQuantity)

        {
            //Session session = (Session)CurrentSession.Get(sessionId);

            return sessionId;

            return sessionQuantity;

        }
         public void Place(int raw,int column)
        {
           
            string[,] place = new string[10, 20];

            for (int i = 0; i < place.GetLength(0); i++)
            {
                for (int j = 0; j <place.GetLength(1); j++)
                {
                    place[i, j] = ("0");
                if (raw == i && column == j)
                    {
                        place[i, j] = "1";
                    }
                }return;
            }
        }
        public override string ToString()
        {
            return $"Price:{Price}|_____|Count:{Count}|_____|Toplam Hesab:{Count * Price}";
        }
    }
}

