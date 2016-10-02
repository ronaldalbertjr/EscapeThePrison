using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Note : MonoBehaviour
{
	public Canvas note;
    bool canSee = false;
	public Sprite openArmario;

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
			GetComponent<SpriteRenderer>().sprite = openArmario;
			transform.localScale = new Vector3(1, 1, 1);
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
    void OnCollisionExit2D(Collision2D col)
    {
        if(col.gameObject.tag == "Player")
        {
            canSee = false;
        }
    }
}
