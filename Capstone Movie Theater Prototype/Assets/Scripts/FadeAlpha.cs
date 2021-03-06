using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeAlpha : MonoBehaviour
{
	Renderer render;
	public float fadeTime;
	public float fadeDelay;

	public Color materialColor1;
	public Color materialColor2;

	bool isFading;

	public KeyCode fadeButton;
	public bool automatic;

	void Start ()
	{
		render = gameObject.GetComponent<Renderer> ();

		render.material.color = materialColor1;

		if (automatic == true)
		{
			Invoke ("BeginFade", fadeDelay);	
		}
	}

	void Update ()
	{
		if (Input.GetKeyDown(fadeButton) && automatic == false)
		{
			BeginFade ();
		}
	}

	void BeginFade ()
	{
		isFading = true;
	}

	void Fade ()
	{
		if (isFading == true)
		{
			render.material.color = Color.Lerp (render.material.color, materialColor2, Time.fixedDeltaTime / fadeTime);
		}
	}

	void FixedUpdate ()
	{
		Fade ();
	}

}
