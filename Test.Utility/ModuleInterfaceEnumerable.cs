﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Autofac.Core;

namespace Messerli.Test.Utility
{
    [Obsolete("Use the [TypesThatNeedToBeImplementedInAssemblyData] attribute instead")]
    public sealed class ModuleInterfaceEnumerable<T> : IEnumerable<Type>
        where T : IModule
    {
        public IEnumerator<Type> GetEnumerator()
        {
            return typeof(T)
                .Assembly
                .GetTypes()
                .Where(type => type.IsInterface)
                .GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
