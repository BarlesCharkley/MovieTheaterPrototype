using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextScene : MonoBehaviour
{
	public KeyCode transitionButton;

	void Start ()
	{
		
	}
	
	void Update ()
	{
		if (Input.GetKeyDown(transitionButton))
		{
			SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
		}
	}
}
