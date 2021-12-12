using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets
{
    public class Animal : Usable
    {
        public int maxFoodValue = 100;
        public int currentFood;
    
        public int maxWaterValue = 100;
        public int currentWater;

        public Bar foodBar;
        public Bar waterBar;

        public BillBoard foodCanvas;
        public BillBoard waterCanvas;

        public override void Start()
        {
            currentFood = maxFoodValue;
            foodBar.SetMaxValue(maxFoodValue);
        
            currentWater = maxWaterValue;
            waterBar.SetMaxValue(maxWaterValue);
        }
        
        protected override void HandleInteractionStarted(Collider collider)
        {
            base.HandleInteractionStarted(collider);
        }

        protected override void HandleInteractionEnded(Collider collider)
        {
            base.HandleInteractionEnded(collider);
        }
    }
}
