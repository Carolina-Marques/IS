﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AirMonit_Service.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "15.3.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute("Data Source=c979e30d-dc64-48b5-9a7b-a84b00ce6051.sqlserver.sequelizer.com;Initial" +
            " Catalog=dbc979e30ddc6448b59a7ba84b00ce6051;Persist Security Info=True;User ID=i" +
            "shycfthudagcmwo;Password=2BEZwEf5zd3eFBinUdQGJ5Ypxdo5H4ETZuwG7DEVLvFctQTtaUCcUs6" +
            "5KpBsqjvE")]
        public string ConnString {
            get {
                return ((string)(this["ConnString"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\leona\\Desktop\\AirDB" +
            " (2).mdf\";Integrated Security=True;Connect Timeout=30")]
        public string DBConn {
            get {
                return ((string)(this["DBConn"]));
            }
        }
    }
}
