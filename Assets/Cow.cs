using System.Collections;
using System.Collections.Generic;
using Assets;
using UnityEngine;

/**
 * Cow class (maybe Horse)
 */
public class Cow : Animal
{
    /**
     * Cow food values
     */
    public int maxFoodValue = 100;
    public int startFoodValue = 70;
    public int currentFoodValue;

    public int maxWaterValue = 100;
    public int startWaterValue = 50;
    public int currentWaterValue;
    
    public Bar foodBar;
    public Bar waterBar;
    
    // Start is called before the first frame update
    private void Start()
    {
        foodBar.SetMaxValue(maxFoodValue);
        currentFoodValue = startFoodValue;
        
        waterBar.SetMaxValue(maxWaterValue);
        currentWaterValue = startWaterValue;
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        
    }
}
