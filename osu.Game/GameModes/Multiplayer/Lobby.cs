﻿//Copyright (c) 2007-2016 ppy Pty Ltd <contact@ppy.sh>.
//Licensed under the MIT Licence - https://raw.githubusercontent.com/ppy/osu/master/LICENCE

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace osu.Game.GameModes.Multiplayer
{
    class Lobby : GameModeWhiteBox
    {
        protected override IEnumerable<Type> PossibleChildren => new[] {
                typeof(MatchCreate),
                typeof(Match)
        };
    }
}
