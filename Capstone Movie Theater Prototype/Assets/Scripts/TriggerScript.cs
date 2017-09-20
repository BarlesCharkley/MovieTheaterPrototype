using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerScript : MonoBehaviour {

    // Use this for initialization
    [SerializeField]
    AudioSource audioSource;
    [SerializeField]
    GameObject particleSystem;

    //GameObject game
    //   public GameObject;
    void Start()
    {

    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            particleSystem.SetActive(false);
            audioSource.Stop();
        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            particleSystem.SetActive(true);
            audioSource.Play();

        }
    }
}
