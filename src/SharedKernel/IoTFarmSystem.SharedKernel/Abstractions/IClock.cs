﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IoTFarmSystem.SharedKernel.Abstractions
{
    public interface IClock
    {
        DateTime UtcNow { get; }
    }
}
