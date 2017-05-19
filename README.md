透過 Win32 EnumWindows 和 GetWindowText 取得所有執行程式的hWnd還有標提

![alt 預覽](https://github.com/donma/GetAllWindowsHwnd/blob/master/sample.jpg?raw=true)

筆記一下，基本上這一陣陣子都在弄一些視窗程式，至於程式碼從哪邊來的

我也忘記了，很有可能來自於stackoverflow 

大家可以透過關鍵字去找找看，主要是紀錄一下，關鍵的地方也不完全是我寫的

主要的目的就是抓到所有執行中的程式並且把他的視窗title印出來，這樣可以拿來判斷那程式的hWnd 

會有助於之後你要對他進行一些win32 的操控，我想這是第一步，就分享給大家。

BLOG:
http://no2don.blogspot.com/2017/05/c-win32-enumwindows-getwindowtext-hwnd.html
