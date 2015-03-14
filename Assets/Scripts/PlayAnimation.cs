using UnityEngine;
using System.Collections;

public class PlayAnimation : MonoBehaviour {

	public GameObject nazi;
	public GameObject nazi2;
	public GameObject nazi3;
	public GameObject nazi4;
	public GameObject nazi5;
	public GameObject nazi6;
	public GameObject nazi7;
	public GameObject nazi8;


	void Start () {
		
	}
	
	
	void OnTriggerEnter(Collider other)
	{
		if(other.gameObject.tag == "Player") 
		{
			nazi.animation.Play();
			nazi2.animation.Play();
			nazi3.animation.Play();
			nazi4.animation.Play();
			nazi5.animation.Play();
			nazi6.animation.Play();
			nazi7.animation.Play();
			nazi8.animation.Play();
			
			
		}
		
	}
}

