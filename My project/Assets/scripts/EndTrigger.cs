using UnityEngine;

public class EndTrigger : MonoBehaviour
{
	public GameManage gameManage;

	void OnTriggerEnter2D(Collider2D collision)
	{
		gameManage.CompleteLevel();
	}
}
