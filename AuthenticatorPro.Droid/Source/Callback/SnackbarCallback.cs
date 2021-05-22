// Copyright (C) 2021 jmh
// SPDX-License-Identifier: GPL-3.0-only

using System;
using Google.Android.Material.Snackbar;

namespace AuthenticatorPro.Droid.Callback
{
    public class SnackbarCallback : Snackbar.Callback
    {
        public event EventHandler<int> Dismiss;
        public event EventHandler Show;
        
        public override void OnDismissed(Snackbar transientBottomBar, int e)
        {
            base.OnDismissed(transientBottomBar, e);
            Dismiss?.Invoke(transientBottomBar, e);
        }

        public override void OnShown(Snackbar sb)
        {
            base.OnShown(sb);
            Show?.Invoke(sb, null);
        }
    }
}