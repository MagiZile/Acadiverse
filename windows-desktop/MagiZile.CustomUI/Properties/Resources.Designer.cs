﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MagiZile.CustomUI.Properties {
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
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("MagiZile.CustomUI.Properties.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap ico_backspace {
            get {
                object obj = ResourceManager.GetObject("ico_backspace", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap ico_enter {
            get {
                object obj = ResourceManager.GetObject("ico_enter", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to You will have to enter the password EVERY TIME you open this project! If you lose/forget the password, it CANNOT be recovered!.
        /// </summary>
        internal static string str_confirm_password_change_message {
            get {
                return ResourceManager.GetString("str_confirm_password_change_message", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Confirm Password Change.
        /// </summary>
        internal static string str_confirm_password_change_title {
            get {
                return ResourceManager.GetString("str_confirm_password_change_title", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Error.
        /// </summary>
        internal static string str_error {
            get {
                return ResourceManager.GetString("str_error", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Please enter a password..
        /// </summary>
        internal static string str_password_blank_error {
            get {
                return ResourceManager.GetString("str_password_blank_error", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The passwords do not match..
        /// </summary>
        internal static string str_password_mismatch_error {
            get {
                return ResourceManager.GetString("str_password_mismatch_error", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Please confirm your password..
        /// </summary>
        internal static string str_password_not_confirmed_error {
            get {
                return ResourceManager.GetString("str_password_not_confirmed_error", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The PIN is incorrect..
        /// </summary>
        internal static string str_pin_incorrect {
            get {
                return ResourceManager.GetString("str_pin_incorrect", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The PIN is incorrect. You have $ tries remaining..
        /// </summary>
        internal static string str_pin_incorrect_limited_tries {
            get {
                return ResourceManager.GetString("str_pin_incorrect_limited_tries", resourceCulture);
            }
        }
    }
}
