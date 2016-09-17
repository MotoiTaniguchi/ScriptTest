using UnityEngine;
using System.Collections;


public class Boss{
	private int hp = 100;          // 体力
	private int power = 25;        // 攻撃力
	private int mp = 53;


	// 攻撃用の関数
	public void Attack() { 
		Debug.Log( this.power + "のダメージを与えた" );
	}

	// 防御用の関数
	public  void Defence(int damage) { 
		Debug.Log( damage+"のダメージを受けた" );
		// 残りhpを減らす
		this.hp -= damage;
	}

	//魔法用の関数
	public void Magic(){
		if (this.mp >= 5) {
			this.mp -= 5;
			Debug.Log ("魔法攻撃をした。残りMPは" + this.mp);
		} else {
			Debug.Log ("MPが足りないため魔法が使えない。");
		}
	}
}
			
public class Test : MonoBehaviour {

	// Use this for initialization
	void Start () {
		int[] array = {1, 2, 3, 4, 5};

		for (int i = 0; i < 5; i++){
			Debug.Log(array[i]);
		}

		for (int i = 4; i >= 0; i--){
			Debug.Log(array[i]);
		}

		Boss lastboss = new Boss ();

		for (int i = 0; i <= 10; i++) {
				lastboss.Magic();
		}


	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
