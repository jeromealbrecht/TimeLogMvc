TimeLog MVC

Application web ASP.NET Core MVC + SQL Server pour la gestion de projets et du temps passé.

TimeLog MVC est une petite application pédagogique visant à explorer un workflow complet :

ASP.NET Core 8 (MVC)

Entity Framework Core 8

SQL Server LocalDB

CRUD complet (Projects / TimeEntries)

Navigation et relations 1-N

Architecture propre et extensible

📌 Fonctionnalités
✔ Gestion des projets

Liste des projets

Création / édition / suppression

Association des entrées de temps

✔ Gestion du time tracking

Ajout d’entrées de temps (TaskName + Hours + ProjectId)

Lien direct avec un projet

Affichage des heures par tâche

✔ SQL Server intégré

Base créée automatiquement via EF Core (EnsureCreated())

Deux tables générées :

Projects

TimeEntries (clé étrangère ProjectId)

Compatible LocalDB et SQL Server complet

✔ Architecture propre
/Controllers
/Models
/Data
/Views
/wwwroot
Program.cs
appsettings.json

🗄️ Base de données

Entity Framework Core génère automatiquement la base :

Projects(Id, Name)
TimeEntries(Id, TaskName, Hours, ProjectId)


Avec relation :

Project (1) ---- (N) TimeEntry
