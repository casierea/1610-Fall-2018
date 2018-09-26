<<<<<<< HEAD:Practice Project/Assets/MouseEventBehaviour.cs
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

=======
﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cat : MonoBehaviour {

	// Use this for initialization
	void Start ()
	{
		print("I am a cat. Meow.");
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
>>>>>>> master:1610FALL2018/Assets/Scenes/New Unity Project/Assets/Cat.cs
