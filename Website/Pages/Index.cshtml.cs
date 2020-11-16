using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BleakwindBuffet.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Sides;

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

            Items = Menu.FullMenu();

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
            double pMin;
            double pMax;
            uint cMin;
            uint cMax;
            if (PriceMax == null) pMax = 2000;
            else pMax = (double)PriceMax;
            if (PriceMin == null) pMin = 0;
            else pMin = (double)PriceMin;
            if (CalMax == null) cMax = 200000;
            else cMax = (uint)CalMax;
            if (CalMin == null) cMin = 0;
            else cMin = (uint)CalMin;
            Items = Items.Where(item =>
                item.Price >= pMin &&
                item.Price <= pMax &&
                item.Calories >= cMin &&
                item.Calories <= cMax);

            if (IncludedCategories != null && IncludedCategories.Count() > 0)
            {
                Items = Items.Where(item =>
                    item is Drink && IncludedCategories.Contains("Drinks") ||
                    item is Entree && IncludedCategories.Contains("Entrees") ||
                    item is Side && IncludedCategories.Contains("Sides"));
            }

            if (SearchString != null)
            {
                string[] strs = SearchString.Split(' ');
                Items = Items.Where(item => ContainsOneOf(strs, item));
            }
        }

        /// <summary>
        /// Determines whether the passed IOrderItem's description or ToString contains
        /// at least one of the strings in the passed array
        /// </summary>
        /// <param name="strings">the strings being checked for</param>
        /// <param name="item">the IOrderItem being evaluated</param>
        /// <returns>whether the IOrderItem's text has one of the strings</returns>
        private bool ContainsOneOf(string[] strings, IOrderItem item)
        {
            foreach (string term in strings)
            {
                if (term.Length > 0)
                {
                    if (item.Description.ToLower().Contains(term.ToLower())) return true;
                    if (item.ToString().ToLower().Contains(term.ToLower())) return true;
                }
            }
            return false;
        }
    }
}
