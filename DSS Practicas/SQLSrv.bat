@ECHO OFF

REM === INICIAR LOS SERVICIOS DE SQL SERVER ===============================================

CLS

ECHO ------------------------------------------------
ECHO - INICIANDO/DETENIENDO SERVICIOS DE SQL SERVER -
ECHO ------------------------------------------------
ECHO.

REM Inicia el Servicio de SQL Server
NET START MSSQLSERVER 2> NUL

IF ERRORLEVEL 1 GOTO parar

   REM ServicioMSSQLSERVER iniciado

   REM Iniciando SQL Server Analysis Services
   NET START MSSQLServerOLAPService 2> NUL

   REM Iniciando SQL Server Integration Services 12.0
   NET START MsDtsServer120 2> NUL

   REM Iniciando SQL Server Reporting Services
   NET START ReportServer 2> NUL

   REM Iniciando SQL Server VSS Writer
   NET START SQLWriter 2> NUL

   GOTO fin

:parar

   REM Detiene el Servicio de SQL Server
   NET STOP MSSQLSERVER 2> NUL

   REM Detiene SQL Server Analysis Services
   NET STOP MSSQLServerOLAPService 2> NUL

   REM Detiene SQL Server Integration Services 12.0
   NET STOP MsDtsServer120 2> NUL

   REM Detiene SQL Server Reporting Services
   NET STOP ReportServer 2> NUL

   REM Detiene SQL Server VSS Writer
   NET STOP SQLWriter 2> NUL
   
   GOTO fin

:fin

ECHO.
ECHO ------------------------------------------------
ECHO.
PAUSE
