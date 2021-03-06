﻿using Halforbit.DataStores.FileStores.BlobStorage.Implementation;
using Halforbit.Facets.Attributes;
using System;

namespace Halforbit.DataStores.FileStores.BlobStorage.Facets
{
    public class QueueConnectionStringAttribute : FacetParameterAttribute
    {
        public QueueConnectionStringAttribute(string value = null, string configKey = null) : base(value, configKey) { }

        public override Type TargetType => typeof(AzureStorageMessageQueue<>);

        public override string ParameterName => "queueConnectionString";
    }
}
