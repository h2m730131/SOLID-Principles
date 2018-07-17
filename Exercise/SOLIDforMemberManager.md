# [『SOLID 之會員管理重構挑戰練習』](https://gist.github.com/vulcanlee/94e2048da270f1c1c1310674405672be)

我們要設計一個會員管理服務 MemberManager，其可以接受會員 Member 進行註冊功能，如底下程式碼。

```csharp
public enum MemberType { Personal, Education, Organization }
public class Member
{
    public MemberType MemberType { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public string Phone { get; set; }
    public string LineID { get; set; }
    public bool Binding { get; set; }
}
public class MemberManager
{
    public void Register(Member member)
    {
        if (string.IsNullOrEmpty(member.Name))
        {
            throw new ArgumentException("姓名不可為空白", nameof(member.Name));
        }
        if (string.IsNullOrEmpty(member.Phone))
        {
            throw new ArgumentException("電話不可為空白", nameof(member.Phone));
        }
        if (string.IsNullOrEmpty(member.Email))
        {
            throw new ArgumentException("Email不可為空白", nameof(member.Email));
        }
        if (string.IsNullOrEmpty(member.LineID))
        {
            throw new ArgumentException("LineID不可為空白", nameof(member.LineID));
        }
        Console.WriteLine($"發送簡訊驗證通知給 {member.Phone}");
        if (member.Binding == false)
        {
            Console.WriteLine("進行 Line ID 資料綁定");
        }
        Console.WriteLine("儲存會員資料");
    }
 
}
```

底下為使用這個類別的用法

```csharp
Console.WriteLine("原始程式碼");
OriginalSituation.MemberManager member = new OriginalSituation.MemberManager();
member.Register(new OriginalSituation.Member()
{
    MemberType = OriginalSituation.MemberType.Personal,
    Name = "Vulcan",
    Email = "vulcan@doggy.com.tw",
    Phone = "0987654321",
    Binding = true,
    LineID = "vulcan",
});
 
Console.WriteLine($"Press any key for continuing...{Environment.NewLine}");
Console.ReadKey();
```

# 變更需求說明

由於現在這個 會員管理服務 MemberManager 在進行會員註冊過程中，將會透過手機簡訊發會給會員一個驗證通知訊息，不過，客戶覺得這樣並不足夠，希望能夠加入發送電子郵件的驗證訊息到會員的信箱中。

# 練習目的說明

當您面對這樣的變更需求的時候，請依據 SOLID 個原則，重構這個類別，使他可以符合 SOLID 原則(也許，並不是每個原則都可以套用進去)，並且重構後程式碼可以滿足客戶的變更需求。

# 練習提示

* 在進行重構實作之前，請大家先提出您的意見，這個 MemberManager 類別，違反了那些 SOLID 原則，並且，請說明，您會準備如何進行重構這件事情或者預計執行想法？

  各位可以參考 [如何進行您的專案程式的 SOLID Principle 原則之評估方法](https://gist.github.com/vulcanlee/822ab34251ad1d9e346b27d535071244) 文章中的說明，套用 分析理由 的制式描述方式，闡明您對於重構前、後，對於 SOLID 驗證的論述
  
  若該程式碼沒有符合 SOLID 其中一個原則，也請您說明您的理由與看法

* 之後，在嘗試逐步修正與重構這個類別，您可以將套用個原則的結果，將原始碼提出來與大家一起分享，並且各位學員一同來檢視這個重構後的程式碼，是否有符合 SOLID 個原則，如果沒有，那麼，在重構後的程式碼中，您覺得是那些地方沒有修正好，而這些地方一樣違反了 SOLID 的哪個原則，並且提出您的解釋理由。

這個練習並沒有一定標準的作法(標準答案)，您需要參考 SOLID 的個原則說明，進行重構。經過這樣的練習，相信您已經開始進入到 SOLID 精通領域中了。* 

