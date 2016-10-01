using UnityEngine;
using System.Collections;

public class Enemy2Behaviour : MonoBehaviour
{
    public GameObject player;
    public bool followingPlayer;
    float time;
	void Start ()
    {
	    
	}
    //Comportamento do segundo policial
	void Update ()
    {
        if(followingPlayer)
        {
            this.transform.position = Vector3.MoveTowards(this.transform.position, player.transform.position, 0.1f);
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
        if (col.gameObject.tag == "Player")
        {
            Application.LoadLevel("MainScene");
        }
    }
}
