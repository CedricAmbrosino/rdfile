# RDFile — Lecteur de fichiers en console (C#)

RDFile est un utilitaire en ligne de commande permettant d’afficher rapidement le contenu des fichiers présents dans un dossier.
Il liste les fichiers disponibles, propose une sélection à l’utilisateur, puis affiche le contenu du fichier choisi.

## Fonctionnalités

Parcours automatique d’un dossier pour détecter les fichiers.

Affichage des noms (sans extension) dans un menu simple.

Vérification robuste de la saisie utilisateur.

Lecture et affichage direct du fichier sélectionné.

## Prérequis

.NET SDK 9+

## Environnement de développement

Ubuntu 24.04.2 LTS

Visual Studio Code + C# Dev Kit

## Installation / exécution
```
git clone <url-du-repo>
cd RDFile
dotnet run
```

## Structure du projet
RDFile/
 ├── Files/           # Dossier contenant les fichiers à lire
 ├── Program.cs      # Logique du programme
 └── README.md

