// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

using System.ComponentModel;

namespace osu.Game.Rulesets.Osu.UI
{
    public enum ReverseArrowPulseMode
    {
        Off,

        [Description("Match osu!stable")]
        Stable,

        [Description("Sync to beatmap")]
        Synced
    }
}
