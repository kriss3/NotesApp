using Notes.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Notes.Services
{
    public interface IPluralsightDataStore
    {
        Task<string> AddNotesAsync(Note courseNote);
        Task<bool> UpdateNotesAsync(Note courseNote);
        Task<Note> GetNoteAsync(string id);
        Task<IList<Note>> GetNotesAsync();
        Task<IList<string>> GetCoursesAsync();
    }
}
