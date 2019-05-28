# CarPartsUltimate
Demo app for architecting a car parts ecommerce site. This app is created as a demo to show how I'd architect a legacy car parts ecommerce web app.

To "keep up" with it being legacy, I decided to create a brand new app using... web forms. This allows me to truly test out my ideas and if they work. The beginning goal of this app is to use n-tier architecture. Presentation layer, business layer, and data layer. Webforms seems to naturally tie all these things together from what I've seen, so I'm attempting newer design practice with a legacy framework.

The solution right now consists of 3 parts:
1. Presentation & business logic layer: Webforms project
2. Data layer: Class library for interacting with the database
3. Models/POCO's: Class library with all the models/pocos used in the app
4. There are a couple webapi controllers in the webforms project for making async calls using javascript

This will be an evolving project
