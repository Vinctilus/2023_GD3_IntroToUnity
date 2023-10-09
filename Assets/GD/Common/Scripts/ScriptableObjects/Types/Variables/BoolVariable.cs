﻿using UnityEngine;

namespace GD
{
    [CreateAssetMenu(fileName = "BoolVariable", menuName = "DkIT/Scriptable Objects/Variables/Bool")]
    public class BoolVariable : ScriptableDataType<bool>
    {
        public void Set(BoolVariable a)
        {
            Set(a.Value);
        }

        public bool Equals(BoolVariable other)
        {
            return Value.Equals(other.Value);
        }
    }
}