﻿using Halforbit.DataStores.FileStores.Ftp.Implementation;
using Halforbit.Facets.Attributes;
using System;

namespace Halforbit.DataStores.FileStores.Ftp.Facets
{
    public class FtpPasswordAttribute : FacetParameterAttribute
    {
        public FtpPasswordAttribute(string value = null, string configKey = null) : base(value, configKey) { }

        public override string ParameterName => "password";

        public override Type TargetType => typeof(FtpFileStore);
    }
}
