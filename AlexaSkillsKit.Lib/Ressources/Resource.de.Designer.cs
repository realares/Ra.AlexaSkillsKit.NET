﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//     Laufzeitversion:4.0.30319.42000
//
//     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
//     der Code erneut generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Ra.AlexaSkillsKit.Ressources {
    using System;
    using System.Reflection;
    
    
    /// <summary>
    ///   Eine stark typisierte Ressourcenklasse zum Suchen von lokalisierten Zeichenfolgen usw.
    /// </summary>
    // Diese Klasse wurde von der StronglyTypedResourceBuilder automatisch generiert
    // -Klasse über ein Tool wie ResGen oder Visual Studio automatisch generiert.
    // Um einen Member hinzuzufügen oder zu entfernen, bearbeiten Sie die .ResX-Datei und führen dann ResGen
    // mit der /str-Option erneut aus, oder Sie erstellen Ihr VS-Projekt neu.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resource1 {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resource1() {
        }
        
        /// <summary>
        ///   Gibt die zwischengespeicherte ResourceManager-Instanz zurück, die von dieser Klasse verwendet wird.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Ra.AlexaSkillsKit.Ressources.Resource1", typeof(Resource1).GetTypeInfo().Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Überschreibt die CurrentUICulture-Eigenschaft des aktuellen Threads für alle
        ///   Ressourcenzuordnungen, die diese stark typisierte Ressourcenklasse verwenden.
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
        ///   Sucht eine lokalisierte Zeichenfolge, die Zugriff verweigert ähnelt.
        /// </summary>
        internal static string ACCESS_DENIED {
            get {
                return ResourceManager.GetString("ACCESS_DENIED", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Sucht eine lokalisierte Zeichenfolge, die Sorry, die Anwendung hat einen Fehler festgestellt ähnelt.
        /// </summary>
        internal static string GENERIC_ERROR {
            get {
                return ResourceManager.GetString("GENERIC_ERROR", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Sucht eine lokalisierte Zeichenfolge, die Fehler: keine gültige Anfrage ähnelt.
        /// </summary>
        internal static string INVALID_REQUEST_TYPE {
            get {
                return ResourceManager.GetString("INVALID_REQUEST_TYPE", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Sucht eine lokalisierte Zeichenfolge, die Sorry, die Anwendung wusste nicht, was mit dem AudioPlayer-Event zu tun ist ähnelt.
        /// </summary>
        internal static string NO_AUDIO_PLAYER_EVENT_HANDLER_FOUND {
            get {
                return ResourceManager.GetString("NO_AUDIO_PLAYER_EVENT_HANDLER_FOUND", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Sucht eine lokalisierte Zeichenfolge, die Sorry, die Anwendung wusste nicht, was mit dieser Anfrage zu tun ist ähnelt.
        /// </summary>
        internal static string NO_INTENT_FOUND {
            get {
                return ResourceManager.GetString("NO_INTENT_FOUND", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Sucht eine lokalisierte Zeichenfolge, die Versuchen Sie, der Anwendung zu sagen, was zu tun ist, anstatt sie zu öffnen ähnelt.
        /// </summary>
        internal static string NO_LAUNCH_FUNCTION {
            get {
                return ResourceManager.GetString("NO_LAUNCH_FUNCTION", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Sucht eine lokalisierte Zeichenfolge, die Diese Anforderung unterstützt keine Sitzungsattribute ähnelt.
        /// </summary>
        internal static string NO_SESSION {
            get {
                return ResourceManager.GetString("NO_SESSION", resourceCulture);
            }
        }
    }
}
