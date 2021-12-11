using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets
{
    public class Source : Usable
    {
        private Player _player = null;

        protected override void HandleInteractionStarted(Collider collider)
        {
            base.HandleInteractionStarted(collider);

            collider.gameObject.TryGetComponent<Player>(out _player);
            if (_player == null)
                return;
        }

        protected override void HandleInteractionEnded(Collider collider)
        {
            base.HandleInteractionEnded(collider);

            if (_player != null)
                _player = null;
        }
    }
}
