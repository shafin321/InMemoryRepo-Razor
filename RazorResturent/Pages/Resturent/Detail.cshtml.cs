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
    public class DetailModel : PageModel
    {
        ResturentService repo = new ResturentService();
        public Resturant Resturant { get; set; }
        public void OnGet(int id)
        {
            Resturant = repo.GetResturantById(id);
        }
    }
}
