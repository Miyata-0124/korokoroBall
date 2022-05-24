using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
    public GameObject clearText; //レベルクリアと表示するテキストを格納
    public GameObject nextButton;//次のレベルへ偏移するボタンを格納
    public AudioSource audioSource;//音楽再生するコンポーネント
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("ゴール!");

        clearText.SetActive(true);//無効になっていたオブジェクトをこのタイミングで有効にする
        nextButton.SetActive(true);
        audioSource.Play();//Playメソッドの実行で音を再生可能
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
