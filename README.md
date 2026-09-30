# Aufgabenliste

Eine Blazor-Web-App mit interaktivem Server-Rendering und SQL Server als Datenspeicher. Aufgaben lassen sich anlegen, abhaken, filtern und löschen.

## Voraussetzungen

- .NET 10 SDK
- Docker mit Docker Compose

## Starten

Im Projektverzeichnis zuerst SQL Server starten:

```bash
docker compose up -d
```

Danach die App starten:

```bash
dotnet run
```

Die App ist unter der URL erreichbar, die `dotnet run` ausgibt. Die Datenbank `TodoDb` und ihre Tabelle werden beim ersten Start automatisch angelegt.

Der Connection String ist in `appsettings.json` für die lokale Entwicklung hinterlegt und kann über `ConnectionStrings__TodoDatabase` überschrieben werden. Das dort verwendete SQL-Server-Passwort ist ausschließlich für lokale Entwicklung gedacht; ändere es vor einem Einsatz außerhalb deiner Entwicklungsumgebung.
