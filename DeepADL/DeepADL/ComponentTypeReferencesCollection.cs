//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//     Laufzeitversion:4.0.30319.42000
//
//     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
//     der Code erneut generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

using NMF.Collections.Generic;
using NMF.Collections.ObjectModel;
using NMF.Expressions;
using NMF.Expressions.Linq;
using NMF.Models;
using NMF.Models.Collections;
using NMF.Models.Expressions;
using NMF.Models.Meta;
using NMF.Serialization;
using NMF.Utilities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;

namespace FZI.SoftwareEngineering.DeepModeling.DeepADL
{
    
    
    /// <summary>
    /// The collection class to implement the refined References reference for the ComponentType class
    /// </summary>
    public class ComponentTypeReferencesCollection : ICollectionExpression<IReference>, ICollection<IReference>, INotifyCollection<IReference>
    {
        
        private IComponentType _parent;
        
        /// <summary>
        /// Creates a new instance
        /// </summary>
        public ComponentTypeReferencesCollection(IComponentType parent)
        {
            this._parent = parent;
            parent.RequiredInterfaces.AsNotifiable().CollectionChanged += this.HandleCollectionChange;
        }
        
        /// <summary>
        /// Gets the amount of elements contained in this collection
        /// </summary>
        public virtual int Count
        {
            get
            {
                int count = 0;
                count = (count + this._parent.RequiredInterfaces.Count);
                return count;
            }
        }
        
        /// <summary>
        /// Gets a value indicating that the collection is not read-only
        /// </summary>
        public virtual bool IsReadOnly
        {
            get
            {
                return false;
            }
        }
        
        /// <summary>
        /// Returns that this composed collection is always attached.
        /// </summary>
        public bool IsAttached
        {
            get
            {
                return true;
            }
        }
        
        /// <summary>
        /// Gets fired when the contents of this collection changes
        /// </summary>
        public event System.Collections.Specialized.NotifyCollectionChangedEventHandler CollectionChanged;
        
        /// <summary>
        /// Fires the CollectionChanged event
        /// </summary>
        protected virtual void OnCollectionChanged(System.Collections.Specialized.NotifyCollectionChangedEventArgs eventArgs)
        {
            System.Collections.Specialized.NotifyCollectionChangedEventHandler handler = this.CollectionChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        private void HandleCollectionChange(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs eventArgs)
        {
            this.OnCollectionChanged(eventArgs);
        }
        
        /// <summary>
        /// Adds the given element to the collection
        /// </summary>
        /// <param name="item">The item to add</param>
        public virtual void Add(IReference item)
        {
            IRequiredInterface requiredInterfacesCasted = item.As<IRequiredInterface>();
            if ((requiredInterfacesCasted != null))
            {
                this._parent.RequiredInterfaces.Add(requiredInterfacesCasted);
            }
        }
        
        /// <summary>
        /// Clears the collection and resets all references that implement it.
        /// </summary>
        public virtual void Clear()
        {
            this._parent.RequiredInterfaces.Clear();
        }
        
        /// <summary>
        /// Gets a value indicating whether the given element is contained in the collection
        /// </summary>
        /// <returns>True, if it is contained, otherwise False</returns>
        /// <param name="item">The item that should be looked out for</param>
        public virtual bool Contains(IReference item)
        {
            if (this._parent.RequiredInterfaces.Contains(item))
            {
                return true;
            }
            return false;
        }
        
        /// <summary>
        /// Copies the contents of the collection to the given array starting from the given array index
        /// </summary>
        /// <param name="array">The array in which the elements should be copied</param>
        /// <param name="arrayIndex">The starting index</param>
        public virtual void CopyTo(IReference[] array, int arrayIndex)
        {
            IEnumerator<IReference> requiredInterfacesEnumerator = this._parent.RequiredInterfaces.GetEnumerator();
            try
            {
                for (
                ; requiredInterfacesEnumerator.MoveNext(); 
                )
                {
                    array[arrayIndex] = requiredInterfacesEnumerator.Current;
                    arrayIndex = (arrayIndex + 1);
                }
            }
            finally
            {
                requiredInterfacesEnumerator.Dispose();
            }
        }
        
        /// <summary>
        /// Removes the given item from the collection
        /// </summary>
        /// <returns>True, if the item was removed, otherwise False</returns>
        /// <param name="item">The item that should be removed</param>
        public virtual bool Remove(IReference item)
        {
            IRequiredInterface requiredInterfaceItem = item.As<IRequiredInterface>();
            if (((requiredInterfaceItem != null) 
                        && this._parent.RequiredInterfaces.Remove(requiredInterfaceItem)))
            {
                return true;
            }
            return false;
        }
        
        /// <summary>
        /// Gets an enumerator that enumerates the collection
        /// </summary>
        /// <returns>A generic enumerator</returns>
        public virtual IEnumerator<IReference> GetEnumerator()
        {
            return Enumerable.Empty<IReference>().Concat(this._parent.RequiredInterfaces).GetEnumerator();
        }
        
        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
        
        /// <summary>
        /// Gets an observable version of this collection
        /// </summary>
        INotifyCollection<IReference> ICollectionExpression<IReference>.AsNotifiable()
        {
            return this;
        }
        
        /// <summary>
        /// Gets an observable version of this collection
        /// </summary>
        INotifyEnumerable<IReference> IEnumerableExpression<IReference>.AsNotifiable()
        {
            return this;
        }
        
        /// <summary>
        /// Gets an observable version of this collection
        /// </summary>
        INotifyEnumerable NMF.Expressions.IEnumerableExpression.AsNotifiable()
        {
            return this;
        }
        
        /// <summary>
        /// Attaches this collection class
        /// </summary>
        public void Attach()
        {
        }
        
        /// <summary>
        /// Detaches this collection class
        /// </summary>
        public void Detach()
        {
        }
    }
}

