using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Enemy2Behaviour : MonoBehaviour
{
    public GameObject player;
    Quaternion rotation;
    public bool followingPlayer;
    float time;

    //Comportamento do segundo policial
	void Update ()
    {
        if(followingPlayer)
        {
			this.transform.position = Vector3.MoveTowards(this.transform.position, player.transform.position, 0.1f);
            rotation = Quaternion.LookRotation(player.transform.position);
            rotation = new Quaternion(0f, 0f, rotation.z, rotation.w);
            this.transform.rotation = rotation;
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
