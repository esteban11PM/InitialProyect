# Para un Correcto Funcionamiento del Proyecto Base

### Backend

#### 1. Inicializar
```bash
dotnet restore
dotnet build
dotnet clean
dotnet run # Ejecutar Proyecto 
```

---
---
---

#### 2. Instalacion de Package Necesarios

> Importante que se mantenga un mismo versionado segun la familia de packages

```bash
# Comando para usar EF 
dotnet ef  # (Verificar antes y despues de instalar)

                     _/\__
               ---==/    \\
         ___  ___   |.    \|\
        | __|| __|  |  )   \\\
        | _| | _|   \_/ |  //|\\
        |___||_|       /   \\\/\\

dotnet tool install --global dotnet-ef
```

```bash
# Ver Paquetes Instalados
dotnet list <Proyecto> package
```

```bash
# Entity
dotnet add package Microsoft.EntityFrameworkCore --version 9.0.4 # Instalado
dotnet add package Microsoft.EntityFrameworkCore.Tools --version 9.0.4 # Instalado
dotnet add package Npgsql.EntityFrameworkCore.PostgreSQL --version 9.0.4 # Instalado
dotnet add package Microsoft.EntityFrameworkCore.SqlServer --version 9.0.4 # Instalado 
dotnet add package Microsoft.EntityFrameworkCore.Relational --version 9.0.4 # Instaldo 
dotnet add package Microsoft.Extensions.Configuration.Json --version 9.0.5 # Instalado 
dotnet add package Microsoft.Extensions.Configuration.FileExtensions --version 9.0.5 # Instalado
```

```bash
# Data
# NULL
```

```bash
# Business
dotnet add package Newtonsoft.Json --version 13.0.3
dotnet add package Microsoft.IdentityModel.Tokens --version 8.10.0
dotnet add package System.IdentityModel.Tokens.Jwt --version 8.10.0
dotnet add package Microsoft.Extensions.Configuration.Json --version 9.0.5 # Instalado
dotnet add package Microsoft.AspNetCore.Authentication.JwtBearer --version 9.0.4
dotnet add package AutoMapper.Extensions.Microsoft.DependencyInjection --version 12.0.1 # Instalado 
```

```bash
# Utilities
dotnet add package Microsoft.Extensions.Identity.Core --version 9.0.4 # Instalado
```

```bash
# Web
dotnet add package Swashbuckle.AspNetCore --version 8.1.1 # Instalado 
dotnet add package Microsoft.EntityFrameworkCore.Design --version 9.0.4 # Instalado 
dotnet add package Microsoft.AspNetCore.Authentication.JwtBearer --version 9.0.4
```

---
---
---

#### 3. Agregar Referencias (Ya Todas Bienen Agregadas 😙)

```bash
# Ver Referencias Actuales
dotnet list <Proyecto> reference
```

```bash
# Entity
dotnet add .\Entity\ reference .\Utilities\
```

```bash
# Data
dotnet add .\Data\ reference .\Entity\
dotnet add .\Data\ reference .\Utilities\
```

```bash
# Business
dotnet add .\Business\ reference .\Entity\
dotnet add .\Business\ reference .\Data\
dotnet add .\Business\ reference .\Utilities\
```

```bash
# Utilities
# NULL
```

```bash
# Web
dotnet add .\Web\  reference .\Entity\
dotnet add .\Web\  reference .\Business\
```

---
---
---

#### 4. Comandos Necesarios

##### Inicializar Migracion (Solo un Provedor)
```bash
# Consola Package:
    # - Crear Migracion
        Add-Migration <Nombre> -Project Entity -StartupProject Web
    # - Aplicar Migracion
        Update-Database -Project Entity -StartupProject Web
    # - Listar Migraciones
        # Ver Manualmene
        Get-Migration -Project Entity -StartupProject Web # Migraciones Aplicadas
    # - Revertir a una migracion especifica
        Update-Database -Migration <NombreMigracion> -Project Entity -StartupProject Web
    # - Generar Script SQL (MI: Migracion Inicial MF: Migracion Final)
        Script-Migration -From <MI> -To <MF> -Project Entity -StartupProject Web -Output "script.sql"
```

```bash
# Consola CLI
    # - Crear Migracion
        dotnet ef migrations add <Nombre> --project Entity --startup-project Web
    # - Aplicar Migracion
        dotnet ef database update --project Entity --startup-project Web
    # - Listar Migraciones
        dotnet ef migrations list --project Entity --startup-project Web
        dotnet ef database update --context AppDbContext --dry-run # Muestra qué se ejecutaría
    # - Revertir a una migracion especifica
        dotnet ef database update <NombreMigracion> --project Entity --startup-project Web
    # - Generar Script SQL (MI: Migracion Inicial MF: Migracion Final)
        dotnet ef migrations script <MI> <MF> --project Entity --startup-project Web --output "Scripts/migration_partial.sql"
```

---

##### Inicializar Migracion (Diferentes Provedores -  Solo CLI)
```bash
# Eliminar 
    # - Elimina Migracion sin Aplicar (A Nivel de Archivo)
        dotnet ef migrations remove -p Entity -s Web
    # - Elimina la Base de Datos del Proveodor 0.0
        dotnet ef database drop -p Entity -s Web -- --provider=
```

```bash
# Crear
dotnet ef migrations add InitPostgres -p Entity -s Web -- --provider=PostgreSQL
dotnet ef migrations add InitSqlServer -p Entity -s Web -- --provider=SqlServer
```

```bash
# Enviar
dotnet ef database update -p Entity -s Web -- --provider=PostgreSQL
dotnet ef database update -p Entity -s Web -- --provider=SqlServer
```


### Frontend

#### 1. Inicializar
```bash
npm install
ng serve # Ejecutar APP
```

#### 2. Comandos Creacion e Instalacion Angular CLI

```bash
# Instalar Angular CLI Global
npm install -g @angular/cli
ng version

# CrearProyecto
ng new nombre-proyecto

# Ejecutar APP
ng serve -o

# Angular Material
ng add @angular/material

# Generar Ambientes
ng g environments

# SweetAler
npm install sweetalert2

# JWT Decode
npm install jwt-decode
```

> Revisar .gitignore linea 69 😏