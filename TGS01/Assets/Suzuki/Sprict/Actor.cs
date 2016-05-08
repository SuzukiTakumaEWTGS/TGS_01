using UnityEngine;
using System.Collections;

/// <summary>
/// 規定クラス
/// </summary>
public class Actor : MonoBehaviour {

	[SerializeField]
	public ActorParam mActorParam;

	/// <summary>
	/// GameObject型の拡張メソッドを管理するクラス
	/// </summary>
	public virtual void Init()
	{
		mActorParam = new ActorParam ();

	}

}
