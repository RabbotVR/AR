using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

public class off : MonoBehaviour {

	private const string URL = "https://api.particle.io/v1/devices/300027001047343438323536/led?access_token=fb1ce304c1fd5d2b54b45bbda201a32c43b98cec";
	public Text responseText;

	public void Request()
	{ 
		//WWW request = new WWW (URL);
		StartCoroutine (Upload());

	}


	private IEnumerator Upload()
	{
		WWWForm form = new WWWForm();
		form.AddField("led", "off");

		UnityWebRequest www = UnityWebRequest.Post((URL), form);
		www.chunkedTransfer = false;////ADD THIS LINE
		yield return www.Send();

		//yield return req;
		//responseText.text = req.text;
	}
}
