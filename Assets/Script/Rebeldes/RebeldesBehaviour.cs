using UnityEngine;
using System.Collections;

public class RebeldesBehaviour : MonoBehaviour
{
	public GameObject player;
	public bool followingPlayer;
	Quaternion rotation;
    [HideInInspector]
    public bool revolution;
    [HideInInspector]
    public bool revolution2;
    public Transform[] revolutionPositions;
    Transform my;
    Rigidbody2D body;
    [SerializeField]
    private AudioSource audio;

    void Awake()
    {
        my = this.GetComponent<Transform>();
        body = this.GetComponent<Rigidbody2D>();
    }
	//Fazedo os rebeldes seguirem
	void Update()
	{
		if (followingPlayer)
		{
			this.transform.position = Vector3.MoveTowards(this.transform.position, player.transform.position, 0.1f);
            Vector2 posiplayer = player.transform.position;
            float AngleRad = Mathf.Atan2(-posiplayer.x + my.position.x, posiplayer.y - my.position.y);
            float angle = (180 / Mathf.PI) * AngleRad;
            this.body.rotation = angle;
            this.transform.rotation = rotation;
		}
        if(revolution)
        {
            this.transform.position = Vector3.MoveTowards(this.transform.position, revolutionPositions[0].position, 0.1f);
            Vector2 posiplayer = revolutionPositions[0].position;
            float AngleRad = Mathf.Atan2(-posiplayer.x + my.position.x, posiplayer.y - my.position.y);
            float angle = (180 / Mathf.PI) * AngleRad;
            this.body.rotation = angle;
            this.GetComponent<Animator>().SetBool("IsWalking", true);
            audio.Play();
        }
        else if(revolution2)
        {

            this.transform.position = Vector3.MoveTowards(this.transform.position, revolutionPositions[1].position, 0.1f);
            Vector2 posiplayer = revolutionPositions[1].position;
            float AngleRad = Mathf.Atan2(-posiplayer.x + my.position.x, posiplayer.y - my.position.y);
            float angle = (180 / Mathf.PI) * AngleRad;
            this.body.rotation = angle;
            this.GetComponent<Animator>().SetBool("IsWalking", true);
        }
	}
	
	void OnCollisionEnter2D(Collision2D col)
	{
		if (col.gameObject.tag == "Player" && followingPlayer)
		{
			Application.LoadLevel("MainScene");
		}
	}
}
