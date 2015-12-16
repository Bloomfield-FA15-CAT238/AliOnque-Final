using UnityEngine;
using System.Collections;

public class Door : MonoBehaviour {
	private GameController gc;
	
	public void Start()
	{
		gc = GameObject.FindWithTag ("GameController").GetComponent<GameController>();
	}
	
	public void OnTriggerEnter(Collider other)
	{
		if (other.tag == "Player") {
			gc.nextLvl();
		}
		
	}
}
