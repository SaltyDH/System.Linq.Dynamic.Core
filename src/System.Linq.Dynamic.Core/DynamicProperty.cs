namespace System.Linq.Dynamic.Core
{
    /// <summary>
    /// DynamicProperty
    /// </summary>
    public class DynamicProperty : DynamicPropertyBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DynamicProperty"/> class.
        /// </summary>
        /// <param name="name">The name from the property.</param>
        /// <param name="type">The type from the property.</param>
        public DynamicProperty(string name, Type type)
            : base(name)
        {
            Type = type;
        }

        /// <summary>
        /// Gets the type from the property.
        /// </summary>
        /// <value>
        /// The type from the property.
        /// </value>
        public Type Type { get; }

        public override Type ResolveType()
        {
            return Type;
        }
    }
}