
using System.Collections.Generic;

namespace PDFBuilder.Components.Interfaces
{
    public abstract class IComponent
    {

        #region Internal fields

        /// <summary>
        /// List of child components
        /// </summary>
        protected List<IContent> childs = new List<IContent>();

        #endregion Internal fields

        #region Properties

        #endregion Properties

        #region Public Methods

        /// <summary>
        /// Add a child component
        /// </summary>
        public void AddComponent(IContent child)
        {
            this.childs.Add(child);
        }

        /// <summary>
        /// Remove a child component
        /// </summary>
        public void RemoveComponent(IContent child)
        {
            this.childs.Remove(child);
        }

        #endregion Public Methods

        #region Non Public Methods



        #endregion Non Public Methods
    }
}
