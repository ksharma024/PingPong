using UnityEngine;
using System.Collections;

public class RightCapsule : MonoBehaviour {

    public enum ePlayer
    {
        Left,
        Right
    }

    public float speed = 15f;
    public ePlayer player;

    // Update is called once per frame
    void Update()
    {

        float inputSpeed = 0f;
        if (player == ePlayer.Left)
        {
            inputSpeed = Input.GetAxisRaw("LeftCapsule");
        }

        else if (player == ePlayer.Right)
        {
            inputSpeed = Input.GetAxisRaw("RightCapsule");
             }

        transform.position += new Vector3(0f, 0f, inputSpeed * speed * Time.deltaTime);
	}
}
