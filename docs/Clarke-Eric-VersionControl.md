# Instructions 
Update this document where indicated (brackets). Replace text inside the brackets with your own information. For example: Course Name should be the name of this course, and not the generic words "Course Name".

**Note:** As you complete each item, also update reference links where indicated below. 

<br>

## [ ADF119 ] 

* **[ Version Control ]**
* **[ Eric Clarke ]**
* **[ 9/5/2021 ]**

This paper addresses some of the topic matter covered in research and activity this week. Be sure to include reference links below to the research and information you used to complete this assignment.

## Topic: Terminal
Professional developers use Terminal daily. It's essential to understand some fundamental commands to use the application. 

Update the information below to demonstrate your knowledge on this topic.   

**1. Using Terminal, there are essential commands to know.**

List the correct Terminal commands to do the actions listed below. Replace **CMD** with the correct command sequence. You can keep or enhance the brief description. 

**The last bullet provides an example**.

* [ clear ]: Clear the Screen 
* [ pwd ]: Print the "Working Directory"
* [ ls ]: List files and folders
* [ ls -a ]: List files and folders, including invisible files
* [ ls -lh ]: List all files and folders, in human readable form
* [ cd ]: Change directory
* [ cd / ]: Change directory, go to root directory
* [ cd ~ ]: Change directory and go to user home directory
* [ cd .. ]: Change directory, go up one folder level
* [ cd ../.. ]: Change directory, go up two folder levels
* **cd ~/Desktop/**: Change directory to my desktop! 


**2. Using Terminal...**

**Folder Drop:** Try typing "cd" followed by a space, and then drag a folder into terminal and press return. Test this out and describe your results below.  

[ The terminal returnes my folder location ]


## Topic: Version Control & Git
Version control, also known as revision control, records changes to a file or set of files over time so that you can recall specific versions later. In this class, we are learning Git. Update the information below where indicated.  

**1. There are three types of version control. List and describe each.**

[ The three types of version control are: 
- Local
- Centralized
- Distributed  ]



**2. Using Terminal, there are also essential Git commands to know.**

List the correct Git commands to do the actions listed below in Terminal. Replace CMD with the correct command and keep or enhance the brief description. **The last bullet provides an example**. 

* [ git clone ]: Clone a repository
* [ git config --global user.name ]: Set-up a global user name
* [ git config --global user.email ]: Set-up a global email address (to match my GitHub account eMail)
* git status : [ This commands displays paths that have differences between the index file and the current HEAD commit, paths that have difference between the working tree and the index file, and paths in the working tree that are not tracked by Git. ]
* [ git add ]: Add modified files to the next commit
* [ git commint -m "message" ]: Make a commit with a new message
* [ git log ]: Show my commit history
* **git help**: This command will bring up Git's help screen in Terminal!
    



**3. Connecting to GitHub using Terminal.**
HTTPS is the the correct way to connect to GitHub in this course. Describe how you connect to GitHub from Terminal using this protocol. What steps do you take? 

[ First, you want to create a remote repository using the 'git remote add origin <REMOTE URL> command in the command within the directory your GitHub instance is intialized. GitHub will prompt for your username and password used to sign into the GitHub account. However, password authentication is deprecated, so now Github requires a personal access token to access accounts through the Terminal application.]



**4. Using .gitignore and Why it's Important**  
Most repositories contain a .gitignore file. 

* What is the purpose of this file?  
* What is the "**.DS_Store**" file and why would you want to ignore it?
* What other file or folder would you want to add to a .gitignore file and why? 


[ 1. - The purpose of this file is to identify the type of file. 
2.  - The Desktop Services Store file holds meta info about the folders thumbnails. This is ignored so that next time a commit is made, it is not necessary to add to the ignore list. These prevent harm to system files.
3. - Other files and folders that you would want to ignore are files with API keys/secrets, credentials for signing apps and other sensitive information. Log files only should be ignored, obviously as a result of not being able to troubleshoot issues without them. ]



<br>

# Reference Links
Replace the example references below with your own links and recommended resources, including the generic "Site Address" label. It is acceptable to provide multiple links for a single topic and to use material provided to you in this class. You are encouraged to link to your own independent research as well. 

[ Research Summary: Briefly describe here what resource(s) you found most helpful this past week and why? ]

**Terminal Commands**  
[Command Line Crash Course](https://learnpythonthehardway.org/book/appendixa.html)  

**Three Types of Version Control**  
[FSO](https://online.fullsail.edu/class_sections/117032/modules/375851/activities/2240164)

**Git Commands**  
[Git](https://git-scm.com/docs)

**Connecting to GitHub using Terminal**  
[GitHub Docs](https://docs.github.com/en/get-started/quickstart/set-up-git)

**Using .gitignore and Why it's Important**  
[Plural Sight](https://www.pluralsight.com/guides/how-to-use-gitignore-file)




