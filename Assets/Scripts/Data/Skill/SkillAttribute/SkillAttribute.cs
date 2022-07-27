using System;

namespace Data.Skill.SkillAttribute
{
    [Serializable]
    public class SkillAttribute<T>
    {
        public string AttributeName { get; protected set; }
        public T baseValue { get; protected set; }
        public T bonusValue { get; protected set; }

        public SkillAttribute(string attributeName, T baseValue, T bonusValue)
        {
            AttributeName = attributeName;
            this.baseValue = baseValue;
            this.bonusValue = bonusValue;
        }

        public virtual T GetValue()
        {
            return baseValue;
        }

        public virtual void ChangeBaseValue(T newValue)
        {
            baseValue = newValue;
        }

        public virtual void ChangeBonusValue(T newValue)
        {
            bonusValue = newValue;
        }
    }
}