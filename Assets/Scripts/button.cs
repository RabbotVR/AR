using System.Collections; using System.Collections.Generic; using UnityEngine; using UnityEngine.Networking; using UnityEngine.UI;   public class button : MonoBehaviour {     //need to change both device id and access token     private const string URL = "https://api.particle.io/v1/devices/26002d000647343138333038/rabbot?access_token=23a029208881361ba9649c6a44ae30c6ace15b79";     public ParticleSystem particles1, particles2;

	void Start()
	{
        particles1.Stop();         particles2.Stop();
	} 
	public void ServoRequest()     {         StartCoroutine(UploadServo());         ////send request to node
        GameController servobutton = GetComponent<GameController>();
        servobutton.OnSound();      }      public void LEDRequest()     {            StartCoroutine(OnParticleTrigger());         StartCoroutine(UploadLED());         GameController lightbutton = GetComponent<GameController>();         lightbutton.OnLight();     }

	private IEnumerator OnParticleTrigger()
	{
        particles1.Play();         particles2.Play();         yield return new WaitForSeconds(0.1f);         particles1.Stop();         particles2.Stop();
	} 
	private IEnumerator UploadServo()     {         WWWForm form = new WWWForm();         form.AddField("servo", "servoon");         UnityWebRequest www = UnityWebRequest.Post((URL), form);         www.chunkedTransfer = false;////ADD THIS LINE         yield return www.Send();      }     private IEnumerator UploadLED()     {         WWWForm form = new WWWForm();         form.AddField("led", "ledon");         UnityWebRequest www = UnityWebRequest.Post((URL), form);         www.chunkedTransfer = false;////ADD THIS LINE         yield return www.Send();       } }