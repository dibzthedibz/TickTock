using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24Hour.Models
{
    /// <summary>
    /// I added
    /// </summary>

    // This first model will handle the task of collecting property data for a list of notes.  When a user enters information, we will want them to enter specific data.  When we show information, we will want to show specific data in specific views

    public class PostListItem
    {
        public int PostId { get; set; }
        public string Title { get; set; }
    }
}
