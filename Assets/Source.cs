using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets
{
    public enum SourceType
    {
        Food = 0,
        Water = 1
    }
    public class Source : Usable
    {
        private Player _player = null;
        
        public int fillSpeed = 1;

        public SourceType sourceType = SourceType.Food;

        protected override void HandleInteractionStarted(Collider collider)
        {
            base.HandleInteractionStarted(collider);

            collider.gameObject.TryGetComponent<Player>(out _player);
            StartCoroutine(FillResource());
        }

        protected override void HandleInteractionEnded(Collider collider)
        {
            base.HandleInteractionEnded(collider);

            if (_player != null)
                _player = null;
        }
        
        private IEnumerator FillResource()
        {
            if (_player != null)
            {
                switch (sourceType)
                {
                    case SourceType.Food:
                        if (!_player.IsFoodInventoryFull())
                            _player.IncreaseFood();
                        break;
                    
                    case SourceType.Water:
                        if (!_player.IsWaterInventoryFull())
                            _player.IncreaseWater();
                        break;
                }
            }
            
            yield return new WaitForSeconds(fillSpeed);
        }
    }
}
