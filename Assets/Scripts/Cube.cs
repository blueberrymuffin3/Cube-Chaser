using UnityEngine;
using System.Collections;
using UnityStandardAssets.CrossPlatformInput;

public class Cube : MonoBehaviour {
    public GameController gameController;
    public float speed;
    public Transform visible;
	// Update is called once per frame
	void Update () {
        if (gameController.gameOn)
        {
            //motion
            Vector3 input = new Vector3(CrossPlatformInputManager.GetAxisRaw("Horizontal"), 0, CrossPlatformInputManager.GetAxisRaw("Vertical"));
            input = input.normalized * Mathf.Clamp01(input.magnitude);
            Vector3 motion = input * speed * Time.deltaTime;
            transform.Translate(motion);
            Vector3 pos = transform.position;
            pos.x = Mathf.Clamp(pos.x, -12, 12);
            pos.z = Mathf.Clamp(pos.z, -6, 6);
            transform.position = pos;

            //rotation
            if (input != Vector3.zero)
            {
                Quaternion rot = Quaternion.LookRotation(input);
                visible.rotation = rot;
            }
        }
    }
}
