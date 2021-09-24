using AWSServerlessLamdaApp.Model;
using AWSServerlessLamdaApp.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AWSServerlessLamdaApp.Controllers
{
    [Route("api/[controller]")]
    //[Route("v1/[shoppingList]")]
    [ApiController]
    public class ShoppingListController : ControllerBase
    {
        private readonly IShoppingListService _shoppingListService;

        public ShoppingListController(IShoppingListService shoppingListService)
        {
            _shoppingListService = shoppingListService;
        }

        [HttpGet]
        [Route("GetAll")]
        public IActionResult GetShoppingList() 
        {
            var result = _shoppingListService.GetItemsFromShoppingList();
            return Ok(result);
        }

        [HttpGet]
        [Route("GetItem")]
        public IActionResult GetItemFromShoppingList(string itemName)
        {
            var result = _shoppingListService.GetItemFromShoppingList(itemName);
            return Ok(result);
        }

        [HttpPost]
        [Route("AddItem")]
        public IActionResult AddItemToShoppingList([FromBody] ShoppingListModel shoppingList)
        {
            _shoppingListService.AddItemsToShoppingList(shoppingList);
            return Ok();
        }

        [HttpDelete]
        [Route("DeleteItem")]
        public IActionResult DeleteItemFromShoppingList([FromBody] ShoppingListModel shoppingList) {
            _shoppingListService.RemoveItem(shoppingList.Name);
            return Ok();
        }
    }
}
