using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Panel
{
	Panel1,
	Panel2,
}

public class OpenSideMenu : MonoBehaviour
{
	private bool isOpen = false;
	[SerializeField] private Transform sideMenu = null;
	[SerializeField] private Transform openTrans = null, closeTrans = null;

	[SerializeField] private float moveSpeed = 2;
	private float startTime = 0;
	private float journeyLength;

	[SerializeField] private GameObject[] panels = null;

	// Start is called before the first frame update
	void Start()
    {
		journeyLength = Vector3.Distance(openTrans.position, closeTrans.position);
	}

    // Update is called once per frame
    void Update()
    {
        if (isOpen)
		{
			float distCovered = (Time.time - startTime) * moveSpeed;

			float fractionOfJourney = distCovered / journeyLength;

			sideMenu.position = Vector3.Lerp(sideMenu.position, openTrans.position, fractionOfJourney);

			Debug.Log("opening");
		}
		else if (!isOpen)
		{
			float distCovered = (Time.time - startTime) * moveSpeed;

			float fractionOfJourney = distCovered / journeyLength;

			sideMenu.position = Vector3.Lerp(sideMenu.position, closeTrans.position, fractionOfJourney);

			Debug.Log("closing");
		}

	}

	public void SideButtonPress()
	{
		startTime = Time.time;

		isOpen = !isOpen;
	}

	public void OpenPanel(int panel)
	{
		for (int i = 0; i < panels.Length; i++)
		{
			if (panel == i)
			{
				panels[i].SetActive(true);
				SideButtonPress();
			}
			else
			{
				panels[i].SetActive(false);
			}
		}
	}
}
