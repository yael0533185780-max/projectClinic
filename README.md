# Clinic Management System

A comprehensive clinic management system that enables scheduling appointments, managing patient records, and tracking doctors. The system uses a clean N-Tier architecture to ensure separation of concerns between business logic, data access, and API endpoints.

## Project Resources

* [Project Presentation] - (Optional: Add link to your presentation)

## Technologies

### Backend
* .NET 8
* Entity Framework Core (ORM)
* SQL Server

### Frontend
* Angular
* TypeScript

## Project Structure

### Backend Directory (N-Tier)
* `Clinic.Core/`      # Entities, DTOs, and Repository Interfaces
* `Clinic.Data/`      # Database Context and Migrations
* `Clinic.Service/`   # Business Logic layer
* `projectClinic/`    # API Controllers and Custom Middleware

### Frontend Directory
* `src/`              # Angular components, services, and modules

## Key Features

* **Full CRUD Operations:** Managing Patients, Doctors, and Appointment queues.
* **Appointment Scheduling:** System for booking and tracking doctor visits.
* **Authentication:** User login and management.
* **Middleware:** Custom server-side logic for system requests.

## Setup and Installation

### Prerequisites
* .NET 8 SDK
* Node.js (for Angular)
* SQL Server

### Installation Steps

1. Restore backend dependencies:
```bash
dotnet restore
