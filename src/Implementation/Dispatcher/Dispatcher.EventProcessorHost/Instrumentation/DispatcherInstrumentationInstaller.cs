﻿// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
namespace Microsoft.Practices.DataPipeline.Dispatcher.Instrumentation
{
    using System.ComponentModel;
    using System.Configuration.Install;

    [RunInstaller(true)]
    public partial class DispatcherInstrumentationInstaller : Installer
    {
        public DispatcherInstrumentationInstaller()
        {
            this.Installers.Add(new DispatcherInstrumentationManager(false).GetInstaller());
        }
    }
}
