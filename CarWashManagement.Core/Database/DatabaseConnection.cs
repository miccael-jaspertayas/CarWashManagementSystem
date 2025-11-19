using System;
using System.Data.SqlClient;

namespace CarWashManagement.Core.Database
{
    public static class DatabaseConnection
    {
        private const string ServerName = "LAPTOP-CH6CVADN";
        private const string DatabaseName = "CarWashManagement";
        private const string IntegratedSecurity = "true";

        public static string ConnectionString => 
            $"Server={ServerName};Database={DatabaseName};Integrated Security={IntegratedSecurity};";

        public static SqlConnection GetConnection()
        {
            return new SqlConnection(ConnectionString);
        }

        public static void EnsureDatabaseExists()
        {
            try
            {
                // First connect to master database to create the database if it doesn't exist
                string masterConnectionString = $"Server={ServerName};Database=master;Integrated Security={IntegratedSecurity};";
                using (SqlConnection conn = new SqlConnection(masterConnectionString))
                {
                    conn.Open();
                    string createDbQuery = $@"
                        IF NOT EXISTS (SELECT * FROM sys.databases WHERE name = '{DatabaseName}')
                        BEGIN
                            CREATE DATABASE [{DatabaseName}]
                        END";
                    using (SqlCommand cmd = new SqlCommand(createDbQuery, conn))
                    {
                        cmd.ExecuteNonQuery();
                    }
                }

                // Now create tables if they don't exist
                using (SqlConnection conn = GetConnection())
                {
                    conn.Open();
                    CreateTables(conn);
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error ensuring database exists: {ex.Message}", ex);
            }
        }

        private static void CreateTables(SqlConnection conn)
        {
            // Create Users table
            string createUsersTable = @"
                IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Users')
                BEGIN
                    CREATE TABLE Users (
                        Username NVARCHAR(50) PRIMARY KEY,
                        Password NVARCHAR(100) NOT NULL,
                        Role NVARCHAR(20) NOT NULL,
                        FullName NVARCHAR(100) NOT NULL,
                        Status NVARCHAR(20) NOT NULL DEFAULT 'ACTIVE',
                        FailedLoginAttempts INT NOT NULL DEFAULT 0
                    )
                END";

            // Create Vehicles table
            string createVehiclesTable = @"
                IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Vehicles')
                BEGIN
                    CREATE TABLE Vehicles (
                        Type NVARCHAR(50) PRIMARY KEY,
                        BaseFee DECIMAL(18,2) NOT NULL,
                        OwnerShare DECIMAL(18,2) NOT NULL,
                        EmployeeShare DECIMAL(18,2) NOT NULL
                    )
                END";

            // Create Services table
            string createServicesTable = @"
                IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Services')
                BEGIN
                    CREATE TABLE Services (
                        Name NVARCHAR(100) PRIMARY KEY,
                        Fee DECIMAL(18,2) NOT NULL DEFAULT 0,
                        PricingType NVARCHAR(50) NOT NULL,
                        Multiplier INT NOT NULL DEFAULT 1
                    )
                END";

            // Create Transactions table
            string createTransactionsTable = @"
                IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Transactions')
                BEGIN
                    CREATE TABLE Transactions (
                        ID NVARCHAR(20) PRIMARY KEY,
                        Timestamp DATETIME NOT NULL,
                        VehicleType NVARCHAR(50) NOT NULL,
                        EmployeeName NVARCHAR(100) NOT NULL,
                        BaseFee DECIMAL(18,2) NOT NULL,
                        ServiceTotal DECIMAL(18,2) NOT NULL,
                        OwnerShare DECIMAL(18,2) NOT NULL,
                        EmployeeShare DECIMAL(18,2) NOT NULL,
                        TotalAmount DECIMAL(18,2) NOT NULL,
                        IsPaid BIT NOT NULL DEFAULT 0,
                        WashStatus NVARCHAR(20) NOT NULL DEFAULT 'Ongoing',
                        DiscountPercentage DECIMAL(5,2) NOT NULL DEFAULT 0
                    )
                END";

            // Create TransactionServices table (for many-to-many relationship)
            string createTransactionServicesTable = @"
                IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'TransactionServices')
                BEGIN
                    CREATE TABLE TransactionServices (
                        TransactionID NVARCHAR(20) NOT NULL,
                        ServiceName NVARCHAR(100) NOT NULL,
                        ServiceFee DECIMAL(18,2) NOT NULL,
                        PricingType NVARCHAR(50) NOT NULL,
                        Multiplier INT NOT NULL DEFAULT 1,
                        PRIMARY KEY (TransactionID, ServiceName),
                        FOREIGN KEY (TransactionID) REFERENCES Transactions(ID) ON DELETE CASCADE
                    )
                END";

            // Create Expenses table
            string createExpensesTable = @"
                IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Expenses')
                BEGIN
                    CREATE TABLE Expenses (
                        Id UNIQUEIDENTIFIER PRIMARY KEY DEFAULT NEWID(),
                        Date DATETIME NOT NULL,
                        Description NVARCHAR(500) NOT NULL,
                        Amount DECIMAL(18,2) NOT NULL
                    )
                END";

            // Create AuditLog table
            string createAuditLogTable = @"
                IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'AuditLog')
                BEGIN
                    CREATE TABLE AuditLog (
                        Id INT IDENTITY(1,1) PRIMARY KEY,
                        Timestamp DATETIME NOT NULL DEFAULT GETDATE(),
                        Message NVARCHAR(MAX) NOT NULL
                    )
                END";

            using (SqlCommand cmd = new SqlCommand(createUsersTable, conn))
            {
                cmd.ExecuteNonQuery();
            }
            using (SqlCommand cmd = new SqlCommand(createVehiclesTable, conn))
            {
                cmd.ExecuteNonQuery();
            }
            using (SqlCommand cmd = new SqlCommand(createServicesTable, conn))
            {
                cmd.ExecuteNonQuery();
            }
            using (SqlCommand cmd = new SqlCommand(createTransactionsTable, conn))
            {
                cmd.ExecuteNonQuery();
            }
            using (SqlCommand cmd = new SqlCommand(createTransactionServicesTable, conn))
            {
                cmd.ExecuteNonQuery();
            }
            using (SqlCommand cmd = new SqlCommand(createExpensesTable, conn))
            {
                cmd.ExecuteNonQuery();
            }
            using (SqlCommand cmd = new SqlCommand(createAuditLogTable, conn))
            {
                cmd.ExecuteNonQuery();
            }
        }
    }
}

