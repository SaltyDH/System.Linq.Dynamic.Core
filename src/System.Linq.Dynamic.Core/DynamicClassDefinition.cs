using System.Collections.Generic;
using JetBrains.Annotations;

namespace System.Linq.Dynamic.Core
{
    public class DynamicClassDefinition
    {
        internal object ResolvedType { get; set; }

        public string Namespace { get; set; }
        public string Name { get; set; }

        public List<DynamicPropertyBase> Properties { get; set; }
        public Type BaseType { get; set; }
        public bool CreateParameterConstructor { get; set; }

        public DynamicClassDefinition([NotNull] List<DynamicPropertyBase> properties, string @namespace = null, string name = null, Type baseType = null, bool createParameterCtor = true)
        {
            Properties = properties;
            Namespace = @namespace;
            Name = name;
            BaseType = baseType;
            CreateParameterConstructor = createParameterCtor;
        }

        public Type ResolveType()
        {
            return ResolvedType as Type;
        }

        public DynamicClass New(params object[] arguments)
        {
            return Activator.CreateInstance(ResolveType(), arguments) as DynamicClass;
        }
    }
}