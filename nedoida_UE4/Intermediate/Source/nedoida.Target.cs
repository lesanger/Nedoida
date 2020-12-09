using UnrealBuildTool;

public class nedoidaTarget : TargetRules
{
	public nedoidaTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		ExtraModuleNames.Add("nedoida");
	}
}
