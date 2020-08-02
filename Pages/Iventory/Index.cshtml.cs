using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using InventoryEditorPage.Data;
using InventoryEditorPage.Models;

namespace InventoryEditorPage.Pages.Iventory
{
    public class IndexModel : PageModel
    {
        private readonly InventoryEditorPage.Data.InventoryEditorPageContext _context;

        public IndexModel(InventoryEditorPage.Data.InventoryEditorPageContext context)
        {
            _context = context;
        }

        public IList<Inventory> Inventory { get;set; }

        public async Task OnGetAsync()
        {
            Inventory = await _context.Inventory.ToListAsync();
        }
    }
}
