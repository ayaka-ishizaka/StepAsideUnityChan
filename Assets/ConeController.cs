using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConeController : MonoBehaviour {

	//conePrefabを入れる
	public GameObject conePrefab;

	//Unityちゃんのオブジェクト
	private GameObject unitychan;

	// Use this for initialization
	void Start () {
		//unityちゃんのオブジェクトを取得
		this.unitychan = GameObject.Find("unitychan");
	}
	
	// Update is called once per frame
	void Update () {
		if (conePrefab.transform.position.z < unitychan.transform.position.z - 5) {
			Destroy (this.gameObject);
		}
	}
}
