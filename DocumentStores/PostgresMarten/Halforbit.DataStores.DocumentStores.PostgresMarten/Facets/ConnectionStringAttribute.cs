﻿using Halforbit.Facets.Attributes;
using System;

namespace Halforbit.DataStores.DocumentStores.PostgresMarten.Facets
{
    public class ConnectionStringAttribute : FacetParameterAttribute
    {
        public ConnectionStringAttribute(string value = null, string configKey = null) : 
            base(value, configKey) { }

        public override string ParameterName => "connectionString";

        public override Type TargetType => typeof(PostgresMartenDataStore<,>);
    }
}
