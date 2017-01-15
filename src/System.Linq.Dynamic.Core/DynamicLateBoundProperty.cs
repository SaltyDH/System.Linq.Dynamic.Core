namespace System.Linq.Dynamic.Core
{
    public class DynamicLateBoundProperty : DynamicPropertyBase
    {
        public DynamicLateBoundProperty(string name, Func<DynamicClassDefinition> definition)
            : this(name, new Func<Type>(() => definition().ResolveType()))
        {
        }

        public DynamicLateBoundProperty(string name, Func<Type> typeResolver)
            : base(name)
        {
            Definition = typeResolver;
        }

        public Func<Type> Definition { get; }

        public override Type ResolveType()
        {
            return Definition();
        }
    }
}