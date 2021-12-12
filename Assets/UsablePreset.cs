using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets
{
    [CreateAssetMenu(fileName = "Preset", menuName = "ScriptableObjects/UsablePreset")]
    public class UsablePreset : ScriptableObject
    {
        private enum Type
        {
            Animal,
            Source
        }

        [SerializeField]
        private Type _presetType;
        [SerializeField]
        private Material _material;
        [SerializeField]
        private Mesh _mesh;
    }
}
