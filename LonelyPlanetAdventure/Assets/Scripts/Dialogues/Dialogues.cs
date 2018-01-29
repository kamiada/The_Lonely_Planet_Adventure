using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dialogues : MonoBehaviour {

	public bool Answer1;
	public bool Answer2;
	public int QuestionList1;
	public int QuestionList2;
	public List<string> Replies1 = new List<string>();
	public List<string> Replies2 = new List<string>();
	public List<string> Dialogue1 = new List<string>();
	public List<string> Dialogue2 = new List<string>();
	public GameObject AskingCanvas; 


	public void EndDialogue()
	{
		Debug.Log ("Ending");
	}

	public void Update()
	{
		if (Input.GetKey(KeyCode.Space)) {
			AskingCanvas.SetActive(true);
			AskQuestion ();
		}

		if (Answer2 == true && QuestionList2 == 1) {
			EndDialogue ();
		}
		if (Answer2 == true && QuestionList2 == 2) {
			EndDialogue ();
		}
		if (Answer1 == true && QuestionList2 == 3) {
			EndDialogue ();
		}
			
	}


	public void AskQuestion()
	{
		if (Answer1) {
			GameObject.Find ("TextDialogue").GetComponent<Text> ().text = Dialogue1 [QuestionList1];
			GameObject.Find ("TextAns1").GetComponent<Text> ().text = Replies1 [QuestionList2];
			GameObject.Find ("TextAns2").GetComponent<Text> ().text = Replies2 [QuestionList2];
		}
		if (Answer2) {
			GameObject.Find ("TextDialogue").GetComponent<Text> ().text = Dialogue1 [QuestionList2];
			GameObject.Find ("TextAns1").GetComponent<Text> ().text = Replies1 [QuestionList2];
			GameObject.Find ("TextAns2").GetComponent<Text> ().text = Replies2 [QuestionList2];
		}
	}


	public void Reply1()
	{
		QuestionList1 += 1;
		QuestionList2 += 1; 
		Answer2 = false;
		Answer1 = true;
		AskQuestion ();
	}

	public void Reply2()
	{
		QuestionList1 += 1;
		QuestionList2 += 1; 
		Answer2 = true;
		Answer1 = false;
		AskQuestion ();
	}
}
