using UnityEngine;
using System.Collections;

public class EnemyBehaviour : MonoBehaviour
{
    public GameObject player;
    public Transform[] enemyPositions;
    public bool followingPlayer = false;
    Transform actualEnemyPosition;
    Transform goingToPosition;
    Quaternion rotation;
    int counter;

    void Start()
    {
        actualEnemyPosition = enemyPositions[0];
        goingToPosition = enemyPositions[1];
        counter = 2;
	}

	void Update ()
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
        else if(followingPlayer)
        {
            rotation = Quaternion.LookRotation(player.transform.position);
            rotation = new Quaternion(0f, 0f, rotation.z, rotation.w);
            this.transform.rotation = rotation;
            this.transform.position = Vector3.MoveTowards(this.transform.position, player.transform.position, 0.1f);
        }
	}

    void OnCollisionEnter2D(Collision2D col)
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
