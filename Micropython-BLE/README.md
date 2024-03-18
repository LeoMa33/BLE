# Bluetooth Low Energy | MicroPython

## 📌 Sommaire
1. [Description du Projet](#📋-description)
2. [Fonctionalités](#🌟-fonctionalités)
3. [Utilisation](#💻-utilisation)
    * [BLE Serveur](#ble-serveur--android)

## 🎯 Badges
[![Protocole BLE](https://img.shields.io/badge/Protocole-BLE-red.svg)](https://www.syscom-prorep.com/application-technologie/ble)
[![Langage Micropython](https://img.shields.io/badge/Langage-MicroPython-blue.svg)](https://docs.micropython.org/en/latest/)

## 📋 Description

Ce projet a pour but de mettre à disposition un système de serveur BLE en MicroPython pouvant authoriser l'accès à une donnée.

## 🌟 Fonctionalités

- Ouverture d'un serveur BLE
- Transfert d'une donnée

## 💻 Utilisation

### BLE Serveur

**Pour initier le serveur BLE :**
```c#
ble = BLE(<deviceName>,<dataToSend>)
```
On créé un objet de type [BLE]() qui initialise un serveur BLE en donnant le nom \<deviceName> à notre appareil et commence a avertir de sa disponibilité et écrit la donnée \<dataToSend> sur sa caractèristique.

[Source](./main.py)