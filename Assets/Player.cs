using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int maxFoodValue = 100;
    public int currentFood;
    
    public int maxWaterValue = 100;
    public int currentWater;

    public Bar foodBar;
    public Bar waterBar;
    
    public bool begin = true;

    private void Start()
    {
        currentFood = maxFoodValue;
        foodBar.SetMaxValue(maxFoodValue);
        
        currentWater = maxWaterValue;
        waterBar.SetMaxValue(maxWaterValue);
        
        // InvokeRepeating("DecreaseFood", 1, 1);
        // InvokeRepeating("DecreaseWater", 1, 1);
    }

    private void Update()
    {
        // if (Input.GetKeyDown(KeyCode.W))
        // {
        //     DecreaseResources(1, 1);
        // }
    }
    
    // private void DecreaseResources(int food, int water)
    // {
    //     currentFood -= food;
    //     foodBar.SetValue(currentFood);
    //     
    //     currentWater -= water;
    //     waterBar.SetValue(currentWater);
    // }

    // private void DecreaseFood()
    // {
    //     if (currentFood > 0)
    //     {
    //         currentFood -= 10;
    //         foodBar.SetValue(currentFood);
    //     }
    // }
    //
    // private void DecreaseWater()
    // {
    //     if (currentWater > 0)
    //     {
    //         currentWater -= 10;
    //         foodBar.SetValue(currentWater);
    //     }
    // }
    
}
