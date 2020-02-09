# Demo-AwaitTask
再試一下 Await async Task 還有 HttpClient

## 參考
- https://dotblogs.com.tw/kinanson/2017/05/03/075119 Async Await的觀念

## 概念 
- 「await」，等待結果
- 可以不用等 function 做完回傳，程式就可以往後進行，一直到出現 await 來取得回傳的結果
- function 回傳值前加上 「async Task」，就可以成為異步的程式，但 function 裡要有處理異步的動作才行

```
TplExample tpl = new TplExample();
Console.WriteLine("Start Cooking !!!");

var makecoffee = await tpl.MakeCoffee();    //這裡會等待回傳，再往下進行, 因為有加上 await
Console.WriteLine("making coffee......");

var grilledtoast =  tpl.GrilledToast();     //這裡不會等，直接往下走, 因為沒有 await
Console.WriteLine("grilling toast......");



var fryegg = tpl.FryEgg();                  //這裡不會等，直接往下走, 因為沒有 await
Console.WriteLine("frying egg......");      

var frysteak = tpl.FrySteak();              //這裡不會等，直接往下走, 因為沒有 await
Console.WriteLine("frying steak......");

await grilledtoast;                         //等待 function 執行結束
await fryegg;                               //等待 function 執行結束
await frysteak;                             //等待 function 執行結束

//上面三個等待回傳也是有先後順序，只是 function 裡的動作不會有先後順序

Console.WriteLine("Completed !!!");         //上面三個等待回傳都執行完，才會執行到這

```

## 心得
- 感覺好像有比較快，但其實總共要花的時間是一樣的，並沒有比較快，只是同時可以叫各個 function 幾乎同時間動作
  因為最後還是得等各個 function 回傳結果回來，只是程式不用一直等其中一個跑完才能去跑下一個
  所以學網路上一樣用了一個做早餐的例子，我可以先把咖啡用下去泡，然後同時用烤麵包機烤麵包，然後去煎蛋，然後煎肉
- 我修改了一下程式，先把咖啡拿去泡，然後把吐司放下烤，然後去煎蛋，因為要肉要等蛋煎用才能用，所以我程式改了一下，
  咖啡和吐司和蛋可以幾乎同時間開始，只有蛋要等煎完了才能煎肉
