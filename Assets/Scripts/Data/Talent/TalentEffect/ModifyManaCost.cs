using System;
using Data.Skill;

namespace Data.Talent.TalentEffect
{
    [Serializable]
    public class ModifyManaCost : TalentEffect
    {
        public float BonusValue;
        public override void Perform(SkillData skillData)
        {
            skillData.ManaCost.ChangeBonusValue(BonusValue);
        }
    }
}