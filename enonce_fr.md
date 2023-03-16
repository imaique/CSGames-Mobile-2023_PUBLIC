# CS Games 2023 - Compétition de développement mobile

## Contexte

La création de villes sous-marines offre une nouvelle opportunité de réimaginer la façon dont les habitants reçoivent des informations sur leur environnement. Dans un souci de transparence, de communication et d'indépendance, le comité des universités souhaite créer une application permettant d'informer les habitants des cités sous-marines.

## Résumé

Le comité universitaire a mandaté votre équipe pour développer une application mobile **.NET MAUI** afin de fournir aux résidents des informations générales pouvant les aider dans leurs activités quotidiennes. Plus précisément, le comité souhaite que les informations suivantes soient fournies aux résidents : horaires de transport en commun, nouvelles locales et mondiales, température (eau et interne), qualité de l'air, qualité de l'eau et niveaux de puissance de la ville. De plus, ils aimeraient que les utilisateurs reçoivent des alertes si jamais divers facteurs environnementaux deviennent une préoccupation pour leur sécurité. Enfin, ils aimeraient également une fonctionnalité permettant aux utilisateurs d'appeler l'aide de l'application si nécessaire.

## Information Technique

Un serveur web avec une API est déjà en place pour vous permettre d'obtenir les informations requises à afficher dans l'application.

- Veuillez noter que toutes les informations varient en permanence et parfois avec des différences significatives pour faciliter les tests

### Température

- Méthode HTTP : `GET`
- URL : `http://15.222.250.19/temp`
- Retour d'API : `JSON`
```
{
  "information":
  {
    "ext_water_temp":4.9,
    "int_temp":19.1
  }
}
```
- ext_water_temp : Représente la température de l'eau à l'extérieur de la ville. Type `Float`
- int_temp : Représente la température ambiante à l'intérieur de la ville. Type `Float`

### Qualité de l'air

- Méthode HTTP : `GET`
- URL : `http://15.222.250.19/air`
- Retour d'API : `JSON`
```
{
  "information":
  {
    "int_air_quality":57,
  }
}
```
- int_air_quality : Représente la qualité de l'air à l'intérieur de l'habitat. Basé sur [Air Quality Index](https://www.airnow.gov/aqi/aqi-basics/). Type `Integer`

### Qualité de l'eau

- Méthode HTTP : `GET`
- URL : `http://15.222.250.19/water`
- Retour d'API : `JSON`
```
{
  "information":
  {
    "int_water_quality":96,
  }
}
```
- int_water_quality : Représente la qualité de l'eau intérieure. Basé sur [Drinking Water Quality Index](https://www.gov.nl.ca/ecc/waterres/quality/drinkingwater/dwqi/). Type `Integer`


### Niveau des batteries

- Méthode HTTP : `GET`
- URL : `http://15.222.250.19/power`
- Retour d'API : `JSON`
```
{
  "information":
  {
    "power_levels":76,
  }
}
```
- power_levels : Représente la charge actuelle des batteries à l'intérieur de la ville en pourcentage. Type `Integer`

### Nouvelles

- Méthode HTTP : `GET`
- URL : `http://15.222.250.19/news`
- Retour d'API : `JSON`
```
{
  "news":[{
    "id":1,
    "message":"Lorem ipsum",
    "title":"Lorem ipsum",
    "type":1
  }
}
```
- id : Représente l'identifiant de la nouvelle. Type `Integer`
- message : Représente le message de la nouvelle (body). Type `String`
- title : Représente le titre de la nouvelle (header). Type `String`
- type : Représente le type de nouvelles. `1` pour les nouvelles locales et `2` pour les nouvelles mondiales. Type `Integer`


### Transport en commun

- Méthode HTTP : `GET`
- URL : `http://15.222.250.19/transit`
- Retour d'API : `JSON`
```
{
  "transit":[{
    "id":1,
    "frequency": 10,
    "line": 1,
    "description": "Line description",
    "schedule": "Monday : 06h00-22h30; Tuesday : 06h00-22h30; Wednesday : 06h00-22h30; Thursday : 06h00-23h00; Friday : 06h00-00h00; Saturday : 07h00-00h00; Sunday : 07h00-00h00;"
  }
}
```
- id : Représente l'identifiant de la ligne de transport en commun. Type `Integer`
- frequency : Représente la fréquence de passage de la ligne. Exprimé en minutes. Type `Integer`
- line : Représente l'identifiant de la ligne de transport en commun. Type `Integer`
- description : Représente la description de la ligne de transport en commun. Type `String`
- schedule : Représente l'horaire de la ligne de transport en commun. Type `String`

### SOS

- Méthode HTTP : `POST`
- URL : `http://15.222.250.19/sos`
- CONTENT-TYPE : `application/json`
- BODY :
```
{
    "sos_signal": {
        "name":"test",
        "location":"location"
    }
}
```
- id : Nom de la personne qui appelle SOS. Type `String`
- location : Localisation de la personne qui appelle SOS. Type `String`

## Valeur de la compétition

`1400 points`

## Tâches

L'application doit être créée avec **.NET MAUI**

### Application

- Créer une application .NET MAUI de base (20 points)
- Créer et utiliser une structure MVVM (30 points)

### Données

- Connectez-vous et obtenez les données de l'API (50 points)
- Créer une structure efficace et simple pour utiliser les données reçues de l'API (50 points)
- 
### Visuels

- Développer une structure visuelle organisée et facilitant la compréhension de l'information (400 points)
  - **Vous devez afficher TOUTES les informations fournies dans la section technique** 
- Conception visuelle générale (200 points)
- Créer un écran de démarrage (50 points)
- Prise en charge du mode sombre et clair (50 points)
- Prend en charge au moins deux langues (50 points)
- Incorporer le thème *Atlantis* (100 points)

### Les fonctions

- Développer une fonction SOS qui est **facile** et **sûre** à utiliser (c'est-à-dire sans clics accidentels) (50 points)
- Développer une fonction pour alerter l'utilisateur lorsque la qualité de l'air change de catégorie (50 points)
- Développer une fonction pour alerter l'utilisateur lorsque la qualité de l'eau change de catégorie (50 points)
- Développer une fonction pour alerter l'utilisateur lorsque les niveaux de puissance descendent en dessous de 35% (50 points)
- Développer un système de navigation facile à utiliser et efficace (100 points)

### Général

- Le code est propre et commenté (25 points)
- Le projet fonctionne sans modifications ni problèmes (25 points)
- L'application s'exécute rapidement et de manière fluide (petite quantité d'images perdues) (50 points)
