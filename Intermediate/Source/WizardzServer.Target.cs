using UnrealBuildTool;

public class WizardzServerTarget : TargetRules
{
	public WizardzServerTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V3;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Server;
		ExtraModuleNames.Add("Wizardz");
	}
}
