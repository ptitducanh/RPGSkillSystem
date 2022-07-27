using System;
using Data.Skill.SkillAttribute;

namespace Data.Skill
{
    [Serializable]
    public class SkillData
    {
        public SkillAttribute<string> Name;
        public SkillAttribute<string> Description;
        public FloatSkillAttribute ManaCost;
        public FloatSkillAttribute Cooldown;
        public SkillAttribute<SkillEffect> SkillEffect;

        public void TriggerSkill()
        {
            //TODO: Check the mana cost. For example player has 10 mana
            if (ManaCost.GetValue() < 10)
            {
                SkillEffect.GetValue().Perform();
            }
        }
    }
}

