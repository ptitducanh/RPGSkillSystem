using System;

namespace Data.Skill.SkillAttribute
{
    [Serializable]
    public class FloatSkillAttribute : SkillAttribute<float>
    {
        public FloatSkillAttribute(string attributeName, float baseValue, float bonusValue) : base(attributeName, baseValue, bonusValue)
        {
            
        }

        public override float GetValue()
        {
            return baseValue + bonusValue;
        }
    }
}

