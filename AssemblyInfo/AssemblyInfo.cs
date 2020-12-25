using System.Resources;
using System.Reflection;
using System.Runtime.InteropServices;
using MelonLoader;

[assembly: AssemblyTitle(TestMod.BuildInfo.Name)]
[assembly: AssemblyDescription("")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany(TestMod.BuildInfo.Company)]
[assembly: AssemblyProduct(TestMod.BuildInfo.Name)]
[assembly: AssemblyCopyright("Created by " + TestMod.BuildInfo.Author)]
[assembly: AssemblyTrademark(TestMod.BuildInfo.Company)]
[assembly: AssemblyCulture("")]
[assembly: ComVisible(false)]
[assembly: AssemblyVersion(TestMod.BuildInfo.Version)]
[assembly: AssemblyFileVersion(TestMod.BuildInfo.Version)]
[assembly: NeutralResourcesLanguage("en")]
[assembly: MelonInfo(typeof(TestMod.TestMod), TestMod.BuildInfo.Name, TestMod.BuildInfo.Version, TestMod.BuildInfo.Author, TestMod.BuildInfo.DownloadLink)]
[assembly: MelonGame("VRChat", "VRChat")]
