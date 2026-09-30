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

Der lokale Connection String steht in `appsettings.Development.json` und kann über `ConnectionStrings__TodoDatabase` überschrieben werden. Das dort verwendete SQL-Server-Passwort ist ausschließlich für lokale Entwicklung gedacht.

## Azure-Deployment

Der GitHub-Actions-Workflow deployt bei jedem Push auf `main` nach Azure App Service. Er benötigt:

- Eine Azure-Web-App für .NET 10 (Linux).
- Die GitHub-Repository-Variable `AZURE_WEBAPP_NAME` mit dem Namen der Web-App.
- Das GitHub-Repository-Secret `AZURE_WEBAPP_PUBLISH_PROFILE` mit dem unter Azure Portal > Web-App > Veröffentlichungsprofil herunterladen exportierten Profil.
- In den Umgebungsvariablen der Web-App das Setting `ConnectionStrings__TodoDatabase` mit dem bereits angelegten Azure-Connection-String.

Das Deployment startet nach dem Anlegen der GitHub-Variable und des Secrets mit dem nächsten Push auf `main`; unter GitHub Actions kann es auch manuell über `Run workflow` gestartet werden. Beim ersten App-Start erstellt `EnsureCreated` die Tabellen in der angegebenen Datenbank.
