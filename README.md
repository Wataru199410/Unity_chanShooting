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
rigid2D.AddForce(new Vector2(5 , Input.mousePosition.y * 0.033f) , ForceMode2D.Impulse);//クリックしたあたりに弾が飛ぶようになる    
```  
ただ、このコードだと"Input.mousePosition.y"をAddForceの引数に使ってしまったため、ゲームがプレイされる環境によって数値が変わる部分が出てしまいました。  
**様々な環境で同じようにプレイできる**ゲーム、そこの意識が足りてなかったと痛感しました。  
# 素材をお借りしたサイト
キャラクター:Unity-chan公式https://unity-chan.com/  
![ユニティちゃんライセンス](http://unity-chan.com/images/imageLicenseLogo.png)  

背景:NEO HIMEISM様https://neo-himeism.net/  

音楽:魔王魂様https://maou.audio/
