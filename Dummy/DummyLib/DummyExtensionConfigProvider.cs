using Microsoft.Azure.WebJobs.Description;
using Microsoft.Azure.WebJobs.Host.Config;

namespace DummyLib
{
    [Extension("DummyInput")]
    public class DummyExtensionConfigProvider : IExtensionConfigProvider
    {
        public void Initialize(ExtensionConfigContext context)
        {
            var rule = context.AddBindingRule<DummyAttribute>();

            rule.BindToInput(BuildItemFromAttr);
        }

        private DummyObject BuildItemFromAttr(DummyAttribute attribute)
        {
            return new DummyObject
            {
                Name = attribute.DummyName
            };
        }
    }
}
