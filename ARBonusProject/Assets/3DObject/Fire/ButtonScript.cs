using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonScript : MonoBehaviour {

	public GameObject CandleLight1;
	public GameObject CandleLight2;
	public GameObject CandleLight3;
	public GameObject Button;

	private const string ActivateText = "Start";
	private const string DeactivateText = "Stop";
	private bool active = false;

	public void OnButtonClicked()
	{
		if (active)
		{
			Button.GetComponent<Text>().text = ActivateText;
			CandleLight1.GetComponent<ParticleSystem>().Stop();
			CandleLight2.GetComponent<ParticleSystem>().Stop();
			CandleLight3.GetComponent<ParticleSystem>().Stop();
			active = false;
		}
		else
		{
			Button.GetComponent<Text>().text = DeactivateText;
			CandleLight1.GetComponent<ParticleSystem>().Play();
			CandleLight2.GetComponent<ParticleSystem>().Play();
			CandleLight3.GetComponent<ParticleSystem>().Play();
			active = true;
		}
	}

	public void OnQuit()
	{
		Application.Quit();
	}
}
