using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spell : MonoBehaviour
{
    private void Start()
    {
        Cast("(Base) Simulation");
        Cast("(Base) Simulation", 0);
    }

    public virtual void Cast()
    {

    }

    public void Cast(string target)
    {
        Debug.Log($"Casting a spell on {target}!");
    }
    public void Cast(string target, int power)
    {
        Debug.Log($"Casting a spell on {target} with power {power}!");
    }
}
