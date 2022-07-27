using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(TalentEffectScriptableObject))]
public class TalentEffectScriptableObjectEditor : Editor
{
    private TalentEffectScriptableObject TalentEffectScriptableObject => (TalentEffectScriptableObject)target;
    private string[] allClassNames;
    private Type[] allClasses;
    private int index = 0;
    private void OnEnable()
    {
        allClasses = Utilities.GetAllSubClasses<SkillEffect>();
        allClassNames = allClasses.Select(type => type.Name).ToArray();
    }

    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();

        index = EditorGUILayout.Popup(index, allClassNames);
        
    }
}
