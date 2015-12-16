using UnityEngine;
using System.Collections;

public class AI : MonoBehaviour 
{

	private GameController gc;
	private GameObject target;
	private NavMeshAgent agent;
	private Transform dest;

	// Use this for initialization
	void Start () {
		target = GameObject.FindGameObjectWithTag ("Player");
		agent = GetComponent<NavMeshAgent> ();
		dest = target.transform;
		gc = GameObject.FindGameObjectWithTag ("GameController").GetComponent<GameController> ();
	}

	
	// Update is called once per frame
	void Update () {
		if (gc.playing) {
			agent.SetDestination (dest.position);
		} else {
			agent.SetDestination(this.gameObject.GetComponent<Transform>().position);
		}

	}
}