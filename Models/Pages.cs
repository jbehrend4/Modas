using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Modas.Models
{
    public class Pages
    {
        public int TotalEvents { get; set; }

        public int ItemsPerPage { get; set; }

        public int CurrentPage { get; set; }

        public int PreviousPage => CurrentPage == 1 ? 1 : CurrentPage - 1;

        public int NextPage => CurrentPage == TotalPages ? CurrentPage : CurrentPage + 1;

        public int TotalPages => (int)Math.Ceiling((decimal)TotalEvents / ItemsPerPage);

        public int PageRangeStart => (CurrentPage - 1) * ItemsPerPage + 1;

        public int PageRangeEnd => CurrentPage == TotalPages ? TotalEvents : PageRangeStart + ItemsPerPage - 1;
    }
}
