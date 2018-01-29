using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Dialogue_Manager : MonoBehaviour {

	public GameObject dialogBox; 
	public Text dialogText;

	public bool dialogActive; 

	public string[] dialogsLines;
	public int CurrentLine;

	void Start () {

	}
	//void TaskOnClick()
	//{
	//	if (dialogActive) 
	//	{
			//dialogBox.SetActive (false);
			//dialogActive = false;
	//	}
	//	Debug.Log("You have clicked the button!");
	//}
	void Update()
	{
		if (dialogActive && Input.GetKeyDown (KeyCode.E)) 
		{
			CurrentLine++;
		}
		if (CurrentLine >= dialogsLines.Length) 
		{
			dialogBox.SetActive (false);
			dialogActive = false;
			CurrentLine = 0;
		}

		dialogText.text = dialogsLines [CurrentLine];
	}

	public void ShowBox(string dialog)
	{
		dialogActive = true;
		dialogBox.SetActive (true);
		dialogText.text = dialog;
	}

	public void ShowDialog()
	{
		dialogActive = true;
		dialogBox.SetActive (true);

	}
}
