using UnityEngine;
using System.Collections;

public class EnemyBehaviour3 : MonoBehaviour
{
    public GameObject player;
    public bool followingPlayer;
    Quaternion rotation;
    Transform my;
    Rigidbody2D body;

    void Start()
    {
        my = this.GetComponent<Transform>();
        body = this.GetComponent<Rigidbody2D>();
    }
	void FixedUpdate ()
    {
		if (followingPlayer)
        {
            Vector2 posiplayer = player.transform.position;
            float AngleRad = Mathf.Atan2(-posiplayer.x + my.position.x, posiplayer.y - my.position.y);
            float angle = (180 / Mathf.PI) * AngleRad;
            this.body.rotation = angle;
            this.transform.position = Vector3.MoveTowards(this.transform.position, player.transform.position, 0.2f);
        }
    }

    void OnCollisionStay2D(Collision2D col)
    {
        if (col.gameObject.tag == "Player" && followingPlayer)
        {
            Application.LoadLevel("MainScene");
        }
    }
}
