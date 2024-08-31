# Resturnag DB&API

This is a program that allows you save tables, customers, menus, menuItems and make bookings. You will
make these things through the api and then it will save to ur local machine/ db. 

## Instructions
* Clone the repo to ur local machine
* Ensure you have the following nuget packages: Tools, Design, Entityframeworkcore and sqlserver.
* run update-database in nuget package-manager
* run the program using the https in the dropdown menu

## API Instructions using swagger
There are crud operations for each table in the database.

### Instructions using Booking table as example:
* CreateBooking: Supply Foreign Keys for customer and table. Input amount of people and for the
3 time variables input them in this format: BookingDay: yyyy-MM-dd BookingTime: yyyy-MM-dd hh:mm
BookingTimeEnd: yyyy-MM-dd hh:mm
* GetAllBookings: Simply Execute
* GetSpecificBooking: Input BookingID and execute
* UpdateBooking: Same as CreateBooking but you have to supply BookingID for the specific Booking you
would like to update
* DeleteBooking: Supply BookingID and execute

Since its crud operations this pattern continues through the rest of the API calls. You are not supposed to
supply id to the "add operations" because it will automaticly give it a id based on the current ids in the 
Database.

## A couple more notes:
MenuItem needs you to supply if the item is available this is just true or false. Also you need to
supply a Foreign key to the specific menu that the MenuItem belongs to. For example the Database comes
with some data for you to play around with and there is a Main Menu and a Drinks Menu if you want to add to Main Menu input Foreign key 1 etc.
