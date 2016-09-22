using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameController : MonoBehaviour {
    public bool gameOn = false;
    public Text score;
    public Canvas Button;
    float timer = 0;
    // Use this for initialization
    public void buttonPressed()
    {
        gameOn = true;
        timer = 0;
    }
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (gameOn) { timer += Time.deltaTime; }
        Button.enabled = !gameOn;
        score.text = "Score: " + Mathf.Round(timer * 10) / 10f + "s";
	}
}
