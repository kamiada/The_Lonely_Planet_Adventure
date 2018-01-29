using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomTexts : MonoBehaviour {

	// Use this for initialization
	private GameObject rndDialogs1;
	private GameObject rndDialogs2;

	private GameObject mvm1;
	private GameObject mvm2;

	//private GameObject dialogWindow;
	//private GameObject dialogWindow2;



	//player1 random texts
	public GameObject dW1;
	public GameObject dW2;
	public GameObject dW3; 
	private GameObject dW4;


	//player2 random texts
	private GameObject dWp1;
	private GameObject dWp2;
	private GameObject dWp3;
	private GameObject dWp4;


	private GameObject[] ArrPlayer1 = new GameObject[3];

	void Start () 
	{
		rndDialogs1 = GameObject.FindGameObjectWithTag("rndText");
		rndDialogs2 = GameObject.FindGameObjectWithTag ("rndText2");

		mvm1 = GameObject.FindGameObjectWithTag("Player1");
		mvm2 = GameObject.FindGameObjectWithTag ("Player2");

		dW1 = GameObject.FindGameObjectWithTag("dW1");
		dW2 = GameObject.FindGameObjectWithTag ("dW2");
		dW3 = GameObject.FindGameObjectWithTag ("dW3");

		ArrPlayer1 [0] = dW1;
		ArrPlayer1 [1] = dW2;
		ArrPlayer1 [2] = dW3;

		//player1


		//dialogWindow = GameObject.FindGameObjectWithTag ("dialogWindowEmpty");


	}
	
	// Update is called once per frame
	void Update () 
	{
		//when player 1 is active
		if(Input.GetKey(KeyCode.E) && rndDialogs1.GetComponent<BoxCollider2D>().IsTouching(rndDialogs2.GetComponent<BoxCollider2D>()) == true 
			&& mvm2.GetComponent<MovementControl2> ().enabled == false)
		{
			//dialogWindow2.SetActive (true);
		}

		//when player 2 is active
		if (Input.GetKey (KeyCode.E) && rndDialogs2.GetComponent<BoxCollider2D> ().IsTouching (rndDialogs1.GetComponent<BoxCollider2D> ()) == true
			&& mvm1.GetComponent<Movement>().enabled == false) 
		{
			//dW1.SetActive(true);
			foreach (var i in ArrPlayer1)
			{
				//ArrPlayer1[1].SetActive (true);
			}
		}
	}
}
