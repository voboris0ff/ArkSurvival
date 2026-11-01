// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class TryHarder : ModuleRules
{
	public TryHarder(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] {
			"Core",
			"CoreUObject",
			"Engine",
			"InputCore",
			"EnhancedInput",
			"AIModule",
			"StateTreeModule",
			"GameplayStateTreeModule",
			"UMG",
			"Slate"
		});

		PrivateDependencyModuleNames.AddRange(new string[] { });

		PublicIncludePaths.AddRange(new string[] {
			"TryHarder",
			"TryHarder/Variant_Platforming",
			"TryHarder/Variant_Platforming/Animation",
			"TryHarder/Variant_Combat",
			"TryHarder/Variant_Combat/AI",
			"TryHarder/Variant_Combat/Animation",
			"TryHarder/Variant_Combat/Gameplay",
			"TryHarder/Variant_Combat/Interfaces",
			"TryHarder/Variant_Combat/UI",
			"TryHarder/Variant_SideScrolling",
			"TryHarder/Variant_SideScrolling/AI",
			"TryHarder/Variant_SideScrolling/Gameplay",
			"TryHarder/Variant_SideScrolling/Interfaces",
			"TryHarder/Variant_SideScrolling/UI"
		});

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}
