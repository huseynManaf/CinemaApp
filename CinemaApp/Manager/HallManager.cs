using System;
namespace TaetrProjekt
{
    internal class HallManager : ICrudService, IPrintService
    {
        private Hall[] halls = new Hall[2];

        private int _currentIndex ;

        public void Add(Entity entity)
        {
            if (_currentIndex>2)
            {
                Console.WriteLine("limiti kecdiz 2 zal var");
                return;
            }
            halls[_currentIndex++] = (Hall)entity;
           
            
        }

        public void Delete(int id)
        {
            bool found = false;

            for (int i = 0; i < halls.Length; i++)
            {
                if (halls[i] == null)

                    continue;
                if (id == halls[i].Id)

                {
                    found = true;

                    for (int j = 0; j < halls.Length - 1; j++)
                    {
                        halls[j] = halls[j + 1];
                    }
                    _currentIndex--;
                    Console.WriteLine($"{id}-li hall silindi");
                    return;
                }
            }   if (!found)
                Console.WriteLine($"{id}-li hall tapilmadi!");
        }

        public Entity Get(int id)
        {
            for (int i = 0; i < halls.Length; i++)
            {
                if (halls[i] == null)
                    continue;
                if (halls[i].Id == id)
                {

                    return halls[i];
                }

            }
            Console.WriteLine("Not found!");

            return null;
        }

       
        public void Print()
        {
            foreach (var item in halls)
            {
                if (item == null)
                    continue;
                Console.WriteLine(item.ToString());
            }
        }

        public void Update(int id, Entity entity)
        {
            for (int i = 0; i < halls.Length; i++)
            {
                if (halls[i] == null) 
                    continue;
                if (halls[i].Id == id)
                {
                    halls[i] = (Hall)entity;
                    Console.WriteLine("ugurla deyisdirildi!");
                    return;
                }
            }
        }
    }
}

