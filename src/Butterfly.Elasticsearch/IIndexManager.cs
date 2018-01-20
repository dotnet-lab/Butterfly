﻿using System;
using System.Collections.Generic;
using System.Text;
using Nest;

namespace Butterfly.Elasticsearch
{
    public interface IIndexManager
    {
        IndexName CreateIndex(DateTimeOffset? dateTimeOffset);
    }
}