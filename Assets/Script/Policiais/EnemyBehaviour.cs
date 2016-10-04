using UnityEngine;
using System.Collections;

public class EnemyBehaviour : MonoBehaviour
{
    public GameObject player;
    public Transform[] enemyPositions;
    public bool followingPlayer = false;
    Transform actualEnemyPosition;
    Transform goingToPosition;
    Transform my;
    Rigidbody2D body;
    Quaternion rotation;
    int counter;
    [HideInInspector] public bool canSeePlayer;

    void Start()
    {
        my = this.GetComponent<Transform>();
        body = this.GetComponent<Rigidbody2D>();
        actualEnemyPosition = enemyPositions[0];
        goingToPosition = enemyPositions[1];
        counter = 2;
	}

	void FixedUpdate ()
    {
        //Movimentacão do policial
        if (!followingPlayer)
        {
			this.GetComponent<Animator>().SetBool("IsWalking", true);
			this.transform.position = Vector3.MoveTowards(this.transform.position, goingToPosition.position, 0.1f);
            this.transform.rotation = goingToPosition.rotation;
            if (this.transform.position == goingToPosition.position)
            {
                actualEnemyPosition = goingToPosition;
                goingToPosition = enemyPositions[counter];
                if (counter >= enemyPositions.Length - 1)
                {
                    counter = 0;
                }
                else
                {
                    counter++;
                }
            }
        }
        //Fazer o policial seguir o jogador
        else if(followingPlayer && canSeePlayer)
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
        if(col.gameObject.tag == "Player")
        {
            if (followingPlayer)
            {
                Application.LoadLevel("MainScene");
            }
        }
    }
}
