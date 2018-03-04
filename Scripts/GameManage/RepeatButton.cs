using UnityEngine;
using System.Collections;

public class RepeatButton : MonoBehaviour 
{
	bool push = false; // ボタンが押されているか？
	
	public void StartPush()
	{
		push = true;
	}
	
	public void StopPush()
	{
		push = false;
	}
	
	void Update()
	{
		if(push)
		{
			//ここにやらせたい処理を書きます
			Debug.Log("押されてます！");
		}
	}
}