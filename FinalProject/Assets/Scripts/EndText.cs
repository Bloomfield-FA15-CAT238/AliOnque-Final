using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class EndText : MonoBehaviour {

	private GameController gc;
	private Text results;
	
	void Start () {
		results = this.GetComponent<Text> ();
		gc = GameObject.Find ("GameController").GetComponent<GameController> ();
		results.text = (gc.ps.player + "\nLives: " + gc.ps.lives + "\nScore: " + gc.ps.score + "\ntime: " + (int)gc.ps.time);
	}

	void Update () {

	}
}
