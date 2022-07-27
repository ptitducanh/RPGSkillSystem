using System.Collections;
using System.Collections.Generic;
using Data.Talent.TalentEffect;
using Data.Talent.TriggerCondition;
using UnityEngine;

[CreateAssetMenu(fileName = "Data", menuName = "Skill Database/Talent/Condition/Skill Name")]
public class SkillNameConditionScriptableObject : TalentConditionScriptableObject
{
    public SkillNameCondition Condition;

    public override TalentTriggerCondition GetTalentTriggerCondition()
    {
        return Condition;
    }
}
