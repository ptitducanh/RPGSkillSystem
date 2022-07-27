using Data.Talent.TalentEffect;
using Data.Talent.TriggerCondition;
using UnityEngine;

public class TalentConditionScriptableObject : ScriptableObject
{
    public virtual TalentTriggerCondition GetTalentTriggerCondition()
    {
        return null;
    }
}