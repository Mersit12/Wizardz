using UnrealBuildTool;

public class WizardzClientTarget : TargetRules
{
	public WizardzClientTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V3;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Client;
		ExtraModuleNames.Add("Wizardz");
	}
}
