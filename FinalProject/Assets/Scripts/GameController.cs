using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
	//So i Know if im me or not
	public static GameController gc;
	//Cereal Eyes
	public PlayerStats ps;
	//FOR THE DAMN HUD
	private Text hudStuff;

	private GameObject player;

	void Awake ()
	{//MustMakeGCStatic
		if (gc == null) {
			DontDestroyOnLoad (gameObject);
			gc = this;
			ps = GetComponentInParent<PlayerStats>();
		} else if (gc != this) {
			Destroy (gameObject);

		}

	}

	// Use this for initialization
	void Start ()
	{

		ps.time = 0.0f;
		ps.lvl = Application.loadedLevel;
		if(PlayerPrefs.HasKey("player"))
			ps.player = PlayerPrefs.GetString("player");
		else
		   ps.player = "StockName";
		ps.score = 0;
		ps.lives = 3;


	}
	
	// Update is called once per frame
	void Update ()
	{
		if (Application.loadedLevelName.Contains ("Playable")) {
			if (hudStuff == null)
				hudStuff = GameObject.Find("HUD").GetComponent<Text>();
			ps.time += Time.deltaTime;
			hudStuff.text = (ps.player + "\nLives: " + ps.lives + "\nScore: " + ps.score + "\ntime: " + (int)ps.time);
		}
	}

 	public void nextLvl()
	{
		ps.lvl++;
		Application.LoadLevel (ps.lvl);
	}

	public void lastLvl()
	{	ps.lvl--;
		Application.LoadLevel (ps.lvl);
	}

	public void endGame()
	{
		Application.LoadLevel ("EndScreen");
	}

	/*
	public void introScreen()
	{
		Application.LoadLevel ("Intro");
	}*/

	public void deads(Vector3 spawn)
	{
		if (ps.lives < 1) {
			endGame ();
		} else {
			if (player == null) {
				player = GameObject.FindWithTag ("Player");
			}
			player.transform.position = spawn;
			ps.lives--;
		}
	}

	public void deads()
	{
		if (ps.lives < 1) {
			endGame ();
		} else {
			if (player == null) {
				player = GameObject.FindWithTag ("Player");
			}
			player.transform.position = GameObject.FindWithTag ("SpawnPoint").transform.position;
			ps.lives--;
		}
	}

	public void grabbed(){
		ps.score += 100;
	}

	public void win()
	{
		endGame ();
	}
}
