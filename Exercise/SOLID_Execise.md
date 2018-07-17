# [『SOLID 重構挑戰練習』](https://gist.github.com/vulcanlee/07602bd1b1a56e335c2ed4c3a5923858)

我們要設計一個將字串文字轉變成為顏色的支援類別，這裡有個類別 StringToColor，裡面有個 Transfer ，負責接收一個字串參數，依據字串參數來進行顏色的轉換，一般來說，你可能會設計成如下的程式碼
(在這裡，我們先假設 Color 這個物件，僅支援傳入 ARGB 四個數值，才能夠建立起一個 Color 物件，不支援傳入顏色字串的功能)

```csharp
public class StringToColor
{
    public Color Transfer(string name)
    {
        Color transferResult;

        switch (name.ToLower())
        {
            case "red":
                transferResult = Color.FromArgb(0xFF, 0xFF, 0x00, 0x00);
                break;
            case "green":
                transferResult = Color.FromArgb(0xFF, 0x80, 0x80, 0x80);
                break;
            case "blue":
                transferResult = Color.FromArgb(0xFF, 0x00, 0x00, 0xFF);
                break;
            default:
                throw new ArgumentException("不正確的顏色名稱");
        }
        return transferResult;
    }
}
```

# 變更需求說明

現在，需要能夠將 Red, Greed, Blue 這三個文字轉換成為相對應的 Color 物件，但是，之後會經常會有變更需求產生，例如：今天有一個需求變更，需要加入一個 Pink 文字顏色，下個星期又要加入 Yellow 文字顏色，總之，這個 StringToColor 類別會經常得變更(不是錯誤與Bug修正喔)，您會如何因應呢？繼續使用 Switch、猜成多個 if

# 練習目的說明

請依據 SOLID 個原則，重構這個類別，使他可以符合 SOLID 原則(也許，並不是每個原則都可以套用進去)

# 練習提示

* 在進行重構實作之前，請大家先提出您的意見，這個 StringToColor 類別，違反了那些 SOLID 原則，並且，請說明，您會準備如何進行重構這件事情或者預計執行想法？

  各位可以參考 [如何進行您的專案程式的 SOLID Principle 原則之評估方法](https://gist.github.com/vulcanlee/822ab34251ad1d9e346b27d535071244) 文章中的說明，套用 分析理由 的制式描述方式，闡明您對於重構前、後，對於 SOLID 驗證的論述

* 之後，在嘗試逐步修正與重構這個類別，您可以將套用個原則的結果，將原始碼提出來與大家一起分享，並且各位學員一同來檢視這個重構後的程式碼，是否有符合 SOLID 個原則，如果沒有，那麼，在重構後的程式碼中，您覺得是那些地方沒有修正好，而這些地方一樣違反了 SOLID 的哪個原則，並且提出您的解釋理由。

這個練習並沒有一定標準的作法(標準答案)，您需要參考 SOLID 的個原則說明，進行重構。經過這樣的練習，相信您已經開始進入到 SOLID 精通領域中了。* 

# 『延伸探討』

在這個範例中，每個 Switch 內的 case 若需要執行超過一個以上的表示式，並且每個 case 內的這些敘述都會不進相同，例如，該類別為產生報表的類別，他會接收一個來自於資料庫內取得的資料，並且產生各式報表：Excel 檔案報表、Word 檔案報表、圖片檔案報表等等。

像是這樣的情況，我們要如何套用 SOLID 各原則，使我們的程式碼具有高可讀性、容易維護性、高內聚、低耦合、可以用於單元測試等特性呢？
