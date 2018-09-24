
using UnityEngine;

[CreateAssetMenu]

public class AddValue : ScriptableObject
{


	public FloatData ValueObj;
	public FloatData MaxValue;
	public FlaotData MinValue;
	
	public UnityEvent EventMax;
	public UnityEvent EventMin;
	
	public void AddValueToObj(FloatData data)
	{
		ValueObj.Value += data.Value;
		
		if (ValueObj.Value <= MaxValue.Value)
		{
			EventMax.invoke();
		}

		if (MaxValue.Obj.Value <= MinValue.Value)
		{
			EventMin.invoke();
		}
	}
}
