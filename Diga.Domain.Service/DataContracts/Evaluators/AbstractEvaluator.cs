﻿using System.Runtime.Serialization;

namespace Diga.Domain.Service.DataContracts.Evaluators
{
    [DataContract(Namespace = "http://diga.clc.fh-hagenberg/datacontracts")]
    [KnownType(typeof(TSPSolutionEvaluator))]
    public abstract class AbstractEvaluator
    {
    }
}

