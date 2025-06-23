# Banking_Application

Simple Banking API
This repository contains a basic ASP.NET Core Web Application designed to simulate a banking service. It demonstrates various API endpoints for retrieving hard-coded bank account information, including account details, current balance, and a dummy statement, while also showcasing essential ASP.NET Core features like attribute routing, route constraints, and parameter validation.

Project Description
This application serves as a minimal backend for a hypothetical bank. It provides read-only access to a single hard-coded bank account's information through different HTTP GET endpoints. The goal is to illustrate how to handle various request types, return different content formats (plain text, JSON, PDF), and manage HTTP status codes and validation.

Key Features & Endpoints
The application exposes the following endpoints:

Welcome Message (/)

Method: GET

Path: /

Description: Returns a simple welcome message for the banking service.

Expected Response: HTTP 200 OK with the body "Welcome to the Best Bank".

Account Details (/account-details)

Method: GET

Path: /account-details

Description: Retrieves all hard-coded bank account details.

Expected Response: HTTP 200 OK with a JSON object containing accountNumber, accountHolderName, and currentBalance.

Account Statement (/account-statement)

Method: GET

Path: /account-statement

Description: Returns a dummy PDF file, simulating a bank statement.

Expected Response: HTTP 200 OK with a binary PDF file stream.

Get Current Balance by Account Number (/get-current-balance/{accountNumber:int})

Method: GET

Path: /get-current-balance/{accountNumber} (where {accountNumber} must be an integer)

Description: Retrieves the current balance for a specified account number.

Validation:

If accountNumber is 1001:

Expected Response: HTTP 200 OK with the balance value (e.g., 5000).

If accountNumber is not supplied (e.g., /get-current-balance):

Expected Response: HTTP 404 Not Found with the body "Account Number should be supplied".

If accountNumber is supplied but not 1001:

Expected Response: HTTP 400 Bad Request with the body "Account Number should be 1001".

Technologies Used
ASP.NET Core: A cross-platform, high-performance, open-source framework for building modern, cloud-based, Internet-connected applications.

C#: The primary programming language used for development.

Attribute Routing: Used for defining clear and readable API routes.

Route Parameters & Constraints: Ensures parameters are of the correct type (e.g., int for account number).

Parameter Validation: Implemented to handle invalid or missing input for specific routes.

ContentResult: For returning plain text responses.

JsonResult: For returning structured JSON data.

FileResult: For returning binary file streams (like a PDF).

HTTP Status Codes: Proper use of 200 OK, 400 Bad Request, and 404 Not Found to indicate the outcome of requests.

How to Run the Project
Clone the Repository:

git clone <repository-url>
cd <repository-directory>

Open in Visual Studio (or your preferred IDE):

Open the .sln file in Visual Studio.

Ensure all NuGet packages are restored.

Run the Application:

Press F5 in Visual Studio or use the .NET CLI:

dotnet run

The application will typically run on https://localhost:5001 (or a similar port).

Usage Examples (after running the application)
You can test the endpoints using a web browser or tools like Postman, curl, or Insomnia:

Welcome Message:

GET https://localhost:5001/

Account Details:

GET https://localhost:5001/account-details

Account Statement:

GET https://localhost:5001/account-statement

Valid Current Balance Request:

GET https://localhost:5001/get-current-balance/1001

Missing Account Number:

GET https://localhost:5001/get-current-balance

Invalid Account Number:

GET https://localhost:5001/get-current-balance/10
