// Copyright (C) 2021 jmh
// SPDX-License-Identifier: GPL-3.0-only

using System;
using System.Collections.Generic;
using System.Text;
using AuthenticatorPro.Shared.Data;

namespace AuthenticatorPro.Droid.Data.Backup
{
    internal class UriListBackup 
    {
        public const string FileExtension = "txt";
        public const string MimeType = "text/plain";
        
        private readonly string _contents;

        private UriListBackup(string contents)
        {
            _contents = contents;
        }

        public override string ToString()
        {
            return _contents;
        }

        public static UriListBackup FromAuthenticators(IEnumerable<Authenticator> authenticators)
        {
            var builder = new StringBuilder();

            foreach(var auth in authenticators)
            {
                string uri;

                try
                {
                    uri = auth.GetOtpAuthUri();
                }
                catch(NotSupportedException)
                {
                    continue;
                }

                builder.AppendLine(uri);
            }

            return new UriListBackup(builder.ToString());
        }
    }
}