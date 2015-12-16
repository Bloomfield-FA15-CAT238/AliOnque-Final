using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Menu : MonoBehaviour {
	private Text player;
	
	public void Start()
	{
		if(Application.loadedLevelName.Equals("StartScreen"))
			player = GameObject.Find ("InputField").GetComponentInChildren<Text> ();
	}
	
	public void iBeenClickedBoss()
	{
		//put a damn name in...
		if (!player.text.Equals("")) {
			PlayerPrefs.SetString ("player", player.text);
			
			Application.LoadLevel (Application.loadedLevel + 1);
		}
	}

	public void BeamMeUpScotty()
	{
		if (GameObject.FindWithTag ("GameController") != null) {
			Destroy(GameObject.FindWithTag ("GameController"));
		}
		Application.LoadLevel("StartScreen");
	}
}
