namespace System.Linq.Dynamic.Core
{
    public abstract class DynamicPropertyBase
    {
        protected DynamicPropertyBase(string name)
        {
            Name = name;
        }


        /// <summary>
        /// Gets the name from the property.
        /// </summary>
        /// <value>
        /// The name from the property.
        /// </value>
        public string Name { get; }

        public abstract Type ResolveType();
    }
}