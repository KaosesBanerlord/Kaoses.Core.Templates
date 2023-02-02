using KaosesCommon.Utils;
using KaosesCommon.Objects;
using BLNamespace.Objects;
using BLNamespace.Settings;
using BLNamespaceCore;
using BLNamespaceCore.Objects;
using BLNamespaceCore.Settings;
using CoreFactory = BLNamespaceCore.Objects.BLNamespaceCoreFactory;
using CoreConfig = BLNamespaceCore.Settings.BLNamespaceCoreConfig;

namespace BLNamespace
{
    /// <summary>
    /// Internal class to initialize the mod settings class from MCM and to set the IM and Logger variables 
    /// </summary>
    internal class Init
    {
        public Init()
        {
            /// Load the Settings Object
            Config settings = Factory.Settings;

            //ConfigOther settings2 = Factory.Settings2;
            //TempCoreConfig settings2 = Factory.SettingsCore;
            //TempCoreConfig settings2 = TempCoreFactory.Settings;
            //Factory.DConfig();


            ///
            /// Set IM variable values
            ///
            InfoMgr im = new InfoMgr(settings.Debug, settings.LogToFile, SubModule.ModuleId, SubModule.modulePath);
            Factory.IM.PrePrend = SubModule.ModuleId;
            Factory.IM.ModVersion = settings.versionTextObj.ToString();
            //Factory.IM.LogFilePath = "c:\\BannerLord\\KaosesCommon\\logfile.text";
            //Factory.IM.AddDateTimeToLog = true;
            Factory.IM = im;
        }
    }
}
