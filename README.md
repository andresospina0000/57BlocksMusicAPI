# 57BlocksMusicAPI
 .Net Core code challenge :D

Hello there!

I'm Andres Ospina and this is an REST API on .Net Core 3.1, which is intended to save on an embeded SqLite database, all the data related to a music app.

This API offer the following functionality:

-Creates an user => POST : https://localhost:44329/api/user

Body request example:

{
    "email" : "felipe@email.com",
    "name" : "felipe ospina",
    "password" : "1234d678912"
}

-Update an user => PUT : https://localhost:44329/api/user

Body request example:

{

    "email" : "felipe@email.com",
    "name" : "felipe ospina upd",
    "password" : "1234d678912"
}



-Gets a registered user by its email => GET : https://localhost:44329/api/user/email/felipe@email.com
No body request needed.

-Deletes a registered user => DELETE : https://localhost:44329/api/user/felipe@email.com
No body request needed.

-Creates an artist that could be public or not
-Creates an album that could be public or not
-Creates a song that could be public or not
-Fetch all the public artists by an user's email
-Fetch all the private artists by an user's email
-Fetch all the public albums by an user's email
-Fetch all the private albums by an user's email
-Fetch all the public songs by an user's email
-Fetch all the private songs by an user's email

Deploying the API
To deploy the API you only have to run it on Visual Studio, deploy it on your prefered web browser.

SQLite ".db" file
Please check if the database "MusicAPI57Blocks.db" exist on the API project directory, is a simple SqLite database embeded on the solution.

Postman project
Please import the "Postman_57BlocksMusicAPI_AndresOspina.json" file in Postman to execute the artist endpoints.
