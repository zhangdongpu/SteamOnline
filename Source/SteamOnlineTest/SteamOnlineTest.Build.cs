// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class SteamOnlineTest : ModuleRules
{
	public SteamOnlineTest(ReadOnlyTargetRules Target) : base(Target)
	{
		PrivateDependencyModuleNames.AddRange(new string[] {  });
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[]
		{
			"Core", 
			"CoreUObject", 
			"Engine", 
			"InputCore",
			"HeadMountedDisplay",
			"EnhancedInput",
			"OnlineSubsystem",
			"OnlineSubsystemSteam"
		});
	}
}
