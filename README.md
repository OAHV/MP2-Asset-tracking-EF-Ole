# MP2-Asset-tracking-EF-Ole
Miniproject 2 Entity

<h1>What I have done</h1>

I have re-implemented an earlier asset tracking console app - now with SQL Server and Entity framework.

I have reached "Level 3" of the assignment (below).

<ul>
<li>I have created a database "code first" with .NET EF
<li>The DB has several tables releated to eachother
<li>Enhanced the console user interface
<li>Introduced seeding for the DB
<li>Used Excel for seeding easily (Excel files included in the depository)
<li>Enclosed a DB backup as an alternative to the seeding (that doesn't always work)
<li>Incorporated (almost) all countries and currencies in the world
<li>Added reporting features (Level 3) in the footers of the lists diplayed (Assets and Offices)
</ul>

Problems:
<ul>
<li>Seeding will not work. I don't know why.
</ul>


<h1>What I have learned</h1>

Entity framework, more C#, SQL, console control
<ul>
<li>Studied a lot of EF, especially seeding
<li>DbSet<> compared til List<>
<li>Adding and updating the DB (and deleting of cause)
</ul>

<h1>The task</h1>

<h2># Asset Tracking with database and Entity Framework Core</h2>
This project is the start of an Asset Tracking database.
Asset Tracking is a way to keep track of the company assets, like Laptops, Stationary computers, phones and so
on...
<ul>
<li>All assets have an end of life which for simplicity reasons is 3 years.
<li>All assets needs to be stored in database using Entity Framework Core.
</ul>

<h3>Level 1</h3>
Create a console app that have the following classes and objects:
<ul>
<li>Laptop Computers
<ul>
<li>MacBook
<li>Asus
<li>Lenovo
</ul>
<li>Mobile Phones
<ul>
<li>Iphone
<li>Samsung
<li>Nokia
</ul>
</ul>
You will need to create the appropriate fields, constructors and properties for each object, like purchase date,
price, model name etc.

All assets needs to be stored in database using Entity Framework Core with Create and Read functionality.

<h3>Level 2</h3>
Create a program to create a list of assets (inputs) where the final result is to write the following to the console:
<ul>
<li>Sorted list with Class as primary (computers first, then phones)
<li>Then sorted by purchase date
<li>Mark any item *RED* if purchase date is less than 3 months away from 3 years.
</ul>
Your application should handle FULL CRUD.

<h3>Level 3</h3>
Add offices to the model:

You should be able to place items in 3 different offices around the world which will use the appropriate currency
for that country. You should be able to input values in dollars and convert them to each currency (based on
todays currency charts)

When you write the list to the console:
<ul>
<li>Sorted first by office
<li>Then Purchase date
<li>Items *RED* if date less than 3 months away from 3 years
<li>Items *Yellow* if date less than 6 months away from 3 years
<li>Each item should have currency according to country
</ul>

<ul>
<li>Your application should handle FULL CRUD.
<li>Your application should have some reporting features.
</ul>

<h1>Dependencies</h1>

The app is depending on the database in SQL Server.

The database is seeded from the migrations.

If the migrations don't work (like it doesn't for me), please use the backup supplied in the depository (AssetTracking.bak).

<i>By Ole Victor</i>
