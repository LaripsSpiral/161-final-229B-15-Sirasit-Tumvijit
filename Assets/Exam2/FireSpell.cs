using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireSpell : Spell
{
    void Start()
    {
        Debug.Log("(Fire) Casting Burner!");
        Cast(target: "Self", power: 666);
    }
}
