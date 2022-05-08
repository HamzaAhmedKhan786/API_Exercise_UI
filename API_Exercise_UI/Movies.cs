using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API_Exercise_UI
{
    internal class Movies
    {
        public string movie_name { get; set; }
        public int movie_rating { get; set; }
        public DateTime movie_release_date { get; set; }
        public string movie_genre { get; set; }
        public string movie_casts { get; set; }
        public string assignee { get; set; }
    }
}
