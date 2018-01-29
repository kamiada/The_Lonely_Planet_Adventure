using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Equipment_Manager : MonoBehaviour {
	
	public Image icon1;
	// Use this for initialization
	void Start () 
	{
        //icon1 = GameObject.FindGameObjectWithTag ("Image1");
        icon1.gameObject.SetActive(false);
	}
	void Update ()
	{
		
	}

	public void test()
	{
        //icon1.SetActive (true);
        //icon1.enabled = true;
        icon1.gameObject.SetActive(true);
		Debug.Log ("Ikona dziala");
	}
}
