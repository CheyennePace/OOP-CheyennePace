using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ButtonManager : MonoBehaviour
{
	//	public Button yourButton;
	Button btn;
	void Start()
	{
		//	Button btn = yourButton.GetComponent<Button>();
		btn = GetComponent<Button>();
		btn.onClick.AddListener(TaskOnClick);
	}

	void TaskOnClick()
	{
		GameManager mygamemanager = FindObjectOfType<GameManager>();
		if (this.gameObject.name == "RestartButton")
        {
			GameData.Score = 0;
			Destroy(mygamemanager.gameObject);
			mygamemanager.ChangeScene("Game");
		}			
			
		if (this.gameObject.name == "Exit") mygamemanager.QuitGame();
		Debug.Log("You have clicked the button!");
	}
}
