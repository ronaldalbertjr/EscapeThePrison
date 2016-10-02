using UnityEngine;
using System.Collections;

public class HowToPlay : MonoBehaviour
{
	private float timer;

	void Start ()
	{
		timer = 0;
	}

	void Update ()
	{
		timer += Time.deltaTime;
		if (timer >= 10)
			Destroy (this.gameObject);
	}
}
