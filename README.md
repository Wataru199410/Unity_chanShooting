# Unity_chanShooting
ユニティちゃんを使った2Dシューティングゲーム  
製作期間・・・Unityの勉強時間を含め約一か月

# プレイ動画  
https://user-images.githubusercontent.com/89332031/137606098-e5668989-a04f-488a-984d-cf4a166e042d.mp4  

実際にプレイ→[こちら](https://wataru199410.github.io/Unity_chanShooting/FlowerGirl/)  

**操作方法**  
十字キー←→で移動  
十字キー↑でジャンプ  
マウス左クリックで**大体**クリックした方向に射撃  
**画面説明**  
![Unity_chanShooting - 説明](https://user-images.githubusercontent.com/89332031/137606996-b3221d3f-84f7-4683-bc5e-615ddbcd54f1.png)

# 開発環境
Windows  
Unity2020.3.17  
# 概要
教本をあらかた読み、何かゲームを作ってみたいと思い製作しました。  
大体は標準的な横スクロールシューティングゲームとして作りましたが、プレイヤーの攻撃方法を工夫しました。  
プレイヤーが向いている方向に攻撃するのではなく、マウスをクリックした方向に攻撃するようにしてみました。  
プレイヤーが攻撃した際に作られる弾にアタッチされてるスクリプト"BulletCtrl"から  
```C#  
this.clickPosition = this.PlayerScript.mousePosition;//このプレハブが作成された際にクリックした座標をPlayerObjectから取得

this.clickPosition = Input.mousePosition;
rigid2D.AddForce(new Vector2(5 , clickPosition.y * 0.033f) , ForceMode2D.Impulse);//クリックしたあたりに弾が飛ぶようになる   
```  
今回**一番失敗した点**はゲームを実行する環境によって左右されるコードが多くなってしまった点です。  
Textの大きさが環境によって大きくなりすぎる、といったのもですが特に上記のコード
