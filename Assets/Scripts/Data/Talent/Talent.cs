using Data.Skill;
using Data.Talent.TriggerCondition;

namespace Data.Talent
{
    public class Talent
    {
        public TalentTriggerCondition Condition;
        public TalentEffect.TalentEffect Effect;

        public void ApplyEffect(SkillData skillData)
        {
            if (Condition != null && Condition.CanTrigger(skillData))
            {
                Effect?.Perform(skillData);
            }
        }
    }
}

