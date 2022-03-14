using UnrealBuildTool;

public class devTarget : TargetRules
{
	public devTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		ExtraModuleNames.Add("dev");
	}
}
