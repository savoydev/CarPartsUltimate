# Car Parts Ultimate
Demo app for architecting a car parts ecommerce site. This app is created as a demo to show how I'd architect a legacy car parts ecommerce web app.

To "keep up" with it being legacy, I decided to create a brand new app using... _web forms_. This allows me to truly test out my ideas and if they work. The beginning goal of this app is to use n-tier architecture. Presentation layer, business layer, and data layer. Webforms seems to naturally tie all these things together from what I've seen, so I'm attempting newer design practice with a legacy framework.

The solution right now consists of 3 parts:
1. Presentation & business logic layer: Webforms project
2. Data layer: Class library for interacting with the database
3. Models/POCO's: Class library with all the models/pocos used in the app
4. There are a couple webapi controllers in the webforms project for making async calls using javascript

Ideally, this will be a highly customizable platform for creating websites with dynamic layouts. Every page will be made of user controls. The controls that are rendered to the page and the order they are rendered in can be decided by the user.

From the `Controls` table:

| Id	| Name	| FilePath |
| --- | ----  | -------  |
|1	|CategorySelector	|~/Components/Default/CategorySelector.ascx|
|2	|DealerFinder	|~/Components/Default/DealerFinder.ascx|
|3	|FeaturedProducts	|~/Components/Default/FeaturedProducts.ascx|
|4	|HeroContent	|~/Components/Default/HeroContent.ascx|
|5	|VehicleSelection	|~/Components/Default/VehicleSelection.ascx|

A user can then put these Id into the `PageControls` table:

|Id	|SiteId|	ControlId|	PageName|	SortOrder|
|---|---|---|---|---|
|1	|1	|4	|default	|1|
|2	|1	|2	|default	|2|
|3	|1	|5	|default	|3|
|4	|1	|1	|default	|4|
|5	|1	|3	|default	|5|

A stored procedure is called on page load to retrieve the controls to display on the page. Using the FilePath the controls are loaded and added to the page.

---

Data is currently stored in Microsoft SQL Server. Right now there are tables for categories, controls, and products and the application is able to pull data from those tables.
