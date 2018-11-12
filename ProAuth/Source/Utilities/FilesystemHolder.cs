﻿using System;
using Android.Support.V7.Widget;
using Android.Views;
using Android.Widget;

namespace ProAuth.Utilities
{
    internal class FilesystemHolder : RecyclerView.ViewHolder
    {
        public ImageView Icon { get; set; }
        public TextView Name { get; set; }

        public FilesystemHolder(View itemView, Action<int> clickListener) : base(itemView)
        {
            Icon = itemView.FindViewById<ImageView>(Resource.Id.fileListItem_icon);
            Name = itemView.FindViewById<TextView>(Resource.Id.fileListItem_name);

            itemView.Click += (sender, e) => clickListener(AdapterPosition);
        }
    }
}