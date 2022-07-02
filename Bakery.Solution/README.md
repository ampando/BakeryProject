# Bakery Shop Project 

#### Test-Driven Development with C# Exercise for Epicodus 06.30.2022

### By Adrienne Matosich 

## Description

This is our first independent project using C#! The application is for a bakery that takes a user's order for bread and pastries. It then returns the total cost of the order, taking into account any deals that may be available. This project also focuses on testing, and I used MSTest to test my models.

## Specifications

**Behavior**: Program will offer a welcome message to the user that describes the cost of bread and pastries from Pierre's Bakery.
  * Input: `dotnet run`
  * Output: "Welcome to Pierre's Bakery. Our loaves of bread are $5, or choose 3 for $10. Our pastries are $2 each or 3 for $5."

**Behavior**: Program will take an input for how many loaves of bread the user would like.
  * Output: "How many loaves of bread would you like?"
  * Input: "2"

**Behavior**: Program will take an input for how many pastries the user would like.
  * Output: "How many pastries would you like?"
  * Input: "3"

**Behavior**: Program will return the total cost of the order.
  * Input: "2" & "3"
  * Output: "Your total comes to $16."
 
**Behavior**: After user is finished adding any additional items, program will display total loaves, pastries, and price.
  * Input: User is finished ordering.
  * Output: "Here is your grand total: $15"

## Setup/Installation Requirements

1.  Navigate to the [BakeryProject repository](https://github.com/ampando/BakeryProject) or open your terminal

2. Clone this project using the GitHub button or the command:
`$ git clone https://github.com/ampando/BakeryProject.git`

3. Navigate to the `Bakery.Solution` directory in your editor of choice, or use [Visual Studio Code](https://code.visualstudio.com/)

5. Within the project, navigate to the `Bakery` directory, and type `dotnet run`. This will open the interactive console app. There will be several lines of introductory material. Press 'Enter' to navigate through the welcome information.

6. If you wish to test the code, navigate to the Bakery.Tests directory. In the terminal type `dotnet restore`, then `dotnet test`.

## Known Bugs

There are no known bugs at this time.

## Support and Contact Details

If there are any issues or questions, please reach out to me through [my GitHub account](https://github.com/ampando).

## Technologies Used

*  [Visual Studio Code](https://code.visualstudio.com/)
*  [Markdown](https://daringfireball.net/projects/markdown/)
*  [C#](https://docs.microsoft.com/en-us/dotnet/csharp/)
*  [.NET5.0](https://dotnet.microsoft.com/download/dotnet-core/net5.0)

### License

*This project uses the following license: [MIT](https://opensource.org/licenses/MIT)*

Copyright (c) 2020 **_Adrienne Matosich_** 