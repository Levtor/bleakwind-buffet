using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BleakwindBuffet.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace Website.Pages
{
    public class IndexModel : PageModel
    {
        /// <summary>
        /// the search results
        /// </summary>
        public IEnumerable<IOrderItem> Items { get; set; }
        /// <summary>
        /// the string of the terms an item must contain to be included in the search results
        /// </summary>
        public string SearchString { get; set; }
        /// <summary>
        /// the categories to be included in the search results
        /// </summary>
        public string[] IncludedCategories { get; set; }
        /// <summary>
        /// the minimum caloric value of the search results
        /// </summary>
        public uint? CalMin { get; set; }
        /// <summary>
        /// the maximum caloric value of the search results
        /// </summary>
        public uint? CalMax { get; set; }
        /// <summary>
        /// the minimum price value of the search results
        /// </summary>
        public double? PriceMin { get; set; }
        /// <summary>
        /// the maximum price value of the search results
        /// </summary>
        public double? PriceMax { get; set; }

        /// <summary>
        /// processes the user input to update Items
        /// </summary>
        public void OnGet()
        {
            SearchString = Request.Query["SearchString"];
            IncludedCategories = Request.Query["IncludedCategories"];

            string temp;
            temp = Request.Query["CalMin"];
            if (temp == null || temp.Equals("")) CalMin = null;
            else CalMin = (uint)Convert.ToInt32(temp);
            temp = Request.Query["CalMax"];
            if (temp == null || temp.Equals("")) CalMax = null;
            else CalMax = (uint)Convert.ToInt32(temp);
            temp = Request.Query["PriceMin"];
            if (temp == null || temp.Equals("")) PriceMin = null;
            else PriceMin = Convert.ToDouble(temp);
            temp = Request.Query["PriceMax"];
            if (temp == null || temp.Equals("")) PriceMax = null;
            else PriceMax = Convert.ToDouble(temp);

            Items = Menu.FullMenu();
            Items = Menu.Search(Items, SearchString);
            Items = Menu.FilterByCategory(Items, IncludedCategories);
            Items = Menu.FilterByCalories(Items, CalMax, CalMin);
            Items = Menu.FilterByPrice(Items, PriceMax, PriceMin);
        }
    }
}
