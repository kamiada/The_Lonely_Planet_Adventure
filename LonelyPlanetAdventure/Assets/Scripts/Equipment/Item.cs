using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour {

	public int Id; 
	private GameObject player1; 
	private GameObject player2; 
	//private Equipment_Manager equipment = new Equipment_Manager();
	public GameObject equipment_mang;

	void Start ()
	{
		player1 = GameObject.FindGameObjectWithTag ("Player1");
		player2 = GameObject.FindGameObjectWithTag ("Player2");	
		equipment_mang = GameObject.FindGameObjectWithTag ("Equipment_Manager");
	}

	void Update ()
	{
        //p1
		if (Input.GetKey (KeyCode.E) && gameObject.GetComponent<BoxCollider2D> ().IsTouching (player1.GetComponent<BoxCollider2D> ()) == true) 
		{
			gameObject.SetActive (false);
			equipment_mang.GetComponent<Equipment_Manager> ().test ();
			Debug.Log ("Player 1 got the test object");
		}
        //p2
		if (Input.GetKey (KeyCode.E) && gameObject.GetComponent<BoxCollider2D> ().IsTouching (player2.GetComponent<BoxCollider2D> ()) == true) 
		{
			gameObject.SetActive (false);
            equipment_mang.GetComponent<Equipment_Manager>().test();
            Debug.Log("Player 2 got the test object");

        }
    }
		
}
