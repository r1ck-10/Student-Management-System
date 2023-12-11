1. You need to clone the project from github link above
2. If you don't have Microsoft SQL Manager Express you must download it
3. After Install everything now you can run the Microsoft SQL Manager app and Make sure you connect to Database
4. After that You must create Database Name "StudenDB"
5. Open project file wiht Visual Studio in project StudentAPI please open filename "appsettings.json" and change the original connection string to yours.

"DefaultConnectionString": "Data Source=<Computer Username\\SQLEXPRESS>;Initial Catalog=StudentDB;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False"

make sure you also install these nuget packages:
+ Microsoft.EntityFrameworkCore
+ Microsoft.EntityFrameworkCore.SqlServer
+ Microsoft.EntityFrameworkCore.Tools
+ Microsoft.EntityFrameworkCore.Design (just in case it get error)

make sure you change this <Computer Username\\SQLEXPRESS> to yours ex: MSI\\SQLEXPRESS.

6. you can remove the old migration folder and Create new by using this command in Nuget Console 
+ To remove use this command "Remove-Migration"
+ To do the Migration use this command "Add-Migration InitialCreate"
You can also delete the migration folder by right click also if you don't want to use command
after that you need to input command "Update Database" in order to create tables in your Database.
You can also check the Tabels to make sure it presents there.

7. now you can run the project studentAPI after that you can use either winform client or console client their have the same feature and function. thank you enjoy your testing!
