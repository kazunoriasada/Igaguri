using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IgaguriGenerator : MonoBehaviour
{
    //IgaguriをPrefabに入れる宣言
    public GameObject IgaguriPrefab;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //GetMouseButtonDown = 画面がタップされたかどうかをチェック
        if(Input.GetMouseButtonDown(0))
        {
            //Instantiate = インスタンスの自動生成
            GameObject Igaguri = Instantiate(IgaguriPrefab) as GameObject;

            //ScreenPointToRayにタップ座標を渡す
            // カメラからタップ座標へ向かうベクトルに沿って進むRayクラスを返す
            //Ray = 
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            Vector3 worldDir = ray.direction;
            Igaguri.GetComponent<IgaguriContoroller>().Shoot(worldDir.normalized * 2000);
            // IgaguriContorollerを呼び出して、中のメソッドを活用
            //アウトレット接続: 必ず変数の前にpublicをつける → インスペクター画面より見えるようになる→ 代入したいオブジェクトをインスペクターにドラックアンドドロップ
            //Igaguri.GetComponent<IgaguriContoroller>().Shoot(new Vector3(0,250,2100));
        }
    }
}
