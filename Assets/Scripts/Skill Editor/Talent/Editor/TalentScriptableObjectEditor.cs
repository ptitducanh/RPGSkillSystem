using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using Data.Talent.TalentEffect;
using Data.Talent.TriggerCondition;
using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(TalentScriptableObject))]
public class TalentScriptableObjectEditor : Editor
{
    public string[] conditionTypes = new string[] { "Skill Name", "Mana Cost" };
    public int index = 0;
    
    private TalentScriptableObject talentScriptableObject => (TalentScriptableObject)target;
    
    public override void OnInspectorGUI()
    {
        GUILayout.Label("TALENT DESCRIPTION");
        GUILayout.Space(10);
        
        GUILayout.Label(CreateSkillDescription());
        
        base.OnInspectorGUI();
    }

    private string CreateSkillDescription()
    {
        StringBuilder sb = new StringBuilder();
        var condition = talentScriptableObject.Condition;
        if (condition is SkillNameConditionScriptableObject skillNameCondition)
        {
            sb.AppendLine($"If Skill Name is {skillNameCondition.Condition.SkillName}");
        }
        
        var effect = talentScriptableObject.TalentEffect;
        if (effect is ModifyManaCostScriptableObject modifyManaCost)
        {
            string prefix = "";
            var bonusValue = modifyManaCost.ModifyManaCost.BonusValue;
            if (bonusValue < 0)
            {
                prefix = "Reduce";
            }
            else
            {
                prefix = "Increase";
            }

            sb.AppendLine($"{prefix} Mana Cost by {Math.Abs(bonusValue)}");
        }

        return sb.ToString();
    }
}
