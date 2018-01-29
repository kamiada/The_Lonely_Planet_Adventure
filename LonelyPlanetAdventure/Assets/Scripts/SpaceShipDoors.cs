using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceShipDoors : MonoBehaviour {

	public GameObject player;
	public GameObject riddle;
	public Movement mvm;
	public GameObject obstacle;
	// Use this for initialization
	void Start () 
	{
		mvm = GetComponent<Movement> ();
		player = GameObject.FindGameObjectWithTag ("Player1");
		obstacle = GameObject.FindGameObjectWithTag ("horizontal border");
	}
	
	// Update is called once per frame
	void Update () 
	{


	}

	void OnTriggerStay2D(Collider2D player)
	{
		if (Input.GetKeyUp (KeyCode.E) && player)
		{
			riddle.SetActive (true);
			Debug.Log ("Works");
			player.GetComponent<Movement> ().enabled = false;
			//mvm.enabled = false;
			obstacle.SetActive (false);
		}
	}
}
