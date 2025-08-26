# Lab4 - Entity Framework Code First Setup

## Models Created
The following model classes have been created in the Models folder:

1. **Post.cs** - Represents a blog post with Title, Content, and relationship to Blog
2. **Blog.cs** - Represents a blog with Name and collection of Posts
3. **BloggingContext.cs** - Entity Framework DbContext for database operations

## To Complete the Setup:

### Step 1: Install Entity Framework
You need to install Entity Framework package. Open Visual Studio and:

1. Right-click on the project in Solution Explorer
2. Select "Manage NuGet Packages..."
3. Click on "Browse" tab
4. Search for "EntityFramework"
5. Install the latest stable version (6.4.4 or newer)

**OR** use Package Manager Console:
```
Install-Package EntityFramework
```

### Step 2: Configure Connection String
Add the following to your web.config file in the `<configuration>` section:

```xml
<connectionStrings>
  <add name="DefaultConnection" 
       connectionString="Data Source=(LocalDb)\MSSQLLocalDB;Initial Catalog=Lab4Blog;Integrated Security=true;MultipleActiveResultSets=True" 
       providerName="System.Data.SqlClient" />
</connectionStrings>
```

### Step 3: Enable Code First Migrations (Optional)
In Package Manager Console, run:
```
Enable-Migrations
Add-Migration InitialCreate
Update-Database
```

## Model Relationships
- Each Blog can have multiple Posts (One-to-Many)
- Each Post belongs to one Blog
- Virtual properties enable lazy loading when EF is properly configured