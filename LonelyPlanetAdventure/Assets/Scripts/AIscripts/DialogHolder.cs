using UnityEngine;
using System.Collections;

public class DialogHolder : MonoBehaviour {


	public string dialogue; 
	private Dialogue_Manager dManager;
	public string[] dialogueLines;
	private GameObject player2;

	private GameObject mvm1;
	private GameObject mvm2;

	private GameObject rndDialogs1;
	private GameObject rndDialogs2;

	public string [] dLines;

	bool inTrigger = false;

	// Use this for initialization
	void Start () {
		dManager = FindObjectOfType<Dialogue_Manager> ();
		//player = FindObjectOfType
		player2 = GameObject.FindGameObjectWithTag("Player2");

		mvm1 = GameObject.FindGameObjectWithTag("Player1");
		mvm2 = GameObject.FindGameObjectWithTag ("Player2");

		rndDialogs1 = GameObject.FindGameObjectWithTag("rndText");
		rndDialogs2 = GameObject.FindGameObjectWithTag ("rndText2");



	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerStay2D(Collider2D other)
	{
        //when player 1 is active
        if (Input.GetKey(KeyCode.E) && rndDialogs1.GetComponent<BoxCollider2D>().IsTouching(rndDialogs2.GetComponent<BoxCollider2D>()) == true
            && mvm2.GetComponent<MovementControl2>().enabled == false)
        {
            dManager.ShowBox(dialogue);
        }



        //when player 2 is active
        if (Input.GetKey (KeyCode.E) && rndDialogs2.GetComponent<BoxCollider2D> ().IsTouching (rndDialogs1.GetComponent<BoxCollider2D> ()) == true
			&& mvm1.GetComponent<Movement>().enabled == false && inTrigger)
		{
				//dManager.ShowBox(dialogue);	

			if (!dManager.dialogActive)
			{
				dManager.dialogsLines = dLines;
				dManager.CurrentLine = 0;
				dManager.ShowDialog ();
			}
		}
	}
}
