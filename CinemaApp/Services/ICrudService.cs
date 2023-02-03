using System;
namespace TaetrProjekt
{
	internal interface ICrudService
	{
		void Add(Entity entity);
		void Update(int id,Entity entity);
		void Delete(int id);
		Entity Get(int id);
		

	}
}

