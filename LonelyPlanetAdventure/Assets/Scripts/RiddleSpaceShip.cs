using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RiddleSpaceShip : MonoBehaviour {
	
	public GameObject numb1;
	public string test; 
	void Start ()
	{


	}

	void Update ()
	{
		if (Input.GetMouseButtonDown (0)) 
		{
			//somehow cannot hit this if its on top of other objects
			CastRay();
		}
	}
	void CastRay()
	{
		Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
		RaycastHit2D hit = Physics2D.Raycast (ray.origin, ray.direction, Mathf.Infinity);
		if (hit)
		{
			Debug.Log ("iT HIT" + hit.collider.gameObject.name);
		}
	}
}
