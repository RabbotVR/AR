﻿using System.Collections; using System.Collections.Generic; using UnityEngine; using UnityEngine.Networking; using UnityEngine.UI;  public class off : MonoBehaviour {      private const string URL = "https://api.particle.io/v1/devices/26002d000647343138333038/led?access_token=23a029208881361ba9649c6a44ae30c6ace15b79";     public Text responseText;      public void Request()     {         //WWW request = new WWW (URL);         StartCoroutine(Upload());      }       private IEnumerator Upload()     {         WWWForm form = new WWWForm();         form.AddField("led", "off");          UnityWebRequest www = UnityWebRequest.Post((URL), form);         www.chunkedTransfer = false;////ADD THIS LINE       yield return www.Send();          //yield return req;         //responseText.text = req.text;     } }