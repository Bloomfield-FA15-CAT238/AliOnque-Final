using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MenuScreen : MonoBehaviour {
	private Text player;
	
	public void Start()
	{
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
}
