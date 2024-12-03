using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : Animal
{
    private float dailyFoodConsumption = .4f;
    private float weight = 5.5f;

    private void Start()
    {
        Init("Bird");

        DisplayName();

        MakeSound();

        Debug.Log($"{animalName} eats {dailyFoodConsumption} kg of food daily and weights {weight} kg.");
        Debug.Log($"{animalName}'s weekly food req: {CalculateFoodRequirement()} kg.");
    }

    public override void MakeSound()
    {
        base.MakeSound();
        Debug.Log($"({animalName})  Kwakk");
    }

    public override float CalculateFoodRequirement()
    {
        return dailyFoodConsumption * weight * 7;
    }
}
