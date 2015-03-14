using UnityEngine;
using System.Collections;

public class MusicScript : MonoBehaviour {

	public GameObject music;

	void Start () {

	}
	

	void OnTriggerEnter(Collider other)
	{
		if(other.gameObject.tag == "Player") 
		{
			music.audio.Play();
		}
		
	}
}

