using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThunderSpell : Spell
{
    void Start()
    {
        Debug.Log("(Ice) Casting Thunder Clap!");
        Cast();
    }

    public override void Cast()
    {
        Debug.Log($"Casting a spell To The SKY");
    }
}
