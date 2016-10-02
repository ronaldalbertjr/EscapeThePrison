using UnityEngine;
using System.Collections;

public class Rebelde1Behaviour : MonoBehaviour
{
	public Transform[] rebeldePositions;
	[HideInInspector] public bool followingPlayer;
	[HideInInspector] public bool canWalk;
	Transform actualRebeldePosition;
	Transform goingToPosition;
	Quaternion rotation;

	void Start ()
	{
		followingPlayer = false;
		actualRebeldePosition = rebeldePositions [0];
		goingToPosition = rebeldePositions[1];
	}

	// Rebelde 1 andando para uma posicao e depois aparece no local do policial 1 com sprite dele caido (FALTA BOTAR O SPRITE)
	void Update ()
	{
		if(!followingPlayer && canWalk)
		{
			this.transform.position = Vector3.MoveTowards(this.transform.position, goingToPosition.position, 0.2f);
			this.transform.rotation = goingToPosition.rotation;
			if (this.transform.position == goingToPosition.position)
			{
				this.transform.position = rebeldePositions[2].position;
                followingPlayer = true;
			}
		}
		else if(this.transform.position == rebeldePositions[2].position)
		{
			canWalk = false;
			this.GetComponent<Animator>().SetBool("IsWalking", false);
		}
	}
}
