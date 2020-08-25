using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyCameraController : MonoBehaviour {
	//Unityちゃんのオブジェクト
	private GameObject unitychan;
	//Unityちゃんとカメラの距離
	private float difference;
	//carPrefabを入れる
	public GameObject carPrefab;
	//coinPrefabを入れる
	public GameObject coinPrefab;
	//conePrefabを入れる
	public GameObject conePrefab;

	// Use this for initialization
	void Start () {

		//Unityちゃんのオブジェクトを取得
		this.unitychan = GameObject.Find("unitychan");
		//Unityちゃんとカメラの位置（ｚ座標）の差を求める
		this.difference = unitychan.transform.position.z - this.transform.position.z;
		
	}
	
	// Update is called once per frame
	void Update () {

		//Unityちゃんの位置に合わせてカメラの位置を移動
		this.transform.position = new Vector3(0,this.transform.position.y,this.unitychan.transform.position.z-difference);

	}

	//画面外に出たらアイテムを破棄
	void OnBecameInvisible(){
		Destroy (carPrefab.gameObject);
		Destroy (coinPrefab.gameObject);
		Destroy (conePrefab.gameObject);
	}
}
