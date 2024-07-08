# Hospital API

API de gestión de hospitales con Entity Framework y C#, para administrar departamentos, pacientes, médicos, laboratorios, empleados, tratamientos, medicamentos, citas, facturas, hospitalizaciones, cirugías, resultados de laboratorio, prescripciones y pagos.

## Tabla de Contenidos

- [Características](#características)
- [Tecnologías Utilizadas](#tecnologías-utilizadas)
- [Estructura de la Base de Datos](#estructura-de-la-base-de-datos)
- [Instalación](#instalación)
- [Uso](#uso)
- [Endpoints](#endpoints)
- [Contribuciones](#contribuciones)
- [Licencia](#licencia)

## Características

- Gestión completa de hospitales y personal médico.
- Registro y seguimiento detallado de pacientes.
- Administración eficiente de citas y tratamientos.
- Integración con sistemas de laboratorio y resultados médicos.
- Facturación y gestión de pagos automatizada.

## Tecnologías Utilizadas

- C#
- .NET
- Entity Framework Core
- SQL Server
- ASP.NET Core

## Estructura de la Base de Datos

La base de datos incluye las siguientes tablas:

1. **Departamentos**
2. **Pacientes**
3. **Medicos**
4. **Laboratorios**
5. **Empleados**
6. **Tratamientos**
7. **Medicamentos**
8. **Citas**
9. **Facturas**
10. **Hospitalizaciones**
11. **Cirugías**
12. **ResultadosLaboratorio**
13. **Prescripciones**
14. **Pagos**

## Instalación

Para instalar y ejecutar este proyecto en tu máquina local, sigue estos pasos:

1. Clona el repositorio:
    ```bash
    git clone https://github.com/tuusuario/hospital-api.git
    ```

2. Navega al directorio del proyecto:
    ```bash
    cd hospital-api
    ```

3. Restaura los paquetes de NuGet:
    ```bash
    dotnet restore
    ```

4. Configura la cadena de conexión a tu base de datos en el archivo `appsettings.json`.

5. Aplica las migraciones para crear la base de datos:
    ```bash
    dotnet ef database update
    ```

6. Ejecuta la aplicación:
    ```bash
    dotnet run
    ```

## Uso

Una vez que la aplicación esté en ejecución, puedes acceder a la API a través de `http://localhost:5000` (o el puerto configurado en tu proyecto).

## Endpoints

A continuación se presentan algunos de los endpoints disponibles:

- **Departamentos**
  - `GET /api/departamentos`
  - `POST /api/departamentos`
  - `GET /api/departamentos/{id}`
  - `PUT /api/departamentos/{id}`
  - `DELETE /api/departamentos/{id}`

- **Pacientes**
  - `GET /api/pacientes`
  - `POST /api/pacientes`
  - `GET /api/pacientes/{id}`
  - `PUT /api/pacientes/{id}`
  - `DELETE /api/pacientes/{id}`

- **Medicos**
  - `GET /api/medicos`
  - `POST /api/medicos`
  - `GET /api/medicos/{id}`
  - `PUT /api/medicos/{id}`
  - `DELETE /api/medicos/{id}`

## Contribuciones

Las contribuciones son bienvenidas. Por favor, sigue estos pasos para contribuir:

1. Haz un fork del proyecto.
2. Crea una nueva rama (`git checkout -b feature/nueva-caracteristica`).
3. Realiza los cambios y haz commit (`git commit -am 'Agrega nueva característica'`).
4. Empuja tus cambios a la rama (`git push origin feature/nueva-caracteristica`).
5. Abre
