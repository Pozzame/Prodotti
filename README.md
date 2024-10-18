# Prodotti
# Product Management Application

## Features
- CRUD operations for managing products and categories.
- User authentication using Identity Framework.
- Product filtering by price and category.
- Pagination for product listing.
- Seed database with initial products from a JSON file.
- Responsive design using Bootstrap.

## Installation
1. Clone the repository.
2. Install the required dependencies:
dotnet restore

3. Run the application:
dotnet run

4. Access the app at `https://localhost:5001`.

## Database Migration
To apply the migrations and initialize the database, run:
dotnet ef migrations add InitialCreate 
dotnet ef database update


## JSON Seed Data
The application seeds the database with initial products from the file `Data/SeedData.json`. Modify this file to change the initial set of products.




TODO:
 - CRUD
 - Login
 - Homepage