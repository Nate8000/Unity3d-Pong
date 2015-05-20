using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ScoreText : MonoBehaviour {

	public PlayerNumbers playerNumber;
	private Text text; 
	public int score;

	void OnEnable() {
		Messenger.AddListener<PlayerNumbers>("Goal", onGoal);
		text = GetComponent<Text>();
		updateScoreText();

	}

	void OnDisable(){
		Messenger.RemoveListener<PlayerNumbers>("Goal", onGoal);
	}

	void onGoal(PlayerNumbers playerNum){
		if( this.playerNumber == playerNum) {
			score++;
			updateScoreText();
		}
	}
	void updateScoreText(){
		text.text = score.ToString();
	}



}
