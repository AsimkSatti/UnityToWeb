# UnityToWeb
I have been working on an Agumented Reality project that once the user clicked a button their data would then transfer them to a web page with the data they selected on the App now on a webpage. 

This simple solution can be used to bridge the gap between games, AR, VR with the Web.

I was tinkering with having a bot run on the app and then having a website triggered that would then run a bot of its own that would throw the user their own site with their data yet as I was clicking through webpages I noticed how long the urls were and I then rememberd that webpages store some data in their urls instead of generating the site on their server.

Using this idea: this simple solution works by, running on an OnSubmit() - by a user triggering some action funciton in Unity. Once the aciton is trigerred your website with the users data concatenated in the URL would bring up the webpage. Using JavaScript now on the webpage, would grab the data stored in the URl. Your are then free to do with what you want through javascript
