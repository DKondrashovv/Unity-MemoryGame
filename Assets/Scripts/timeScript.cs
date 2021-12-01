using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class timeScript : MonoBehaviour {

	public Text counterText;
	public bool timeCounter = true;
	public float seconds;

	
	void Start () {
		counterText = GetComponent<Text> () as Text;
	}
	

	void Update () {
		if (timeCounter) {
			seconds = (int)(Time.timeSinceLevelLoad % 60f);
			counterText.text = seconds.ToString ("00");
		}
		
	}

	public void endGame() {
		timeCounter = false;
		counterText.color = Color.red;
	}
}
