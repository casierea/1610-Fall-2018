using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

	[CreateAssetMenu(fileName = "FloatInput")]
	
	public class FloatInput : FloatData
	{
		public string InputType;

		public float Value
		{
			get return Input.GetAxis(InputType);
		}
}
