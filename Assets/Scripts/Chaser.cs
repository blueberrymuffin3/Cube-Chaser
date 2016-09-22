using UnityEngine;
using System.Collections;

public class Chaser : MonoBehaviour {
    public GameController gameController;
    public Transform target;
    public float speed;
    // Update is called once per frame
	void Update () {
        if (gameController.gameOn)
        {
            Vector3 delta = target.position - transform.position;
            Vector3 direction = delta.normalized;
            if (delta.magnitude > 1)
            {
                transform.Translate(direction * Time.deltaTime * speed);
            }
            else
            {
                target.position = Vector3.zero;
                transform.position = new Vector3(-7, 0, 4);
                gameController.gameOn = false;
            }
        }
    }
}
