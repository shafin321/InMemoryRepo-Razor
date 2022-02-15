using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorResturent.Models;
using RazorResturent.Models.Service;

namespace RazorResturent.Pages.Resturent
{
    public class ListModel : PageModel
    {
        ResturentService repo = new ResturentService();

        public IEnumerable<Resturant> Resturants { get; set; }

        [BindProperty(SupportsGet =true)]
        public string SearchTearm { get; set; }
        public void OnGet()
        {
           Resturants= repo.GettAllResturantByName(SearchTearm);
        }
    }
}
