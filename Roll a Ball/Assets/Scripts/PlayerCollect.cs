using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayerCollect : MonoBehaviour {

	public Text countText;
	public GameObject tokenParent;

	private int tokenCount;
	private int totalTokenCount;

	// Use this for initialization
	void Start () {
		totalTokenCount = tokenParent.transform.childCount;
		tokenCount = 0;
		SetCountText ();
	}

	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.CompareTag("Token"))
		{
			other.gameObject.SetActive (false);
			tokenCount = tokenCount + 1;
			SetCountText ();
		}
	}

	void SetCountText ()
	{
		countText.text = "Tokens: " + tokenCount.ToString () + "/" + totalTokenCount.ToString();
	}
}