using System.Reflection;
using Castle.Facilities.TypedFactory;

namespace Website.Windsor.Factory
{
    class FactoryComponentSelector : DefaultTypedFactoryComponentSelector
    {
        protected override string GetComponentName(MethodInfo method, object[] arguments)
        {
            return (string)arguments[0];
        }
    }
}