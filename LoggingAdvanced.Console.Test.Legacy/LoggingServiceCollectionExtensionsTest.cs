// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using Microsoft.Extensions.DependencyInjection;
using Xunit;

namespace LoggingAdvanced.Console.Test.Legacy
{
    public class LoggingServiceCollectionExtensionsTest
    {
        [Fact]
        public void AddLogging_allows_chaining()
        {
            var services = new ServiceCollection();

            Assert.Same(services, services.AddLogging());
        }
    }
}
