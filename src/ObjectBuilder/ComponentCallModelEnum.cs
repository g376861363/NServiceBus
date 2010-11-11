namespace NServiceBus.ObjectBuilder
{
    /// <summary>
    /// Represent the various call models for a component.
    /// </summary>
    public enum ComponentCallModelEnum
    {
        /// <summary>
        /// Accept the default call model of the underlying technology. This rougly maps to the
        /// InstancePerUnitOfWork lifecycle in our new lifycycle definitions
        /// </summary>
        None,
        
        /// <summary>
        /// Only one instance of the component will ever be called. This maps to the
        /// SingleInstance lifecycle in our new lifycycle definitions
        /// </summary>
        Singleton,

        /// <summary>
        /// Each call on the component will be performed on a new instance.  This maps to the
        /// InstancePerCall lifecycle in our new lifycycle definitions
        /// </summary>
        Singlecall
    }
}
