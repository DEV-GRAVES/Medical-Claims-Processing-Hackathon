﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreClaims.SemanticKernel
{
    public record RulesEngineSettings
    {
        public required string OpenAIKey { get; set; }
        public required string OpenAIEndpoint { get; set; }
        public required string OpenAICompletionsDeployment { get; set; }
    }
}
