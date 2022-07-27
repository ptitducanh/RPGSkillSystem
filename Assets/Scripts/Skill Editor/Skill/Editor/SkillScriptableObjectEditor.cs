using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(SkillScriptableObject))]
public class SkillScriptableObjectEditor : Editor
{
    private SkillScriptableObject SkillScriptableObject => (SkillScriptableObject)target;
    private string[] allClassNames;
    private Type[] allClasses;
    private int previousIndex = -1;
    
    private void OnEnable()
    {
        allClasses = Utilities.GetAllSubClasses<SkillEffect>();
        allClassNames = allClasses.Select(type => type.Name).ToArray();
    }
    
    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();
        
        SkillScriptableObject.CurrentSelectedSkill = EditorGUILayout.Popup(SkillScriptableObject.CurrentSelectedSkill, allClassNames);
        if (SkillScriptableObject.CurrentSelectedSkill != previousIndex)
        {
            previousIndex = SkillScriptableObject.CurrentSelectedSkill;
            if (SkillScriptableObject.CurrentSelectedSkill > -1)
            {
                SkillScriptableObject.SkillEffect = (SkillEffect)Activator.CreateInstance(allClasses[SkillScriptableObject.CurrentSelectedSkill]);
            }
        }
    }
}
