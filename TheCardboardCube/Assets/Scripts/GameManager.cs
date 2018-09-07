using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

    public static int score = 0;
    public Text scoreText;
    public GameObject Object;

	// Use this for initialization
	void Start () {
        Instantiate(Object, Random.insideUnitSphere * 25f, Quaternion.identity);
	}
	
	// Update is called once per frame
	void Update () {
        scoreText.text = "Score: " + score;

        if (!GameObject.FindWithTag("Target")) {
            Instantiate(Object, Random.insideUnitSphere * 25f, Quaternion.identity);
        }
	}
}
