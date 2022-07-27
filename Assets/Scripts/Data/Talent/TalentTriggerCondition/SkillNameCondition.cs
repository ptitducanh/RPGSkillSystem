using System;

namespace Data.Talent.TriggerCondition
{
    [Serializable]
    public class SkillNameCondition : TalentTriggerCondition
    {
        public string SkillName;
        public override bool CanTrigger(Skill.SkillData skillData)
        {
            return skillData.Name.GetValue() == SkillName;
        }
    }
}