using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleshipLiteLibrary.Models
{
    public class GridSpotModel
    {
        public string SpotLetter { get; set; }
        public int SpotNumber { get; set; }

        // 0 = empty, 1 = ship, 2 = miss, 3 = hit, 4 = sunk
        // daca folosim = inseamna ca by default Status va avea valorea 'Empty'
        public GridSpotStatus Status { get; set; } = GridSpotStatus.Empty;
    }
}
