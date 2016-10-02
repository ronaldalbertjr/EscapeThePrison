using UnityEngine;
using System.Collections;

public class CameraVision : MonoBehaviour
{


	void Update()
	{

	}

	void OnTriggerEnter2D(Collider2D col)
	{
		if (col.gameObject.tag == "Player")
		{
			Application.LoadLevel("MainScene");
		}
	}
}
