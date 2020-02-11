# Lab 4.2: Movies
## Task
List movies by category.

## What will the application do?
* The application stores a list of at least 10 movies and displays them by category.
* The user can enter any of the following categories to display the films in the list that match the category: animated, drama, horror, scifi.
* After the list is displayed, the user is asked if he or she wants to continue. If no, the program ends.

## Build Specifications
1. Build a Movie class with two private fields: title and category. Both of these fields should be Strings. The class should also provide a constructor that accepts a title and category as parameters and uses the values passed to it to initialize its fields.
    * Class has proper fields of correct type—1 point total
    * Class has properties for each field—1 point total
    * Class has constructor—1 point
1. In your Main, create a List <Movie> and store at least 10 movies there. You can use literals to construct the movies. Make sure to have a mixture of categories.
    * Program constructs list properly—1 point
    * Program puts at least 10 properly instantiated Movies into the List—1 point
1. When the user enters a category, the program should read through all of the movies in the List and display a line for any movie whose category matches the category entered by the user.
    * Program takes user input correctly—1 point
    * Program gives explicit feedback if user enters invalid category—1 point
    * Program iterates through List validly—1 point
    * Program only outputs if movie matches category—1 point
1. Program loops if user wants to continue.
    * Program loops back to ask category again based on user input—1 point
  
## Extended Exercises
* Standardize the category codes by displaying a menu of categories and having the user select the category by number rather than entering the name.
* Display the movies for the selected category in alphabetical order.
* Expand the information in your Movie class—run time in minutes, year released, etc. Display the additional information when listing movies.
