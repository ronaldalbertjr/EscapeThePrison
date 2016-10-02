using UnityEngine;
using System.Collections;

public class RebeldesBehaviour : MonoBehaviour
{
	public GameObject player;
	public bool followingPlayer;
	Quaternion rotation;

	//Fazedo os rebeldes seguirem
	void Update()
	{
		if (followingPlayer)
		{
			this.transform.position = Vector3.MoveTowards(this.transform.position, player.transform.position, 0.1f);
			rotation = Quaternion.LookRotation(player.transform.position);
			rotation = new Quaternion(0f, 0f, rotation.z, rotation.w);
			this.transform.rotation = rotation;
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
