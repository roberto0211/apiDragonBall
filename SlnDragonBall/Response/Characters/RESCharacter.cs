using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Response.Characters
{
    public class ResCharacter
    {
        public int idCharacter { get; set; }
        public string? vc_Name { get; set; }
        public string? vc_Pic { get; set; }
        public string? vc_abaout { get; set; }
        public string? vc_Race { get; set; }

        public List<ResTransformation> Transformation { get; set; }
        
    }
}
