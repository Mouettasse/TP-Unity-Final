using UnityEngine;
using System.Collections;


public class TriggerTorch : MonoBehaviour{

public GameObject point_light;
public GameObject particule;
public GameObject sound1;



void Start()
{
	point_light.SetActive(false); 
	particule.SetActive(false);
	
}


void OnTriggerEnter(Collider other)
{
	if(other.gameObject.tag == "Player") 
	{
		point_light.SetActive(true);
		particule.SetActive(true);
		sound1.audio.Play();
		Destroy(gameObject);
	}
	
}
}