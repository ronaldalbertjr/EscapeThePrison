using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class AnimateTexts : MonoBehaviour
{
	public float letterPause = 0.2f;
	string message;
	public Text text2;
	private float timer;

	void Start ()
	{
		message = GetComponent<Text>().text;
		GetComponent<Text>().text = "";
		StartCoroutine(TypeText ());
	}

	void Update()
	{
		if(GetComponent<Text>().text == message)
		{
			timer += Time.deltaTime;
			if(timer >= 1)
			{
				text2.GetComponent<AnimateText2>().Wait();
				GetComponent<Text>().text = "";
			}
		}
	}
	
	IEnumerator TypeText ()
	{
		foreach (char letter in message.ToCharArray())
		{
			GetComponent<Text>().text += letter;
			yield return 0;
			yield return new WaitForSeconds (letterPause);
		}      
	}
}
