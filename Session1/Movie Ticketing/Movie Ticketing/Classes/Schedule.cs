using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Movie_Ticketing.Database;

namespace Movie_Ticketing.Classes
{
    class Schedule
    {
        public int StudioNo { get; set; }
        public string FilmTitle { get; set; }
        public List<string> Times { get
            {
                using (SampleDataContext db = new SampleDataContext())
                {
                    List<string> timelist = new List<string>();
                    var List = (from h in db.headerschedules
                                join m in db.mappings
                                on h.mappingid equals m.mappingid
                                join f in db.msfilms
                                on m.filmid equals f.filmid
                                where f.title == FilmTitle
                                select new { Time = h.time }).ToList();
                    foreach (var l in List)
                    {
                        timelist.Add(((DateTime)l.Time).ToString("hh:mm tt"));
                    }
                    return timelist;
                }
            } }
    }
}
