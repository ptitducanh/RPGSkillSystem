using Data.Talent;
using Data.Talent.TriggerCondition;
using UnityEngine;

[CreateAssetMenu(fileName = "Data", menuName = "Skill Database/Talent/New Talent")]
public class TalentScriptableObject : ScriptableObject
{
    public TalentConditionScriptableObject Condition;
    public TalentEffectScriptableObject TalentEffect;

    public Talent GetTalent()
    {
        return new Talent()
        {
            Condition = Condition.GetTalentTriggerCondition(),
            Effect = TalentEffect.GetTalentEffect()
        };
    }
}