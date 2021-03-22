using Microsoft.Azure.WebJobs.Description;
using System;

namespace DummyLib
{
    [AttributeUsage(AttributeTargets.Parameter | AttributeTargets.ReturnValue)]
    [Binding]
    public class DummyAttribute : Attribute
    {
        public string DummyName { get; set; }
    }
}
