# **Attendance Management System**

A desktop application to automate attendance tracking for organizations. Features include user authentication, attendance recording, SQL Server database storage, data validation, and report generation.

---

## **Features**

- **User Roles**: Admin, Instructor, Student with role-specific permissions.
- **Attendance Recording**: Teachers mark attendance; students view their records.
- **Database**: SQL Server for storing attendance data.
- **Reports**: Generate and export reports (Excel).

---

## **Technologies**

- **Frontend**: Windows Forms (C#)
- **Backend**: .NET
- **Database**: SQL Server
- **Reporting**: Crystal Reports or similar

---

## **Installation**

1. **Clone the Repository**:
   ```bash
   git clone https://github.com/Ahmed-Reda-elshahawy/Attendance-System.git
   ```

2. **Set Up Database**:
   - Restore `Attendance.bak` to SQL Server.
   - Update the connection string in `MyConnection.json`.

3. **Run the Project**:
   - Open `AttendanceSystem.sln` in Visual Studio.
   - Build and run (F5).

---

## **Usage**

1. **Login**:
   - Admin
   - Teacher
   - Student

2. **Mark Attendance**: Teachers can mark attendance for students.
3. **Generate Reports**: Admins can generate and export reports.
