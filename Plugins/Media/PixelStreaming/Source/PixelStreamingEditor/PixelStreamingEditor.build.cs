// Copyright Epic Games, Inc. All Rights Reserved.

using System.IO;

namespace UnrealBuildTool.Rules
{
	public class PixelStreamingEditor : ModuleRules
	{
		public PixelStreamingEditor(ReadOnlyTargetRules Target) : base(Target)
		{
			var EngineDir = Path.GetFullPath(Target.RelativeEnginePath);

			// NOTE: General rule is not to access the private folder of another module
			PrivateIncludePaths.AddRange(new string[]
			{
				Path.Combine("$(ProjectDir)", "Plugins/Media/PixelStreaming/Source/PixelStreaming/Private"),
			});

			PrivateDependencyModuleNames.AddRange(new string[]
			{
				"Core",
				"CoreUObject",
				"Engine",
				"Projects",
				"RenderCore",
				"Renderer",
				"RHI",
				"PixelStreaming",
				"Slate",
				"SlateCore",
				"EngineSettings",
				"InputCore",
				"Json",
				"PixelCapture",
				"PixelStreamingServers",
				"HTTP",
				"Sockets",
				"ApplicationCore",
				"PixelStreamingInput"
			});

			if(Target.bBuildEditor)
			{
				PrivateDependencyModuleNames.AddRange(new string[]
				{
					"UnrealEd",
					"ToolMenus",
					"EditorStyle",
					"DesktopPlatform",
					"LevelEditor",
					"MainFrame"
				});
			}
		}
	}
}
