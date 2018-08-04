# Hair Salon Many-to-Many
### This was made by the same developer who brought you Part-1 HairSalon "Brian Palowski"

This app has now been upgraded with a new feature. It will allow you to add by inputing a speciality to your stylist. In case you did not know this app will allow you to be able to add a list of the stylists, and for each stylist, add clients who see that stylist. Now you can also view the stylist information which has their specialities and clients.

### Description
```
You will be able to see a list of all the stylists.
You will be able to see a list of all the specialities.
You will be able to select a stylist, and see a list of all clients and their specialities that belong to that stylist.
You can add new stylists .
You can add new specialities to a specific stylist. .
You can add a new client to a specific stylist.
```
### Set Up
```
(Before trying to use/open this app make sure you have the proper setup to your system in place)
Clone from GitHub Repository (https://github.com/bpalowski/SalonPt2)
Copy and paste to a text editor(Terminal)
Navigate using terminal with cd and name of the folder (HairSalon)
Make sure you have you MAMP database open and import brian_palowski.sql into it.
With the terminal in order to use the app you have to
1-dotnet restore
2-dotnet build
3-dotnet run. From here you can go into your URL and type in http://localhost:5000/
Enjoy!!!
```
### Example
```
1- Lets start out by looking at the Main Page.You are given options to either create a Stylist, create a Client, Create a Speciality, view all the stylist, view all the Clients and view Specialities.
2- If you do choose to create a client you first have to create a stylist.Make sure your start there.
3- Once you have created and inputed a stylist name. You should check out your data base and you will see the inputed name in the stylists table.
4- Now that you have created the stylist you can now create a client. When you click on the link to Create Client you will be taken to a page with a form just like the stylist page.The only difference now is that you can add the stylist to the client. Once you do that re-check your database and you will see how it is now linked together. Cool!!!
5- When viewing you Stylist a form has been added to add a speciality to that stylist.
6- You can also create a Specialty.
7- Finally when clicking on the stylist info you can now see all their clients and what types of specialites that stylist has.
 ```
 ### Support and contact details
For any questions please contact:
Brianpalowski00@gmail.com.com



Technologies Used
C#, Atom,Terminal,MAMP

License
Licensed under MIT

Copyright (c) 2018 {Brian Palowski}
