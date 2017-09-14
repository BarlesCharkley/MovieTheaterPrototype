using UnityEngine;
using System.Collections;

public class OrbitScript : MonoBehaviour {

	public float XDPS = 0F;
	public float YDPS = 0.05F;
	public float ZDPS = 0F;

	// Use this for initialization
	void Start ()
	{
	
	}
	
	// Update is called once per frame
	void Update ()
	{
		transform.Rotate (XDPS, YDPS, ZDPS * Time.deltaTime);
	}
}
