# ShippingQuotePackage

The ShippingQuotePackage project is a console-based application that calculates a shipping quote for a package based on its weight and dimensions. The program guides the user through the process and provides the estimated shipping cost as a dollar amount.

# Project Description
The ShippingQuotePackage project focuses on branching and mathematical calculations to determine the shipping cost for a package. By gathering the package weight, width, height, and length, the program performs the necessary calculations and displays the quote to the user.

# Instructions
Upon running the program, the user will be greeted with the message "Welcome to Package Express. Please follow the instructions below."

The program will prompt the user to enter the package weight as follows:

"Please enter the package weight:" (Float)

If the entered weight is greater than 50, the program will display the error message "Package too heavy to be shipped via Package Express. Have a good day." The program will then end.

If the weight is within the acceptable range, the program will proceed to prompt the user for the package dimensions:

"Please enter the package width:" (Float)

"Please enter the package height:" (Float)

"Please enter the package length:" (Float)

If the sum of the dimensions (height, width, and length) exceeds 50, the program will display the error message "Package too big to be shipped via Package Express." The program will then end.

If the dimensions are within the acceptable range, the program will calculate the quote by multiplying the three dimensions together and multiplying the product by the weight. Finally, the outcome will be divided by 100.

The program will display the quote to the user in the following format:

"Your estimated total for shipping this package is: $[quote amount]"

The program will conclude with the message "Thank you!"

# Skills Demonstrated
This project demonstrates the following skills and concepts related to branching and mathematical calculations in C#:

Console application development

User input validation and data type handling (float values)

Decision-making based on conditional statements

Mathematical calculations involving multiplication and division

String manipulation and output formatting
