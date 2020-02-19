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
        [BindProperty(SupportsGet = true)]
        public string BookSort { get; set; }
        public string DateSort { get; set; }

       
        public IList<Scripture> ScriptureList { get;set; }
        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }
        // Requires using Microsoft.AspNetCore.Mvc.Rendering;
        public SelectList Book { get; set; }
        [BindProperty(SupportsGet = true)]
        public string BookList { get; set; }
        [BindProperty(SupportsGet = true)]
        public string NoteSearch { get; set; }
        public async Task OnGetAsync(string sortOrder)
        {
            BookSort = String.IsNullOrEmpty(sortOrder) ? "book_desc" : "";
            DateSort = sortOrder == "Date" ? "date_desc" : "Date";
            // Use LINQ 
            IQueryable<Scripture> BookST = from m in _context.Scripture
                                          
                                        select m;
            IQueryable<string> BookQuery = from m in _context.Scripture
                                            select m.Book;
            IQueryable<string> NoteQuery = from m in _context.Scripture
                                           orderby m.Note
                                           select m.Note;
            IQueryable<DateTime> DateSortQuery = from m in _context.Scripture
                                               orderby m.Date
                                               select m.Date;

            switch (sortOrder)
            {
                case "book_desc":

                    //BookST = BookST.OrderByDescending(s => s.Book.Contains(BookList));
                    BookST = BookST.Where(s => s.Book.Contains(BookSort));
                    break;
                case "Date":
                    BookST = BookST.OrderBy(s => s.Date);
                    break;
                case "date_desc":
                    BookST = BookST.OrderByDescending(s => s.Date);
                    break;
                default:
                    BookST = BookST.OrderBy(s => s.Book.Contains(BookSort));
                    break;
            }


           // ScriptureList = await BookST.ToListAsync();

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
            //var DateSort = await DateSortQuery.Distinct().ToListAsync();
            //Note = new Search(await NoteQuery.Distinct().ToListAsync());

            ScriptureList = await scriptures.ToListAsync();

        }
    }
}
