using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.SceneManagement;

public class Switch : MonoBehaviour {

	public GameObject player1;
	public GameObject player2;


	void Start () 
	{
		player1 = GameObject.FindGameObjectWithTag("Player1");
		player2 = GameObject.FindGameObjectWithTag ("Player2");

		player2.GetComponent<MovementControl2> ().enabled = false;
	}
		
	void Update () 
	{

		if (Input.GetKey(KeyCode.Alpha1)) 
		{
			if (player1.GetComponent<Movement> ().enabled == true) 
			{
				player2.GetComponent<MovementControl2> ().enabled = false;
			}
			if (player1.GetComponent<Movement> ().enabled == false)
			{
				player1.GetComponent<Movement> ().enabled = true;
				player2.GetComponent<MovementControl2> ().enabled = false;
			}
		}

		if (Input.GetKey (KeyCode.Alpha2) && player2.GetComponent<MovementControl2> ().enabled == false) 
		{
			player2.GetComponent<MovementControl2> ().enabled = true;
			player1.GetComponent<Movement> ().enabled = false;
		}
			
	}
}
