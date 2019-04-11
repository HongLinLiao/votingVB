
# e起來投票

**視窗程式設計期末專題**<br/><br/>

開發環境：Visual Studio Community 2017 Visual Basic WindowsAPP應用程式<br/>

資料庫：local SQL Server<br/><br/><br/>

一打開Application後，會先進入歡迎頁面<br/>
<div  align="center"><img  width="700"  height="400"  src="https://github.com/HongLinLiao/votingVB/blob/master/IMG/welcomePage.PNG"/><br>歡迎頁面</div>
<br/>
歡迎頁面等待三秒後會自動跳轉至登入頁面
<br/><br/>
<div  align="center"><img  width="700"  height="400"  src="https://github.com/HongLinLiao/votingVB/blob/master/IMG/loginPage_1.PNG"/><br>登入頁面(選擇登入模式)</div>
<br/>
在這裡可以選擇登入模式，Client端或Admin端
<br/><br/>
<div  align="center"><img  width="700"  height="400"  src="https://github.com/HongLinLiao/votingVB/blob/master/IMG/loginPage_2(client).PNG"/><br>登入頁面(Client)</div>
<br/>
選擇Client後，可以依據ID Number與Birth進行登入，應用程式會根據ID Number與Birth的格式先進行Proprocess，通過後才會與資料庫進行比對<br/>
按下Back，會返回上一頁選擇登入頁面<br/>
按下SignUp，會出現輸入框進行註冊動作
<br/><br/>
<div  align="center"><img  width="700"  height="400"  src="https://github.com/HongLinLiao/votingVB/blob/master/IMG/signUp_1.PNG"/><br>註冊(ID Number)</div>
<br/><br/>
<div  align="center"><img  width="700"  height="400"  src="https://github.com/HongLinLiao/votingVB/blob/master/IMG/signUp_2.PNG"/><br>註冊(Birth)</div>
<br/><br/>
<div  align="center"><img  width="700"  height="400"  src="https://github.com/HongLinLiao/votingVB/blob/master/IMG/signUp_3.PNG"/><br>註冊(Name)</div>
<br/><br/>
<div  align="center"><img  width="700"  height="400"  src="https://github.com/HongLinLiao/votingVB/blob/master/IMG/DB_User.PNG"/><br>DB(User List)</div>
<br/>
通過一些邏輯判斷後，會新增一筆使用者資料進User List<br/><br/>
<div  align="center"><img  width="700"  height="400"  src="https://github.com/HongLinLiao/votingVB/blob/master/IMG/DB_Normal.PNG"/><br>DB(Normal List)</div>
<br/>
將Client註冊的資料丟進Normal List(區分Admin與Client)
<br/><br/>
<div  align="center"><img  width="700"  height="400"  src="https://github.com/HongLinLiao/votingVB/blob/master/IMG/loginPage_2(admin).PNG"/><br>登入頁面(Admin)</div>
<br/>
在Admin登入頁面中，不開放註冊Admin
<br/><br/>
<div  align="center"><img  width="700"  height="400"  src="https://github.com/HongLinLiao/votingVB/blob/master/IMG/listPage(client).PNG"/><br>首頁(Client)</div>
<br/>
Client登入後，左上角為User Name，左方為條列式投票，經過截止狀態排序後，可以進行不同的操作，Client端只能進行投票動作，不能刪除與新增投票
<br/><br/>
<div  align="center"><img  width="700"  height="400"  src="https://github.com/HongLinLiao/votingVB/blob/master/IMG/listPage(admin).PNG"/><br>首頁(Admin)</div>
<br/>
Admin登入後，比Client多了刪除與新增投票選項<br/>
按下刪除投票後，如下圖
<br/><br/>
<div  align="center"><img  width="700"  height="400"  src="https://github.com/HongLinLiao/votingVB/blob/master/IMG/deletePage.PNG"/><br>刪除投票</div>
<br/>
刪除投票後少了一個選項
<br/><br/>
<div  align="center"><img  width="700"  height="400"  src="https://github.com/HongLinLiao/votingVB/blob/master/IMG/addVoteItem.PNG"/><br>建立投票(項目)</div>
<br/>
按下建立投票後，會讓使用者輸入有幾個投票項目，在實體化出指定數量(用實體化解決動態產生問題)
<br/><br/>
<div  align="center"><img  width="700"  height="600"  src="https://github.com/HongLinLiao/votingVB/blob/master/IMG/addVote.PNG"/><br>建立投票(內容)</div>
<br/>
在指定內容填完資料後按下建立，會回到首頁
<br/><br/>
<div  align="center"><img  width="700"  height="400"  src="https://github.com/HongLinLiao/votingVB/blob/master/IMG/DB_Vote.PNG"/><br>DB(投票項目)</div>
<br/><br/>
<div  align="center"><img  width="700"  height="600"  src="https://github.com/HongLinLiao/votingVB/blob/master/IMG/resultPage.PNG"/><br>結果頁面</div>
<br/>
可以在結果頁面進行投票，每次進入結果頁面會先進資料庫抓取是否有投過票，再到頁面選擇呈現
<br/><br/>
<div  align="center"><img  width="700"  height="400"  src="https://github.com/HongLinLiao/votingVB/blob/master/IMG/DB_Choice.PNG"/><br>DB_投票總列表</div>
<br/>
