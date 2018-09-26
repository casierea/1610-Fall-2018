using UnityEngine;


    [CreateAssetMenu]
    public abstract class FloatData : ScriptableObject
    {
        public abstract float Value { get; }
    }
