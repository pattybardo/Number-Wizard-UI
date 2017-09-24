using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class NumberWizard : MonoBehaviour {

	
	int max;
	int min;
	int guess;

	public Text text;

	public int maxGuessesAllowed;
	// Use this for initialization
	void Start () {
		StartGame();
	}
	
	void StartGame() {
		max = 1001;
		min = 0;
		NextGuess();

	}

	public void GuessHigher () {
		min = guess;
		NextGuess();
	}

	public void GuessLower (){
		max = guess;
		NextGuess();
	}
	
	void NextGuess ()
	{
		guess = Random.Range(min+1, max);
		maxGuessesAllowed = maxGuessesAllowed - 1;
		if (maxGuessesAllowed <= 0) {
			SceneManager.LoadScene("Win");
		}
		text.text = guess.ToString();
	}



}
