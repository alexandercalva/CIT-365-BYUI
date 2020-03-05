using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.Web.CodeGeneration.Contracts.Messaging;
using MyScriptureJournal.Data;
using MyScriptureJournal.Models;

namespace MyScriptureJournal
{
    public class IndexModel : PageModel
    {
        private readonly MyScriptureJournal.Data.MyScriptureJournalContext _context;

        public IndexModel(MyScriptureJournal.Data.MyScriptureJournalContext context)
        {
            _context = context;
        }
        
        public string BookSort { get; set; }
        public string DateSort { get; set; }

       
        public IList<Scripture> ScriptureList { get;set; }
        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }
        // Requires using Microsoft.AspNetCore.Mvc.Rendering;
        public SelectList BookSelectList { get; set; }
        [BindProperty(SupportsGet = true)]
        public string BookList { get; set; }
        [BindProperty(SupportsGet = true)]
        public string NoteSearch { get; set; }
        public async Task OnGetAsync(string sortOrder)
        {
            BookSort = sortOrder == "book_asc" ? "book_desc" : "book_asc";
            DateSort = sortOrder == "date_asc" ? "date_desc" : "date_asc";
            
            // Use LINQ 
           
            IQueryable<string> BookQuery = from m in _context.Scripture
                                            select m.BookModels;
            IQueryable<string> NoteQuery = from m in _context.Scripture
                                           orderby m.Note
                                           select m.Note;
           
            var scriptures = from m in _context.Scripture
                             select m;
            switch (sortOrder)
            {
                case "book_desc":
                    scriptures = scriptures.OrderByDescending(s => s.BookModels);
                    break;
                case "date_asc":
                    scriptures = scriptures.OrderBy(s => s.Date);
                    break;
                case "date_desc":
                    scriptures = scriptures.OrderByDescending(s => s.Date);
                    break;
                default:
                    scriptures = scriptures.OrderBy(s => s.BookModels);
                    break;
            }

            
            ScriptureList = await scriptures.AsNoTracking().ToListAsync();


            var note = from n in _context.Scripture select n;
           

           
            if (!string.IsNullOrEmpty(SearchString))
            {
                scriptures = scriptures.Where(s => s.BookModels.Contains(SearchString));
            }
            if (!string.IsNullOrEmpty(NoteSearch))
            {
                scriptures = scriptures.Where(s => s.Note.Contains(NoteSearch));
            }
            //Scripture = await _context.Scripture.ToListAsync();

            if (!string.IsNullOrEmpty(BookList))
            {
                scriptures = scriptures.Where(x => x.BookModels == BookList);
            }
            BookSelectList = new SelectList(await BookQuery.Distinct().ToListAsync());
            //var DateSort = await DateSortQuery.Distinct().ToListAsync();
            //Note = new Search(await NoteQuery.Distinct().ToListAsync());

            ScriptureList = await scriptures.ToListAsync();
        }
    }
}
