using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppearDisappearController : MonoBehaviour
{
	private Renderer target;
	private bool isVisible = true;

	void Awake()
	{
		target = GetComponent<Renderer>();
	}

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Alpha1))
		{
			if(isVisible)
			{
				//Play effect backwards
				target.material.SetFloat("_PlayingForward", 0f);
				target.material.SetFloat("_AppearFXTime", Time.time);
			}
			else
			{
				//Play effect forward
				target.material.SetFloat("_PlayingForward", 1f);
				target.material.SetFloat("_AppearFXTime", Time.time);
			}

			isVisible = !isVisible;
		}


		if(Input.GetKeyDown(KeyCode.Alpha2))
		{
			//Play one-time effect
			target.material.SetFloat("_ShakeFXTime", Time.time);
		}
    }
}
