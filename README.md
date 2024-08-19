# Hospital API 🏥
> [!NOTE]
API for hospital management using Entity Framework and C#, to manage departments, patients, doctors, laboratories, employees, treatments, medications, appointments, invoices, hospitalizations, surgeries, lab results, prescriptions, and payments.

<div style="display: flex;">
  <img src="https://github.com/K3ury99/Hospital-API/assets/128008789/0b513eaa-c2c6-450c-b4b3-24db3f11749a" width="49%"></img>
  <img src="https://github.com/K3ury99/Hospital-API/assets/128008789/75287c78-6298-4395-aa80-bea91ed84ee2" width="49%"></img>
</div>


## Table of Contents 📔

- [Features](#features)
- [Technologies Used](#technologies-used)
- [Database Structure](#database-structure)
- [Installation](#installation)
- [Usage](#usage)
- [Endpoints](#endpoints)
- [Contributing](#contributing)
- [License](#license)

## Features ✨

- Comprehensive management of hospitals and medical staff.
- Detailed registration and tracking of patients.
- Efficient administration of appointments and treatments.
- Integration with laboratory systems and medical results.
- Automated billing and payment management.

## Technologies Used ♟

- C#
- .NET
- Entity Framework Core
- SQL Server
- ASP.NET Core

## Database Structure 💎

The database includes the following tables:

1. **Departments**
2. **Patients**
3. **Doctors**
4. **Laboratories**
5. **Employees**
6. **Treatments**
7. **Medications**
8. **Appointments**
9. **Invoices**
10. **Hospitalizations**
11. **Surgeries**
12. **LabResults**
13. **Prescriptions**
14. **Payments**

## Installation 🛠

To install and run this project on your local machine, follow these steps:

1. Clone the repository:
    ```bash
    git clone https://github.com/yourusername/hospital-api.git
    ```

2. Navigate to the project directory:
    ```bash
    cd hospital-api
    ```

3. Restore NuGet packages:
    ```bash
    dotnet restore
    ```

4. Configure the connection string to your database in the `appsettings.json` file.

5. Apply migrations to create the database:
    ```bash
    dotnet ef database update
    ```

6. Run the application:
    ```bash
    dotnet run
    ```

## Usage 🐱‍👤

Once the application is running, you can access the API via `http://localhost:5000` (or the port configured in your project).

## Endpoints

Below are some of the available endpoints:

- **Departments**
  - `GET /api/departments`
  - `POST /api/departments`
  - `GET /api/departments/{id}`
  - `PUT /api/departments/{id}`
  - `DELETE /api/departments/{id}`

- **Patients**
  - `GET /api/patients`
  - `POST /api/patients`
  - `GET /api/patients/{id}`
  - `PUT /api/patients/{id}`
  - `DELETE /api/patients/{id}`

- **Doctors**
  - `GET /api/doctors`
  - `POST /api/doctors`
  - `GET /api/doctors/{id}`
  - `PUT /api/doctors/{id}`
  - `DELETE /api/doctors/{id}`

## Contributing 🏆

Contributions are welcome. Please follow these steps to contribute:

1. Fork the repository.
2. Create a new branch (`git checkout -b feature/new-feature`).
3. Make your changes and commit them (`git commit -am 'Add new feature'`).
4. Push to the branch (`git push origin feature/new-feature`).
5. Open a pull request.

## License 📏

This project is licensed under the [MIT] License - see the [LICENSE.md](LICENSE.md) file for details.
