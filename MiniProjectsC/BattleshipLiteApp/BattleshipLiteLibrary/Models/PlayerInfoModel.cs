using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleshipLiteLibrary.Models
{
    public class PlayerInfoModel
    {
        public string Username { get; set; }
        public List<GridSpotModel> ShipLocations { get; set; } = new List<GridSpotModel>();

        // cum arata by default campul nostru de lupta
        public List<GridSpotModel> ShotGrid { get; set; } = new List<GridSpotModel>();

    }
}
