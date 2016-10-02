using UnityEngine;
using System.Collections;

public class Note : MonoBehaviour
{
	public GameObject note;
	private float timer;
	private bool canCount;

	void Start()
	{
		note.SetActive (false);
		canCount = false;
	}
	//Fazendo o bilhete aparecer e o jogador poder fechar apertando qualquer tecla depois de 3 segundos
	void Update()
	{
		if(canCount)
			timer += Time.deltaTime;
		if(timer >= 3)
		{
			if (Input.anyKey)
				note.SetActive (false);
		}
	}
	
	void OnCollisionEnter2D(Collision2D col)
	{
		if(col.gameObject.tag == "Player")
		{
			note.SetActive(true);
			canCount = true;
		}
	}
}
