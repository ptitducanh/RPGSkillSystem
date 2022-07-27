using System;

namespace Data.Talent.TriggerCondition
{
    [Serializable]
    public class TalentTriggerCondition
    {
        public virtual bool CanTrigger(Data.Skill.SkillData skillData)
        {
            return true;
        }
    }
}