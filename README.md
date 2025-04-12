# 📚 Application de Gestion des Étudiants - ENSAJ

Cette application Windows Forms permet de gérer facilement les informations des étudiants d'un établissement (ajout, modification, suppression, affichage). Elle utilise une base de données SQL Server avec LINQ to SQL pour interagir avec les données.

---

## 🔧 Fonctionnalités

- Ajouter un nouvel étudiant
- Modifier les informations d’un étudiant existant
- Supprimer un étudiant
- Afficher tous les étudiants dans un tableau (`DataGridView`)
- Sélection automatique d’un étudiant dans le tableau pour édition

---

## 🛠️ Technologies utilisées

- **C#**
- **.NET Framework / WinForms**
- **SQL Server**
- **LINQ to SQL**
- **Visual Studio**

---

## 🗂️ Structure du projet

```bash
├── Form1.cs               # Code principal de la logique du formulaire
├── Form1.Designer.cs      # Interface utilisateur (UI)
├── Form1.resx             # Ressources utilisées (polices, etc.)
├── App.config             # Fichier de configuration
├── Student.dbml           # Fichier LINQ to SQL (modèle de base de données)
├── README.md              # Ce fichier
