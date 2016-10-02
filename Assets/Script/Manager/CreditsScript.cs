using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CreditsScript : MonoBehaviour
{
    public Text[] texts;
    public GameObject position;
    float time;
	void Start () {
	
	}
	
	void Update ()
    {
        time += Time.deltaTime;
        if(time > 10)
        {
            Application.LoadLevel("Menu");
        }
	
	}
}
