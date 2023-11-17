using System.Collections.Generic;
using System.Linq;

namespace MarioPizza;

public class Menu : IMenu
{
  public ICollection<IPizza> AllPizzas { get; set; }
  
  public ICollection<string> FindPizza(IList<string> mustHaveIngredients, IList<string> wontHaveIngredients)
  {
        // Get a list of all pizzas that have all "mustHaveIngredients"
        ICollection<IPizza> mustHaveIngredientsPizzas = AllPizzas.Where(pizza => mustHaveIngredients.All(x => pizza.Ingredients.Contains(x))).ToList();
        // Get a list of all pizzas that also do not have any "wontHaveIngredients"
        ICollection<IPizza> mustHaveIngredientsAndWontHaveIngredientsPizzas = mustHaveIngredientsPizzas.Where(pizza => wontHaveIngredients.All(x => !pizza.Ingredients.Contains(x))).ToList();

        ICollection<string> pizzas = (from pizza in mustHaveIngredientsAndWontHaveIngredientsPizzas select pizza.Name).ToList();

        return pizzas;
  }
}
