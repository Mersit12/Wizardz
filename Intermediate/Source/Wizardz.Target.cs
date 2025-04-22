using UnrealBuildTool;

public class WizardzTarget : TargetRules
{
	public WizardzTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V3;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Game;
		ExtraModuleNames.Add("Wizardz");
	}
}
