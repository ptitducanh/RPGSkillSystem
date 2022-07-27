using System;
using System.Collections.Generic;
using Data.Skill;
using Data.Skill.SkillAttribute;
using Data.Talent;
using UnityEngine;

public class Player : MonoBehaviour
{
    public SkillScriptableObject[] SkillDataBase;
    public TalentScriptableObject[] TalentDataBase;

    private List<SkillData> Skills = new List<SkillData>();
    private List<Talent> Talents = new List<Talent>();

    private void Start()
    {
        GetSkillAndTalent();
        ApplyAllTalent();
    }

    private void GetSkillAndTalent()
    {
        foreach (var skillDB in SkillDataBase)
        {
            Skills.Add(skillDB.GetSkillData());
        }

        foreach (var talentDB in TalentDataBase)
        {
            var talent = talentDB.GetTalent();
            Talents.Add(talent);
        }
    }

    public void ApplyAllTalent()
    {
        foreach (var talent in Talents)
        {
            foreach (var skill in Skills)
            {
                talent.ApplyEffect(skill);
            }
        }
    }
}