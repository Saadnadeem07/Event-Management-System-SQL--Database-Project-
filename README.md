# Event Management System

A desktop **Event Management System** built with **C# WinForms** and an **Oracle** database. Users can register for events and create participant entries, while admins can manage events, participants, and notifications. Every Create / Read / Update / Delete action is backed by parameterized SQL run against Oracle.

<p align="left">
  <img alt="C#" src="https://img.shields.io/badge/C%23-.NET%20Framework%204.7.2-512BD4?logo=csharp&logoColor=white">
  <img alt="WinForms" src="https://img.shields.io/badge/UI-Windows%20Forms-0078D6?logo=windows&logoColor=white">
  <img alt="Oracle" src="https://img.shields.io/badge/Database-Oracle%20XE-F80000?logo=oracle&logoColor=white">
  <img alt="License" src="https://img.shields.io/badge/License-MIT-green">
</p>

---

## Features

- 🔐 **Admin login** — authenticates against the `admin` table
- 📝 **User & participant registration** — add participants tied to an event
- 📅 **Event creation & management** — create, view, and delete events
- 🔔 **Notifications** — generated for participants using an Oracle sequence
- 📊 **Reports & views** — browse events and participant details in data grids
- 🗑️ **Full CRUD** — every operation uses parameterized `OracleCommand` queries

## Tech Stack

| Layer     | Technology                                  |
|-----------|---------------------------------------------|
| Language  | C# (.NET Framework 4.7.2)                    |
| UI        | Windows Forms                               |
| Database  | Oracle Database XE                           |
| Driver    | Oracle.ManagedDataAccess (ODP.NET)          |
| IDE       | Visual Studio 2022                          |

## Project Structure

```
.
├── EventManagementSystem.sln      # Visual Studio solution
├── database/
│   └── schema.sql                 # Oracle tables, sequence & seed data
├── src/
│   └── project2/                  # C# WinForms application
│       ├── Program.cs             # Application entry point (launches mainform)
│       ├── mainform.cs            # Landing screen — user / admin entry
│       ├── adminlogin.cs          # Admin authentication
│       ├── Register.cs            # Participant registration
│       ├── eventcreation*.cs      # Event creation screens
│       ├── view events.cs         # Event listing / browsing
│       ├── participant_view.cs    # Participant details
│       ├── Notification.cs        # Notification generation
│       ├── user_*.cs              # User-facing event / report screens
│       ├── *.Designer.cs / *.resx # WinForms designer & resources
│       └── App.config             # Database connection string
└── README.md
```

## Database Schema

The application uses four tables (full DDL in [`database/schema.sql`](database/schema.sql)):

| Table          | Key columns                                                    |
|----------------|----------------------------------------------------------------|
| `admin`        | `username`, `password`                                         |
| `event`        | `event_id`, `eventname`, `event_date`, `event_time`, `location`|
| `participant`  | `participant_id`, `event_id` → `event`, `name`, `email`, `phone`|
| `notification` | `notification_id` (from `notification_seq`), `participant_id`, `event_id` |

## Getting Started

### Prerequisites

- Windows + [Visual Studio 2022](https://visualstudio.microsoft.com/) with the **.NET desktop development** workload
- [Oracle Database XE](https://www.oracle.com/database/technologies/xe-downloads.html)

### Setup

1. **Clone the repository**
   ```bash
   git clone https://github.com/Saadnadeem07/Event-Management-System-SQL.git
   ```

2. **Create the database objects**

   Run [`database/schema.sql`](database/schema.sql) against your Oracle instance (e.g. via SQL\*Plus or SQL Developer).

3. **Configure the connection**

   Update the connection string in [`src/project2/App.config`](src/project2/App.config) (and the `conStr` fields in the forms) to match your Oracle host, user, and password:
   ```
   DATA SOURCE=localhost:1521/xe;USER ID=<user>;PASSWORD=<password>
   ```

4. **Build & run**

   Open `EventManagementSystem.sln` in Visual Studio and press **F5**.

## Screenshots

![Screenshot](https://github.com/Saadnadeem07/Event-Management-System-SQL/assets/112171181/8190bcd3-5ee9-433b-bc7f-d654997578a2)
![Screenshot](https://github.com/Saadnadeem07/Event-Management-System-SQL/assets/112171181/80e09f56-e46c-4f13-a679-128e1204b63b)
![Screenshot](https://github.com/Saadnadeem07/Event-Management-System-SQL/assets/112171181/ff7b82bb-7600-421e-8587-c268a8965ef7)
![Screenshot](https://github.com/Saadnadeem07/Event-Management-System-SQL/assets/112171181/a2381be3-c901-4ce9-aac2-8f07003f3f70)
![Screenshot](https://github.com/Saadnadeem07/Event-Management-System-SQL/assets/112171181/39ffab44-4173-4f9d-ace6-cb438c6c8d85)
![Screenshot](https://github.com/Saadnadeem07/Event-Management-System-SQL/assets/112171181/c56ab065-b7f2-4dae-a15e-afec1ee3b65a)
![Screenshot](https://github.com/Saadnadeem07/Event-Management-System-SQL/assets/112171181/f87b6eab-58a0-4b75-b3e7-83ee9c609d82)
![Screenshot](https://github.com/Saadnadeem07/Event-Management-System-SQL/assets/112171181/213100fa-b632-4d37-91cf-053c649bf819)
![Screenshot](https://github.com/Saadnadeem07/Event-Management-System-SQL/assets/112171181/5f52799d-2653-480c-bd8b-62fb095e9839)
![Screenshot](https://github.com/Saadnadeem07/Event-Management-System-SQL/assets/112171181/2db9271b-5301-4ead-983a-e14793085773)

## License

Released under the [MIT License](LICENSE).
