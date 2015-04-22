using UnityEngine;
using System.Collections;

public class Score : MonoBehaviour {

	void OnEnable() {
		Messenger.AddListener<PlayerNumbers>("Goal", OnGoal);
	}

	void OnDisable() {
		Messenger.RemoveListener<PlayerNumbers>("Goal",OnGoal);
	}

	void OnGoal(PlayerNumbers player) {

		switch(player){
			case PlayerNumbers.One: 
				Debug.Log ("Player 1 Scored");
				break;
			case PlayerNumbers.Two: 
			Debug.Log ("Player 2 Scored");
				break;
		}

	}
	
}