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
    /// The default implementation of the SystemArchitecture class
    /// </summary>
    [XmlNamespaceAttribute("http://github.com/georghinkel/DeepADL/1.0")]
    [XmlNamespacePrefixAttribute("core")]
    [ModelRepresentationClassAttribute("http://github.com/georghinkel/DeepADL/1.0#//SystemArchitecture/")]
    [DebuggerDisplayAttribute("SystemArchitecture {Name}")]
    public class SystemArchitecture : NMF.Models.Meta.Type, ISystemArchitecture, IModelElement
    {
        
        /// <summary>
        /// The backing field for the AssemblyContexts property
        /// </summary>
        private ObservableCompositionList<IAssemblyContext> _assemblyContexts;
        
        event EventHandler<ValueChangedEventArgs> IClass.IdentifierChanged
        {
            add
            {
            }
            remove
            {
            }
        }
        event EventHandler<ValueChangedEventArgs> IClass.InstanceOfChanged
        {
            add
            {
            }
            remove
            {
            }
        }
        event EventHandler<ValueChangedEventArgs> IClass.IsInterfaceChanged
        {
            add
            {
            }
            remove
            {
            }
        }
        event EventHandler<ValueChangedEventArgs> IClass.IsAbstractChanged
        {
            add
            {
            }
            remove
            {
            }
        }
        
        public SystemArchitecture()
        {
            this._assemblyContexts = new ObservableCompositionList<IAssemblyContext>(this);
            this._assemblyContexts.CollectionChanged += this.AssemblyContextsCollectionChanged;
        }
        
        /// <summary>
        /// The AssemblyContexts property
        /// </summary>
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Content)]
        [XmlAttributeAttribute(false)]
        [ContainmentAttribute()]
        [ConstantAttribute()]
        public virtual ICollectionExpression<IAssemblyContext> AssemblyContexts
        {
            get
            {
                return this._assemblyContexts;
            }
        }
        
        ICollectionExpression<IReference> IReferenceType.References
        {
            get
            {
                return new SystemArchitectureReferencesCollection(this);
            }
        }
        
        ICollectionExpression<IReferenceConstraint> IClass.ReferenceConstraints
        {
            get
            {
                return EmptyList<IReferenceConstraint>.Instance;
            }
        }
        
        ICollectionExpression<IAttribute> IStructuredType.Attributes
        {
            get
            {
                return EmptyList<IAttribute>.Instance;
            }
        }
        
        ICollectionExpression<IAttributeConstraint> IClass.AttributeConstraints
        {
            get
            {
                return EmptyList<IAttributeConstraint>.Instance;
            }
        }
        
        ICollectionExpression<IEvent> IReferenceType.Events
        {
            get
            {
                return EmptyList<IEvent>.Instance;
            }
        }
        
        ICollectionExpression<IOperation> IStructuredType.Operations
        {
            get
            {
                return EmptyList<IOperation>.Instance;
            }
        }
        
        IAttribute IClass.Identifier
        {
            get
            {
                return null;
            }
            set
            {
                if ((value != null))
                {
                    throw new System.NotSupportedException();
                }
            }
        }
        
        IClass IClass.InstanceOf
        {
            get
            {
                return null;
            }
            set
            {
                if ((value != null))
                {
                    throw new System.NotSupportedException();
                }
            }
        }
        
        ICollectionExpression<IClass> IClass.BaseTypes
        {
            get
            {
                return new SystemArchitectureBaseTypesCollection(this);
            }
        }
        
        bool IClass.IsInterface
        {
            get
            {
                return false;
            }
            set
            {
                if ((value != false))
                {
                    throw new System.NotSupportedException();
                }
            }
        }
        
        bool IClass.IsAbstract
        {
            get
            {
                return false;
            }
            set
            {
                if ((value != false))
                {
                    throw new System.NotSupportedException();
                }
            }
        }
        
        /// <summary>
        /// Gets the child model elements of this model element
        /// </summary>
        public override IEnumerableExpression<IModelElement> Children
        {
            get
            {
                return base.Children.Concat(new SystemArchitectureChildrenCollection(this));
            }
        }
        
        /// <summary>
        /// Gets the referenced model elements of this model element
        /// </summary>
        public override IEnumerableExpression<IModelElement> ReferencedElements
        {
            get
            {
                return base.ReferencedElements.Concat(new SystemArchitectureReferencedElementsCollection(this));
            }
        }
        
        /// <summary>
        /// Gets the Class element that describes the structure of this type
        /// </summary>
        public new static NMF.Models.Meta.IClass ClassInstance
        {
            get
            {
                return NMF.Models.Repository.MetaRepository.Instance.ResolveClass("http://github.com/georghinkel/DeepADL/1.0#//SystemArchitecture/");
            }
        }
        
        /// <summary>
        /// Forwards change notifications for the AssemblyContexts property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void AssemblyContextsCollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            this.OnCollectionChanged("AssemblyContexts", e);
        }
        
        /// <summary>
        /// Gets the Model element collection for the given feature
        /// </summary>
        /// <returns>A non-generic list of elements</returns>
        /// <param name="feature">The requested feature</param>
        protected override System.Collections.IList GetCollectionForFeature(string feature)
        {
            if ((feature == "ASSEMBLYCONTEXTS"))
            {
                return this._assemblyContexts;
            }
            return base.GetCollectionForFeature(feature);
        }
        
        /// <summary>
        /// Gets the Class for this model element
        /// </summary>
        public override IClass GetClass()
        {
            return ((IClass)(NMF.Models.Repository.MetaRepository.Instance.Resolve("http://github.com/georghinkel/DeepADL/1.0#//SystemArchitecture/")));
        }
        
        /// <summary>
        /// The collection class to to represent the children of the SystemArchitecture class
        /// </summary>
        public class SystemArchitectureChildrenCollection : ReferenceCollection, ICollectionExpression<IModelElement>, ICollection<IModelElement>
        {
            
            private SystemArchitecture _parent;
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public SystemArchitectureChildrenCollection(SystemArchitecture parent)
            {
                this._parent = parent;
            }
            
            /// <summary>
            /// Gets the amount of elements contained in this collection
            /// </summary>
            public override int Count
            {
                get
                {
                    int count = 0;
                    count = (count + this._parent.AssemblyContexts.Count);
                    return count;
                }
            }
            
            protected override void AttachCore()
            {
                this._parent.AssemblyContexts.AsNotifiable().CollectionChanged += this.PropagateCollectionChanges;
            }
            
            protected override void DetachCore()
            {
                this._parent.AssemblyContexts.AsNotifiable().CollectionChanged -= this.PropagateCollectionChanges;
            }
            
            /// <summary>
            /// Adds the given element to the collection
            /// </summary>
            /// <param name="item">The item to add</param>
            public override void Add(IModelElement item)
            {
                IAssemblyContext assemblyContextsCasted = item.As<IAssemblyContext>();
                if ((assemblyContextsCasted != null))
                {
                    this._parent.AssemblyContexts.Add(assemblyContextsCasted);
                }
            }
            
            /// <summary>
            /// Clears the collection and resets all references that implement it.
            /// </summary>
            public override void Clear()
            {
                this._parent.AssemblyContexts.Clear();
            }
            
            /// <summary>
            /// Gets a value indicating whether the given element is contained in the collection
            /// </summary>
            /// <returns>True, if it is contained, otherwise False</returns>
            /// <param name="item">The item that should be looked out for</param>
            public override bool Contains(IModelElement item)
            {
                if (this._parent.AssemblyContexts.Contains(item))
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
            public override void CopyTo(IModelElement[] array, int arrayIndex)
            {
                IEnumerator<IModelElement> assemblyContextsEnumerator = this._parent.AssemblyContexts.GetEnumerator();
                try
                {
                    for (
                    ; assemblyContextsEnumerator.MoveNext(); 
                    )
                    {
                        array[arrayIndex] = assemblyContextsEnumerator.Current;
                        arrayIndex = (arrayIndex + 1);
                    }
                }
                finally
                {
                    assemblyContextsEnumerator.Dispose();
                }
            }
            
            /// <summary>
            /// Removes the given item from the collection
            /// </summary>
            /// <returns>True, if the item was removed, otherwise False</returns>
            /// <param name="item">The item that should be removed</param>
            public override bool Remove(IModelElement item)
            {
                IAssemblyContext assemblyContextItem = item.As<IAssemblyContext>();
                if (((assemblyContextItem != null) 
                            && this._parent.AssemblyContexts.Remove(assemblyContextItem)))
                {
                    return true;
                }
                return false;
            }
            
            /// <summary>
            /// Gets an enumerator that enumerates the collection
            /// </summary>
            /// <returns>A generic enumerator</returns>
            public override IEnumerator<IModelElement> GetEnumerator()
            {
                return Enumerable.Empty<IModelElement>().Concat(this._parent.AssemblyContexts).GetEnumerator();
            }
        }
        
        /// <summary>
        /// The collection class to to represent the children of the SystemArchitecture class
        /// </summary>
        public class SystemArchitectureReferencedElementsCollection : ReferenceCollection, ICollectionExpression<IModelElement>, ICollection<IModelElement>
        {
            
            private SystemArchitecture _parent;
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public SystemArchitectureReferencedElementsCollection(SystemArchitecture parent)
            {
                this._parent = parent;
            }
            
            /// <summary>
            /// Gets the amount of elements contained in this collection
            /// </summary>
            public override int Count
            {
                get
                {
                    int count = 0;
                    count = (count + this._parent.AssemblyContexts.Count);
                    return count;
                }
            }
            
            protected override void AttachCore()
            {
                this._parent.AssemblyContexts.AsNotifiable().CollectionChanged += this.PropagateCollectionChanges;
            }
            
            protected override void DetachCore()
            {
                this._parent.AssemblyContexts.AsNotifiable().CollectionChanged -= this.PropagateCollectionChanges;
            }
            
            /// <summary>
            /// Adds the given element to the collection
            /// </summary>
            /// <param name="item">The item to add</param>
            public override void Add(IModelElement item)
            {
                IAssemblyContext assemblyContextsCasted = item.As<IAssemblyContext>();
                if ((assemblyContextsCasted != null))
                {
                    this._parent.AssemblyContexts.Add(assemblyContextsCasted);
                }
            }
            
            /// <summary>
            /// Clears the collection and resets all references that implement it.
            /// </summary>
            public override void Clear()
            {
                this._parent.AssemblyContexts.Clear();
            }
            
            /// <summary>
            /// Gets a value indicating whether the given element is contained in the collection
            /// </summary>
            /// <returns>True, if it is contained, otherwise False</returns>
            /// <param name="item">The item that should be looked out for</param>
            public override bool Contains(IModelElement item)
            {
                if (this._parent.AssemblyContexts.Contains(item))
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
            public override void CopyTo(IModelElement[] array, int arrayIndex)
            {
                IEnumerator<IModelElement> assemblyContextsEnumerator = this._parent.AssemblyContexts.GetEnumerator();
                try
                {
                    for (
                    ; assemblyContextsEnumerator.MoveNext(); 
                    )
                    {
                        array[arrayIndex] = assemblyContextsEnumerator.Current;
                        arrayIndex = (arrayIndex + 1);
                    }
                }
                finally
                {
                    assemblyContextsEnumerator.Dispose();
                }
            }
            
            /// <summary>
            /// Removes the given item from the collection
            /// </summary>
            /// <returns>True, if the item was removed, otherwise False</returns>
            /// <param name="item">The item that should be removed</param>
            public override bool Remove(IModelElement item)
            {
                IAssemblyContext assemblyContextItem = item.As<IAssemblyContext>();
                if (((assemblyContextItem != null) 
                            && this._parent.AssemblyContexts.Remove(assemblyContextItem)))
                {
                    return true;
                }
                return false;
            }
            
            /// <summary>
            /// Gets an enumerator that enumerates the collection
            /// </summary>
            /// <returns>A generic enumerator</returns>
            public override IEnumerator<IModelElement> GetEnumerator()
            {
                return Enumerable.Empty<IModelElement>().Concat(this._parent.AssemblyContexts).GetEnumerator();
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the IsInterface property
        /// </summary>
        private sealed class IsInterfaceProxy : ModelPropertyChange<IClass, bool>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public IsInterfaceProxy(IClass modelElement) : 
                    base(modelElement)
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override bool Value
            {
                get
                {
                    return this.ModelElement.IsInterface;
                }
                set
                {
                    this.ModelElement.IsInterface = value;
                }
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be subscribed to the property change event</param>
            protected override void RegisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.IsInterfaceChanged += handler;
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be unsubscribed from the property change event</param>
            protected override void UnregisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.IsInterfaceChanged -= handler;
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the IsAbstract property
        /// </summary>
        private sealed class IsAbstractProxy : ModelPropertyChange<IClass, bool>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public IsAbstractProxy(IClass modelElement) : 
                    base(modelElement)
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override bool Value
            {
                get
                {
                    return this.ModelElement.IsAbstract;
                }
                set
                {
                    this.ModelElement.IsAbstract = value;
                }
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be subscribed to the property change event</param>
            protected override void RegisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.IsAbstractChanged += handler;
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be unsubscribed from the property change event</param>
            protected override void UnregisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.IsAbstractChanged -= handler;
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the InstanceOf property
        /// </summary>
        private sealed class InstanceOfProxy : ModelPropertyChange<IClass, IClass>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public InstanceOfProxy(IClass modelElement) : 
                    base(modelElement)
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override IClass Value
            {
                get
                {
                    return this.ModelElement.InstanceOf;
                }
                set
                {
                    this.ModelElement.InstanceOf = value;
                }
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be subscribed to the property change event</param>
            protected override void RegisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.InstanceOfChanged += handler;
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be unsubscribed from the property change event</param>
            protected override void UnregisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.InstanceOfChanged -= handler;
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the Identifier property
        /// </summary>
        private sealed class IdentifierProxy : ModelPropertyChange<IClass, IAttribute>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public IdentifierProxy(IClass modelElement) : 
                    base(modelElement)
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override IAttribute Value
            {
                get
                {
                    return this.ModelElement.Identifier;
                }
                set
                {
                    this.ModelElement.Identifier = value;
                }
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be subscribed to the property change event</param>
            protected override void RegisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.IdentifierChanged += handler;
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be unsubscribed from the property change event</param>
            protected override void UnregisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.IdentifierChanged -= handler;
            }
        }
    }
}

