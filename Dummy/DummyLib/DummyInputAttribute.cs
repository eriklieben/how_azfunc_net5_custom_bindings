
using Microsoft.Azure.Functions.Worker.Extensions.Abstractions;

namespace DummyLib
{
    public sealed class DummyInputAttribute : InputBindingAttribute
    {
        public string DummyName { get; set; }
    }
}
