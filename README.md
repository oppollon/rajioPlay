# rajioPlay (ラジオ)
a somewhat lightwheight* and partly open-source internet radio player in the windows taskbar / notification tray <br />
*(172 SLOC , 806 KB, minimal RAM usage, no WinForms GUI)*

![Rajio in my notification tray](https://raw.githubusercontent.com/oppollon/rajioPlay/master/rajosc.PNG)

## intro
I initially made this program for myself (private use) using [BASS.NET API](http://www.bass.radio42.com/) which I believe is licensed and not open-source! This program however is open-source, you could this for your personal education, if you can't hold back. I decided to publish it. I haven't deciced what license I want to use or if I ever am going to use one (don't ask me).
I made this program since I couldn't find any other program which just plays internet radios only - whitout unnecessary features and GUI, only ToolStripMenuItems, some text files and an Akari icon.

## requirements
- .NET Framework 4.5+ (I use 4.7.2)

## getting started
1. download rajioPlay.zip from the [latest release](https://github.com/oppollon/rajioPlay/releases/latest)
2. extract all files into a folder of your choice
3. run rajioPlay.exe, a notification should show up (*if not, check if .NET 4.5+ is installed and the two .dll files are in the same directory*)
4. exit rajioPlay (right-click on the icon in the taskbar -> "Exit")
5. open the auto-created "radios.txt" file and insert your custom radios in the **second** - not first - line

### an example radios.txt file:

```
Insert your custom radios like this: radioName|radioURL
r/a/dio|https://stream.r-a-d.io/main.mp3
eden|http://edenofthewest.com:8080/eden.mp3
listen.moe|https://listen.moe/fallback
```
Obvious notice: The links must be **direct audio links** and usually should have extentions like .mp3, .aac, .ogg, .pls etc. Please don't randomly insert links! Currently some .m3u links don't work, I'm gonna implement playlist support when I feel like it.<br />
You can get direct audio urls from [www.radio-browser.info](http://www.radio-browser.info).

6. close the .txt and start the .exe again
Now, you should be able to select your Radio from the ToolStripMenu (by right clicking on the icon).
If you did everything and there are errors or crashes, just contact me or create an issue.

## how to use?
Everything is pretty self-explanatory, once you try it out. But if there are questions left, just contact me.

## already added features
- [x] play internet radios
- [x] add custom radios
- [x] show current song (as notification)
- [x] add current song to a "likes.txt" file
- [x] copy current song to clipboard
- [x] search current song (with DuckDuckGo or YouTube)

## upcoming features (unordered)
- [ ] keyboard shortcuts
- [ ] add own search engines
- [ ] m3u/pls links support

## launch program on startup
1. open your explorer.exe
2. type "shell:startup" in the directory bar..? (*don't know whats it called*)
3. right click and create a shortcut
4. insert the full path to your rajioPlay.exe

## where can I complain and cry *in private*?
I prefer you don't, but [click here](mailto:tatomete@rptonmail.com) if you can't help yourself. You will however be blocked if I feel annoyed or needlessly contacted.
