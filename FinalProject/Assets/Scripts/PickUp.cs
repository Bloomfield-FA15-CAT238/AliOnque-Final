using UnityEngine;
using System.Collections;

public class PickUp : MonoBehaviour {
	public GameController gameC;
	public float spd;
	// Use this for initialization
	void Start () {
		if (spd <= 0.0f) {
			spd = 40;
		}
		gameC = GameObject.FindWithTag ("GameController").GetComponent<GameController>();	
	}
	
	void OnTriggerEnter(Collider other)
	{
		gameC.grabbed ();
		Destroy (this.gameObject);
	}
	
	// Update is called once per frame
	void Update () {
		this.gameObject.transform.Rotate(new Vector3 (0.0f, 0.0f, 1.0f) * (spd * Time.deltaTime));
	}
}
