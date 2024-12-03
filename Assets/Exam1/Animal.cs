using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;

public abstract class Animal : MonoBehaviour
{
    protected string animalName;

    public void Init(string animalName)
    {
        this.animalName = animalName;
    }

    public abstract float CalculateFoodRequirement();

    public virtual void MakeSound()
    {
        Debug.Log($"{animalName} is makes a sound");
    }

    public void DisplayName()
    {
        Debug.Log($"This is {animalName}");
    }

}
