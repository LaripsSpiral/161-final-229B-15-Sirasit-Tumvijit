using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dog : Animal
{
    private float dailyFoodConsumption = .7f;
    private int activityLevel = 17;

    private void Start()
    {
        Init("Dog");

        DisplayName();

        MakeSound();

        Debug.Log($"{animalName} eats {dailyFoodConsumption} kg of food daily and activity {activityLevel}.");
        Debug.Log($"{animalName}'s weekly food req: {CalculateFoodRequirement()} kg.");
    }

    public override void MakeSound()
    {
        base.MakeSound();
        Debug.Log($"({animalName})  Woof");
    }

    public override float CalculateFoodRequirement()
    {
        return dailyFoodConsumption * activityLevel * 7;
    }
}
