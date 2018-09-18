using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CatStats : MonoBehaviour
{

	public int Score = 100;
	public int Life = 9;
	public int Age = 92;

	public float Health = 5.5f;
	public float CatPower = 9.9f;

	public Vector3 Movement;
 
	public Color CatColor = Color.blue;

	public Animation Anims;

	public UnityEvent Event;
}
