﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Web.Management.PHP {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0")]
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
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Web.Management.PHP.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to Cannot find a php.ini file associated with PHP executable {0}..
        /// </summary>
        internal static string CannotFindPhpIniForExecutableError {
            get {
                return ResourceManager.GetString("CannotFindPhpIniForExecutableError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot register PHP because FastCGI module is not enabled in IIS..
        /// </summary>
        internal static string FastCgiNotEnabledError {
            get {
                return ResourceManager.GetString("FastCgiNotEnabledError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The folder {0} does not contain &quot;ext&quot; folder with PHP extensions..
        /// </summary>
        internal static string FolderDoesNotHaveExtDirError {
            get {
                return ResourceManager.GetString("FolderDoesNotHaveExtDirError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to There is no php executable file (php-cgi.exe) at the specified location {0}..
        /// </summary>
        internal static string PhpCgiExeDoesNotExistError {
            get {
                return ResourceManager.GetString("PhpCgiExeDoesNotExistError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The provided php executable path {0} is invalid..
        /// </summary>
        internal static string PhpCgiExePathInvalidError {
            get {
                return ResourceManager.GetString("PhpCgiExePathInvalidError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot file php.ini or php.ini-recommended or php.ini-production in {0}..
        /// </summary>
        internal static string PhpIniFilesDoNotExistError {
            get {
                return ResourceManager.GetString("PhpIniFilesDoNotExistError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to PHP Manager for IIS.
        /// </summary>
        internal static string PHPManagerFriendlyName {
            get {
                return ResourceManager.GetString("PHPManagerFriendlyName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot perform the action because PHP is not registered properly..
        /// </summary>
        internal static string PhpNotRegisteredError {
            get {
                return ResourceManager.GetString("PhpNotRegisteredError", resourceCulture);
            }
        }
    }
}
