﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinController : MonoBehaviour {

	//coinPrefabを入れる
	public GameObject coinPrefab;

	//Unityちゃんのオブジェクト
	private GameObject unitychan;

	// Use this for initialization
	void Start () {
		//回転を開始する角度を設定
		this.transform.Rotate(0,Random.Range(0,360),0);

		//unityちゃんのオブジェクトを取得
		this.unitychan = GameObject.Find("unitychan");
		
	}
	
	// Update is called once per frame
	void Update () {
		//回転
		this.transform.Rotate(0,3,0);

		if (coinPrefab.transform.position.z < unitychan.transform.position.z - 5) {
			Destroy (this.gameObject);
		}
	}
}
