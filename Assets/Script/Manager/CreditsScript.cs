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
        foreach(Text i in texts)
        {
            i.GetComponent<RectTransform>().localPosition += new Vector3(0f, 0.5f);
        }
        if(time > 10)
        {
            Application.LoadLevel("Menu");
        }
	
	}
}
