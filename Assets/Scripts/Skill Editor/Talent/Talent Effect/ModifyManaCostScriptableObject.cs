using System.Collections;
using System.Collections.Generic;
using Data.Talent.TalentEffect;
using UnityEngine;

[CreateAssetMenu(fileName = "Data", menuName = "Skill Database/Talent/Talent Effect/Modify Mana Cost")]
public class ModifyManaCostScriptableObject : TalentEffectScriptableObject
{
    public ModifyManaCost ModifyManaCost;

    public override TalentEffect GetTalentEffect()
    {
        return ModifyManaCost;
    }
}
