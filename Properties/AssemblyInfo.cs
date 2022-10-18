using System.Reflection;
using MelonLoader;

[assembly: AssemblyTitle(MinimiseOnLoad.BuildInfo.Description)]
[assembly: AssemblyDescription(MinimiseOnLoad.BuildInfo.Description)]
[assembly: AssemblyProduct(MinimiseOnLoad.BuildInfo.Name)]
[assembly: AssemblyCopyright("Created by " + MinimiseOnLoad.BuildInfo.Author)]
[assembly: AssemblyVersion(MinimiseOnLoad.BuildInfo.Version)]
[assembly: AssemblyFileVersion(MinimiseOnLoad.BuildInfo.Version)]
[assembly: MelonInfo(typeof(MinimiseOnLoad.MinimiseOnLoadMod), MinimiseOnLoad.BuildInfo.Name, MinimiseOnLoad.BuildInfo.Version, MinimiseOnLoad.BuildInfo.Author, MinimiseOnLoad.BuildInfo.DownloadLink)]
[assembly: MelonColor()]

// Create and Setup a MelonGame Attribute to mark a Melon as Universal or Compatible with specific Games.
// If no MelonGame Attribute is found or any of the Values for any MelonGame Attribute on the Melon is null or empty it will be assumed the Melon is Universal.
// Values for MelonGame Attribute can be found in the Game's app.info file or printed at the top of every log directly beneath the Unity version.
[assembly: MelonGame("Alpha Blend Interactive", "ChilloutVR")]
