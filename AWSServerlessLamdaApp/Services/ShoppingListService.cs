using AWSServerlessLamdaApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AWSServerlessLamdaApp.Services
{
    public class ShoppingListService : IShoppingListService
    {
        private readonly Dictionary<string, int> _shoppingListStorage = new Dictionary<string, int>();
        public Dictionary<string, int> GetItemsFromShoppingList()
        {
            return _shoppingListStorage;
        }

        void IShoppingListService.AddItemsToShoppingList(ShoppingListModel shoppingList)
        {
            _shoppingListStorage.Add(shoppingList.Name, shoppingList.Quantity);
        }

        object IShoppingListService.GetItemFromShoppingList(String itemName)
        {
            return  _shoppingListStorage.FirstOrDefault(x => x.Key == itemName);
        }

        void IShoppingListService.RemoveItem(string shoppingListName)
        {
            _shoppingListStorage.Remove(shoppingListName);
        }
    }
}
