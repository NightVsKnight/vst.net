﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Jacobi.Vst.Plugin.Framework.Properties {
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
    public class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Jacobi.Vst.Plugin.Framework.Properties.Resources", typeof(Resources).Assembly);
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
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The property is already set to an instance of an object. Reset to null before assigning a new object instance..
        /// </summary>
        public static string ExtensibleInterfaceRef_InstanceAlreadySet {
            get {
                return ResourceManager.GetString("ExtensibleInterfaceRef_InstanceAlreadySet", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The Host does not implement OpenFileSelector..
        /// </summary>
        public static string FileSelectorScope_OpenNotSupported {
            get {
                return ResourceManager.GetString("FileSelectorScope_OpenNotSupported", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The HostCommandStub has not been initialized..
        /// </summary>
        public static string StdPluginCommandStub_HostNotInitialized {
            get {
                return ResourceManager.GetString("StdPluginCommandStub_HostNotInitialized", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The Plugin returned a {0} &apos;{1}&apos; that is too long. Maximum length is {2} characters..
        /// </summary>
        public static string StdPluginCommandStub_StringTooLong {
            get {
                return ResourceManager.GetString("StdPluginCommandStub_StringTooLong", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The VstEventCollection is read-only..
        /// </summary>
        public static string VstEventCollection_CollectionReadOnly {
            get {
                return ResourceManager.GetString("VstEventCollection_CollectionReadOnly", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A plugin cannot send events to the host when it does not implement IVstPluginMidiSource..
        /// </summary>
        public static string VstHost_PluginRequiresMidiSource {
            get {
                return ResourceManager.GetString("VstHost_PluginRequiresMidiSource", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Assigned VstParameterManager value is not linked to this VstParamaterInfo instance..
        /// </summary>
        public static string VstParameterInfo_ParameterManagerNotLinked {
            get {
                return ResourceManager.GetString("VstParameterInfo_ParameterManagerNotLinked", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The specified VstParameterInfo instance already has a VstParameterNormalizationInfo instance attached..
        /// </summary>
        public static string VstParameterNormalizationInfo_AlreadyAttached {
            get {
                return ResourceManager.GetString("VstParameterNormalizationInfo_AlreadyAttached", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The specified VstParameterInfo does not have a valid value range set..
        /// </summary>
        public static string VstParameterNormalizationInfo_ParameterInfoInvalid {
            get {
                return ResourceManager.GetString("VstParameterNormalizationInfo_ParameterInfoInvalid", resourceCulture);
            }
        }
    }
}
