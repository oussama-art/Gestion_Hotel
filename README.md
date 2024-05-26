# Gestion Hotel

![logo](Hotel/Hotel/Resources/7faf09dc-b643-4912-ba83-f457cf1ece4d.jpg)

This project is a hotel management system developed in C#. It facilitates the management of hotel operations including bookings, guest management, and billing through a user-friendly interface.

## Table of Contents

- [Overview](#overview)
- [Software Architecture](#software-architecture)
- [Backend](#backend)
- [Getting Started](#getting-started)
- [Usage](#usage)
- [Folder Structure](#folder-structure)
- [Dependencies](#dependencies)
- [Contributing](#contributing)
- [Demonstration](#demonstration)

## Overview

The Gestion Hotel system streamlines hotel operations, ensuring efficient handling of bookings, guest check-ins and check-outs, and billing. It is designed to be robust and easy to use.

## Software Architecture

The application follows a modular architecture, separating the frontend and backend functionalities. The backend is developed in C#, handling the core logic and database operations, while the frontend provides an intuitive interface for users.



### Frontend Project Structure

- **Templates:** Contains the HTML templates for various pages.
- **Static:** Contains static files such as CSS and images.

## Backend

### Technologies Used

- C#
- SQL Server

### Backend Project Structure

The backend is structured to ensure clarity and maintainability, with separate modules for different functionalities.

- **Hotel/**: Main application directory containing C# code.
- **hotel.sql**: SQL script for setting up the database schema.

### Dependencies

1. **.NET Framework**: Required to run the C# application.
2. **SQL Server**: Database management system.

## Getting Started

### Prerequisites

- .NET Framework
- SQL Server

### Setup

1. **Clone the Repository:**
   ```bash
   git clone https://github.com/oussama-art/Gestion_Hotel.git
   cd Gestion_Hotel
   
2. **Configure Database::**
Create a SQL Server database.
Update the database configuration in the application settings.
3. **Set Up Database Schema:**
sqlcmd -S <server_name> -U <username> -P <password> -i hotel.sql


5. **Run the Application:**
dotnet run.

### Folder Structure
Gestion_Hotel/
├── Hotel/
│   ├── Controllers/
│   ├── Models/
│   ├── Views/
│   └── ...
├── hotel.sql
└── README.md


## Contributing
Fork the repository.
Create a new branch (git checkout -b feature-branch).
Make your changes and commit them (git commit -m 'Add new feature').
Push to the branch (git push origin feature-branch).
Create a new Pull Request.
```

