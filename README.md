# 🏨 Kavaklar Restaurant Automation

## 📌 About the Project
Kavaklar Restaurant Automation is developed to digitize restaurant operations, improving customer experience and business processes. The system allows comprehensive management of:
- **Table management**
- **Order tracking**
- **Reservation management**
- **Recording staff activities**

This project is developed using **C#** programming language and **DevExpress 2017** library and operates with **Microsoft SQL Server**.

## 🎯 Features
✅ **Table Management** – Monitor table occupancy in real time.  
✅ **Order Tracking** – Manage customer orders and synchronize with the kitchen.  
✅ **Reservation System** – Add, edit, and cancel customer reservations.  
✅ **Staff Management** – Track employees and their tasks.  
✅ **Reporting & Analytics** – Generate daily, weekly, and monthly sales reports.  
✅ **Payment Processing** – Facilitate payment tracking with different payment methods.  

## 🔧 Technologies Used

- **Programming Language**: C# (Version 17)
- **UI Design**: DevExpress 2017
- **Database**: MSSQL (Relational Database)

## 💾 Database Structure

Database name: **kvkrestorant**  
The database used in the project contains the following essential tables:

- **adisyonlar** – Stores customer orders.
- **hesapOdemeleri** – Records payment transactions.
- **kategoriler** – Contains product categories.
- **login** – Stores user login information.
- **masalar** – Manages restaurant tables.
- **musteriler** – Stores customer information.
- **odemeTurleri** – Includes different payment types.
- **paketSiparis** – Manages takeaway orders.
- **personeIGorevieri** – Records staff duties.
- **personeHareketleri** – Tracks staff activities.
- **personeller** – Stores staff information.
- **rezervasyonlar** – Manages customer reservations.
- **satislar** – Contains sales data.
- **servisturu** – Records service types.
- **urunler** – Stores product details.

📌 **Database Relationships:**  

![Database Diagram](https://github.com/talhakvk/Restaurant-Automation/blob/main/images/Ekran%20g%C3%B6r%C3%BCnt%C3%BCs%C3%BC%202025-01-15%20054137.png)

## 🎨 Forms & Functions

### Main Menu

The main menu provides a central interface for users to access different modules of the application, such as reservations, orders, table management, and reporting.

![Main Menu Image](https://github.com/talhakvk/Restaurant-Automation/blob/main/images/Ekran%20g%C3%B6r%C3%BCnt%C3%BCs%C3%BC%202025-01-15%20044414.png)

### Table Management

This form displays the status of restaurant tables, including occupancy rate, reservation status, and customer details.

![Table Management Image](https://github.com/talhakvk/Restaurant-Automation/blob/main/images/Ekran%20g%C3%B6r%C3%BCnt%C3%BCs%C3%BC%202025-01-15%20044423.png)

### Reservation Management

The reservation management form is used to add, edit, and cancel customer reservations. Date, time, and customer information are recorded here.

![Reservation Management Image](https://github.com/talhakvk/Restaurant-Automation/blob/main/images/Ekran%20g%C3%B6r%C3%BCnt%C3%BCs%C3%BC%202025-01-15%20044509.png)

### Order Management

This form is used to record and manage customer orders. Order status, products, and payment information can be viewed here.

![Order Management Image](https://github.com/talhakvk/Restaurant-Automation/blob/main/images/Ekran%20g%C3%B6r%C3%BCnt%C3%BCs%C3%BC%202025-01-15%20052010.png)
![Order Management Image](https://github.com/talhakvk/Restaurant-Automation/blob/main/images/Ekran%20g%C3%B6r%C3%BCnt%C3%BCs%C3%BC%202025-01-15%20044524.png)

### Reports

The reports form allows viewing of various reports such as sales, reservations, and staff performance.

![Reports Image](https://github.com/talhakvk/Restaurant-Automation/blob/main/images/Ekran%20g%C3%B6r%C3%BCnt%C3%BCs%C3%BC%202025-01-15%20051328.png)
![Reports Image](https://github.com/talhakvk/Restaurant-Automation/blob/main/images/Ekran%20g%C3%B6r%C3%BCnt%C3%BCs%C3%BC%202025-01-15%20051410.png)

### Kitchen Management

The kitchen management module allows staff to track food preparation and coordinate with order management efficiently.

![Kitchen Management Image](https://github.com/talhakvk/Restaurant-Automation/blob/main/images/Ekran%20g%C3%B6r%C3%BCnt%C3%BCs%C3%BC%202025-01-15%20051343.png)
![Kitchen Management Image](https://github.com/talhakvk/Restaurant-Automation/blob/main/images/Ekran%20g%C3%B6r%C3%BCnt%C3%BCs%C3%BC%202025-01-15%20051355.png)


### Customer Management

This section enables the addition of new customers, tracking of order history, and management of customer preferences.

![Customer Management Image](https://github.com/talhakvk/Restaurant-Automation/blob/main/images/Ekran%20g%C3%B6r%C3%BCnt%C3%BCs%C3%BC%202025-01-15%20050921.png)

### Staff Management

The staff management section allows for hiring and removing employees, tracking their shifts, and assigning roles.

![Staff Management Image](https://github.com/talhakvk/Restaurant-Automation/blob/main/images/Ekran%20g%C3%B6r%C3%BCnt%C3%BCs%C3%BC%202025-01-15%20051423.png)
![Staff Management Image](https://github.com/talhakvk/Restaurant-Automation/blob/main/images/Ekran%20g%C3%B6r%C3%BCnt%C3%BCs%C3%BC%202025-01-15%20051455.png)

## 🚀 Installation Steps

### 📌 Requirements

- Visual Studio 2017 or later
- .NET Framework 4.6.1 or later
- Microsoft SQL Server

### 🛠️ Steps

1. **Download the Project:**  
   ```sh
   git clone https://github.com/talhakvk/Restaurant-Automation.git
   ```

2. **Database Setup:**
   - Use the `script.sql` file located in the project root directory to create the database.
   - Open SQL Server Management Studio (SSMS) or another SQL Server management tool.
   - Open a new query window and paste the content of the `script.sql` file.
   - Execute the query to create the database and tables.

3. **Connection String Configuration:**
   - Update the connection string in the `cGenel` class with your SQL Server information.
   ```csharp
   public string conString = "Data Source=SERVER_NAME;Initial Catalog=kvkrestorant;Integrated Security=True";
   ```
   Replace `SERVER_NAME` with your actual SQL Server name.
      
4. **Run the Project:**  
   - Open the project in Visual Studio.
   - Press `F5` to run the project.

## 🤝 Contributing

To contribute to the project, follow these steps:

1. **Fork the repository**
2. **Create a new branch** (`git checkout -b new-feature`)
3. **Make your changes and commit** (`git commit -m 'Added new feature'`)
4. **Submit a pull request**

## 📜 License

This project is licensed under the **MIT License**. For more details, check the `LICENSE` file.
