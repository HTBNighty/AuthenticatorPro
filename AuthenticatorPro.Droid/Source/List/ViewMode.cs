// Copyright (C) 2021 jmh
// SPDX-License-Identifier: GPL-3.0-only

namespace AuthenticatorPro.Droid.List
{
    public enum ViewMode
    {
        Default = 0, Compact = 1, Tile = 2
    }

    public static class ViewModeSpecification
    {
        public static ViewMode FromName(string name)
        {
            return name switch
            {
                "compact" => ViewMode.Compact,
                "tile" => ViewMode.Tile,
                _ => ViewMode.Default
            };
        }
        
        public static int GetMinColumnWidth(this ViewMode viewMode)
        {
            return viewMode switch
            {
                ViewMode.Compact => 300,
                ViewMode.Tile => 170,
                _ => 340
            };
        }

        public static int GetSpacing(this ViewMode viewMode)
        {
            return viewMode switch
            {
                ViewMode.Default => 8,
                ViewMode.Compact => 6,
                _ => 4
            };
        }
    }
}