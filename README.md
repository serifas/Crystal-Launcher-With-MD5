# Crystal-Launcher
An auto updater and launcher for game clients.

**Using The Source**

**Step #1:**
*Navigate here.*

![Navigate To](https://i.imgur.com/d0LaPMB.png)



*Edit this Line in the config.cs to where you hold your UpdateInfo.dat file generated with the Update Maker*
*Also edit the NewsURL variable to point to a valid txt file on your web server.*
**(NOTE: The app won't run well unless the news txt file is pointed correctly)**

![Edit](https://i.imgur.com/sHmtHwC.png)



*the news.txt file should aways start with*
\rtf1\ansi 
*Followed by the content of the formatted news*
**Examples of text formatting for the news.txt file**
\rtf1\ansi 
\b Here is some bold text\b0\
\line
\i here is a new line with some italic text\i0
\line
\i \b here is some italic and bold text \i0 \b0
\line
\none here is some regular text \none
\line
\b http://awebsitelinkhere \b0



**Step #2:** *Put all files including directories in a folder called Files in the same folder with the update maker, and turn on the update maker*

Your structure should look something like this.



![Folder Structure](https://i.imgur.com/fwIyYk9.png)

**Step #3:**
*Open the Update Maker and it should auto populate with the files in your Files directory like below*



![Update Maker Generation1](https://i.imgur.com/gw1dtvJ.png)


**Step #4:**
*Place your current version number of the assembly in the Version field.*
**NOTE: All updates that you publish, you will need to include a new version of the launcher with a version (In the compiled Launcher's Assembly Version) that matches the the version number generated in the UpdateInfo.dat**
**Just make sure your launcher assembly version matches the update. you can do that by opening the Launcher project properties**


![Update Maker Generation2](https://i.imgur.com/XQVbT0Z.png)

*Hit generate and you will receive an UpdateInfo.dat file*
*You guessed it. This goes in the same url as the line you edited in step 1*

*Now just upload all your files without any folders on your server in the same directory as your UpdateInfo.dat*



*Like this*


![Online File Structure](https://i.imgur.com/CMZIWoW.png)



*Revert the local Launchers Assembly version to a lower version number and compile*

*Run the launcher from your client directory to update.*

**I will be creating a news file creator in a future release, aswell as an image slider section**