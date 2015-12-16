using UnityEngine;
using System.Collections;

public class AI : MonoBehaviour {

	private GameObject target;
	private NavMeshAgent agent;
	private Transform dest;

	// Use this for initialization
	void Start () {
		target = GameObject.FindGameObjectWithTag ("Player");
		agent = GetComponent<NavMeshAgent> ();
		dest = target.transform;
	}

	
	// Update is called once per frame
	void Update () {
		agent.SetDestination (dest.position);

	}
}
