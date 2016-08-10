﻿using System;
using Rocket.API;
using Rocket.API.Extensions;

namespace RocketRegions.Model.Flag
{
    public abstract class IntFlag : RegionFlag
    {
        public override bool ParseValue(IRocketPlayer caller, Region region, string[] command, out string shownValue, Group group = Group.NONE)
        {
            shownValue = null;
            int? value = command.GetInt32Parameter(0);
            try
            {
                shownValue = value.Value.ToString();
                SetValue(Convert.ToInt32(value.Value), group);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}