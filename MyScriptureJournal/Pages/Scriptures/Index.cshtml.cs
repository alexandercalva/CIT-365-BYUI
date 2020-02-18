using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
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

        public IList<Scripture> Scripture { get;set; }
        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }
        // Requires using Microsoft.AspNetCore.Mvc.Rendering;
        public SelectList Book { get; set; }
        [BindProperty(SupportsGet = true)]
        public string BookList { get; set; }
        [BindProperty(SupportsGet = true)]
        public string NoteSearch { get; set; }
        public async Task OnGetAsync()
        {
            // Use LINQ to get list of genres.
            IQueryable<string> BookQuery = from m in _context.Scripture
                                            orderby m.Book
                                            select m.Book;
            IQueryable<string> NoteQuery = from m in _context.Scripture
                                           orderby m.Note
                                           select m.Note;

            var scriptures = from m in _context.Scripture
                         select m;
            var note = from n in _context.Scripture select n;

            if (!string.IsNullOrEmpty(SearchString))
            {
                scriptures = scriptures.Where(s => s.Book.Contains(SearchString));
            }
            if (!string.IsNullOrEmpty(NoteSearch))
            {
                scriptures = scriptures.Where(s => s.Note.Contains(NoteSearch));
            }
            //Scripture = await _context.Scripture.ToListAsync();

            if (!string.IsNullOrEmpty(BookList))
            {
                scriptures = scriptures.Where(x => x.Book == BookList);
            }
           Book = new SelectList(await BookQuery.Distinct().ToListAsync());

            //Note = new Search(await NoteQuery.Distinct().ToListAsync());
            
            Scripture = await scriptures.ToListAsync();

        }
    }
}
