﻿using Halforbit.DataStores.FileStores.AmazonS3.Implementation;
using Halforbit.Facets.Attributes;
using System;

namespace Halforbit.DataStores.FileStores.AmazonS3.Facets
{
    public class SecretAccessKeyAttribute : FacetParameterAttribute
    {
        public override Type TargetType => typeof(AmazonS3FileStore);

        public override string ParameterName => "secretAccessKey";
    }
}
