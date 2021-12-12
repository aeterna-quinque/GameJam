using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets
{
    public class Animal : Usable
    {
        private Player _player = null;
        
        public int maxFoodValue = 100;
        public int currentFood;
    
        public int maxWaterValue = 100;
        public int currentWater;

        public Bar foodBar;
        public Bar waterBar;

        public BillBoard foodCanvas;
        public BillBoard waterCanvas;

        public int eatSpeed = 1;
        
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
            
            collider.gameObject.TryGetComponent<Player>(out _player);
            StartCoroutine(Eat());
        }

        protected override void HandleInteractionEnded(Collider collider)
        {
            base.HandleInteractionEnded(collider);
        }

        private IEnumerator Eat()
        {
            if (_player != null)
            {
                if (currentFood < maxFoodValue && !_player.IsFoodInventoryEmpty())
                {
                    IncreaseFood(_player.feedFoodValue);
                    _player.DecreaseFood();
                }

                if (currentWater < maxWaterValue && !_player.IsWaterInventoryEmpty())
                {
                    IncreaseWater(_player.feedWaterValue);
                    _player.DecreaseWater();
                }
            }
            
            yield return new WaitForSeconds(eatSpeed);
        }

        private void IncreaseFood(int eatValue)
        {
            if (currentFood < maxFoodValue)
            {
                currentFood += eatValue;
                currentFood = currentFood > maxFoodValue ? maxFoodValue : currentFood;
                foodBar.SetValue(currentFood);
            }
        } 
        
        private void IncreaseWater(int drinkValue)
        {
            if (currentWater < maxWaterValue)
            {
                currentWater += drinkValue;
                currentWater = currentWater > maxFoodValue ? maxFoodValue : currentWater;
                waterBar.SetValue(currentWater);
            }
        }
    }
}
