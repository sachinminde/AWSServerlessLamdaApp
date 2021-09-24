using AWSServerlessLamdaApp.Model;
using System.Collections.Generic;

namespace AWSServerlessLamdaApp.Services
{
    public interface IShoppingListService
    {
        Dictionary<string, int> GetItemsFromShoppingList();
        void AddItemsToShoppingList(ShoppingListModel shoppingList);
        void RemoveItem(string name);
        object GetItemFromShoppingList(string itemName);
    }
}