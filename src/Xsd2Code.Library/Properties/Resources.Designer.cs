﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Xsd2Code.Library.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Xsd2Code.Library.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to        #region  Fields
        ///        private bool isDeserializingField;
        ///        private ObjectState originalobjectStateField = ObjectState.Added;
        ///        private bool isInitilizedField = false;
        ///        private readonly ObservableCollection&lt;PropertyValueState&gt; changeSetsField = new ObservableCollection&lt;PropertyValueState&gt;();
        ///        private Delegate collectionChangedDelegateField = null;
        ///
        ///        private bool objectTrackingEnabledField;
        ///        private readonly object trackedObjectField;
        ///
        ///        private [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string ObjectChangeTracker_cs {
            get {
                return ResourceManager.GetString("ObjectChangeTracker_cs", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to         public ObjectState NewState { get; set; }.
        /// </summary>
        internal static string ObjectStateChangingEventArgs_cs {
            get {
                return ResourceManager.GetString("ObjectStateChangingEventArgs_cs", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to         public string PropertyName { get; set; }
        ///        public object OriginalValue { get; set; }
        ///        public object CurrentValue { get; set; }
        ///        public ObjectState State { get; set; }.
        /// </summary>
        internal static string PropertyValueState_cs {
            get {
                return ResourceManager.GetString("PropertyValueState_cs", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to         /// &lt;summary&gt;
        ///        /// Name of property
        ///        /// &lt;/summary&gt;
        ///        private string propertyNameField;
        ///
        ///        /// &lt;summary&gt;
        ///        /// Occurs when [trackable collection changed].
        ///        /// &lt;/summary&gt;
        ///        public virtual event NotifyTrackableCollectionChangedEventHandler TrackableCollectionChanged;
        ///
        ///        /// &lt;summary&gt;
        ///        /// Initializes a new instance of the &lt;see cref=&quot;TrackableCollection&amp;lt;T&amp;gt;&quot;/&gt; class.
        ///        /// &lt;/summary&gt;
        ///        /// &lt;param name=&quot;propertyName [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string TrackableCollection_cs {
            get {
                return ResourceManager.GetString("TrackableCollection_cs", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &quot;Code provider for language {0} is not supported&quot;.
        /// </summary>
        internal static string UnsupportedLanguageCodeDomProvider {
            get {
                return ResourceManager.GetString("UnsupportedLanguageCodeDomProvider", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Target framework %0 is not supported.
        /// </summary>
        internal static string UnsupportedTargetFramework {
            get {
                return ResourceManager.GetString("UnsupportedTargetFramework", resourceCulture);
            }
        }
    }
}