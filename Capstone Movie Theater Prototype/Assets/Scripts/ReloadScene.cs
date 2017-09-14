using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReloadScene : MonoBehaviour
{
	public KeyCode ReloadButton;

	void Start ()
	{
		
	}
	
	void Update ()
	{
		if (Input.GetKeyDown(ReloadButton))
		{
			SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex);
		}
	}
}
