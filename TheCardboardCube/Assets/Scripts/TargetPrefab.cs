using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetPrefab : MonoBehaviour {

    private float timeLeft;
    private Color targetColor;

    void Start()
    {
        if (transform.position.y <= 0) {
            Vector3 oldPosition = transform.position;
            transform.position = new Vector3(oldPosition.x, Mathf.Abs(oldPosition.y), oldPosition.z);
        }   
    }

    // Update is called once per frame
    void Update()
    {
        UpdateColor();
    }

    private void UpdateColor() {
        if (timeLeft <= Time.deltaTime) {
            GetComponent<Renderer>().material.color = targetColor;
            targetColor = new Color(Random.value, Random.value, Random.value);
            timeLeft = 1.0f;
        } else {
            GetComponent<Renderer>().material.color = Color.Lerp(GetComponent<Renderer>().material.color, targetColor, Time.deltaTime / timeLeft);
            timeLeft -= Time.deltaTime;
        }
    }

    private void OnCollisionEnter(Collision collision) {
        if (collision.gameObject.tag == "Ball") {
            Destroy(this.gameObject);
            GameManager.score += 1;
        }
    }
}
