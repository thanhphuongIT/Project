using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TuDienOnline
{
     public class Data
    {
        public string language { get; set; }
        public List<Sentence> sentences { get; set; }
        public List<SuggestionList> suggestions { get; set; }
        public List<tu> tratu { get; set; }
    }
}
