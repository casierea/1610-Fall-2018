﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class MouseEventBehaviour : MonoBehaviour
{

	public UnityEvent MouseDown;
	public UnityEvent MouseUp;
	void OnMouseDown()
	{
		MouseDown.Invoke();
	}

	private void OnMouseUp()
	{
		MouseUp.Invoke;
	}
}

