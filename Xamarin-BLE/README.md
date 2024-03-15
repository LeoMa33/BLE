# Bluetooth Low Energy | Xamarin

## 📌 Sommaire
1. [Description du Projet](#📋-description)
2. [Fonctionalités](#🌟-fonctionalités)
3. [Utilisation](#💻-utilisation)
    * [BLE Client](#ble-client--android)
    * [BLE Serveur](#ble-serveur--android)

## 🎯 Badges
[![Protocole BLE](https://img.shields.io/badge/Protocole-BLE-red.svg)](https://www.syscom-prorep.com/application-technologie/ble)
[![Xamarin Framework](https://img.shields.io/badge/Framework-Xamarin-blue.svg)](https://visualstudio.microsoft.com/fr/xamarin/)
[![Langage C#](https://img.shields.io/badge/Langage-CSharp-blue.svg)](https://learn.microsoft.com/fr-fr/dotnet/csharp/)
[![Package BLE2.1.3](https://img.shields.io/badge/Package-PluginBLE_2.1.3-green.svg)](https://github.com/dotnet-bluetooth-le/dotnet-bluetooth-le)
[![OS Android](https://img.shields.io/badge/OS-Android-yellow.svg)](https://www.android.com/intl/fr_fr/)

## 📋 Description

Ce projet a pour but de mettre à disposition un système de serveur BLE en Xamarin C# ainsi qu'un client pouvant le contacter pour échanger des données.

## 🌟 Fonctionalités

- Transfert de longues données
- Filtrage des serveurs BLE lors du scan client
- Connexion à un serveur BLE
- Lecture de Caractéristique BLE

## 💻 Utilisation

### BLE Client | Android

**Pour lancer un scan de serveur, se connecter au premier découvert et récupérer les données mises à disposition :**
```c#
BLEClient.BLEConnection();
```
Lors de la mise en place de ce projet, nous avions besoin de se connecter au premier appareil trouvé et de lire sa caractéristique, il est possible de modifier le code source pour adapter votre client BLE à vos besoins.

*Une version plus permissive sera bientôt réalisée.*

[Source](./BLE/BLE/BLEClient.cs)

### BLE Serveur | Android

**Pour initier le serveur BLE :**
```c#
IBLEServer bleServer = DependencyService.Get<IBLEServer>();
```
On créé un objet de type [IBLEServer](./BLE/BLE/IBLEServer.cs) qui est une interface qui permettra par la suite d'utiliser les fonctions de notre serveur BLE codé spécifiquement pour l'OS Android.

**Pour démarrer le serveur et définir la donner que l'on souhaite transferer :**
```c#
string dataToSend = "I'm a data";
bleServer.StartAdvert(dataToSend);
```
On définit la donnée que l'on souhaite envoyer (celle-ci doit être de ```type string```) et on demande à notre serveur BLE d'avertir de sa disponibilité.


[Source](./BLE.Droid/BLEServer.cs)