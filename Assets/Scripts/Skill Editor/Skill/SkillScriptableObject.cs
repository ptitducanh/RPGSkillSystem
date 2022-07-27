using Data.Skill;
using Data.Skill.SkillAttribute;
using UnityEngine;

[CreateAssetMenu(fileName = "Data", menuName = "Skill Database/Skill/New Skill")]
public class SkillScriptableObject : ScriptableObject
{
    private SkillData SkillData;

    public string Name;
    public string Description;
    public float ManaCost;
    public float Cooldown;
    public SkillEffect SkillEffect;

    [HideInInspector]public int CurrentSelectedSkill = -1;

    public SkillData GetSkillData()
    {
        SkillData = new SkillData()
        {
            Name = new SkillAttribute<string>("Name", Name, ""),
            Description = new SkillAttribute<string>("Description", Description, ""),
            ManaCost = new FloatSkillAttribute("Mana Cost", ManaCost, 0),
            Cooldown = new FloatSkillAttribute("Cooldown", Cooldown, 0),
            SkillEffect = new SkillAttribute<SkillEffect>("Skill Effect", new SkillEffect(), null)
        };

        return SkillData;
    }
}
