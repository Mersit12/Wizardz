using UnrealBuildTool;

public class WizardzEditorTarget : TargetRules
{
	public WizardzEditorTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V3;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Editor;
		ExtraModuleNames.Add("Wizardz");
	}
}
