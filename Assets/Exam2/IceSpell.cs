using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IceSpell : Spell
{
    void Start()
    {
        Debug.Log("(Ice) Casting Freeze Ray!");
        Cast(target: "Dog");
    }
}
