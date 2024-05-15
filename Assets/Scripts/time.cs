using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class time : MonoBehaviour
{
	[SerializeField] private int minute;
	[SerializeField] private float seconds;
	[SerializeField] private TextMeshProUGUI TextTime;

	private int f_Goal; //ゴールに到着したときに1となるフラグを追加

	//　前のUpdateの時の秒数
	private float oldSeconds;
 
	void Start () {
		minute = 0;
		seconds = 0f;
		oldSeconds = 0f;
		TextTime.text = "Time 00:00";
		f_Goal = 0;
	}
 
	void Update () {
		if(f_Goal == 0){
			seconds += Time.deltaTime;
		}
		if(seconds >= 60f) {
			minute++;
			seconds = seconds - 60;
		}
		//　値が変わった時だけテキストUIを更新
		if((int)seconds != (int)oldSeconds) {
			TextTime.text = "Time " + minute.ToString("00") + ":" + ((int) seconds).ToString ("00");
		}
		oldSeconds = seconds;
	}

	//衝突を判定する
	void OnCollisionEnter(Collision other) // 衝突を判定する関数を呼ぶ
	{
		if (other.gameObject.name == "Star_Trophy") // 衝突した物体が「ゴール」なら
		{
		f_Goal = 1; // 衝突フラグを上げる
		}
	}
}
