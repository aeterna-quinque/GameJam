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
