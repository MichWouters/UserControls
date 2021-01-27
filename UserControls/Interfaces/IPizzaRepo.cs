using System.Collections.Generic;

namespace UserControls
{
    public interface IPizzaRepo
    {
        List<IPizza> GetPizzas();

        IPizza GetPizza(int id);
    }
}