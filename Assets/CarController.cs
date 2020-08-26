using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour {
	//carPrefabを入れる
	public GameObject carPrefab;

	//Unityちゃんのオブジェクト
	private GameObject unitychan;

	// Use this for initialization
	void Start () {
		//unityちゃんのオブジェクトを取得
		this.unitychan = GameObject.Find("unitychan");
	}

	// Update is called once per frame
	void Update () {
		if (carPrefab.transform.position.z < unitychan.transform.position.z - 5) {
			Destroy (this.gameObject);
		}
	}
}
