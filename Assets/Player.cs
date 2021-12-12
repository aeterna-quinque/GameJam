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

    public int increasingFoodValue = 10;
    public int feedFoodValue = 10;

    public int increasingWaterValue = 10;
    public int feedWaterValue = 10;
    
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

    public void IncreaseFood()
    {
        currentFood += increasingFoodValue;
        foodBar.SetValue(currentFood);
    }

    public bool IsFoodInventoryFull()
    {
        return currentFood == maxFoodValue;
    }
    
    public void IncreaseWater()
    {
        currentWater += increasingWaterValue;
        foodBar.SetValue(currentWater);
    }

    public bool IsWaterInventoryFull()
    {
        return currentWater == maxWaterValue;
    }

    public void DecreaseFood()
    {
        currentFood -= feedFoodValue;
        foodBar.SetValue(currentFood);
    }
    
    public bool IsFoodInventoryEmpty()
    {
        return currentFood == 0;
    }
    
    public void DecreaseWater()
    {
        currentWater -= feedWaterValue;
        waterBar.SetValue(currentWater);
    }
    
    public bool IsWaterInventoryEmpty()
    {
        return currentWater == 0;
    }
}
