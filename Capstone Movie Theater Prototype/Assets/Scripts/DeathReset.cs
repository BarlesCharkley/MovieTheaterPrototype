using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathReset : MonoBehaviour
{

	void Start ()
	{
		
	}
	
	void Update ()
	{
		
	}

	void OnTriggerEnter ()
	{
		SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex);
	}
}
