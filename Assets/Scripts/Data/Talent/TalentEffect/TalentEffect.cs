using System;
using Data.Skill;

namespace Data.Talent.TalentEffect
{
    [Serializable]
    public class TalentEffect
    {
        public virtual void Perform(SkillData skillData) {}
    }
}
