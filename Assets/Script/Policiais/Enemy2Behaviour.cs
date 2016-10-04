using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Enemy2Behaviour : MonoBehaviour
{
    public GameObject player;
    Quaternion rotation;
    public bool followingPlayer;
	Transform my;
	Rigidbody2D body;
    float time;

	void Start()
	{
		my = this.GetComponent<Transform> ();
		body = this.GetComponent<Rigidbody2D> ();
	}
    //Comportamento do segundo policial
	void FixedUpdate ()
    {
        if(followingPlayer)
        {
			Vector2 posiplayer = player.transform.position;
			float AngleRad = Mathf.Atan2(-posiplayer.x + my.position.x, posiplayer.y - my.position.y);
			float angle = (180 / Mathf.PI) * AngleRad;
			this.body.rotation = angle;
			this.transform.position = Vector3.MoveTowards(this.transform.position, player.transform.position, 0.2f);
        }
        else
        {
            time += Time.deltaTime;
            if (time > 10)
            {
                this.transform.rotation = Quaternion.Euler(this.transform.eulerAngles + new Vector3(0f, 0f, 180f));
                time = 0;
            }
        }   
	}

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Player" && followingPlayer)
        {
            Application.LoadLevel("MainScene");
        }
    }

    void OnTriggerStay2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player" && !followingPlayer && Input.GetKey(KeyCode.Return))
        {
            player.GetComponent<PlayerBehaviour>().copClothes();
			player.GetComponent<PlayerBehaviour>().gotCopClothes = true;
        }
    }
}
