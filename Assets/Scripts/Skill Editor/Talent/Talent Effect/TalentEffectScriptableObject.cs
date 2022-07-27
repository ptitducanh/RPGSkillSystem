using System.Collections;
using System.Collections.Generic;
using Data.Talent.TalentEffect;
using UnityEngine;


public class TalentEffectScriptableObject : ScriptableObject
{
    public virtual TalentEffect GetTalentEffect()
    {
        return null;
    }
}
