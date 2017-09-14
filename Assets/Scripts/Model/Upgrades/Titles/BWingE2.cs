﻿using Ship;
using Ship.BWing;
using Upgrade;
using System.Collections.Generic;

namespace UpgradesList
{
    public class BWingE2 : GenericUpgradeSlotUpgrade
    {
        public BWingE2() : base()
        {
            Type = UpgradeType.Modification;
            Name = ShortName = "B-Wing/E2";
            ImageUrl = "https://raw.githubusercontent.com/guidokessels/xwing-data/master/images/upgrades/Modification/b-wing-e2.png";
            Cost = 1;
            AddedSlots = new List<UpgradeSlot>
            {
                new UpgradeSlot(UpgradeType.Crew)
            };
        }

        public override bool IsAllowedForShip(GenericShip ship)
        {
            return ship is BWing;
        }
    }
}
