﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.18444
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WoWHeadParser.Properties {
    using System;
    
    
    /// <summary>
    ///   Класс ресурса со строгой типизацией для поиска локализованных строк и т.д.
    /// </summary>
    // Этот класс создан автоматически классом StronglyTypedResourceBuilder
    // с помощью такого средства, как ResGen или Visual Studio.
    // Чтобы добавить или удалить член, измените файл .ResX и снова запустите ResGen
    // с параметром /str или перестройте свой проект VS.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Возвращает кэшированный экземпляр ResourceManager, использованный этим классом.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("WoWHeadParser.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Перезаписывает свойство CurrentUICulture текущего потока для всех
        ///   обращений к ресурсу с помощью этого класса ресурса со строгой типизацией.
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
        ///   Ищет локализованную строку, похожую на Do you really want to stop ?.
        /// </summary>
        internal static string AbortQuestion {
            get {
                return ResourceManager.GetString("AbortQuestion", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Entries count: {0}.
        /// </summary>
        internal static string EntryCountLabel {
            get {
                return ResourceManager.GetString("EntryCountLabel", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Cannot get response from {0}.
        /// </summary>
        internal static string Error_Cannot_get_response {
            get {
                return ResourceManager.GetString("Error_Cannot_get_response", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Can&apos;t get loader for {0} file.
        /// </summary>
        internal static string Error_unsupported_db_file_loader {
            get {
                return ResourceManager.GetString("Error_unsupported_db_file_loader", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Error while loading {0}! Skip.
        /// </summary>
        internal static string Error_while_loading_db_file {
            get {
                return ResourceManager.GetString("Error_while_loading_db_file", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Error while loading welf file {0} - {1}.
        /// </summary>
        internal static string Error_while_loading_welf_file {
            get {
                return ResourceManager.GetString("Error_while_loading_welf_file", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Do you really want to quit WoWHead Parser ?.
        /// </summary>
        internal static string ExitQuestion {
            get {
                return ResourceManager.GetString("ExitQuestion", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Item data parser.
        /// </summary>
        internal static string ItemParser {
            get {
                return ResourceManager.GetString("ItemParser", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Aborting....
        /// </summary>
        internal static string Label_Abort {
            get {
                return ResourceManager.GetString("Label_Abort", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Complete!.
        /// </summary>
        internal static string Label_Complete {
            get {
                return ResourceManager.GetString("Label_Complete", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Parsing....
        /// </summary>
        internal static string Label_Working {
            get {
                return ResourceManager.GetString("Label_Working", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Loaded {0} db files in {1} ms.
        /// </summary>
        internal static string Loaded_count_db_files {
            get {
                return ResourceManager.GetString("Loaded_count_db_files", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Starting value can not be bigger than ending value!.
        /// </summary>
        internal static string MultipleTypeBigger {
            get {
                return ResourceManager.GetString("MultipleTypeBigger", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Starting value can not be equal ending value!.
        /// </summary>
        internal static string MultipleTypeEqual {
            get {
                return ResourceManager.GetString("MultipleTypeEqual", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на NPC data parser.
        /// </summary>
        internal static string NpcDataParser {
            get {
                return ResourceManager.GetString("NpcDataParser", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на NPC locale data parser.
        /// </summary>
        internal static string NpcLocaleParser {
            get {
                return ResourceManager.GetString("NpcLocaleParser", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Book page data parser.
        /// </summary>
        internal static string PageParser {
            get {
                return ResourceManager.GetString("PageParser", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Quest template data parser.
        /// </summary>
        internal static string QuestDataParser {
            get {
                return ResourceManager.GetString("QuestDataParser", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Quest locale data parser.
        /// </summary>
        internal static string QuestLocaleParser {
            get {
                return ResourceManager.GetString("QuestLocaleParser", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Professions &amp; Class Trainer data parser.
        /// </summary>
        internal static string TrainerParser {
            get {
                return ResourceManager.GetString("TrainerParser", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Vendor data parser.
        /// </summary>
        internal static string VendorParser {
            get {
                return ResourceManager.GetString("VendorParser", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на File {0} not found!.
        /// </summary>
        internal static string WelfFileNotFound {
            get {
                return ResourceManager.GetString("WelfFileNotFound", resourceCulture);
            }
        }
    }
}
