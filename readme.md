# Comics Database

## Table of Contents
- [Comics Database](#comics-database)
  - [Table of Contents](#table-of-contents)
  - [Technology Used](#technology-used)
  - [Log Ins](#log-ins)
    - [Admin](#admin)
    - [User](#user)
  - [Known Issues](#known-issues)
  - [TODO](#todo)
  - [Notes](#notes)

This is a project I've developed to help me learn and improve my C# knowledge. It is not suitable for production due to a number of issues such as a lack of security on passwords.

## Technology Used
- C#
  - .net forms
- SQL
  - sqlite3
  - Using blobs to store images

## Log Ins

### Admin

Username: admin
Password: adminPassword

### User

Username: user
Password: userPassword

## Known Issues

1. ListView does not update after adding/editing a user.
2. Ratings are shared between users
   1. This issue would be fixed by moving the 'rating' field from `comics` to `userComics`


## TODO

1. Implement view users
2. Implement Comics stats (e.g. most popular character and average rating)
   1. Potential Pie Chart?

## Notes

Certain pieces of code are taken from other sources, these are listed in the top of each respective file.