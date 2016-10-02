using UnityEngine;
using System.Collections;

public class Note : MonoBehaviour
{
	public Canvas note;
    bool canSee = false;
	void Start()
	{
		note.enabled = false;
	}
	//Fazendo o bilhete aparecer e o jogador poder fechar apertando qualquer tecla depois de 3 segundos
	void Update()
	{
        if(canSee && Input.GetKeyDown(KeyCode.Return))
        {
            note.enabled = true;
            canSee = false;
            Time.timeScale = 0;
        }
        else if(!canSee && Input.anyKeyDown)
        {
            note.enabled = false;
            Time.timeScale = 1;
        }
	}
	
	void OnCollisionEnter2D(Collision2D col)
	{
		if(col.gameObject.tag == "Player")
		{
            canSee = true;
		}
	}
}
